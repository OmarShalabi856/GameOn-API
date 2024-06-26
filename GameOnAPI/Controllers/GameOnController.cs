using AutoMapper;
using Azure;
using Azure.Core;
using GameOnAPI.Data;
using GameOnAPI.DTOs;
using GameOnAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Identity.Web.Resource;
using System.Text.Json;
using System.Threading.Channels;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using Response = GameOnAPI.DTOs.Response;
using Team = GameOnAPI.Models.Team;

namespace GameOnAPI.Controllers
{
	[Authorize]
	[ApiController]
	[Route("[controller]")]
	public class GameOnController : ControllerBase
	{


		private readonly ILogger<GameOnController> _logger;
		private readonly ApplicationDbContext _db;
		private readonly IMapper _mapper;
		protected Response response;

		public GameOnController(ILogger<GameOnController> logger, ApplicationDbContext db, IMapper mapper)
		{
			_logger = logger;
			_db = db;
			_mapper = mapper;
			response = new DTOs.Response();
		}
		[HttpPost("update-invite", Name = "UpdateInvite")]
		public async Task<ActionResult<Response>> UpdateInvite([FromBody] UpdateInvitationStatus update)
		{
			try
			{
				Invitation invitation = await _db.Invitation
					.Include(i => i.Match)
					.Include(i => i.InvitedPlayer)
					.Where(i => i.InvitedPlayer.Email.Equals(update.email) &&
					i.Match.Id == update.matchId).FirstOrDefaultAsync();


				if (invitation is null)
					return NotFound();


				invitation.Status = SetInvitationStatus(update);

				var user = await GetUser(update);
				string userId = user?.Id;


				await CheckIfInviteCreatesMatch(invitation);
				Team teamPlayerFor = SetTeam(invitation);

				if (update.accepted && userId != null)
				{
					await _db.MatchParticipation.AddAsync(new MatchParticipation()
					{
						MatchId = invitation.MatchId,
						UserId = userId,
						TeamPlayingFor = teamPlayerFor

					});
					

					var notificationTitle = "Player Joined";
					var notificationMessage = $"{user?.UserName} just joined the the match!";
					var receivingUsers = _db.MatchParticipation
					.Where(i => i.MatchId == update.matchId && i.UserId != user.Id)
					.Select(i => i.User)
					.ToList();
					await SendNotification(receivingUsers,update.matchId, notificationTitle, notificationMessage, user);
				}
				else
				{
					response.message = "Could not find the invited user";
					response.isSuccess = false;
					return NotFound(response);
				}

				await _db.SaveChangesAsync();
				
				return Ok(response);

			}
			catch (Exception ex)
			{
				response.message = "An error occured when updating invite status";
				response.isSuccess = false;
				_logger.LogError(ex, "Error in updating invite status");
				return BadRequest(response);
			}
		}

		private async Task<User> GetUser(UpdateInvitationStatus update)
		{
			var user = await _db.User.Where(i => i.Email.Equals(update.email)).FirstOrDefaultAsync();

			return user;
		}

		private string SetInvitationStatus(UpdateInvitationStatus update)
		{
			return update.accepted ? "Accepted" : "Rejected";
		}

		private Team SetTeam(Invitation invitation)
		{
			if (invitation.MatchCreation)
			{
				return Team.Team2;
			}

			return (invitation.Match.TeamOneCaptainId == invitation.MatchCaptainId)
			? Team.Team1
			: Team.Team2;
		}

		private async Task CheckIfInviteCreatesMatch(Invitation invitation)
		{
			if (invitation.MatchCreation)
			{
				Match match = await _db.Match.FindAsync(invitation.MatchId);
				match.Status = invitation.Status == "Accepted" ? "Created" : "Cancelled";
				await _db.SaveChangesAsync();
			}
		}

		[HttpGet("get-invites", Name = "GetInvitations")]
		public async Task<ActionResult<List<Invitation>>> GetInvitations([FromQuery] InvitationFilter filters)
		{
			try
			{
				List<Invitation> invitations = await _db.Invitation
					.Include(i => i.MatchCaptain)
					.Include(i => i.InvitedPlayer)
					.Include(i => i.Match)
					.ThenInclude(i => i.field)
					.Where(i => (filters.IsSent == false || i.MatchCaptain.Email.Equals(filters.userEmail))
					&& (filters.IsReceived == false || i.InvitedPlayer.Email.Equals(filters.userEmail)))
					.ToListAsync();

				response.result = invitations;
				return Ok(response);

			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "An error occured while retrieving invitations!"); ;
				response.message = "An error occured while retrieving invitations!";
				response.isSuccess = false;
				return BadRequest(response);
			}
		}
		[HttpPost("delete-invite", Name = "DeleteInvite")]
		public async Task<ActionResult<Response>> DeleteInvitation([FromBody] JsonElement json)
		{
			try
			{
				int inviteId = json.GetProperty("inviteId").GetInt32();
				Invitation invitationToBeDeleted = await _db.Invitation.FindAsync(inviteId);
				if (invitationToBeDeleted == null)
				{
					return NotFound(new Response { isSuccess = false, message = "Invitation not found" });
				}

				_db.Invitation.Remove(invitationToBeDeleted);
				await _db.SaveChangesAsync();

				return Ok(new Response { isSuccess = true, message = "Invitation deleted successfully" });
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "An error occurred while deleting the invitation!");
				return StatusCode(500, new Response { isSuccess = false, message = "An error occurred while deleting the invitation!" });
			}
		}

		[HttpPost("create-match", Name = "CreateMatch")]
		public async Task<ActionResult<Response>> CreateMatch(CreateMatchDTO match)
		{
			try
			{
				match.CreationDateTime = DateTime.Now;
				var matchDTO = _mapper.Map<Match>(match);

				matchDTO.TeamOneCaptainId = _db.User
					.Where(u => u.Email == match.TeamOneCaptainEmail)
					.Select(u => u.Id)
					.FirstOrDefault();

				matchDTO.TeamTwoCaptainId = _db.User
				.Where(u => u.Email == match.TeamTwoCaptainEmail)
				.Select(u => u.Id)
				.FirstOrDefault();

				_db.Match.Add(matchDTO);

				await _db.SaveChangesAsync();
				Match createdMatch = _db.Match.Where(i => i.Equals(matchDTO)).FirstOrDefault();
				await _db.MatchParticipation.AddAsync(new MatchParticipation()
				{
					MatchId = createdMatch.Id,
					UserId = createdMatch.TeamOneCaptainId,
					TeamPlayingFor = Team.Team1

				});
				SendTeamTwoCaptainInvite(match, matchDTO.TeamTwoCaptainId, matchDTO.TeamOneCaptainId);
				return Ok(response);
			}
			catch (Exception e)
			{
				_logger.LogError(e, "An error occured while creating the match!");
				var res = response.isSuccess = false;
				response.message = "An error occured while creating the match!";
				return BadRequest(response);
			}

		}
		[HttpPost("update-match",Name = "UpdateMatch")]
		public async Task<ActionResult<Response>> UpdateMatch(UpdateMatchDTO updatedMatch)
		{
			try
			{
				var changes = new List<string>();
				var existingMatch = _db.Match.Find(updatedMatch.Id);
				var user = _db.User.Find(updatedMatch.UpdatingUserId);

				if (existingMatch != null)
				{
					DateTime ConvertToUserTimezone(DateTime utcDateTime)
					{
						var beirutTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Asia/Beirut");
						return TimeZoneInfo.ConvertTimeFromUtc(utcDateTime, beirutTimeZone);
					}

					if (existingMatch.StartDateTime != ConvertToUserTimezone(updatedMatch.StartDateTime))
					{
						changes.Add("Start Date and Time");
						existingMatch.StartDateTime = ConvertToUserTimezone(updatedMatch.StartDateTime);
					}

					if (existingMatch.EndDateTime != ConvertToUserTimezone(updatedMatch.EndDateTime))
					{
						changes.Add("End Date and Time");
						existingMatch.EndDateTime = ConvertToUserTimezone(updatedMatch.EndDateTime);
					}

					if (existingMatch.CreationDateTime != ConvertToUserTimezone(updatedMatch.CreationDateTime))
					{
						changes.Add("Creation Date and Time");
						existingMatch.CreationDateTime = ConvertToUserTimezone(updatedMatch.CreationDateTime);
					}

					if (existingMatch.DeadlineRequestsDateTime != ConvertToUserTimezone(updatedMatch.DeadlineRequestsDateTime))
					{
						changes.Add("Deadline Requests Date and Time");
						existingMatch.DeadlineRequestsDateTime = ConvertToUserTimezone(updatedMatch.DeadlineRequestsDateTime);
					}

					if (existingMatch.FieldId != updatedMatch.FieldId)
					{
						changes.Add("Field ID");
						existingMatch.FieldId = updatedMatch.FieldId;
					}

					if (existingMatch.Notes != updatedMatch.Notes)
					{
						changes.Add("Notes");
						existingMatch.Notes = updatedMatch.Notes;
					}

					if (existingMatch.feePerPlayer != updatedMatch.feePerPlayer)
					{
						changes.Add("Fee Per Player");
						existingMatch.feePerPlayer = updatedMatch.feePerPlayer;
					}

					if (existingMatch.Gender != updatedMatch.Gender)
					{
						changes.Add("Gender");
						existingMatch.Gender = updatedMatch.Gender;
					}

					if (existingMatch.AgeGroup != updatedMatch.AgeGroup)
					{
						changes.Add("Age Group");
						existingMatch.AgeGroup = updatedMatch.AgeGroup;
					}
				}

				_db.Match.Update(existingMatch);
				await _db.SaveChangesAsync();

				if (changes.Any())
				{
					var title = "Match Updated";
					var changeMessage = $"The following match information were updated: {string.Join(", ", changes)} by the captain {user.UserName}";

					var receivingUsers = _db.MatchParticipation
					.Where(i => i.MatchId == updatedMatch.Id && i.UserId != user.Id)
					.Select(i => i.User)
					.ToList();

					bool notificationSent = await SendNotification(receivingUsers,updatedMatch.Id, title, changeMessage, user);
					if (!notificationSent)
					{
						throw new Exception("An error occurred while sending notifications");
					}
				}

				return Ok(new Response { isSuccess = true, message = "Match updated successfully." });
			}
			catch (Exception e)
			{
				_logger.LogError(e, "An error occurred while updating the match!");
				return BadRequest(new Response { isSuccess = false, message = "An error occurred while updating the match or sending the notifications." });
			}
		}

		[HttpGet("get-notifications")]
		public  ActionResult<List<NotificationUser>> GetNotifications(string userId)
		{
			try
			{
				var user = _db.User
					.Include(i => i.ReceivedNotifications)
					.ThenInclude(i => i.Notification)
					.Where(i => i.Id.Equals(userId))
					.FirstOrDefault();


				return user.ReceivedNotifications;
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "An error occurred while fetching notifications");
				return BadRequest(new Response { isSuccess = false, message = "An error occurred while fetching the notifications." });

			}
		}

		private async Task<bool> SendNotification(List<User> receivingUsers,int matchId, string title, string changeMessage, User user)
		{
			try
			{
		

				 int notificationId = await CreateNotification(matchId, title, changeMessage, user);
				if (notificationId != 0)
				{
					await SendNotificationToReceivingUsers(receivingUsers, notificationId);
					return true;
				}
				return false;


			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.StackTrace);
				return false;
			}
		}

		[HttpPost("delete-match")]
		public async Task<ActionResult> DeleteMatch(DeleteMatchDTO matchDTO)
		{
			try
			{
				var match = _db.Match.Find(matchDTO.matchId);
				if(matchDTO.userId.Equals(match.TeamOneCaptainId) || matchDTO.userId.Equals(match.TeamTwoCaptainId))
				{
					_db.Match.Remove(match);
					await _db.SaveChangesAsync();
					return Ok();
				}
				return Unauthorized();


			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.StackTrace);
				return BadRequest();
			}
		}

		private async Task SendNotificationToReceivingUsers(List<User> receivingUsers, int notificationId)
		{
			List<NotificationUser> notificationUsers = new List<NotificationUser>();
			foreach (var user in receivingUsers)
			{
				NotificationUser notificationUser = new NotificationUser()
				{
					NotificationId = notificationId,
					UserId = user.Id,
				};
				notificationUsers.Add(notificationUser);
			}
			if (notificationUsers.Count() > 0)
			{
				await _db.NotificationUser.AddRangeAsync(notificationUsers);
				await _db.SaveChangesAsync();
			}
				
		}

		private async Task<int> CreateNotification(int matchId, string title, string changeMessage, User user)
		{

			Notification notification = new Notification()
			{
				MatchId = matchId,
				Title = title,
				SendingUserId = user.Id,
				Description = changeMessage,
				timeStamp = DateTime.Now,

			};


			await _db.Notification.AddAsync(notification);
			await _db.SaveChangesAsync();
			int notificationId = _db.Notification
				.Where(n => n.Equals(notification))
				.Select(n => n.Id)
				.FirstOrDefault();

			return notificationId;
		}

		private void SendTeamTwoCaptainInvite(CreateMatchDTO match, string teamTwoCaptainId, string teamOneCaptainId)
		{
			int matchId = _db.Match
				.Where(m => m.TeamOneCaptainId == teamOneCaptainId && m.TeamTwoCaptainId == teamTwoCaptainId && m.StartDateTime == match.StartDateTime && m.Status == "Pending Confirmation")
				.Select(i => i.Id)
				.FirstOrDefault();

			if (matchId == 0)
			{
				throw new Exception("Can't Send Invite To Team Captain Two Because Match Isn't Created!");
			}

			try
			{
				Invitation playerInvitation = new Invitation
				{
					MatchCaptainId = teamOneCaptainId,
					InvitedPlayerId = teamTwoCaptainId,
					MatchId = matchId,
					ExpiryDate = match.DeadlineRequestsDateTime,
					SentDate = DateTime.Now,
					Status = "Pending",
					MatchCreation = true,
					Notes = match.Notes
				};

				_db.Invitation.Add(playerInvitation);
				_db.SaveChanges();
			}
			catch (Exception ex)
			{
				throw new Exception("Error while sending invitation to Team Captain Two.", ex);
			}
		}


		[HttpGet("matches", Name = "GetMatches")]
		public async Task<ActionResult<List<Match>>> GetMatches([FromQuery] MatchFilters filters)
		{
			try
			{

				var matches = _db.Match
					.Include(m => m.field)
					.Include(m => m.TeamOneCaptain)
					.Include(m => m.TeamTwoCaptain)
					.ToList();

				if (matches.Count() == 0)
				{
					response.result = new List<Match>();
					return Ok(response);
				}
				if (filters.UserEmail != null && filters.UserId == null)
					filters.UserId = _db.Users
						.Where(u => u.Email == filters.UserEmail)
						.Select(u => u.Id)
						.FirstOrDefault();

				matches = ApplyFilters(matches, filters);

				response.result = matches;
				return Ok(response);


			}
			catch (Exception ex)
			{
				response.isSuccess = false;
				response.message = "An error occured while retrieving the matches!";
				return BadRequest(response);
			}

		}

		private List<Match> ApplyFilters(List<Match> matches, MatchFilters filters)
		{
			var validMatches= matches.Where(match => (filters.City == null || match.field.Location == filters.City) &&
			(filters.AgeGroup == null || match.AgeGroup == filters.AgeGroup) &&
			(filters.Gender == null || match.Gender == filters.Gender) &&
			(filters.FreeMatchesOnly == null || filters.FreeMatchesOnly ? match.feePerPlayer == 0 : match.feePerPlayer >= 0) && (filters.UserId == null || filters.UserId == match.TeamOneCaptainId || filters.UserId == match.TeamTwoCaptainId) &&
			(filters.Featured==null || filters.Featured == match.Featured))
				.ToList();
			if (filters.Newest)
			{
				validMatches = validMatches.Where(i => i.DeadlineRequestsDateTime > DateTime.Now).OrderByDescending(i => i.CreationDateTime).ToList();
			}
			return validMatches;
		}

		[HttpGet("match-details", Name = "GetMatchDetails")]
		public ActionResult<Match> GetMatchDetails(int id)
		{
			try
			{
				var match = _db.Match.Where(match => match.Id == id)
					.Include(match => match.field)
					.Include(match => match.Participations)
					.ThenInclude(p => p.User)
					.FirstOrDefault();


				if (match == null)
				{

					return NotFound("Match is not found!");
				}
				//match.Participations.ForEach(p => p.User=_mapper.Map<PlayerUser>(p.User));
				var matchDTO = _mapper.Map<LiveMatchDTO>(match);
				return Ok(matchDTO);
			}
			catch (Exception ex)
			{
				_logger.LogError($"An Error occured when retrieving match details:{ex}");
				return StatusCode(500, "An error occurred while processing your request.");
			}
		}
		[HttpPost("update-participations", Name = "UpdateMatchParticipations")]
		public async Task<ActionResult<Response>> UpdateMatchParticipations([FromBody] UpdatePlayerPositionsDTO updatedPlayerPositions)
		{

			try
			{
				var user = await _db.User.FindAsync(updatedPlayerPositions.ChangingUserId);
				string title = "Your Position Changed";
				string description = $"Your Position Has Changed In This Match By {user.UserName}, View Match To Check!";
				foreach (var participation in updatedPlayerPositions.UpdatedParticipations)
				{
					var existingParticipation =  _db.MatchParticipation.Include(p => p.User).First(
						p=>p.Id==participation.matchParticipationId);
					
					if (existingParticipation != null)
					{
						if(existingParticipation.xPosition!= participation.xPosition || existingParticipation.yPosition != participation.yPosition)
						{
							existingParticipation.xPosition = participation.xPosition;
							existingParticipation.yPosition = participation.yPosition;
							await SendNotification(new List<User>() { existingParticipation.User },existingParticipation.MatchId, title, description, user);
							_db.MatchParticipation.Update(existingParticipation);
						}
						
					}
					else
					{
						_logger.LogError($"Match participation with Id {participation.matchParticipationId} not found.");
						response.isSuccess = false;
						response.message = $"Match participation with Id {participation.matchParticipationId} not found.";
					}
				}

				await _db.SaveChangesAsync();
				return Ok(response);
			}
			catch (Exception ex)
			{
				_logger.LogError($"An error occurred while updating the match participations: {ex}");
				response.isSuccess = false;
				response.message = "An error occurred while updating the match participations.";
				return BadRequest(response);
			}
		}

		[HttpPost("send-invite")]
		public async Task<ActionResult<Response>> SendMatchInvite([FromBody] InvitationDTO matchInvitation)
		{
			try
			{
				string matchCaptainId = _db.User
					.Where(u => u.Email == matchInvitation.MatchCaptainEmail)
					.Select(u => u.Id)
					.FirstOrDefault();

				string invitedPlayerId = _db.User
					.Where(u => u.Email == matchInvitation.InvitedPlayerEmail)
					.Select(u => u.Id)
					.FirstOrDefault();

				Match match = _db.Match
					.Where(m => m.Id == matchInvitation.MatchId)
					.FirstOrDefault();

				Invitation existingInvitation = _db.Invitation
					.FirstOrDefault(inv => inv.MatchId == matchInvitation.MatchId && inv.InvitedPlayerId == invitedPlayerId);

				if (existingInvitation != null)
				{
					existingInvitation.ExpiryDate = matchInvitation.ExpiryDate.GetValueOrDefault();
					existingInvitation.Status = "Pending";
					var existingParticipation = await _db.MatchParticipation
						.Where(i => i.MatchId == matchInvitation.MatchId && i.UserId == invitedPlayerId)
						.FirstOrDefaultAsync();

					_db.MatchParticipation.Remove(existingParticipation);
				}
				else
				{
					// If no existing invitation, create a new one
					Invitation modelInvitation = _mapper.Map<Invitation>(matchInvitation);
					modelInvitation.ExpiryDate = match.DeadlineRequestsDateTime;
					modelInvitation.Status = "Pending";
					modelInvitation.InvitedPlayerId = invitedPlayerId;
					modelInvitation.MatchCaptainId = matchCaptainId;

					_db.Invitation.Add(modelInvitation);
				}

				await _db.SaveChangesAsync();
				return response;
			}
			catch (Exception ex)
			{
				response.message = ex.Message;
				response.isSuccess = false;
				return BadRequest(response);
			}
		}


		[HttpGet("fields")]
		public ActionResult<Field> GetFields(int? id)
		{
			try
			{
				List<Field> fields;

				if (id != null)
				{
					var field = _db.Field.Find(id);
					if (field != null)
					{
						response.result = new List<Field>() { field };
						return Ok(response);
					}
					return NotFound();
				}
				else
				{
					fields = _db.Field.ToList();
					if (fields.Any())
					{
						response.result = fields;
						return Ok(response);
					}
					return NoContent();
				}
			}
			catch (Exception ex)
			{
				response.message = ex.Message;
				response.isSuccess = false;
				return BadRequest(response);
			}
		}

	}

	public class MatchFilters
	{
		public string? AgeGroup { get; set; }
		public string? City { get; set; }
		public string? Gender { get; set; }
		public bool Featured { get; set; }
		public bool Newest { get; set; }
		public bool FreeMatchesOnly { get; set; }
		public string? UserEmail { get; set; }
		public string? UserId { get; set; }
	}
}
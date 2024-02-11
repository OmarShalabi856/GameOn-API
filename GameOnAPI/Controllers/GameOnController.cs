using AutoMapper;
using Azure;
using Azure.Core;
using GameOnAPI.Data;
using GameOnAPI.DTOs;
using GameOnAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Web.Resource;
using System.Text.Json;
using Response = GameOnAPI.DTOs.Response;

namespace GameOnAPI.Controllers
{
	//[Authorize]
	[ApiController]
	[Route("[controller]")]
	//[RequiredScope(RequiredScopesConfigurationKey = "AzureAd:Scopes")]
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
					.Include(i => i.InvitedPlayer)
					.Where(i => i.InvitedPlayer.Email.Equals(update.email) &&
					i.Match.Id == update.matchId).FirstOrDefaultAsync();

				if (invitation is null)
					return NotFound();
				invitation.Status = update.accepted ? "Accepted" : "Rejected";
				string userId = await _db.User.Where(i => i.Email.Equals(update.email)).Select(i => i.Id).FirstOrDefaultAsync();
				if (update.accepted && userId!=null)
				{
					_db.MatchParticipation.AddAsync(new MatchParticipation()
					{
						MatchId = invitation.MatchId,
						UserId = userId,

					}); 
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

		[HttpGet("featured", Name = "GetFeaturedMatches")]
		public ActionResult<IEnumerable<Match>> GetFeaturedMatches()
		{
			try
			{
				var currentDateTime = DateTime.Now;
				var availableMatches = _db.Match
					.Where(x => x.DeadlineRequestsDateTime > currentDateTime && x.Featured).Include(x => x.field)
					.ToList();
				return Ok(availableMatches);
			}
			catch (Exception e)
			{
				_logger.LogError(e, "An error occured while retrieving available matches!");
				return StatusCode(500, "An error occurred while processing your request.");
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
		[HttpGet("matches", Name = "GetMatches")]
		public async Task<ActionResult<List<Match>>> GetMatches([FromQuery] MatchFilters filters)
		{
			try
			{

				var matches = _db.Match
					.Include(m => m.field)
					.Include(m => m.TeamOneCaptain)
					.Include(m => m.TeamTwoCaptain)
					.Where(m => m.DeadlineRequestsDateTime > DateTime.Now)
					.ToList();

				if (matches.Count() == 0)
				{
					return NoContent();
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
			return matches.Where(match => (filters.City == null || match.field.Location == filters.City) &&
			(filters.AgeGroup == null || match.AgeGroup == filters.AgeGroup) &&
			(filters.Gender == null || match.Gender == filters.Gender) &&
			(filters.FreeMatchesOnly == null || filters.FreeMatchesOnly ? match.feePerPlayer == 0 : match.feePerPlayer >= 0) && filters.UserId == null || filters.UserId == match.TeamOneCaptainId || filters.UserId == match.TeamTwoCaptainId)
				.ToList();
		}

		[HttpGet("newest", Name = "GetNewestMatches")]
		public ActionResult<List<Match>> GetNewestMatches()
		{
			try
			{
				var newMatches = _db.Match
					.Include(x => x.field)
					.Where(match => match.CreationDateTime < DateTime.Now.AddDays(-7))
					.OrderBy(match => match.CreationDateTime)
					.ToList();
				if (newMatches.Any())
				{
					response.result = newMatches;
					return Ok(response);
				}
				else
				{
					return NoContent();

				}

			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "An error occurred while processing GetNewestMatches endpoint.");
				return StatusCode(500, ex.Message);
			}
		}
		//[Authorize(Roles = "Admin")]
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
		[HttpPost("update-participations",Name ="UpdateMatchParticipations")]
		public async Task<ActionResult<Response>> UpdateMatchParticipations([FromBody]List<UpdatePosition> updatedParticipations)
		{

			try
			{

				foreach (var participation in updatedParticipations)
				{
					var existingParticipation = await _db.MatchParticipation.FindAsync(participation.matchParticipationId);

					if (existingParticipation != null)
					{

						existingParticipation.xPosition = participation.xPosition;
						existingParticipation.yPosition = participation.yPosition;


						_db.MatchParticipation.Update(existingParticipation);
					}
					else
					{
						_logger.LogError($"Match participation with Id {participation.matchParticipationId} not found.");
						response.isSuccess = false;
						response.message = $"Match participation with Id {participation.matchParticipationId} not found.";
						return NotFound(response);
					}
				}

				await _db.SaveChangesAsync();
				response.isSuccess = true;
				response.message = "Match participations updated successfully.";
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
					var existingParticipation= await _db.MatchParticipation
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

		public bool FreeMatchesOnly { get; set; }
		public string? UserEmail { get; set; }
		public string? UserId { get; set; }
	}
}
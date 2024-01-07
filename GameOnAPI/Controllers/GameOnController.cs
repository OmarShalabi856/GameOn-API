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
		public ActionResult<Response> CreateMatch(CreateMatchDTO match)
		{
			try
			{
				match.CreationDateTime = DateTime.Now;
				var matchDTO = _mapper.Map<Match>(match);
				_db.Match.Add(matchDTO);
				_db.SaveChanges();
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
					.Include(m => m.User)
					.Where(m => m.DeadlineRequestsDateTime > DateTime.Now)
					.ToList();

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
			return matches.Where(match => (filters.City == null || match.City == filters.City) &&
			(filters.AgeGroup == null && match.AgeGroup == filters.AgeGroup) &&
			(filters.Gender == null && match.Gender == filters.Gender) &&
			(filters.FreeMatchesOnly == null || filters.FreeMatchesOnly ? match.feePerPlayer == 0 : match.feePerPlayer >= 0)).ToList();
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
		[Authorize(Roles = "Admin")]
		[HttpGet("match-details", Name = "GetMatchDetails")]
		public ActionResult<Match> GetMatchDetails(int id)
		{
			try
			{
				var match = _db.Match.Where(x => x.Id == id)
					.Include(x => x.field)
					.Include(x => x.Participations)
					.ThenInclude(p => p.User).FirstOrDefault();


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
				_logger.LogError("An Error occured when retrieving match details");
				return StatusCode(500, "An error occurred while processing your request.");
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
	}
}
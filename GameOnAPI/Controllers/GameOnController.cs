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
}
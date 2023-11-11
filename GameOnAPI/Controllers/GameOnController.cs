using GameOnAPI.Data;
using GameOnAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Web.Resource;

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

		public GameOnController(ILogger<GameOnController> logger, ApplicationDbContext db)
		{
			_logger = logger;
			_db = db;
		}

		[HttpGet("featured",Name = "GetFeaturedMatches")]
		public ActionResult<IEnumerable<Match>> GetFeaturedMatches()
		{
			try
			{
				var currentDateTime = DateTime.Now;
				var availableMatches = _db.Match
					.Where(x => x.DeadlineRequestsDateTime > currentDateTime && x.Featured).Include(x=>x.field)
					.ToList();
				return Ok(availableMatches);
			}
			catch (Exception e)
			{
				_logger.LogError(e, "An error occured while retrieving available matches!");
				return StatusCode(500, "An error occurred while processing your request.");
			}

		}
		[HttpGet("match-details",Name="GetMatchDetails")]
		public ActionResult<Match> GetMatchDetails(int id)
		{
			try
			{
				var match = _db.Match.Where(x=>x.Id==id)
					.Include(x=>x.field)
					.Include(x=>x.Participations);
				if(match == null)
				{
					return NotFound("Match is not found!");
				}
				return Ok(match);
			}
			catch(Exception ex)
			{
				_logger.LogError("An Error occured when retrieving match details");
				return StatusCode(500, "An error occurred while processing your request.");
			}
		}


	}
}
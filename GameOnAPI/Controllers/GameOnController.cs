using GameOnAPI.Data;
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
		public ActionResult<IEnumerable<Match>> Get()
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


	}
}
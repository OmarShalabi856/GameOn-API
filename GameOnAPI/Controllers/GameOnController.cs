using GameOnAPI.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Web.Resource;

namespace GameOnAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    [RequiredScope(RequiredScopesConfigurationKey = "AzureAd:Scopes")]
    public class GameOnController : ControllerBase
    {
        

        private readonly ILogger<GameOnController> _logger;
		private readonly ApplicationDbContext _db;

		public GameOnController(ILogger<GameOnController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        [HttpGet(Name = "GetAvailableMatches")]
        public ActionResult<IEnumerable<Match>> Get()
        {


            return null;
        }
        
       
        }
    }
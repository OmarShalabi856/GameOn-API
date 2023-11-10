using GameOnAPI.DTOs;
using GameOnAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace GameOnAPI.Controllers
{
	[Route("GameOn")]
	public class GameOnAuthAPI : ControllerBase
	{

		private readonly IAuthService authService;
		protected Response response;
		public GameOnAuthAPI(IAuthService authService)
		{
			this.authService = authService;
			response = new Response();	
		}


		[HttpPost("register")]
		public async Task<IActionResult> Register([FromBody] RegisterUser regUser)
		{
			string errors = await authService.RegisterUserAsync(regUser);	
			if (!string.IsNullOrEmpty(errors))
			{
				response.isSuccess = false;
				response.message = errors;
				return BadRequest(response);

			}
			return BadRequest(errors);	
		}
	}
}

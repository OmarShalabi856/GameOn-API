using GameOnAPI.DTOs;
using GameOnAPI.Responses;
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

		[HttpPost("login")]
		public async Task<IActionResult> Login([FromBody] LoginUser loginUser)
		{
			LoginResponse lr = await authService.LoginUserAsync(loginUser);
			if(lr.LoginUser == null)
			{
				response.isSuccess = false;
				response.message = "Username Or Password Is Incorrect!";
				return BadRequest(response);
			}
			response.result = lr;
			return Ok(response);
		}
	}
}

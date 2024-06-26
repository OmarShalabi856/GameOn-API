﻿using AutoMapper;
using GameOnAPI.DTOs;
using GameOnAPI.Responses;
using GameOnAPI.Services;
using Microsoft.AspNetCore.Mvc;
using static GameOnAPI.Services.AuthService;

namespace GameOnAPI.Controllers
{
	[Route("GameOn")]
	public class GameOnAuthAPI : ControllerBase
	{

		private readonly IAuthService authService;
		private readonly IMapper _mapper;
		protected Response response;
		public GameOnAuthAPI(IAuthService authService, IMapper mapper)
		{
			this.authService = authService;
			_mapper = mapper;
			response = new Response();	
		}


		[HttpPost("register")]
		public async Task<IActionResult> Register([FromBody] RegisterUser regUser)
		{
			string errors = await authService.RegisterUserAsync(regUser);

			await authService.AssignRole(regUser.Email, "User");
			if (!string.IsNullOrEmpty(errors))
			{
				response.isSuccess = false;
				response.message = errors;
				return BadRequest(response);

			}
			LoginUser loginUser = _mapper.Map<LoginUser>(regUser);	
			LoginResponse lr = await authService.LoginUserAsync(loginUser);
			response.result = lr;
			return Ok(response);	
		}

		[HttpPost("login")]
		public async Task<IActionResult> Login([FromBody] LoginUser loginUser)
		{
			LoginResponse lr = await authService.LoginUserAsync(loginUser);
			if(lr.LoginUser == null)
			{
				response.isSuccess = false;
				response.message = "Username Or Password Is Incorrect!";
				return Unauthorized(response);
			}
			response.result = lr;
			return Ok(response);
		}

		[HttpPost("check-email")]
		public async Task<IActionResult> CheckEmail([FromBody] string email)
		{
			bool emailPresent = await authService.CheckRegEmail(email);
			if (emailPresent)
			{
				response.isSuccess = false;
				response.message = "This Email Already Exists!";
				return Ok(response);
			}
			response.message = "";
			return Ok(response);
		}


		//[HttpPost("add-role")]
		//public async Task<IActionResult> AddRole([FromBody] RegisterUser regUser)
		//{

		//		bool roleAssgined = await authService.AssignRole(regUser.Email, regUser.role);
		//		if (!roleAssgined)
		//		{
		//			response.isSuccess = false;
		//			response.message = "Could not assign role! User not found";
		//			return BadRequest(response);
		//		}
		//		return Ok(response);


		//}
	}
}

using AutoMapper;
using GameOnAPI.Data;
using GameOnAPI.DTOs;
using GameOnAPI.Models;
using GameOnAPI.Responses;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace GameOnAPI.Services
{
	public class AuthService : IAuthService
	{
		private readonly ApplicationDbContext _db;
		private readonly UserManager<User> _userManager;
		private readonly RoleManager<IdentityRole> _roleManager;
		private readonly IMapper _mapper;
		private readonly IJWTTokenGenerator _tokenGenerator;

		public AuthService(ApplicationDbContext db, UserManager<User> userManager, RoleManager<IdentityRole> roleManager, IMapper mapper,IJWTTokenGenerator tokenGenerator)
		{
			_db = db;
			_userManager = userManager;
			_roleManager = roleManager;
			_mapper = mapper;
			_tokenGenerator = tokenGenerator;
		}


		public async Task<string> RegisterUserAsync(RegisterUser user)
		{
			User regUser = new User()
			{
				UserName = user.UserName,
				Email = user.Email,
				NormalizedEmail = user.Email.ToUpper(),
				Name = user.Name

			};

			try
			{
				var result = await _userManager.CreateAsync(regUser, user.Password);
				if (result.Succeeded)
				{
					return "";
				}
				return result.Errors.FirstOrDefault().Description;
			}
			catch (Exception ex)
			{
				return ex.ToString();
			}
		}

		async Task<LoginResponse> IAuthService.LoginUserAsync(LoginUser user)
		{
			var _user = _db.User.FirstOrDefault(x => x.UserName.ToLower() == user.Username.ToLower());
			bool isValid = await _userManager.CheckPasswordAsync(_user, user.Password);
			if (user is null || !isValid)
			{
				return new LoginResponse { LoginUser = null, token = "" };
			}

			LoginUser responseUser = _mapper.Map<LoginUser>(user);
			string token = _tokenGenerator.GenerateToken(responseUser);
			return new LoginResponse { LoginUser = responseUser, token = token };
		}
	}
}

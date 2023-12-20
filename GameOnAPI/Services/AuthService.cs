using AutoMapper;
using GameOnAPI.Data;
using GameOnAPI.DTOs;
using GameOnAPI.Models;
using GameOnAPI.Responses;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GameOnAPI.Services
{
	public class AuthService : IAuthService
	{
		private readonly ApplicationDbContext _db;
		private readonly UserManager<User> _userManager;
		private readonly RoleManager<IdentityRole> _roleManager;
		private readonly IMapper _mapper;
		private readonly IJWTTokenGenerator _tokenGenerator;

		public AuthService(ApplicationDbContext db, UserManager<User> userManager, RoleManager<IdentityRole> roleManager, IMapper mapper, IJWTTokenGenerator tokenGenerator)
		{
			_db = db;
			_userManager = userManager;
			_roleManager = roleManager;
			_mapper = mapper;
			_tokenGenerator = tokenGenerator;
		}

		public async Task<bool> AssignRole(string email, string roleName)
		{
			try
			{
				var user = await _userManager.FindByEmailAsync(email);

				if (user != null && _userManager != null && _roleManager != null)
				{
					if (!await _roleManager.RoleExistsAsync(roleName))
					{
						await _roleManager.CreateAsync(new IdentityRole(roleName));
					}

					var role = await _roleManager.FindByNameAsync(roleName);

					if (role != null)
					{
						if (!await _userManager.IsInRoleAsync(user, roleName))
						{
							await _userManager.AddToRoleAsync(user, roleName);
							return true;
						}
						else
						{
							Console.WriteLine($"User {email} is already assigned to role {roleName}.");
							return false;
						}
					}
					else
					{
						Console.WriteLine($"Role {roleName} not found.");
						return false;
					}
				}
				else
				{
					Console.WriteLine("User manager, role manager, or user is null.");
					return false;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error assigning role: {ex.Message}");
				return false;
			}
		}




		public async Task<string> RegisterUserAsync(RegisterUser user)
		{
			User regUser = new User()
			{
				UserName = user.Email.ToLower().Split('@')[0],
				Email = user.Email,
				NormalizedEmail = user.Email.ToUpper(),
				Name = user.Name,
				position=user.position,
				preferredFoot= user.preferredFoot,
				Height=user.Height,
				Weight=user.Weight,
				FavoriteTeam=user.FavoriteTeam
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

		public async Task<bool> CheckRegEmail(string email)
		{
			try
			{
				var userAlreadyPresent = await _userManager.FindByEmailAsync(email);
				if (userAlreadyPresent != null)
				{
					return true;
				}
				return false;
			}
			catch(Exception ex)
			{
				return false;
			}
			
		}


		async Task<LoginResponse> IAuthService.LoginUserAsync(LoginUser user)
		{
			var _user = _db.User.FirstOrDefault(x => x.Email.ToLower() == user.Email.ToLower());
			bool isValid = await _userManager.CheckPasswordAsync(_user, user.Password);
			if (user is null || !isValid)
			{
				return new LoginResponse { LoginUser = null, token = "" };
			}

			LoginUser responseUser = _mapper.Map<LoginUser>(user);
			string token = _tokenGenerator.GenerateToken(responseUser);
			return new LoginResponse { LoginUser = responseUser, token = token };
		}

		public enum role
		{
			Admin,
			User,
			Co_Admin
		}

		public enum Position
		{
			Striker,
			Left_Winger,
			Right_Winger,
			Defensive_Midfielder,
			General_Midfielder,
			Left_Back,
			Center_Back,
			Right_Back,
			Goalkeeper
		}

		public enum PreferredFoot
		{
			Right,
			Left
		}

		public enum ExperienceLevel
		{
			Amateur,
			SemiPro,
			Professional
		}
	}
}

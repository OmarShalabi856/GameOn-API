using GameOnAPI.Data;
using GameOnAPI.DTOs;
using GameOnAPI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace GameOnAPI.Services
{
	public class AuthService : IAuthService
	{
		private readonly ApplicationDbContext _db;
		private readonly UserManager<User> _userManager;
		private readonly RoleManager<IdentityRole> _roleManager;

		public AuthService(ApplicationDbContext db, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
		{
			_db = db;
			_userManager = userManager;
			_roleManager = roleManager;
		}

		public Task<PlayerUser> LoginUserAsync(LoginUser user)
		{
			return null;
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
					//User createdUser = _db.User.FirstOrDefault(x=>x.Email==user.Email);
					//return new PlayerUser
					//{
					//	Name = createdUser.Name,
					//	ID = createdUser.Id,
					//	Email = createdUser.Email,
					//	position = (PlayerUser.Position)createdUser.position,
					//	experienceLevel = (PlayerUser.ExperienceLevel)createdUser.experienceLevel,
					//	preferredFoot = (PlayerUser.PreferredFoot)createdUser.preferredFoot,
					//	FavoriteTeam = createdUser.FavoriteTeam,
					//	Height = createdUser.Height,
					//	Weight = createdUser.Weight,
					//	Location = createdUser.Location,
					//	ProfileImageUrl = createdUser.ProfileImageUrl,
					//	MatchParticipations = createdUser.MatchParticipations

					//};
					return "";
				}
				return result.Errors.FirstOrDefault().Description;
			}
			catch (Exception ex)
			{
				return ex.ToString();
			}
		}
	}
}

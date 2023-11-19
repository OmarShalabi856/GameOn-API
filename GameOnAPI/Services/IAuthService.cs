using GameOnAPI.Data;
using GameOnAPI.DTOs;
using GameOnAPI.Responses;
using static GameOnAPI.Services.AuthService;

namespace GameOnAPI.Services
{
	public interface IAuthService
	{
		Task<string> RegisterUserAsync(RegisterUser user);
		Task<LoginResponse>LoginUserAsync(LoginUser user);
		Task<bool> CheckRegEmail(string email);
		Task<bool> AssignRole(string email, string roleName);

		
	}

	
}

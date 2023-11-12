using GameOnAPI.Data;
using GameOnAPI.DTOs;
using GameOnAPI.Responses;

namespace GameOnAPI.Services
{
	public interface IAuthService
	{
		Task<string> RegisterUserAsync(RegisterUser user);
		Task<LoginResponse>LoginUserAsync(LoginUser user);
	}
}

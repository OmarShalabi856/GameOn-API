using GameOnAPI.Data;
using GameOnAPI.DTOs;

namespace GameOnAPI.Services
{
	public interface IAuthService
	{
		Task<string> RegisterUserAsync(RegisterUser user);
		Task<PlayerUser>LoginUserAsync(LoginUser user);
	}
}

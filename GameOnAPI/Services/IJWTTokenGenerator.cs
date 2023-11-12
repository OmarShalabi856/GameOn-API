using GameOnAPI.DTOs;

namespace GameOnAPI.Services
{
	public interface IJWTTokenGenerator
	{
		public string GenerateToken(LoginUser user);	
	}
}

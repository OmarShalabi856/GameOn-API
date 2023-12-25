using GameOnAPI.DTOs;
using GameOnAPI.Models;

namespace GameOnAPI.Services
{
	public interface IjwtTokenGenerator
	{
		public string GenerateToken(User user,List<string> roles);	
	}
}

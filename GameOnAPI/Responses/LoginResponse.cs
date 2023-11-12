using GameOnAPI.DTOs;

namespace GameOnAPI.Responses
{
	public class LoginResponse
	{
		public LoginUser LoginUser { get; set; }	
		public string token { get; set; }	
	}
}

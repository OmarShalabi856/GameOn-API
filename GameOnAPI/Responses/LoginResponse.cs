﻿using GameOnAPI.DTOs;

namespace GameOnAPI.Responses
{
	public class LoginResponse
	{
		public string userId { get; set; }

		public LoginUser LoginUser { get; set; }	

		public List<string> role { get; set; }
		public string token { get; set; }
		
		public string message { get; set; }
	}
}

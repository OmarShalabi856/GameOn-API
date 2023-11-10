namespace GameOnAPI.Models
{
	public class JWTOptions
	{
		public string secret { get; set; } = string.Empty;
		public string issuer { get; set; } = string.Empty;
		public string audience { get; set; } = string.Empty;
	}
}

using GameOnAPI.Models;
using System.Text.Json.Serialization;

namespace GameOnAPI.DTOs
{
	public class RegisterUser
	{
		public string Email { get; set; }
		public string Password { get; set; }
		public string Name { get; set; }

		[JsonConverter(typeof(JsonStringEnumConverterWithCamelCase))]
		public User.Position position { get; set; }

		[JsonConverter(typeof(JsonStringEnumConverterWithCamelCase))]
		public User.PreferredFoot preferredFoot { get; set; }

		[JsonConverter(typeof(JsonStringEnumConverterWithCamelCase))]
		public User.ExperienceLevel experienceLevel { get; set; }
		public string FavoriteTeam { get; set; }
		public double Height { get; set; }
		public double Weight { get; set; }
	}

	
}

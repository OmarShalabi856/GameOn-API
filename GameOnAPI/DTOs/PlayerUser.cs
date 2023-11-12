using GameOnAPI.Models;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GameOnAPI.DTOs
{
	public class PlayerUser
	{
		public string ID { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		 [JsonConverter(typeof(JsonStringEnumConverterWithCamelCase))]
        public Position position { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverterWithCamelCase))]
        public PreferredFoot preferredFoot { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverterWithCamelCase))]
        public ExperienceLevel experienceLevel { get; set; }
		public string FavoriteTeam { get; set; }
		public double Height { get; set; }
		public double Weight { get; set; }
		public string Location { get; set; }
		public string ProfileImageUrl { get; set; }
		public List<MatchParticipationDTO> MatchParticipations { get; set; }
		public string token { get; set; }

		public enum Position
		{
			Striker,
			Left_Winger,
			Right_Winger,
			Defensive_Midfielder,
			General_Midfielder,
			Left_Back,
			Center_Back,
			Right_Back,
			Goalkeeper
		}

		public enum PreferredFoot
		{
			Right,
			Left
		}

		public enum ExperienceLevel
		{
			Amateur,
			SemiPro,
			Professional
		}
	}
	public class JsonStringEnumConverterWithCamelCase : JsonStringEnumConverter
	{
		public JsonStringEnumConverterWithCamelCase() : base(namingPolicy: JsonNamingPolicy.CamelCase)
		{
		}
	}
}

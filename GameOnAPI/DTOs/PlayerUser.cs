using GameOnAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace GameOnAPI.DTOs
{
	public class PlayerUser
	{
		public string ID { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public Position position { get; set; }
		public PreferredFoot preferredFoot { get; set; }
		public ExperienceLevel experienceLevel { get; set; }
		public string FavoriteTeam { get; set; }
		public double Height { get; set; }
		public double Weight { get; set; }
		public string Location { get; set; }
		public string ProfileImageUrl { get; set; }
		public List<MatchParticipation> MatchParticipations { get; set; }
		public string token { get; set; }	

		public enum Position
		{
			Forward,
			Midfielder,
			Defender,
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
}

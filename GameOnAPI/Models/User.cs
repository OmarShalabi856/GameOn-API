using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GameOnAPI.Models
{
	public class User : IdentityUser
	{
		public User() { }
		[Required]
		public Position position { get; set; }
		[Required]
		public PreferredFoot preferredFoot { get; set; }
		public ExperienceLevel experienceLevel { get; set; }
		public string FavoriteTeam { get; set; }
		[Required]
		public double Height { get; set; }
		[Required]
		public double Weight { get; set; }
		public string Location { get; set; }
		public string ProfileImageUrl { get; set; }
		public List<MatchParticipation> MatchParticipations { get; set; }

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

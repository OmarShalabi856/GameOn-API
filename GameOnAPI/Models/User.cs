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
		public string FavoriteTeam { get; set; } = "";
		[Required]
		public double Height { get; set; }
		[Required]
		public double Weight { get; set; }
		public string Location { get; set; } = "";
		public string ProfileImageUrl { get; set; } = "";
		public List<MatchParticipation> MatchParticipations { get; set; }

		public List<Invitation> Invitations { get; set; }

		public List<UserRoles> userRoles { get;set; }	
		public string Name { get; set; }

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
}

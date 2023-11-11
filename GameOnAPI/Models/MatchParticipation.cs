using System.ComponentModel.DataAnnotations;

namespace GameOnAPI.Models
{
	public class MatchParticipation
	{
		public int Id { get; set; }

		public string UserId { get; set; }
		public User User { get; set; }
		public int MatchId { get; set; }
		public Match Match { get; set; }
		public User.Position position { get; set; }
		public Team TeamPlayingFor { get; set; }
		[Range(1, 10, ErrorMessage = "Rating should be between 1 and 10")]
		public double Rating { get; set; }
	}

	public enum Team
	{
		Team1 = 1,
		Team2 = 2
	}
}

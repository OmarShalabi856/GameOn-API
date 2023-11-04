namespace GameOnAPI.Models
{
	public class MatchParticipation
	{
		public int Id { get; set; }

		public string UserId { get; set; }
		public User User { get; set; }
		public int MatchId { get; set; }
		public Match Match { get; set; }

		public Team TeamPlayedFor { get; set; }
		public int GoalsScored { get; set; }
	}

	public enum Team
	{
		Team1 = 1,
		Team2 = 2
	}
}

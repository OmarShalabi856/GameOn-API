using GameOnAPI.Models;

namespace GameOnAPI.DTOs
{
	public class MatchParticipationDTO
	{
		public int Id { get; set; }
		public string UserId { get; set; }
		public PlayerUser User { get; set; } 
		public int MatchId { get; set; }
		public int Position { get; set; } 
		public double xPosition { get; set; }
		public double yPosition { get; set; }
		public Team TeamPlayingFor { get; set; }
		public double Rating { get; set; }
	}

	public enum Team
	{
		Team1 = 1,
		Team2 = 2
	}
}

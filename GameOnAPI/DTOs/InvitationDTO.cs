namespace GameOnAPI.DTOs
{
	public class InvitationDTO
	{

		public string MatchCaptainEmail { get; set; }
		public string InvitedPlayerEmail { get; set; }

		public int MatchId { get; set; }
		public DateTime? ExpiryDate { get; set; }

		public string Notes { get; set; }

		public DateTime sentDate { get; set; }
	}
}


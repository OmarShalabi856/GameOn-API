namespace GameOnAPI.DTOs
{
	public class UpdateInvitationStatus
	{

		public bool accepted { get; set; }
		public string email { get; set; }
		public int matchId { get; set; }
	}
}

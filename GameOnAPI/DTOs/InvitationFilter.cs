namespace GameOnAPI.DTOs
{
	public class InvitationFilter
	{
		public bool IsSent { get; set; }
		public bool IsReceived { get; set; }

		public string userEmail { get; set; }
	}
}

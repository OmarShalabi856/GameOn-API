using System.ComponentModel.DataAnnotations;

namespace GameOnAPI.Models
{
	public class Notification
	{
		[Key]
		public int Id { get; set; }	
		public string Title { get; set; }
		public DateTime timeStamp { get; set; }
		public string Description { get; set; }
		public bool Deleted { get; set; }
		public string? SendingUserId { get; set; }
		public User SendingUser { get; set; }
		public int MatchId { get; set; }
		public Match Match { get; set; }
		public List<NotificationUser> ReceivingUsers { get; set; }

	}
}

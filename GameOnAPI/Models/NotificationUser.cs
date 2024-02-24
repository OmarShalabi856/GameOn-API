using System.ComponentModel.DataAnnotations;

namespace GameOnAPI.Models
{
	public class NotificationUser
	{
			[Key]
			public int Id { get; set; }

			public int NotificationId { get; set; }
			public Notification Notification { get; set; }

			public bool Viewed { get; set; }
			public string UserId { get; set; }
			public User User { get; set; }
		}
	
}

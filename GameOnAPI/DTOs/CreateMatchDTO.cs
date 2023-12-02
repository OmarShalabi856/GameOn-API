using GameOnAPI.Models;

namespace GameOnAPI.DTOs
{
	public class CreateMatchDTO
	{
		public DateTime StartDateTime { get; set; }

		public DateTime EndDateTime { get; set; }

		public DateTime DeadlineRequestsDateTime { get; set; }

		public int FieldId { get; set; }

		//public Field field { get; set; }

	}
}

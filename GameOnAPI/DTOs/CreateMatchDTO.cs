using GameOnAPI.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameOnAPI.DTOs
{
	public class CreateMatchDTO
	{
		public DateTime StartDateTime { get; set; }

		public DateTime EndDateTime { get; set; }

		public DateTime CreationDateTime { get; set; }

		public DateTime DeadlineRequestsDateTime { get; set; }
		public string Email { get; set; }

		[ForeignKey("Field")]
		public int FieldId { get; set; }

		public string Notes { get; set; }

		public double feePerPlayer { get; set; }

		public string Gender { get; set; }

		public string AgeGroup { get; set; }

		public Field? Field { get; set; }

	}
}

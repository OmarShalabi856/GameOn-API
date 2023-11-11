using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameOnAPI.Models
{
	public class Field
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		[Required]	
		public string Location { get; set; }
		[Required]
		public string FieldName { get; set; }

		[Required]
		public string FieldImage { get; set; }
	}
}

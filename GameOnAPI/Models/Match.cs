using GameOnAPI.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Match
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int Id { get; set; }
	[Required]
	public DateTime StartDateTime { get; set; }
	[Required]
	public DateTime EndDateTime { get; set; }
	[Required]
	public DateTime DeadlineRequestsDateTime { get; set; }

	[Required]
	[Range(2, int.MaxValue, ErrorMessage = "Player count must be at least 2.")]
	public int PlayerCount { get; set; }

	public int FieldId { get; set; }

	public bool Featured { get; set; }	
	
	public Field field { get; set; }
	public List<User> Team1 { get; set; }
	public List<User> Team2 { get; set; }

	public int Team1GoalCount { get; set; }
	public int Team2GoalCount { get; set; }
}

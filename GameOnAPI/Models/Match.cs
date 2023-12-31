using GameOnAPI.DTOs;
using GameOnAPI.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Match
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int Id { get; set; }

	[Required]
	//public int UserId { get; set; }
	//public User User { get; set; }

	public string UserId { get; set; }
	public User User { get; set; }

	[Required]
	public DateTime StartDateTime { get; set; }
	[Required]
	public DateTime EndDateTime { get; set; }
	[Required]
	public DateTime DeadlineRequestsDateTime { get; set; }

	public DateTime CreationDateTime { get; set; }

	[Required]
	[Range(2, int.MaxValue, ErrorMessage = "Player count must be at least 2.")]
	public int PlayerCount { get; set; }

	public string Notes { get; set; }

	public double feePerPlayer { get; set; }	

	public int FieldId { get; set; }

	public bool Featured { get; set; }	
	
	public Field field { get; set; }
	public List<MatchParticipation> Participations { get; set; }	
}

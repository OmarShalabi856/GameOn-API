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
	public string TeamOneCaptainId { get; set; }

	[ForeignKey("TeamOneCaptainId")]
	public User TeamOneCaptain { get; set; }

	public string? TeamTwoCaptainId { get; set; }

	[ForeignKey("TeamTwoCaptainId")]
	public User TeamTwoCaptain { get; set; }

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

	public string Gender { get; set; }

	public string AgeGroup { get; set; }
	public string Status { get; set; } = "Pending Confirmation";
	public Field field { get; set; }
	public List<MatchParticipation> Participations { get; set; }	
}

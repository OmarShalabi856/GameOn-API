using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameOnAPI.Models
{
	public class Invitation
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[ForeignKey("MatchCaptain")] 
		public string? MatchCaptainId { get; set; }
		public User MatchCaptain { get; set; }

		[ForeignKey("InvitedPlayer")] 
		public string? InvitedPlayerId { get; set; }
		public User InvitedPlayer { get; set; }

		public int MatchId { get; set; }
		public Match Match { get; set; }

		public DateTime ExpiryDate { get; set; }
		public string Notes { get; set; }

		public string Status { get; set; }
		public DateTime SentDate { get; set; }

		public bool MatchCreation { get; set; } = false;
	}
}

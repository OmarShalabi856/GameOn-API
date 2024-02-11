using GameOnAPI.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GameOnAPI.DTOs
{
	public class LiveMatchDTO
	{
		public string userId { get; set; }

		public DateTime StartDateTime { get; set; }

		public DateTime EndDateTime { get; set; }

		public DateTime DeadlineRequestsDateTime { get; set; }

		public int PlayerCount { get; set; }

		public int FieldId { get; set; }

		public bool Featured { get; set; }

		public Field field { get; set; }
		public List<MatchParticipationDTO> Participations { get; set; }
	}
}

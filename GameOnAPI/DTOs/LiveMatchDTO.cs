﻿using GameOnAPI.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GameOnAPI.DTOs
{
	public class LiveMatchDTO
	{
		public string TeamOneCaptainId { get; set; }

		[ForeignKey("TeamOneCaptainId")]
		public User TeamOneCaptain { get; set; }

		public string? TeamTwoCaptainId { get; set; }

		[ForeignKey("TeamTwoCaptainId")]
		public User TeamTwoCaptain { get; set; }

		public DateTime StartDateTime { get; set; }

		public DateTime EndDateTime { get; set; }

		public DateTime DeadlineRequestsDateTime { get; set; }

		public int PlayerCount { get; set; }

		public int FieldId { get; set; }

		public string AgeGroup { get; set; }
		public string Notes { get; set; }
		public double feePerPlayer { get; set; }
		public string Gender { get; set; }

		public bool Featured { get; set; }

		public Field field { get; set; }
		public List<MatchParticipationDTO> Participations { get; set; }
	}
}

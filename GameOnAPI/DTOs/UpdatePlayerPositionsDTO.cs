namespace GameOnAPI.DTOs
{
	public class UpdatePlayerPositionsDTO
	{
		public List<UpdatePosition> UpdatedParticipations { get; set; }
		public string ChangingUserId { get; set; }
	}
}

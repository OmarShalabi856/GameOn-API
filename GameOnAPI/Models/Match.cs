using GameOnAPI.Models;

public class Match
{
	public int Id { get; set; }

	public DateTime StartDateTime { get; set; }
	public DateTime EndDateTime { get; set; }

	public DateTime DeadlineRequestsDateTime { get; set; }

	public string Location { get; set; }
	public string FieldName { get; set; }
	public int PlayerCount { get; set; }

	public List<User> Team1 { get; set; }
	public List<User> Team2 { get; set; }

	public int Team1GoalCount { get; set; }
	public int Team2GoalCount { get; set; }
}

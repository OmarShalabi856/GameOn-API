namespace GameOnAPI.DTOs
{
	public class Response
	{
		public object? result {  get; set; }
		public bool isSuccess { get; set; } = true;
		public string message { get; set; } = "";

	}
}

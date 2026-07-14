namespace TicketSystem.Api.Models
{
	public enum TicketStatus
	{
		Open,
		InProgress,
		Resolved,
		Closed
	}
	public enum TicketPriority
	{
		Low,
		Medium,
		High,
		Urgent
	}
	public class Ticket
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public TicketStatus Status { get; set; }
		public TicketPriority Priority { get; set; }
	}
}

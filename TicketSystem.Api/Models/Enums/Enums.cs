namespace TicketSystem.Api.Models.Enums
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
	public enum Role
	{
		User, 
		Agent
	}
}

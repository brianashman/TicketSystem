using TicketSystem.Api.Models.Enums;

namespace TicketSystem.Api.Models.DTO
{
	public class AddTicketDTO
	{
		public string Title { get; set; }
		public string Description { get; set; }
		public TicketStatus Status { get; set; }
		public TicketPriority Priority { get; set; }
	}
}

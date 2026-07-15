using TicketSystem.Api.Models.Enums;

namespace TicketSystem.Api.Models.DTO.TicketDTO
{
	public class ReadTicketDTO
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public TicketStatus Status { get; set; }
		public TicketPriority Priority { get; set; }
	}
}

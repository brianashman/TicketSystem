using TicketSystem.Api.Models;

namespace TicketSystem.Api.Services.Abstractions
{
	public interface ITicketService
	{
		public Task<List<Ticket>> GetAllTicketsAsync();
		public Task<Ticket?> GetTicketByIdAsync(int id);
		public Task<bool> UpdateTicketByIDAsync(int id, Ticket updatedTicket);
		public Task<bool> DeleteTicketByIDAsync(int id);
	}
}

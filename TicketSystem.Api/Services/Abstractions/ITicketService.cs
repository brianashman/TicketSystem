using TicketSystem.Api.Models.DTO;

namespace TicketSystem.Api.Services.Abstractions
{
	public interface ITicketService
	{
		public Task<IEnumerable<TicketDTO>> GetallTicketsAsync();
		public Task<TicketDTO> GetTicketByIdAsync(int id);
		public Task<bool> UpdateTicketByIDAsync(int id, TicketDTO updatedTicket);
		public Task<bool> DeleteTicketByIDAsync(int id);
	}
}

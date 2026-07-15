using TicketSystem.Api.Models.DTO;

namespace TicketSystem.Api.Services.Abstractions
{
	public interface ITicketService
	{
		public Task<IEnumerable<ReadTicketDTO>> GetallTicketsAsync();
		public Task<ReadTicketDTO> GetTicketByIdAsync(int id);
		public Task<bool> UpdateTicketByIDAsync(int id, ReadTicketDTO updatedTicket);
		public Task<bool> DeleteTicketByIDAsync(int id);
	}
}

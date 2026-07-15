using TicketSystem.Api.Models.DTO;
using TicketSystem.Api.Services.Abstractions;

namespace TicketSystem.Api.Services
{
	public class TicketService : ITicketService
	{
		public Task<bool> DeleteTicketByIDAsync(int id)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<ReadTicketDTO>> GetallTicketsAsync()
		{
			throw new NotImplementedException();
		}

		public Task<ReadTicketDTO> GetTicketByIdAsync(int id)
		{
			throw new NotImplementedException();
		}

		public Task<bool> UpdateTicketByIDAsync(int id, ReadTicketDTO updatedTicket)
		{
			throw new NotImplementedException();
		}
	}
}

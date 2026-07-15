using Microsoft.EntityFrameworkCore;
using TicketSystem.Api.Data;
using TicketSystem.Api.Models;
using TicketSystem.Api.Models.DTO;
using TicketSystem.Api.Services.Abstractions;

namespace TicketSystem.Api.Services
{
	public class TicketService : ITicketService
	{
		private readonly AppDBContext _context;
		public TicketService(AppDBContext context)
		{
			_context = context;
		}
		public async Task<bool> DeleteTicketByIDAsync(int id)
		{
			var ticket = await _context.Tickets.FindAsync(id);
			if (ticket == null) return false;

			_context.Tickets.Remove(ticket);
			return (await _context.SaveChangesAsync()) > 0;
		}

		public async Task<List<Ticket>> GetAllTicketsAsync() => await _context.Tickets.ToListAsync();

		public async Task<Ticket?> GetTicketByIdAsync(int id) => await _context.Tickets.FindAsync(id);

		public async Task<bool> UpdateTicketByIDAsync(int id, Ticket updatedTicket)
		{
			var ticket = await _context.Tickets.FindAsync(id);
			if (ticket == null) return false;

			_context.Entry(ticket).CurrentValues.SetValues(updatedTicket);
			return (await _context.SaveChangesAsync()) > 0;
		}
	}
}

using Microsoft.EntityFrameworkCore;
using TicketSystem.Api.Models;

namespace TicketSystem.Api.Data
{
	public class AppDBContext(DbContextOptions<AppDBContext> options) : DbContext(options)
	{
		public DbSet<Ticket> Tickets => Set<Ticket>();
	}
}

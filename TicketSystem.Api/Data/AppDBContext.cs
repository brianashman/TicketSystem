using Microsoft.EntityFrameworkCore;
using TicketSystem.Api.Models;

namespace TicketSystem.Api.Data
{
	public class AppDBContext: DbContext
	{
		AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
		{

		}
		public DbSet<Ticket> Tickets => Set<Ticket>();
	}
}

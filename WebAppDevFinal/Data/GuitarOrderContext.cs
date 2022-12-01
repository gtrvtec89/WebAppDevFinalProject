using Microsoft.EntityFrameworkCore;
using WebAppDevFinal.Models;

namespace WebAppDevFinal.Data
{
	public class GuitarOrderContext : DbContext
	{
		public GuitarOrderContext(DbContextOptions<GuitarOrderContext> options)
			: base(options)
		{

		}
		public DbSet<Guitar> Guitars { get; set; }
		public DbSet<Order> Orders { get; set; }
	}
}

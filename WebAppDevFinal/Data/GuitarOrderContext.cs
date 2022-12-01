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

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Guitar>().HasData(
				new Guitar
				{
					Id = 1,
					Brand = "Grog Guitars",
					Type = "Ibanez",
					Model = "S-type",
					Cost = 3000.00m, 
					List = 5000.00m,
					Quantity = 3
				},
				new Guitar
				{
					Id = 2,
					Brand = "Ibanez Guitars",
					Type = "S-type",
					Model = "670qm",
					Cost = 2500.00m,
					List = 4000.00m,
					Quantity = 6

				}

				);
		}
	}

}

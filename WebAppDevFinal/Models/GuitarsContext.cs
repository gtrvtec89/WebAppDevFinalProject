using Microsoft.EntityFrameworkCore;

namespace WebAppDevFinal.Models
{
    public class GuitarsContext : DbContext
    {
        public GuitarsContext(DbContextOptions<GuitarsContext> options)
            : base(options)
        { }

        public DbSet<Guitars> Guitars { get; set; }
    }
}
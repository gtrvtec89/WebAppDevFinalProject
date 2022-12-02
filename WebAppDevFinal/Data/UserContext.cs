using Microsoft.EntityFrameworkCore;
using WebAppDevFinal.Models;

namespace WebAppDevFinal.Data
{
	public class UserContext : DbContext
	{
		public UserContext(DbContextOptions<UserContext> options)
			: base(options)
		{

		}
		public DbSet<User> Users { get; set; }
	}
}

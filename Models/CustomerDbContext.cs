using Microsoft.EntityFrameworkCore;

namespace AmarilloMarble.Models
{
	public class CustomerDbContext : DbContext
	{
		public CustomerDbContext (DbContextOptions<CustomerDbContext> options)
			: base(options)
		{
		}
		public DbSet<Customer> Customers {get; set;}
	}
}

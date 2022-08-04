using Microsoft.EntityFrameworkCore;

namespace WebApplication5.Models
{
	public class EmployeeDbContext : DbContext
	{
		public DbSet<Employee> employees { get; set; }

		public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options)
		 : base(options)
		{

		}

	}
}
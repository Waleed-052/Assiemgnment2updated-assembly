using Assignment2up.Client.Pages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Assignment2up.Data
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = "DefaultConnection";
                optionsBuilder.UseSqlServer(connectionString, b => b.MigrationsAssembly("Assignment2up.Client"));
            }
        }
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Assignment2up.Models.Employee> Employees { get; set; }

    }
}
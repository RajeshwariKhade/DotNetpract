using _05CRUDDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace _05CRUDDemo.DAL
{
    public class DbContextDemo : DbContext
    {
        public DbSet<Employee> employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //a Service for - To read appsettings.json config file
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            IConfiguration config = builder.Build();
            string connectionString = config.GetConnectionString("conStr");

            //Databse Provider Service Register
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}

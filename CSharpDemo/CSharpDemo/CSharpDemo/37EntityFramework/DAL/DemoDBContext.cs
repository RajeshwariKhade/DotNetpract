
using _37EntityFramework.Model;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace _37EntityFramework.DAL
{
    public class DemoDBContext : DbContext
    {
        public DbSet<Employee> employees { get; set; }
        //public DbSet<Student> students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            IConfiguration config = builder.Build();
            string connectionString = config.GetConnectionString("conStr");

            optionsBuilder.UseSqlServer(connectionString);
        }

        public Employee GetEmpById(int id)
        {
            var idParam = new SqlParameter("@Id", id);
            return employees.FromSqlRaw("EXEC getEmpById @Id", idParam).AsEnumerable().FirstOrDefault();
        }
    }
}

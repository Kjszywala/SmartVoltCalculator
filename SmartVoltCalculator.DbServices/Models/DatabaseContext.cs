using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SmartVoltCalculator.DbServices.Models.Database;

namespace SmartVoltCalculator.DbServices.Models
{
    public class DatabaseContext : IdentityDbContext<IdentityUser>
    {
        private readonly string connectionString;

        public DatabaseContext(DbContextOptions<DatabaseContext> options, IConfiguration configuration)
            : base(options) 
        {
            connectionString = configuration.GetSection("ConnectionStrings:DefaultConnection").Value;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public virtual DbSet<MainPage> MainPages { get; set; }
    }
}

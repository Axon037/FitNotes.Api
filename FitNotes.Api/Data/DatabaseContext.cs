using FitNotes.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace FitNotes.Api.Data
{
    public class DatabaseContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DatabaseContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to postgres with connection string from app settings
            options.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"));

        }

        public DbSet<Exercises> Exercises { get; set; }
        public DbSet<Sets> Sets { get; set; }
        public DbSet<Users> User { get; set; }
    }
}

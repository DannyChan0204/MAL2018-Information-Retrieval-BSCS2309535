using Microsoft.EntityFrameworkCore;

namespace CW2_Assignment_App.Model
{
    public class UserDBContext : DbContext
    {
        public UserDBContext() 
        { 
            
        }
        public UserDBContext(DbContextOptions<UserDBContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("AppDb");
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users", schema: "CW2");
        }
    }
}

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
        public DbSet<Profile> Profile { get; set; }
        public DbSet <Badges> Badges { get; set; }
        public DbSet<Trail> Trail { get; set; }
        public DbSet<Leaderboard> Leaderboard { get; set; }
        public DbSet<Comments> Comments { get; set; }

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
            modelBuilder.Entity<Profile>().ToTable("Profile", schema: "CW2");
            modelBuilder.Entity<Badges>().ToTable("Badges", schema: "CW2");
            modelBuilder.Entity<Trail>().ToTable("Trail", schema: "CW2");
            modelBuilder.Entity<Leaderboard>().ToTable("Leaderboard", schema: "CW2");
            modelBuilder.Entity<Comments>().ToTable("Comments", schema: "CW2");
        }
    }
}

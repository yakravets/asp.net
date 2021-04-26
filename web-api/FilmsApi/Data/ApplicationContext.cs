using Microsoft.EntityFrameworkCore;

namespace FilmsApi.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions option) : base(option)
        {
            Database.EnsureCreated();
        }

        public DbSet<Genre> Genres { get; set; }
        public DbSet<Film> Films { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(new Genre { Id = 1, Name = "Comedy" });
            modelBuilder.Entity<Genre>().HasData(new Genre { Id = 2, Name = "Travel" });
            modelBuilder.Entity<Genre>().HasData(new Genre { Id = 3, Name = "Fantastic" });
        }
    }
}

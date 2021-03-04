namespace GameStore.DAL
{
    using GameStore.DAL.Entities;
    using System.Data.Entity;

    public class ApplicationContext : DbContext
    {
        public ApplicationContext()
            : base("name=ApplicationContext")
        {
            Database.SetInitializer(new GameInitializer());
        }

        public DbSet<Developer> Developers{ get; set; }
        public DbSet<Genre> Genres{ get; set; }
        public DbSet<Game> Games{ get; set; }

    }
}
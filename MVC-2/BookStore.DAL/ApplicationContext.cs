namespace BookStore.DAL
{
    using BookStore.DAL.Entities;
    using System.Data.Entity;

    public class ApplicationContext : DbContext
    {
        public ApplicationContext()
            : base("name=ApplicationContext")
        {
            //Database.SetInitializer(new GameInitializer());
        }

        public DbSet<Book> Books{ get; set; }
        public DbSet<Genre> Genres{ get; set; }
        public DbSet<Author> Authors{ get; set; }

    }
}
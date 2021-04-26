using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rooms.API.Data
{
    public class _AppContext : DbContext
    {
        public _AppContext(DbContextOptions<_AppContext> options) : base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            RoomInitializer.Seed(modelBuilder);
        }

        public DbSet<Room> Rooms { get; set; }
    }
}

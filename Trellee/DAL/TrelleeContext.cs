using Trellee.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Trellee.DAL
{
    public class TrelleeContext : DbContext
    {

        public TrelleeContext() : base("TrelleeContext")
        {
        }

        public DbSet<Card> Cards { get; set; }
        public DbSet<SwimLane> SwimLanes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Board> Boards { get; set; }
        public DbSet<BoardSubscriptions> BoardSubscriptions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using ConcertDB.DAL.Entities;
using System.Diagnostics.Metrics;

namespace ConcertDB.DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Ticket>().HasIndex(c => c.Id).IsUnique();
        }
    }
}

using BeerhallEF.Data.Mapping;
using BeerhallEF.Models;
using Microsoft.EntityFrameworkCore;

namespace BeerhallEF.Data
{
    class ApplicationDbContext : DbContext
    {
        public DbSet<Brewer> Brewers { get; set; }
        public DbSet<Beer> Beers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString =
                @"Server=.;Database=Beerhall;Integrated Security=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new BrewerConfiguration());
        }

    }
}

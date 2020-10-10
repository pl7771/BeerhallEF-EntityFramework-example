using Microsoft.EntityFrameworkCore;

namespace BeerhallEF.Data
{
    class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString =
                @"Server=.;Database=Beerhall;Integrated Security=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}

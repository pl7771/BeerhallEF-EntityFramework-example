using BeerhallEF.Data;
using System;
namespace BeerhallEF
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();
                Console.WriteLine("Database created");
            }
        }
    }
}

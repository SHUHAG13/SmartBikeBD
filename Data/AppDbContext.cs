using Microsoft.EntityFrameworkCore;
using SmartBikeBD.Models;

namespace SmartBikeBD.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
            
        }
            public DbSet<Make> Makes { get; set; }
            public DbSet<Model> Models { get; set; }


    }
}

using Microsoft.EntityFrameworkCore;

namespace SharpLab2_3.DbData
{
    public class AppDbContext : DbContext
    {
        public DbSet<Genres> Genres { get; set; }

        public DbSet<Artists> Artists { get; set; }

        public DbSet<Albums> Albums { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}

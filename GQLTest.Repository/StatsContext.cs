using Microsoft.EntityFrameworkCore;
using GQLTest.Data.models;

namespace GQLTest.Repository
{
    public class StatsContext : DbContext
    {
        public StatsContext(DbContextOptions options)
            : base(options)
        {
            // these are mutually exclusive, migrations cannot be used with EnsureCreated()
            // Database.EnsureCreated();
            //Database.Migrate();
        }
        public DbSet<PedidoQuery> PedidoQuerys { get; set; }

    }
}

using Microsoft.EntityFrameworkCore;

namespace craftSupplies.Models
{
    public class CraftSuppliesContext : DbContext
    {
        public CraftSuppliesContext(DbContextOptions<CraftSuppliesContext> options)
            : base(options)
        {
        }

        public DbSet<EmbroideryThread> EmbroideryThreads { get; set; }
    }
}
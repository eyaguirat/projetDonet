using Microsoft.EntityFrameworkCore;
using SW.Models;

namespace SW.DAL
{
    public class SWDBContext : DbContext
    {
        public DbSet<Citoyen> Citoyens { get; set; }

        public SWDBContext(DbContextOptions<SWDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Citoyen>()
                .HasOne<Citoyen>(x => x.PereBiologique);

            modelBuilder.Entity<Citoyen>()
                .HasOne<Citoyen>(x => x.MereBiologique);
            base.OnModelCreating(modelBuilder);
        }
    }
}
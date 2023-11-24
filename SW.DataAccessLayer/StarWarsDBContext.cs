using Microsoft.EntityFrameworkCore;
using SW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW.DataAccessLayer
{
    public class StarWarsDBContext : DbContext
    {
        // Le DbSet est la représentation de la table des citoyens
        // Son utilisation est semblable à une collection .NET classique (list, array, etc)
        public DbSet<Citoyen> Citoyens { get; set; }

        public DbSet<Espece> Especes { get; set; }


        public StarWarsDBContext(DbContextOptions<StarWarsDBContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // On configure le Citoyen pour 'expliquer' à EF Core comment l'utiliser
            // Le citoyen possède - 'HasOne' un PereBiologique
            modelBuilder.Entity<Citoyen>()
                .HasOne<Citoyen>(c => c.PereBiologique);

            // Le citoyen possède - 'HasOne' une MereBiologique
            modelBuilder.Entity<Citoyen>()
                .HasOne<Citoyen>(c => c.MereBiologique);
        }
    }
}

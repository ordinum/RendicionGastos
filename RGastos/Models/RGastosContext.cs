using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace RGastos.Models
{
    public partial class RGastosContext : DbContext
    {
        public DbSet<Ciudad> Ciudad { get; set; }
        public DbSet<Factura> Factura { get; set; }
        public DbSet<Moneda> Moneda { get; set; }
        public DbSet<Pais> Pais { get; set; }
        public DbSet<Rendicion> Rendicion { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {        
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }        
    }
}
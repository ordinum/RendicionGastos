using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using RGastos.Models;
using RGastos.DAL;

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
            //Evitar pluralización...
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //modelBuilder.Entity<Reporte>()
            //    .HasRequired(f => f.Cliente)
            //    .WithRequiredDependent()
            //    .WillCascadeOnDelete(false);


            //modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            ////Muchos-a-Muchos
            //modelBuilder.Entity<SacSistemas>()
            //    .HasMany(c => c.SacSolicitudAccion).WithMany(i => i.SacSistemas)
            //    .Map(t => t.MapLeftKey("SacSistemasID")
            //        .MapRightKey("SacSolicitudAccionID")
            //        .ToTable("SacSistemasSacSolicitudAccion"));

        }
        


        
    }


}
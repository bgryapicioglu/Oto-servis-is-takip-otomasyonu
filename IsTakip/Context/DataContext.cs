using EntityFramework.DynamicFilters;
using IsTakip.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Context
{
    internal class DataContext : DbContext
    {
        public DbSet<Musteri> MusteriS { get; set; }
        public DbSet<Marka> MarkaS { get; set; }
        public DbSet<Model> Model { get; set; }
        public DbSet<bakimGrubu> bakimGrubus { get; set; }
        public DbSet<bakimTuru> bakimTurus { get; set; }
        public DbSet<yakitTuru> yakitTurus { get; set; }
        public DbSet<IsEmri> IsEmris { get; set; }
        public DbSet<Islemler> Islemlers { get; set; }
        public DbSet<IsDiger> IsDigers { get; set; }
        public DbSet<Sabit> Sabits { get; set; }
        public DbSet<ortakIslem> ortakIslems { get; set; }
        public DbSet<musteriRapor> musteriRapors { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Filter("IsDeleted", (Musteri m) => m.IsDeleted, false);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Filter("IsDeleted", (Marka m) => m.IsDeleted, false);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Filter("IsDeleted", (Model m) => m.IsDeleted, false);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Filter("IsDeleted", (bakimTuru m) => m.IsDeleted, false);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Filter("IsDeleted", (bakimGrubu m) => m.IsDeleted, false);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Filter("IsDeleted", (IsEmri m) => m.IsDeleted, false);
            base.OnModelCreating(modelBuilder);


        }

    }
}

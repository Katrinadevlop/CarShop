using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CarShopWpf.Data
{
    class AppContent : DbContext
    {
        public DbSet<Registrations> Registrations { get; set; }

        public AppContent() : base("DefaultConnection") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Registrations>()
                .HasKey(r => r.id_person);

            modelBuilder.Entity<Baskets>()
               .HasKey(b => b.id);

            base.OnModelCreating(modelBuilder);
        }

    }
}

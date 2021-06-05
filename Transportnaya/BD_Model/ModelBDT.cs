using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Transportnaya.BD_Model
{
    public partial class ModelBDT : DbContext
    {
        public ModelBDT()
            : base("name=ModelBDT")
        {
        }

        public virtual DbSet<Application> Application { get; set; }
        public virtual DbSet<Avtorizac> Avtorizac { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Driver> Driver { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Application>()
                .Property(e => e.Cargo_weight)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}

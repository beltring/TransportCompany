namespace CourseWork
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TransportCompanyContext : DbContext
    {
        public TransportCompanyContext()
            : base("name=TransportCompanyContextDB")
        {
        }

        public virtual DbSet<Cargo> Cargos { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

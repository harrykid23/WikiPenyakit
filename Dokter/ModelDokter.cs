namespace TugasPBO.Dokter
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelDokter : DbContext
    {
        public ModelDokter()
            : base("name=ModelDokter1")
        {
        }

        public virtual DbSet<DaftarDokter> DaftarDokters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

namespace TugasPBO.Penyakit
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelPenyakit : DbContext
    {
        public ModelPenyakit()
            : base("name=ModelPenyakit1")
        {
        }

        public virtual DbSet<DaftarPenyakit> DaftarPenyakits { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

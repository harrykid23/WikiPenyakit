namespace TugasPBO.Penyakit
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DaftarPenyakit")]
    public partial class DaftarPenyakit
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string NamaPenyakit { get; set; }

        [Required]
        [StringLength(20)]
        public string JenisPenyakit { get; set; }

        [Required]
        [StringLength(1000)]
        public string GejalaPenyakit { get; set; }
    }
}

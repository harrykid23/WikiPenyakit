using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TugasPBO.Penyakit;

namespace TugasPBO.Dokter
{
    public abstract class KelasDokter
    {
        #region Atribut Dasar Dokter
        static int id = 0;
        protected string nama;
        protected string spesialis;
        #endregion

        #region Properti Dasar Dokter
        public static int Id { get { return id++; } set { id = value; } }

        public abstract string Nama { get; protected set; }

        public abstract string Spesialis { get; protected set; }
        #endregion

        #region Metode Dasar Dokter
        public int TambahDatabase(string nama, string gejala)
        {
            DaftarPenyakit penyakit;
            try
            {
                using (var db = new ModelPenyakit())
                {
                    penyakit = new DaftarPenyakit
                    {
                        Id = KelasDokter.Id,
                        NamaPenyakit = nama,
                        GejalaPenyakit = gejala + "\nBy : " + this.ToString(),
                        JenisPenyakit = this.Spesialis
                    };
                    db.DaftarPenyakits.Add(penyakit);
                    db.SaveChanges();
                }
                return 1;
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException e) {
                return -1;
            }
        }

        public int EditDatabase(string namaOld, string nama, string gejala)
        {
            try
            {
                using (var db = new ModelPenyakit())
                {
                    var result = db.DaftarPenyakits.SingleOrDefault(k => k.NamaPenyakit == namaOld);
                    if (result != null)
                    {
                        result.NamaPenyakit = nama;
                        result.GejalaPenyakit = gejala + "\nBy : " + this.ToString();
                        db.SaveChanges();
                    }
                }
                return 1;
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException e) {
                return -1;
            }
        }

        public void HapusDatabase(string nama)
        {
            using (var db = new ModelPenyakit())
            {
                db.DaftarPenyakits.RemoveRange(db.DaftarPenyakits.Where(item => item.NamaPenyakit == nama));
                db.SaveChanges();
            }
        }

        public new string ToString()
        {
            return "dr. " + Nama;
        }
        #endregion
    }

    public class DokterUmum : KelasDokter
    {
        #region Properti Dokter Umum
        public override string Nama
        {
            get { return this.nama; }
            protected set { this.nama = value; }
        }

        public override string Spesialis
        {
            get { return this.spesialis; }
            protected set { this.spesialis = value; }
        }
        #endregion

        #region Konstruktor Dokter Umum
        public DokterUmum(string name)
        {
            this.nama = name;
            this.spesialis = "Umum";
        }
        #endregion
    }

    public class DokterTHT : KelasDokter
    {
        #region Properti Dokter THT
        public override string Nama
        {
            get { return this.nama; }
            protected set { this.nama = value; }
        }

        public override string Spesialis
        {
            get { return this.spesialis; }
            protected set { this.spesialis = value; }
        }
        #endregion

        #region Konstruktor Dokter THT
        public DokterTHT(string name)
        {
            this.nama = name;
            this.spesialis = "THT";
        }
        #endregion
    }

    public class DokterPD : KelasDokter
    {
        #region Properti Dokter PD
        public override string Nama
        {
            get { return this.nama; }
            protected set { this.nama = value; }
        }

        public override string Spesialis
        {
            get { return this.spesialis; }
            protected set { this.spesialis = value; }
        }
        #endregion

        #region Konstruktor Dokter PD
        public DokterPD(string name)
        {
            this.nama = name;
            this.spesialis = "Penyakit Dalam";
        }
        #endregion
    }
}

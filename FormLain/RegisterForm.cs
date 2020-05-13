using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TugasPBO.Dokter;

namespace TugasPBO.FormLain
{
    public partial class RegisterForm : Form
    {
        static int IDDC = 0;

        public static int IDDOC 
        {
            get { return IDDC++; }
        }


        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            TambahDokter();
        }

        private void TambahDokter()
        {
            if (tBoxNama.Text != "" && tBoxPassword.Text != "")
            {
                using (var db = new ModelDokter())
                {
                    DaftarDokter dokter = new DaftarDokter
                    {
                        Id = IDDOC,
                        NamaLengkap = tBoxNama.Text,
                        Password = tBoxPassword.Text,
                        SpesialisasiDokter = cBoxSpes.Text
                    };
                    var cekDokter = db.DaftarDokters.FirstOrDefault(item => item.NamaLengkap == dokter.NamaLengkap);
                    if (cekDokter == null)
                    {
                        db.DaftarDokters.Add(dokter);
                        db.SaveChanges();
                        MessageBox.Show("Dokter berhasil ditambahkan!");
                        Close();
                    }
                    else {
                        MessageBox.Show("Username sudah dipakai, silakan gunakan username lain!");
                    }                    
                }
            }
            else
            {
                MessageBox.Show("Nama dan Password harus diisi!");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

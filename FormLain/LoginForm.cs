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
    public partial class LoginForm : Form
    {
        public MainForm.Pengguna pengguna;
        public KelasDokter dokter;
        
        public LoginForm(MainForm.Pengguna pengguna)
        {
            InitializeComponent();
            this.pengguna = pengguna;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MasukanInfo();
        }

        private void MasukanInfo()
        {
            if (tBoxNama.Text != "" && tBoxPassword.Text != "")
            {
                string nama = "", password, spesialisasi = "";
                bool isCorrect = false;
                using (var db = new ModelDokter())
                {
                    var query = from daftar in db.DaftarDokters where (daftar.NamaLengkap == tBoxNama.Text) select daftar;
                    foreach (var item in query)
                    {
                        nama = item.NamaLengkap;
                        password = item.Password;
                        spesialisasi = item.SpesialisasiDokter;
                        if (password == tBoxPassword.Text)
                            isCorrect = true;
                    }

                    if (nama == "")
                        MessageBox.Show("Dokter tidak ditemukan!");
                    else if (!isCorrect)
                        MessageBox.Show("Kata sandi keliru!");
                    else
                    {
                        pengguna = (MainForm.Pengguna)Enum.Parse(typeof(MainForm.Pengguna), spesialisasi.Replace(' ','_'));
                        if (pengguna == MainForm.Pengguna.Umum)
                        {
                            dokter = dokter as DokterUmum;
                            dokter = new DokterUmum(nama);
                        }
                        else if (pengguna == MainForm.Pengguna.THT)
                        {
                            dokter = dokter as DokterTHT;
                            dokter = new DokterTHT(nama);
                        }
                        else
                        {
                            dokter = dokter as DokterPD;
                            dokter = new DokterPD(nama);
                        }
                        MessageBox.Show("Berhasil login.");
                        Close();
                    }
                }
            }
            else
                MessageBox.Show("Kedua kolom harus diisi!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

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
using TugasPBO.Penyakit;

namespace TugasPBO.FormLain
{
    public partial class EditPenyakitForm : Form
    {
        public enum Mode {
            Edit, Tambah
        }
        KelasDokter despa;
        DaftarPenyakit penyakit;
        private Mode mode;
        

        public EditPenyakitForm(ListView.SelectedListViewItemCollection selectedItems, KelasDokter dokter, Mode mode)
        {
            InitializeComponent();
            despa = dokter;
            
            MainForm.Pengguna pengguna = MainForm.Pengguna.Pasien;
            try
            {
                pengguna = (MainForm.Pengguna)Enum.Parse(typeof(MainForm.Pengguna), dokter.Spesialis.Replace(' ', '_'));
            }
            catch (Exception) {
                pengguna = MainForm.Pengguna.Pasien;
            }
            this.mode = mode;
            if (mode == Mode.Edit) {
                tBoxNamaPenyakit.Text = selectedItems[0].SubItems[0].Text;
                rtBoxGejala.Text = selectedItems[0].SubItems[2].Text;
            }
            using (var db = new ModelPenyakit()) {
                var item = db.DaftarPenyakits.SingleOrDefault(k => k.NamaPenyakit == tBoxNamaPenyakit.Text);
                penyakit = item;
            }
            if(penyakit == null)
                penyakit = new DaftarPenyakit()
                {
                    NamaPenyakit = "",
                    GejalaPenyakit = "",
                    JenisPenyakit = ""
                };
            if (pengguna.ToString().Replace('_',' ') == penyakit.JenisPenyakit || (pengguna != MainForm.Pengguna.Pasien && penyakit.JenisPenyakit == MainForm.Pengguna.Umum.ToString()) || mode == Mode.Tambah)
            {
                btnTambah.Enabled = true;
            }
            else
            {
                tBoxNamaPenyakit.ReadOnly = true;
                tBoxNamaPenyakit.BackColor = Color.White;
                rtBoxGejala.ReadOnly = true;
                rtBoxGejala.BackColor = Color.White;
                btnTambah.Visible = false;
                btnTambah.Enabled = false;
                tBoxNamaPenyakit.BorderStyle = BorderStyle.None;
                rtBoxGejala.BorderStyle = BorderStyle.None;
                tBoxNamaPenyakit.Top = 47;
                tBoxNamaPenyakit.BackColor = this.BackColor;
                rtBoxGejala.BackColor = this.BackColor;
            }
            btnTambah.Text = mode == Mode.Edit ? "Update" : "Tambah";
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (mode == Mode.Tambah)
            {
                if (despa.TambahDatabase(tBoxNamaPenyakit.Text, rtBoxGejala.Text) == 1)
                {
                    MessageBox.Show("Penyakit berhasi ditambahkan!");
                    Close();
                }
                else
                    MessageBox.Show("Batas karakter terlampaui!");
            }
            else
            {
                if (despa.EditDatabase(penyakit.NamaPenyakit, tBoxNamaPenyakit.Text, rtBoxGejala.Text) == 1)
                {
                    MessageBox.Show("Penyakit berhasi diedit!");
                    Close();
                }
                else
                    MessageBox.Show("Batas karakter terlampaui!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            despa.HapusDatabase(tBoxNamaPenyakit.Name);
            MessageBox.Show("Penyakit Berhasi dihapus!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

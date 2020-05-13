using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TugasPBO.FormLain;
using TugasPBO.Penyakit;
using TugasPBO.Dokter;

namespace TugasPBO
{
    public partial class MainForm : Form
    {
        public enum Pengguna {
            Pasien, Umum, THT, Penyakit_Dalam
        }
        private Pengguna pengguna;
        private KelasDokter dokter;
        private void TambahPenyakit(string namaPenyakit, string jenisPenyakit, string gejalaPenyakit) {
            using(var db = new ModelPenyakit()) {
                DaftarPenyakit newPenyakit = new DaftarPenyakit()
                {
                    NamaPenyakit = namaPenyakit,
                    JenisPenyakit = jenisPenyakit,
                    GejalaPenyakit = gejalaPenyakit
                };
                db.DaftarPenyakits.Add(newPenyakit);
                db.SaveChanges();
            }
        }
        public MainForm()
        {
            InitializeComponent();
            tBoxNamaPenyakit.Controls.Add(new Label()
            {
                Height = 1,
                Dock = DockStyle.Bottom,
                BackColor = Color.RoyalBlue
            });
            pengguna = Pengguna.Pasien;
            using (var db = new ModelPenyakit()) {
                var check = db.DaftarPenyakits.Count();
                if (check == 0) {
                    TambahPenyakit("Penyakit jantung", "Penyakit Dalam", "- Jantung berdebar, atau detak jantung justru melambat.\n- Pusing.\n- Demam\n- Pembengkakan pada lengan, perut, tungkai, atau sekitar mata.\n- Nyeri pada bagian leher, rahang, tenggorokan, punggung, dan lengan.\n- Pingsan atau terasa mau pingsan.\n- Batuk kering yang tak kunjung membaik.\n- Mual.\n- Sesak napas atau napas menjadi pendek.\n- Tangan dan kaki terasa dingin.\n- Warna kulit membiru (sianosis).");
                    TambahPenyakit("Asma", "Penyakit Dalam", "- Batuk\n- Dada sesak\n- Sesak napas\n- Badan lemas, lesu, dan tidak bertenaga\n- Suara sengau\n- Menghela napas terus-terusan\n- Rasa gelisah yang tidak biasa");
                    TambahPenyakit("Diabetes mellitus", "Penyakit Dalam", "- Sering merasa haus.\n- Sering buang air kecil, terutama di malam hari.\n- Sering merasa sangat lapar.\n- Turunnya berat badan tanpa sebab yang jelas.\n- Berkurangnya massa otot.\n- Terdapat keton dalam urine. Keton adalah produk sisa dari pemecahan otot dan lemak akibat tubuh tidak dapat menggunakan gula sebagai sumber energi.\n- Lemas.\n- Pandangan kabur.\n- Luka yang sulit sembuh.\n- Sering mengalami infeksi, misalnya pada gusi, kulit, vagina, atau saluran kemih.\n- Mulut kering.\n- Rasa terbakar, kaku, dan nyeri pada kaki.\n- Gatal-gatal.\n- Disfungsi ereksi atau impotensi.\n- Mudah tersinggung.\n- Mengalami hipoglikemia reaktif, yaitu hipoglikemia yang terjadi beberapa jam setelah makan akibat produksi insulin yang berlebihan.\n- Munculnya bercak-bercak hitam di sekitar leher, ketiak, dan selangkangan, (akantosis nigrikans) sebagai tanda terjadinya resistensi insulin.");
                    TambahPenyakit("Faringitis", "THT", "- Sakit tenggorokan\n- Demam\n- Sakit kepala\n- Nyeri sendi dan nyeri otot\n- Ruam kulit\n- Membengkaknya kelenjar getah bening di leher");
                    TambahPenyakit("Influenza", "THT", "- Demam\n- Pilek\n- Hidung tersumbat\n- Bersin-bersin\n- Batuk\n- Sakit tenggorokan\n- Sakit kepala\n- Lemas\n- Nyeri otot\n- Tidak nafsu makan\n- Mual dan muntah\n- Menggigil");
                    TambahPenyakit("Mastoiditis", "THT", "- Keluarnya cairan dari telinga atau telinga bernanah.\n- Telinga terasa nyeri.\n- Demam, mungkin terjadi secara tiba-tiba dengan suhu yang tinggi.\n- Sakit kepala.\n- Gangguan pendengaran, seperti menurunnya atau bahkan hilangnya pendengaran.\n- Pembengkakan dan kemerahan di belakang telinga.\n- Pembengkakan di belakang telinga, dapat menyebabkan telinga menonjol atau terasa seperti terisi dengan cairan.");
                }
            }
        }

        private void btnCariPenyakit_Click(object sender, EventArgs e)
        {
            refreshList();
        }

        private void btnLoginDokter_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(pengguna);
            if (loginForm.ShowDialog() == DialogResult.Cancel) {
                dokter = loginForm.dokter;
                try
                {
                    pengguna = (MainForm.Pengguna)Enum.Parse(typeof(MainForm.Pengguna), dokter.Spesialis.Replace(' ', '_'));
                }
                catch (Exception) { }
                refreshInfo();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm form = new RegisterForm();
            form.ShowDialog();
        }

        private void LvPenyakit_DoubleClick(object sender, EventArgs e)
        {
            EditPenyakitForm penyakitForm = new EditPenyakitForm(lvPenyakit.SelectedItems, dokter, EditPenyakitForm.Mode.Edit);
            if(penyakitForm.ShowDialog() != null) {
                refreshList();
            };
        }

        private void BtnTambahPenyakit_Click(object sender, EventArgs e)
        {
            EditPenyakitForm penyakitForm = new EditPenyakitForm(lvPenyakit.SelectedItems, dokter, EditPenyakitForm.Mode.Tambah);
            if (penyakitForm.ShowDialog() != null) {
                refreshList();
            };
        }

        private void LvPenyakit_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            btnHapusPenyakit.Enabled = lvPenyakit.SelectedItems.Count>0;
        }

        private void BtnKeluarDokter_Click(object sender, EventArgs e)
        {
            pengguna = Pengguna.Pasien;
            dokter = dokter as KelasDokter;
            refreshInfo();
        }
        private void refreshInfo() {
            btnLoginDokter.Visible = pengguna == Pengguna.Pasien ? true : false;
            btnRegister.Visible = pengguna == Pengguna.Pasien ? true : false;
            btnTambahPenyakit.Visible = pengguna == Pengguna.Pasien ? false : true;
            btnHapusPenyakit.Visible = pengguna == Pengguna.Pasien ? false : true;
            btnHapusPenyakit.Enabled = lvPenyakit.SelectedItems.Count > 0;
            btnKeluarDokter.Visible = pengguna == Pengguna.Pasien ? false : true;
            lblSpesialis.Visible = pengguna != Pengguna.Pasien;
            if (pengguna != Pengguna.Pasien)
            {
                lblHalo.Text = "Halo, " + dokter.Nama + "!";
                lblHalo.Left = 452 - 5*(dokter.Nama.Length);
                if (pengguna == Pengguna.Umum)
                {
                    lblSpesialis.Text = "Dokter Umum";
                    lblSpesialis.Left = 448;
                }
                else if (pengguna == Pengguna.Penyakit_Dalam)
                {
                    lblSpesialis.Text = "Dokter Spesialis Penyakit Dalam";
                    lblSpesialis.Left = 405;
                }
                else {
                    lblSpesialis.Text = "Dokter Spesialis THT";
                    lblSpesialis.Left = 430;
                }
            }
            else
            {
                lblHalo.Text = "Halo, User!";
                lblHalo.Left = 427;
            }
        }

        private void refreshList() {
            lvPenyakit.Items.Clear();
            using (var db = new ModelPenyakit())
            {
                Boolean exist = false;
                var query = from penyakit in db.DaftarPenyakits where (penyakit.NamaPenyakit.Contains(tBoxNamaPenyakit.Text) || penyakit.GejalaPenyakit.Contains(tBoxNamaPenyakit.Text)) select penyakit;
                foreach (var item in query)
                {
                    exist = true;
                    ListViewItem newList = new ListViewItem(item.NamaPenyakit);
                    newList.SubItems.Add(item.JenisPenyakit.Replace('_', ' '));
                    newList.SubItems.Add(item.GejalaPenyakit);
                    lvPenyakit.Items.Add(newList);
                }
                if (!exist)
                {
                    MessageBox.Show("Data tidak ditemukan");
                }
            }
        }

        private void BtnHapusPenyakit_Click(object sender, EventArgs e)
        {
            string namaPenyakit = lvPenyakit.SelectedItems[0].SubItems[0].Text;
            using (var db = new ModelPenyakit()) {
                db.DaftarPenyakits.RemoveRange(db.DaftarPenyakits.Where(item => item.NamaPenyakit == namaPenyakit));
                db.SaveChanges();
            }
            lvPenyakit.SelectedItems[0].Remove();
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int IParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }
    }
}

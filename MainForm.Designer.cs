namespace TugasPBO
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnCariPenyakit = new System.Windows.Forms.Button();
            this.tBoxNamaPenyakit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gBoxPenyakit = new System.Windows.Forms.GroupBox();
            this.lvPenyakit = new System.Windows.Forms.ListView();
            this.chNama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chKategori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGejala = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRegister = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoginDokter = new System.Windows.Forms.Button();
            this.panelPenyakit = new System.Windows.Forms.Panel();
            this.btnTambahPenyakit = new System.Windows.Forms.Button();
            this.btnHapusPenyakit = new System.Windows.Forms.Button();
            this.btnKeluarDokter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHalo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSpesialis = new System.Windows.Forms.Label();
            this.gBoxPenyakit.SuspendLayout();
            this.panelPenyakit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCariPenyakit
            // 
            this.btnCariPenyakit.AutoEllipsis = true;
            this.btnCariPenyakit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCariPenyakit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCariPenyakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCariPenyakit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCariPenyakit.Location = new System.Drawing.Point(515, 151);
            this.btnCariPenyakit.Name = "btnCariPenyakit";
            this.btnCariPenyakit.Size = new System.Drawing.Size(75, 23);
            this.btnCariPenyakit.TabIndex = 9;
            this.btnCariPenyakit.Text = "CARI";
            this.btnCariPenyakit.UseVisualStyleBackColor = false;
            this.btnCariPenyakit.Click += new System.EventHandler(this.btnCariPenyakit_Click);
            // 
            // tBoxNamaPenyakit
            // 
            this.tBoxNamaPenyakit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tBoxNamaPenyakit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBoxNamaPenyakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxNamaPenyakit.Location = new System.Drawing.Point(59, 156);
            this.tBoxNamaPenyakit.Name = "tBoxNamaPenyakit";
            this.tBoxNamaPenyakit.Size = new System.Drawing.Size(450, 13);
            this.tBoxNamaPenyakit.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cari Penyakit :";
            // 
            // gBoxPenyakit
            // 
            this.gBoxPenyakit.Controls.Add(this.lvPenyakit);
            this.gBoxPenyakit.Location = new System.Drawing.Point(13, 3);
            this.gBoxPenyakit.Name = "gBoxPenyakit";
            this.gBoxPenyakit.Size = new System.Drawing.Size(538, 198);
            this.gBoxPenyakit.TabIndex = 0;
            this.gBoxPenyakit.TabStop = false;
            this.gBoxPenyakit.Text = "Penyakit : ";
            // 
            // lvPenyakit
            // 
            this.lvPenyakit.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNama,
            this.chKategori,
            this.chGejala});
            this.lvPenyakit.FullRowSelect = true;
            this.lvPenyakit.HideSelection = false;
            this.lvPenyakit.Location = new System.Drawing.Point(6, 19);
            this.lvPenyakit.MultiSelect = false;
            this.lvPenyakit.Name = "lvPenyakit";
            this.lvPenyakit.Size = new System.Drawing.Size(521, 173);
            this.lvPenyakit.TabIndex = 0;
            this.lvPenyakit.UseCompatibleStateImageBehavior = false;
            this.lvPenyakit.View = System.Windows.Forms.View.Details;
            this.lvPenyakit.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LvPenyakit_ItemSelectionChanged);
            this.lvPenyakit.DoubleClick += new System.EventHandler(this.LvPenyakit_DoubleClick);
            // 
            // chNama
            // 
            this.chNama.Text = "Nama Penyakit";
            this.chNama.Width = 120;
            // 
            // chKategori
            // 
            this.chKategori.Text = "Kategori";
            this.chKategori.Width = 100;
            // 
            // chGejala
            // 
            this.chGejala.Text = "Gejala";
            this.chGejala.Width = 300;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(489, 76);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(143, 23);
            this.btnRegister.TabIndex = 13;
            this.btnRegister.Text = "Daftar sebagai Dokter";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(547, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Version 1.0";
            // 
            // btnLoginDokter
            // 
            this.btnLoginDokter.Location = new System.Drawing.Point(340, 76);
            this.btnLoginDokter.Name = "btnLoginDokter";
            this.btnLoginDokter.Size = new System.Drawing.Size(143, 23);
            this.btnLoginDokter.TabIndex = 11;
            this.btnLoginDokter.Text = "Login sebagai Dokter";
            this.btnLoginDokter.UseVisualStyleBackColor = true;
            this.btnLoginDokter.Click += new System.EventHandler(this.btnLoginDokter_Click);
            // 
            // panelPenyakit
            // 
            this.panelPenyakit.Controls.Add(this.gBoxPenyakit);
            this.panelPenyakit.Location = new System.Drawing.Point(40, 179);
            this.panelPenyakit.Name = "panelPenyakit";
            this.panelPenyakit.Size = new System.Drawing.Size(567, 204);
            this.panelPenyakit.TabIndex = 10;
            // 
            // btnTambahPenyakit
            // 
            this.btnTambahPenyakit.Location = new System.Drawing.Point(59, 389);
            this.btnTambahPenyakit.Name = "btnTambahPenyakit";
            this.btnTambahPenyakit.Size = new System.Drawing.Size(75, 23);
            this.btnTambahPenyakit.TabIndex = 14;
            this.btnTambahPenyakit.Text = "Tambah";
            this.btnTambahPenyakit.UseVisualStyleBackColor = true;
            this.btnTambahPenyakit.Visible = false;
            this.btnTambahPenyakit.Click += new System.EventHandler(this.BtnTambahPenyakit_Click);
            // 
            // btnHapusPenyakit
            // 
            this.btnHapusPenyakit.Location = new System.Drawing.Point(140, 389);
            this.btnHapusPenyakit.Name = "btnHapusPenyakit";
            this.btnHapusPenyakit.Size = new System.Drawing.Size(75, 23);
            this.btnHapusPenyakit.TabIndex = 15;
            this.btnHapusPenyakit.Text = "Hapus";
            this.btnHapusPenyakit.UseVisualStyleBackColor = true;
            this.btnHapusPenyakit.Visible = false;
            this.btnHapusPenyakit.Click += new System.EventHandler(this.BtnHapusPenyakit_Click);
            // 
            // btnKeluarDokter
            // 
            this.btnKeluarDokter.Location = new System.Drawing.Point(414, 76);
            this.btnKeluarDokter.Name = "btnKeluarDokter";
            this.btnKeluarDokter.Size = new System.Drawing.Size(139, 23);
            this.btnKeluarDokter.TabIndex = 16;
            this.btnKeluarDokter.Text = "Keluar sebagai Dokter";
            this.btnKeluarDokter.UseVisualStyleBackColor = true;
            this.btnKeluarDokter.Visible = false;
            this.btnKeluarDokter.Click += new System.EventHandler(this.BtnKeluarDokter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 70);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // lblHalo
            // 
            this.lblHalo.AutoSize = true;
            this.lblHalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHalo.Location = new System.Drawing.Point(427, 35);
            this.lblHalo.Name = "lblHalo";
            this.lblHalo.Size = new System.Drawing.Size(103, 24);
            this.lblHalo.TabIndex = 18;
            this.lblHalo.Text = "Halo, User!";
            this.lblHalo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(613, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // lblSpesialis
            // 
            this.lblSpesialis.AutoSize = true;
            this.lblSpesialis.BackColor = System.Drawing.Color.Transparent;
            this.lblSpesialis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSpesialis.Location = new System.Drawing.Point(448, 60);
            this.lblSpesialis.Name = "lblSpesialis";
            this.lblSpesialis.Size = new System.Drawing.Size(72, 13);
            this.lblSpesialis.TabIndex = 20;
            this.lblSpesialis.Text = "Dokter Umum";
            this.lblSpesialis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSpesialis.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(644, 432);
            this.Controls.Add(this.lblSpesialis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblHalo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnKeluarDokter);
            this.Controls.Add(this.btnHapusPenyakit);
            this.Controls.Add(this.btnTambahPenyakit);
            this.Controls.Add(this.btnCariPenyakit);
            this.Controls.Add(this.tBoxNamaPenyakit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLoginDokter);
            this.Controls.Add(this.panelPenyakit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "WikiPenyakit";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.gBoxPenyakit.ResumeLayout(false);
            this.panelPenyakit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCariPenyakit;
        private System.Windows.Forms.TextBox tBoxNamaPenyakit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gBoxPenyakit;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLoginDokter;
        private System.Windows.Forms.Panel panelPenyakit;
        private System.Windows.Forms.ListView lvPenyakit;
        private System.Windows.Forms.ColumnHeader chNama;
        private System.Windows.Forms.ColumnHeader chGejala;
        private System.Windows.Forms.Button btnTambahPenyakit;
        private System.Windows.Forms.Button btnHapusPenyakit;
        private System.Windows.Forms.Button btnKeluarDokter;
        private System.Windows.Forms.ColumnHeader chKategori;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHalo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSpesialis;
    }
}


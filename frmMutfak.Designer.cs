namespace Restorant_Projesi
{
    partial class frmMutfak
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
            this.lvKategoriler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvGıdaListesi = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblIstenilenUrun = new System.Windows.Forms.Label();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.panelurun = new System.Windows.Forms.Panel();
            this.txtKategoriId = new System.Windows.Forms.TextBox();
            this.txtAcıklama = new System.Windows.Forms.TextBox();
            this.txtKategoriAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbKategoriler1 = new System.Windows.Forms.ComboBox();
            this.cbKategoriler = new System.Windows.Forms.ComboBox();
            this.panelAnaKategori = new System.Windows.Forms.Panel();
            this.txtKategoriId1 = new System.Windows.Forms.TextBox();
            this.txtAciklama1 = new System.Windows.Forms.TextBox();
            this.txtKategoriAdi1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelUrun1 = new System.Windows.Forms.Panel();
            this.txtUrunId = new System.Windows.Forms.TextBox();
            this.txtGidaFiyati = new System.Windows.Forms.TextBox();
            this.txtGidaAdi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rbAltKategori = new System.Windows.Forms.RadioButton();
            this.AnaKategori = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelurun.SuspendLayout();
            this.panelAnaKategori.SuspendLayout();
            this.panelUrun1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvKategoriler
            // 
            this.lvKategoriler.BackgroundImage = global::Restorant_Projesi.Properties.Resources.lw;
            this.lvKategoriler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvKategoriler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvKategoriler.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.lvKategoriler.FullRowSelect = true;
            this.lvKategoriler.GridLines = true;
            this.lvKategoriler.Location = new System.Drawing.Point(12, 358);
            this.lvKategoriler.Name = "lvKategoriler";
            this.lvKategoriler.Size = new System.Drawing.Size(343, 260);
            this.lvKategoriler.TabIndex = 0;
            this.lvKategoriler.UseCompatibleStateImageBehavior = false;
            this.lvKategoriler.View = System.Windows.Forms.View.Details;
            this.lvKategoriler.SelectedIndexChanged += new System.EventHandler(this.lvKategoriler_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tur Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kategori";
            this.columnHeader2.Width = 141;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Acıklama";
            this.columnHeader3.Width = 141;
            // 
            // lvGıdaListesi
            // 
            this.lvGıdaListesi.BackgroundImage = global::Restorant_Projesi.Properties.Resources.lw;
            this.lvGıdaListesi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvGıdaListesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvGıdaListesi.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.lvGıdaListesi.FullRowSelect = true;
            this.lvGıdaListesi.GridLines = true;
            this.lvGıdaListesi.Location = new System.Drawing.Point(387, 358);
            this.lvGıdaListesi.Name = "lvGıdaListesi";
            this.lvGıdaListesi.Size = new System.Drawing.Size(478, 260);
            this.lvGıdaListesi.TabIndex = 1;
            this.lvGıdaListesi.UseCompatibleStateImageBehavior = false;
            this.lvGıdaListesi.View = System.Windows.Forms.View.Details;
            this.lvGıdaListesi.SelectedIndexChanged += new System.EventHandler(this.lvGıdaListesi_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "UrunId";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "UrunKategoriId";
            this.columnHeader5.Width = 85;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Katgori";
            this.columnHeader6.Width = 110;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Urun Adı";
            this.columnHeader7.Width = 143;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Urun Fiyatı";
            this.columnHeader8.Width = 88;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnEkle.BackgroundImage = global::Restorant_Projesi.Properties.Resources.ekle;
            this.btnEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Location = new System.Drawing.Point(167, 240);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(128, 91);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnDegistir
            // 
            this.btnDegistir.BackColor = System.Drawing.Color.Transparent;
            this.btnDegistir.BackgroundImage = global::Restorant_Projesi.Properties.Resources.degistir;
            this.btnDegistir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDegistir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDegistir.Location = new System.Drawing.Point(314, 240);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(128, 91);
            this.btnDegistir.TabIndex = 2;
            this.btnDegistir.UseVisualStyleBackColor = false;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnBul
            // 
            this.btnBul.BackColor = System.Drawing.Color.Transparent;
            this.btnBul.BackgroundImage = global::Restorant_Projesi.Properties.Resources.bul;
            this.btnBul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBul.Location = new System.Drawing.Point(461, 240);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(129, 91);
            this.btnBul.TabIndex = 2;
            this.btnBul.UseVisualStyleBackColor = false;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Transparent;
            this.btnSil.BackgroundImage = global::Restorant_Projesi.Properties.Resources.sil1;
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Location = new System.Drawing.Point(609, 240);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(129, 91);
            this.btnSil.TabIndex = 2;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblIstenilenUrun
            // 
            this.lblIstenilenUrun.AutoSize = true;
            this.lblIstenilenUrun.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblIstenilenUrun.Location = new System.Drawing.Point(268, 202);
            this.lblIstenilenUrun.Name = "lblIstenilenUrun";
            this.lblIstenilenUrun.Size = new System.Drawing.Size(173, 18);
            this.lblIstenilenUrun.TabIndex = 3;
            this.lblIstenilenUrun.Text = "Aramak İstediğiniz Ürün :";
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(448, 201);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(122, 20);
            this.txtArama.TabIndex = 4;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // panelurun
            // 
            this.panelurun.BackColor = System.Drawing.Color.Transparent;
            this.panelurun.Controls.Add(this.txtKategoriId);
            this.panelurun.Controls.Add(this.txtAcıklama);
            this.panelurun.Controls.Add(this.txtKategoriAdi);
            this.panelurun.Controls.Add(this.label4);
            this.panelurun.Controls.Add(this.label3);
            this.panelurun.Controls.Add(this.label2);
            this.panelurun.Controls.Add(this.cbKategoriler1);
            this.panelurun.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.panelurun.Location = new System.Drawing.Point(608, 43);
            this.panelurun.Name = "panelurun";
            this.panelurun.Size = new System.Drawing.Size(292, 129);
            this.panelurun.TabIndex = 5;
            // 
            // txtKategoriId
            // 
            this.txtKategoriId.Location = new System.Drawing.Point(257, 53);
            this.txtKategoriId.Name = "txtKategoriId";
            this.txtKategoriId.Size = new System.Drawing.Size(27, 25);
            this.txtKategoriId.TabIndex = 4;
            this.txtKategoriId.Visible = false;
            // 
            // txtAcıklama
            // 
            this.txtAcıklama.Location = new System.Drawing.Point(136, 87);
            this.txtAcıklama.Name = "txtAcıklama";
            this.txtAcıklama.Size = new System.Drawing.Size(100, 25);
            this.txtAcıklama.TabIndex = 3;
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.Location = new System.Drawing.Point(136, 53);
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.Size = new System.Drawing.Size(100, 25);
            this.txtKategoriAdi.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Açıklama  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kategori Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gıda Kategorisi :";
            // 
            // cbKategoriler1
            // 
            this.cbKategoriler1.FormattingEnabled = true;
            this.cbKategoriler1.Location = new System.Drawing.Point(136, 17);
            this.cbKategoriler1.Name = "cbKategoriler1";
            this.cbKategoriler1.Size = new System.Drawing.Size(121, 26);
            this.cbKategoriler1.TabIndex = 0;
            this.cbKategoriler1.SelectedIndexChanged += new System.EventHandler(this.cbKategoriler_SelectedIndexChanged);
            // 
            // cbKategoriler
            // 
            this.cbKategoriler.FormattingEnabled = true;
            this.cbKategoriler.Location = new System.Drawing.Point(136, 17);
            this.cbKategoriler.Name = "cbKategoriler";
            this.cbKategoriler.Size = new System.Drawing.Size(121, 26);
            this.cbKategoriler.TabIndex = 0;
            this.cbKategoriler.SelectedIndexChanged += new System.EventHandler(this.cbKategoriler_SelectedIndexChanged_1);
            // 
            // panelAnaKategori
            // 
            this.panelAnaKategori.BackColor = System.Drawing.Color.Transparent;
            this.panelAnaKategori.Controls.Add(this.txtKategoriId1);
            this.panelAnaKategori.Controls.Add(this.txtAciklama1);
            this.panelAnaKategori.Controls.Add(this.txtKategoriAdi1);
            this.panelAnaKategori.Controls.Add(this.label5);
            this.panelAnaKategori.Controls.Add(this.label6);
            this.panelAnaKategori.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.panelAnaKategori.Location = new System.Drawing.Point(310, 43);
            this.panelAnaKategori.Name = "panelAnaKategori";
            this.panelAnaKategori.Size = new System.Drawing.Size(292, 129);
            this.panelAnaKategori.TabIndex = 5;
            // 
            // txtKategoriId1
            // 
            this.txtKategoriId1.Location = new System.Drawing.Point(210, 50);
            this.txtKategoriId1.Name = "txtKategoriId1";
            this.txtKategoriId1.Size = new System.Drawing.Size(27, 25);
            this.txtKategoriId1.TabIndex = 4;
            this.txtKategoriId1.Visible = false;
            // 
            // txtAciklama1
            // 
            this.txtAciklama1.Location = new System.Drawing.Point(104, 84);
            this.txtAciklama1.Name = "txtAciklama1";
            this.txtAciklama1.Size = new System.Drawing.Size(100, 25);
            this.txtAciklama1.TabIndex = 3;
            // 
            // txtKategoriAdi1
            // 
            this.txtKategoriAdi1.Location = new System.Drawing.Point(104, 50);
            this.txtKategoriAdi1.Name = "txtKategoriAdi1";
            this.txtKategoriAdi1.Size = new System.Drawing.Size(100, 25);
            this.txtKategoriAdi1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Açıklama :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Kategori Adı :";
            // 
            // panelUrun1
            // 
            this.panelUrun1.BackColor = System.Drawing.Color.Transparent;
            this.panelUrun1.Controls.Add(this.txtUrunId);
            this.panelUrun1.Controls.Add(this.txtGidaFiyati);
            this.panelUrun1.Controls.Add(this.txtGidaAdi);
            this.panelUrun1.Controls.Add(this.label7);
            this.panelUrun1.Controls.Add(this.label8);
            this.panelUrun1.Controls.Add(this.label9);
            this.panelUrun1.Controls.Add(this.cbKategoriler);
            this.panelUrun1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.panelUrun1.Location = new System.Drawing.Point(12, 43);
            this.panelUrun1.Name = "panelUrun1";
            this.panelUrun1.Size = new System.Drawing.Size(292, 129);
            this.panelUrun1.TabIndex = 5;
            // 
            // txtUrunId
            // 
            this.txtUrunId.Location = new System.Drawing.Point(257, 53);
            this.txtUrunId.Name = "txtUrunId";
            this.txtUrunId.Size = new System.Drawing.Size(27, 25);
            this.txtUrunId.TabIndex = 4;
            this.txtUrunId.Visible = false;
            // 
            // txtGidaFiyati
            // 
            this.txtGidaFiyati.Location = new System.Drawing.Point(136, 87);
            this.txtGidaFiyati.Name = "txtGidaFiyati";
            this.txtGidaFiyati.Size = new System.Drawing.Size(100, 25);
            this.txtGidaFiyati.TabIndex = 3;
            // 
            // txtGidaAdi
            // 
            this.txtGidaAdi.Location = new System.Drawing.Point(136, 53);
            this.txtGidaAdi.Name = "txtGidaAdi";
            this.txtGidaAdi.Size = new System.Drawing.Size(100, 25);
            this.txtGidaAdi.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Gıda Fiyatı :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "Gıda Adı :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 18);
            this.label9.TabIndex = 1;
            this.label9.Text = "Gıda Kategorisi :";
            // 
            // rbAltKategori
            // 
            this.rbAltKategori.AutoSize = true;
            this.rbAltKategori.BackColor = System.Drawing.Color.Transparent;
            this.rbAltKategori.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.rbAltKategori.Location = new System.Drawing.Point(184, 12);
            this.rbAltKategori.Name = "rbAltKategori";
            this.rbAltKategori.Size = new System.Drawing.Size(90, 22);
            this.rbAltKategori.TabIndex = 5;
            this.rbAltKategori.TabStop = true;
            this.rbAltKategori.Text = "Urun Ekle";
            this.rbAltKategori.UseVisualStyleBackColor = false;
            this.rbAltKategori.CheckedChanged += new System.EventHandler(this.rbAltKategori_CheckedChanged);
            // 
            // AnaKategori
            // 
            this.AnaKategori.AutoSize = true;
            this.AnaKategori.BackColor = System.Drawing.Color.Transparent;
            this.AnaKategori.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.AnaKategori.Location = new System.Drawing.Point(294, 12);
            this.AnaKategori.Name = "AnaKategori";
            this.AnaKategori.Size = new System.Drawing.Size(119, 22);
            this.AnaKategori.TabIndex = 5;
            this.AnaKategori.TabStop = true;
            this.AnaKategori.Text = "Urun Kategori";
            this.AnaKategori.UseVisualStyleBackColor = false;
            this.AnaKategori.CheckedChanged += new System.EventHandler(this.AnaKategori_CheckedChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::Restorant_Projesi.Properties.Resources.exit1;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(799, 650);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 58);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Restorant_Projesi.Properties.Resources.geridon2;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(678, 650);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 58);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMutfak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Restorant_Projesi.Properties.Resources._01;
            this.ClientSize = new System.Drawing.Size(900, 720);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AnaKategori);
            this.Controls.Add(this.rbAltKategori);
            this.Controls.Add(this.panelAnaKategori);
            this.Controls.Add(this.panelUrun1);
            this.Controls.Add(this.panelurun);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.lblIstenilenUrun);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lvGıdaListesi);
            this.Controls.Add(this.lvKategoriler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMutfak";
            this.Text = "frmMutfak";
            this.Load += new System.EventHandler(this.frmMutfak_Load);
            this.panelurun.ResumeLayout(false);
            this.panelurun.PerformLayout();
            this.panelAnaKategori.ResumeLayout(false);
            this.panelAnaKategori.PerformLayout();
            this.panelUrun1.ResumeLayout(false);
            this.panelUrun1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvKategoriler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lvGıdaListesi;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblIstenilenUrun;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Panel panelurun;
        private System.Windows.Forms.TextBox txtKategoriId;
        private System.Windows.Forms.TextBox txtAcıklama;
        private System.Windows.Forms.TextBox txtKategoriAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbKategoriler;
        private System.Windows.Forms.Panel panelAnaKategori;
        private System.Windows.Forms.TextBox txtKategoriId1;
        private System.Windows.Forms.TextBox txtAciklama1;
        private System.Windows.Forms.TextBox txtKategoriAdi1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelUrun1;
        private System.Windows.Forms.TextBox txtUrunId;
        private System.Windows.Forms.TextBox txtGidaFiyati;
        private System.Windows.Forms.TextBox txtGidaAdi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbKategoriler1;
        private System.Windows.Forms.RadioButton rbAltKategori;
        private System.Windows.Forms.RadioButton AnaKategori;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
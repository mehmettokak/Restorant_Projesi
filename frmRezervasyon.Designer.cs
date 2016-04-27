namespace Restorant_Projesi
{
    partial class frmRezervasyon
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
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.txtMasa = new System.Windows.Forms.TextBox();
            this.txtKisisayisi = new System.Windows.Forms.TextBox();
            this.txtMasaNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnYeniMusteri = new System.Windows.Forms.Button();
            this.btnRzrvsynAc = new System.Windows.Forms.Button();
            this.btnSipariskontrol = new System.Windows.Forms.Button();
            this.btnMustriGuncelle = new System.Windows.Forms.Button();
            this.cbKisiSayisi = new System.Windows.Forms.ComboBox();
            this.cbMasa = new System.Windows.Forms.ComboBox();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMusteriad = new System.Windows.Forms.TextBox();
            this.txtMusteriTlf = new System.Windows.Forms.TextBox();
            this.txtMusteriAdres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lvMusteriler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnKapat = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTarih
            // 
            this.txtTarih.BackColor = System.Drawing.Color.Linen;
            this.txtTarih.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTarih.Location = new System.Drawing.Point(98, 63);
            this.txtTarih.Multiline = true;
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.ReadOnly = true;
            this.txtTarih.Size = new System.Drawing.Size(111, 29);
            this.txtTarih.TabIndex = 0;
            // 
            // txtMasa
            // 
            this.txtMasa.BackColor = System.Drawing.Color.Linen;
            this.txtMasa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMasa.Location = new System.Drawing.Point(98, 98);
            this.txtMasa.Multiline = true;
            this.txtMasa.Name = "txtMasa";
            this.txtMasa.ReadOnly = true;
            this.txtMasa.Size = new System.Drawing.Size(111, 29);
            this.txtMasa.TabIndex = 0;
            // 
            // txtKisisayisi
            // 
            this.txtKisisayisi.BackColor = System.Drawing.Color.Linen;
            this.txtKisisayisi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKisisayisi.Enabled = false;
            this.txtKisisayisi.Location = new System.Drawing.Point(98, 133);
            this.txtKisisayisi.Multiline = true;
            this.txtKisisayisi.Name = "txtKisisayisi";
            this.txtKisisayisi.ReadOnly = true;
            this.txtKisisayisi.Size = new System.Drawing.Size(111, 29);
            this.txtKisisayisi.TabIndex = 0;
            // 
            // txtMasaNo
            // 
            this.txtMasaNo.Location = new System.Drawing.Point(239, 98);
            this.txtMasaNo.Multiline = true;
            this.txtMasaNo.Name = "txtMasaNo";
            this.txtMasaNo.ReadOnly = true;
            this.txtMasaNo.Size = new System.Drawing.Size(30, 21);
            this.txtMasaNo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(34, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "TARİH :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(13, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "MASA SEÇ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(10, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "AÇIKLAMA :";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(98, 183);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(171, 116);
            this.txtAciklama.TabIndex = 0;
            // 
            // btnYeniMusteri
            // 
            this.btnYeniMusteri.Location = new System.Drawing.Point(201, 350);
            this.btnYeniMusteri.Name = "btnYeniMusteri";
            this.btnYeniMusteri.Size = new System.Drawing.Size(133, 66);
            this.btnYeniMusteri.TabIndex = 3;
            this.btnYeniMusteri.Text = "YENİ MUSTERİ EKLE";
            this.btnYeniMusteri.UseVisualStyleBackColor = true;
            this.btnYeniMusteri.Click += new System.EventHandler(this.btnYeniMusteri_Click);
            // 
            // btnRzrvsynAc
            // 
            this.btnRzrvsynAc.Location = new System.Drawing.Point(354, 350);
            this.btnRzrvsynAc.Name = "btnRzrvsynAc";
            this.btnRzrvsynAc.Size = new System.Drawing.Size(130, 66);
            this.btnRzrvsynAc.TabIndex = 3;
            this.btnRzrvsynAc.Text = "REZERVASYON AÇ";
            this.btnRzrvsynAc.UseVisualStyleBackColor = true;
            this.btnRzrvsynAc.Click += new System.EventHandler(this.btnRzrvsynAc_Click);
            // 
            // btnSipariskontrol
            // 
            this.btnSipariskontrol.Location = new System.Drawing.Point(490, 350);
            this.btnSipariskontrol.Name = "btnSipariskontrol";
            this.btnSipariskontrol.Size = new System.Drawing.Size(129, 66);
            this.btnSipariskontrol.TabIndex = 3;
            this.btnSipariskontrol.Text = "REZERVASYONLAR";
            this.btnSipariskontrol.UseVisualStyleBackColor = true;
            this.btnSipariskontrol.Click += new System.EventHandler(this.btnSipariskontrol_Click);
            // 
            // btnMustriGuncelle
            // 
            this.btnMustriGuncelle.Location = new System.Drawing.Point(625, 350);
            this.btnMustriGuncelle.Name = "btnMustriGuncelle";
            this.btnMustriGuncelle.Size = new System.Drawing.Size(111, 66);
            this.btnMustriGuncelle.TabIndex = 3;
            this.btnMustriGuncelle.Text = "GUNCELLE";
            this.btnMustriGuncelle.UseVisualStyleBackColor = true;
            this.btnMustriGuncelle.Click += new System.EventHandler(this.btnMustriGuncelle_Click);
            // 
            // cbKisiSayisi
            // 
            this.cbKisiSayisi.FormattingEnabled = true;
            this.cbKisiSayisi.Location = new System.Drawing.Point(215, 133);
            this.cbKisiSayisi.Name = "cbKisiSayisi";
            this.cbKisiSayisi.Size = new System.Drawing.Size(18, 21);
            this.cbKisiSayisi.TabIndex = 1;
            this.cbKisiSayisi.SelectedIndexChanged += new System.EventHandler(this.cbKisiSayisi_SelectedIndexChanged);
            this.cbKisiSayisi.MouseEnter += new System.EventHandler(this.cbKisiSayisi_MouseEnter);
            this.cbKisiSayisi.MouseLeave += new System.EventHandler(this.cbKisiSayisi_MouseLeave);
            // 
            // cbMasa
            // 
            this.cbMasa.FormattingEnabled = true;
            this.cbMasa.Location = new System.Drawing.Point(215, 98);
            this.cbMasa.Name = "cbMasa";
            this.cbMasa.Size = new System.Drawing.Size(18, 21);
            this.cbMasa.TabIndex = 1;
            this.cbMasa.SelectedIndexChanged += new System.EventHandler(this.cbMasa_SelectedIndexChanged);
            this.cbMasa.MouseEnter += new System.EventHandler(this.cbMasa_MouseEnter);
            this.cbMasa.MouseLeave += new System.EventHandler(this.cbMasa_MouseLeave);
            // 
            // dtTarih
            // 
            this.dtTarih.Location = new System.Drawing.Point(215, 64);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(18, 20);
            this.dtTarih.TabIndex = 4;
            this.dtTarih.ValueChanged += new System.EventHandler(this.dtTarih_ValueChanged);
            this.dtTarih.Enter += new System.EventHandler(this.dtTarih_Enter);
            this.dtTarih.MouseEnter += new System.EventHandler(this.dtTarih_MouseEnter);
            this.dtTarih.MouseLeave += new System.EventHandler(this.dtTarih_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(7, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "KİŞİ SAYISI  :";
            // 
            // txtMusteriad
            // 
            this.txtMusteriad.Location = new System.Drawing.Point(417, 42);
            this.txtMusteriad.Multiline = true;
            this.txtMusteriad.Name = "txtMusteriad";
            this.txtMusteriad.Size = new System.Drawing.Size(137, 25);
            this.txtMusteriad.TabIndex = 5;
            this.txtMusteriad.TextChanged += new System.EventHandler(this.txtMusteriad_TextChanged);
            // 
            // txtMusteriTlf
            // 
            this.txtMusteriTlf.Location = new System.Drawing.Point(560, 42);
            this.txtMusteriTlf.Multiline = true;
            this.txtMusteriTlf.Name = "txtMusteriTlf";
            this.txtMusteriTlf.Size = new System.Drawing.Size(136, 25);
            this.txtMusteriTlf.TabIndex = 5;
            this.txtMusteriTlf.TextChanged += new System.EventHandler(this.txtMusteriTlf_TextChanged);
            // 
            // txtMusteriAdres
            // 
            this.txtMusteriAdres.Location = new System.Drawing.Point(702, 42);
            this.txtMusteriAdres.Multiline = true;
            this.txtMusteriAdres.Name = "txtMusteriAdres";
            this.txtMusteriAdres.Size = new System.Drawing.Size(148, 25);
            this.txtMusteriAdres.TabIndex = 5;
            this.txtMusteriAdres.TextChanged += new System.EventHandler(this.txtMusteriAdres_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(487, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Müşteri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(620, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Telefon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(729, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Adres";
            // 
            // lvMusteriler
            // 
            this.lvMusteriler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvMusteriler.FullRowSelect = true;
            this.lvMusteriler.GridLines = true;
            this.lvMusteriler.Location = new System.Drawing.Point(560, 88);
            this.lvMusteriler.MultiSelect = false;
            this.lvMusteriler.Name = "lvMusteriler";
            this.lvMusteriler.Size = new System.Drawing.Size(497, 247);
            this.lvMusteriler.TabIndex = 6;
            this.lvMusteriler.UseCompatibleStateImageBehavior = false;
            this.lvMusteriler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Musteri No";
            this.columnHeader1.Width = 73;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adı";
            this.columnHeader2.Width = 116;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyadı";
            this.columnHeader3.Width = 93;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefon";
            this.columnHeader4.Width = 91;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Adres";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "E-mail";
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(757, 350);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(111, 66);
            this.btnKapat.TabIndex = 3;
            this.btnKapat.Text = "GERİ DÖN";
            this.btnKapat.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::Restorant_Projesi.Properties.Resources.cikis1;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(163, 424);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 58);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Restorant_Projesi.Properties.Resources.geridon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(42, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 58);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmRezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.BackgroundImage = global::Restorant_Projesi.Properties.Resources._01;
            this.ClientSize = new System.Drawing.Size(999, 494);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvMusteriler);
            this.Controls.Add(this.txtMusteriAdres);
            this.Controls.Add(this.txtMusteriTlf);
            this.Controls.Add(this.txtMusteriad);
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnMustriGuncelle);
            this.Controls.Add(this.btnSipariskontrol);
            this.Controls.Add(this.btnRzrvsynAc);
            this.Controls.Add(this.btnYeniMusteri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbKisiSayisi);
            this.Controls.Add(this.cbMasa);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtKisisayisi);
            this.Controls.Add(this.txtMasa);
            this.Controls.Add(this.txtMasaNo);
            this.Controls.Add(this.txtTarih);
            this.Name = "frmRezervasyon";
            this.Text = "frmRezervasyon";
            this.Load += new System.EventHandler(this.frmRezervasyon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.TextBox txtMasa;
        private System.Windows.Forms.TextBox txtKisisayisi;
        private System.Windows.Forms.TextBox txtMasaNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Button btnYeniMusteri;
        private System.Windows.Forms.Button btnRzrvsynAc;
        private System.Windows.Forms.Button btnSipariskontrol;
        private System.Windows.Forms.Button btnMustriGuncelle;
        private System.Windows.Forms.ComboBox cbKisiSayisi;
        private System.Windows.Forms.ComboBox cbMasa;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMusteriad;
        private System.Windows.Forms.TextBox txtMusteriTlf;
        private System.Windows.Forms.TextBox txtMusteriAdres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lvMusteriler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
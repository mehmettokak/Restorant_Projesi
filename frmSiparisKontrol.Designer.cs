namespace Restorant_Projesi
{
    partial class frmSiparisKontrol
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
            this.lvMusteriDetaylari = new System.Windows.Forms.ListView();
            this.MusteriId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MusteriAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MusteriSyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AdisyonID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvSatisDetaylari = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbltoplTutar = new System.Windows.Forms.Label();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblToplamSiparis = new System.Windows.Forms.Label();
            this.lblGenelToplam = new System.Windows.Forms.Label();
            this.lblSonSiparisTarihi = new System.Windows.Forms.Label();
            this.lvMusteriler = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnGeridon = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvMusteriDetaylari
            // 
            this.lvMusteriDetaylari.BackColor = System.Drawing.SystemColors.WindowText;
            this.lvMusteriDetaylari.BackgroundImage = global::Restorant_Projesi.Properties.Resources.lw;
            this.lvMusteriDetaylari.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvMusteriDetaylari.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MusteriId,
            this.MusteriAd,
            this.MusteriSyad,
            this.Tarih,
            this.AdisyonID});
            this.lvMusteriDetaylari.Font = new System.Drawing.Font("Open Sans", 8F, System.Drawing.FontStyle.Bold);
            this.lvMusteriDetaylari.FullRowSelect = true;
            this.lvMusteriDetaylari.GridLines = true;
            this.lvMusteriDetaylari.Location = new System.Drawing.Point(395, 12);
            this.lvMusteriDetaylari.Name = "lvMusteriDetaylari";
            this.lvMusteriDetaylari.Size = new System.Drawing.Size(579, 381);
            this.lvMusteriDetaylari.TabIndex = 0;
            this.lvMusteriDetaylari.UseCompatibleStateImageBehavior = false;
            this.lvMusteriDetaylari.View = System.Windows.Forms.View.Details;
            this.lvMusteriDetaylari.SelectedIndexChanged += new System.EventHandler(this.lvMusteriDetaylari_SelectedIndexChanged);
            // 
            // MusteriId
            // 
            this.MusteriId.Text = "Musteri ID";
            this.MusteriId.Width = 73;
            // 
            // MusteriAd
            // 
            this.MusteriAd.Text = "Musteri Adı";
            this.MusteriAd.Width = 163;
            // 
            // MusteriSyad
            // 
            this.MusteriSyad.Text = "Musteri Soyadı";
            this.MusteriSyad.Width = 157;
            // 
            // Tarih
            // 
            this.Tarih.Text = "Tarih";
            this.Tarih.Width = 107;
            // 
            // AdisyonID
            // 
            this.AdisyonID.Text = "Adisyon ID";
            this.AdisyonID.Width = 78;
            // 
            // lvSatisDetaylari
            // 
            this.lvSatisDetaylari.BackgroundImage = global::Restorant_Projesi.Properties.Resources.lw;
            this.lvSatisDetaylari.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvSatisDetaylari.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvSatisDetaylari.Font = new System.Drawing.Font("Open Sans", 8F, System.Drawing.FontStyle.Bold);
            this.lvSatisDetaylari.FullRowSelect = true;
            this.lvSatisDetaylari.GridLines = true;
            this.lvSatisDetaylari.Location = new System.Drawing.Point(395, 413);
            this.lvSatisDetaylari.Name = "lvSatisDetaylari";
            this.lvSatisDetaylari.Size = new System.Drawing.Size(579, 229);
            this.lvSatisDetaylari.TabIndex = 1;
            this.lvSatisDetaylari.UseCompatibleStateImageBehavior = false;
            this.lvSatisDetaylari.View = System.Windows.Forms.View.Details;
            this.lvSatisDetaylari.SelectedIndexChanged += new System.EventHandler(this.lvSatisDetaylari_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Satıs ID";
            this.columnHeader1.Width = 73;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Urun Adı";
            this.columnHeader2.Width = 321;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Urun Adeti";
            this.columnHeader3.Width = 98;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Urun Fiyatı";
            this.columnHeader4.Width = 169;
            // 
            // lbltoplTutar
            // 
            this.lbltoplTutar.AutoSize = true;
            this.lbltoplTutar.BackColor = System.Drawing.Color.Transparent;
            this.lbltoplTutar.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbltoplTutar.Location = new System.Drawing.Point(32, 45);
            this.lbltoplTutar.Name = "lbltoplTutar";
            this.lbltoplTutar.Size = new System.Drawing.Size(96, 18);
            this.lbltoplTutar.TabIndex = 2;
            this.lbltoplTutar.Text = "Siparis Adeti :";
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtToplamTutar.Location = new System.Drawing.Point(143, 45);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.ReadOnly = true;
            this.txtToplamTutar.Size = new System.Drawing.Size(35, 25);
            this.txtToplamTutar.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(64, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Toplam :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(23, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Genel Toplam :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(43, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Son Sİparis :";
            // 
            // lblToplamSiparis
            // 
            this.lblToplamSiparis.AutoSize = true;
            this.lblToplamSiparis.BackColor = System.Drawing.Color.Transparent;
            this.lblToplamSiparis.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblToplamSiparis.Location = new System.Drawing.Point(143, 86);
            this.lblToplamSiparis.Name = "lblToplamSiparis";
            this.lblToplamSiparis.Size = new System.Drawing.Size(33, 18);
            this.lblToplamSiparis.TabIndex = 2;
            this.lblToplamSiparis.Text = "_____";
            // 
            // lblGenelToplam
            // 
            this.lblGenelToplam.AutoSize = true;
            this.lblGenelToplam.BackColor = System.Drawing.Color.Transparent;
            this.lblGenelToplam.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblGenelToplam.Location = new System.Drawing.Point(143, 120);
            this.lblGenelToplam.Name = "lblGenelToplam";
            this.lblGenelToplam.Size = new System.Drawing.Size(33, 18);
            this.lblGenelToplam.TabIndex = 2;
            this.lblGenelToplam.Text = "_____\r\n";
            // 
            // lblSonSiparisTarihi
            // 
            this.lblSonSiparisTarihi.AutoSize = true;
            this.lblSonSiparisTarihi.BackColor = System.Drawing.Color.Transparent;
            this.lblSonSiparisTarihi.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSonSiparisTarihi.Location = new System.Drawing.Point(143, 154);
            this.lblSonSiparisTarihi.Name = "lblSonSiparisTarihi";
            this.lblSonSiparisTarihi.Size = new System.Drawing.Size(33, 18);
            this.lblSonSiparisTarihi.TabIndex = 2;
            this.lblSonSiparisTarihi.Text = "_____\r\n";
            // 
            // lvMusteriler
            // 
            this.lvMusteriler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvMusteriler.Font = new System.Drawing.Font("Open Sans", 6F, System.Drawing.FontStyle.Bold);
            this.lvMusteriler.FullRowSelect = true;
            this.lvMusteriler.GridLines = true;
            this.lvMusteriler.Location = new System.Drawing.Point(35, 289);
            this.lvMusteriler.Name = "lvMusteriler";
            this.lvMusteriler.Size = new System.Drawing.Size(197, 89);
            this.lvMusteriler.TabIndex = 1;
            this.lvMusteriler.UseCompatibleStateImageBehavior = false;
            this.lvMusteriler.View = System.Windows.Forms.View.Details;
            this.lvMusteriler.Visible = false;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Musteri ID";
            this.columnHeader5.Width = 64;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Musteri";
            this.columnHeader6.Width = 68;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Adisyon ID";
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnCikis.BackgroundImage = global::Restorant_Projesi.Properties.Resources.exit1;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCikis.Location = new System.Drawing.Point(919, 674);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(5);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(67, 60);
            this.btnCikis.TabIndex = 6;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnGeridon
            // 
            this.btnGeridon.BackColor = System.Drawing.Color.Transparent;
            this.btnGeridon.BackgroundImage = global::Restorant_Projesi.Properties.Resources.geridon2;
            this.btnGeridon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeridon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGeridon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeridon.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGeridon.Location = new System.Drawing.Point(814, 674);
            this.btnGeridon.Margin = new System.Windows.Forms.Padding(5);
            this.btnGeridon.Name = "btnGeridon";
            this.btnGeridon.Size = new System.Drawing.Size(67, 60);
            this.btnGeridon.TabIndex = 7;
            this.btnGeridon.UseVisualStyleBackColor = false;
            this.btnGeridon.Click += new System.EventHandler(this.btnGeridon_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lbltoplTutar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblToplamSiparis);
            this.groupBox1.Controls.Add(this.txtToplamTutar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblSonSiparisTarihi);
            this.groupBox1.Controls.Add(this.lblGenelToplam);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(24, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 218);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Özet ";
            // 
            // frmSiparisKontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Restorant_Projesi.Properties.Resources._01;
            this.ClientSize = new System.Drawing.Size(1000, 760);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGeridon);
            this.Controls.Add(this.lvMusteriler);
            this.Controls.Add(this.lvSatisDetaylari);
            this.Controls.Add(this.lvMusteriDetaylari);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSiparisKontrol";
            this.Text = "frmSiparisKontrol";
            this.Load += new System.EventHandler(this.frmSiparisKontrol_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvMusteriDetaylari;
        private System.Windows.Forms.ColumnHeader MusteriId;
        private System.Windows.Forms.ColumnHeader MusteriAd;
        private System.Windows.Forms.ColumnHeader MusteriSyad;
        private System.Windows.Forms.ColumnHeader Tarih;
        private System.Windows.Forms.ColumnHeader AdisyonID;
        private System.Windows.Forms.ListView lvSatisDetaylari;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lbltoplTutar;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblToplamSiparis;
        private System.Windows.Forms.Label lblGenelToplam;
        private System.Windows.Forms.Label lblSonSiparisTarihi;
        private System.Windows.Forms.ListView lvMusteriler;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGeridon;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
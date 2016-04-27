namespace Restorant_Projesi
{
    partial class frmRaporlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRaporlar));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtBitis = new System.Windows.Forms.DateTimePicker();
            this.grpMenuBaslik = new System.Windows.Forms.GroupBox();
            this.grpIstatistik = new System.Windows.Forms.GroupBox();
            this.btnAnaYemek = new System.Windows.Forms.Button();
            this.btnIcecekler = new System.Windows.Forms.Button();
            this.btnSalatalar = new System.Windows.Forms.Button();
            this.btnFastfood = new System.Windows.Forms.Button();
            this.btnMakarnalar = new System.Windows.Forms.Button();
            this.btnTatlilar = new System.Windows.Forms.Button();
            this.btnCorbalar = new System.Windows.Forms.Button();
            this.btnAraSicaklar = new System.Windows.Forms.Button();
            this.chRapor = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lvIstatistik = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnTumurunler = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnGeridon = new System.Windows.Forms.Button();
            this.grpMenuBaslik.SuspendLayout();
            this.grpIstatistik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(245, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlangıç Tarhi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(276, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bitiş Tarhi :";
            // 
            // dtBaslangic
            // 
            this.dtBaslangic.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dtBaslangic.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.dtBaslangic.CalendarTitleForeColor = System.Drawing.Color.Transparent;
            this.dtBaslangic.CalendarTrailingForeColor = System.Drawing.Color.Transparent;
            this.dtBaslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBaslangic.Location = new System.Drawing.Point(363, 37);
            this.dtBaslangic.Name = "dtBaslangic";
            this.dtBaslangic.Size = new System.Drawing.Size(200, 20);
            this.dtBaslangic.TabIndex = 1;
            // 
            // dtBitis
            // 
            this.dtBitis.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dtBitis.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.dtBitis.CalendarTitleForeColor = System.Drawing.Color.Transparent;
            this.dtBitis.CalendarTrailingForeColor = System.Drawing.Color.Transparent;
            this.dtBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBitis.Location = new System.Drawing.Point(363, 74);
            this.dtBitis.Name = "dtBitis";
            this.dtBitis.Size = new System.Drawing.Size(200, 20);
            this.dtBitis.TabIndex = 2;
            // 
            // grpMenuBaslik
            // 
            this.grpMenuBaslik.BackColor = System.Drawing.Color.Transparent;
            this.grpMenuBaslik.Controls.Add(this.btnAraSicaklar);
            this.grpMenuBaslik.Controls.Add(this.btnTatlilar);
            this.grpMenuBaslik.Controls.Add(this.btnCorbalar);
            this.grpMenuBaslik.Controls.Add(this.btnAnaYemek);
            this.grpMenuBaslik.Controls.Add(this.btnIcecekler);
            this.grpMenuBaslik.Controls.Add(this.btnMakarnalar);
            this.grpMenuBaslik.Controls.Add(this.btnSalatalar);
            this.grpMenuBaslik.Controls.Add(this.btnFastfood);
            this.grpMenuBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpMenuBaslik.Location = new System.Drawing.Point(12, 94);
            this.grpMenuBaslik.Name = "grpMenuBaslik";
            this.grpMenuBaslik.Size = new System.Drawing.Size(307, 529);
            this.grpMenuBaslik.TabIndex = 3;
            this.grpMenuBaslik.TabStop = false;
            this.grpMenuBaslik.Text = "MENU";
            // 
            // grpIstatistik
            // 
            this.grpIstatistik.BackColor = System.Drawing.Color.Transparent;
            this.grpIstatistik.Controls.Add(this.chRapor);
            this.grpIstatistik.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpIstatistik.Location = new System.Drawing.Point(513, 232);
            this.grpIstatistik.Name = "grpIstatistik";
            this.grpIstatistik.Size = new System.Drawing.Size(551, 391);
            this.grpIstatistik.TabIndex = 3;
            this.grpIstatistik.TabStop = false;
            this.grpIstatistik.Text = "İSTATİSTİK";
            // 
            // btnAnaYemek
            // 
            this.btnAnaYemek.BackColor = System.Drawing.Color.Transparent;
            this.btnAnaYemek.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnaYemek.BackgroundImage")));
            this.btnAnaYemek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnaYemek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnaYemek.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnaYemek.Location = new System.Drawing.Point(19, 18);
            this.btnAnaYemek.Name = "btnAnaYemek";
            this.btnAnaYemek.Size = new System.Drawing.Size(123, 121);
            this.btnAnaYemek.TabIndex = 0;
            this.btnAnaYemek.UseVisualStyleBackColor = false;
            this.btnAnaYemek.Click += new System.EventHandler(this.btnAnaYemek_Click);
            // 
            // btnIcecekler
            // 
            this.btnIcecekler.BackColor = System.Drawing.Color.Transparent;
            this.btnIcecekler.BackgroundImage = global::Restorant_Projesi.Properties.Resources.icecekler;
            this.btnIcecekler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIcecekler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIcecekler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIcecekler.Location = new System.Drawing.Point(148, 18);
            this.btnIcecekler.Name = "btnIcecekler";
            this.btnIcecekler.Size = new System.Drawing.Size(123, 121);
            this.btnIcecekler.TabIndex = 0;
            this.btnIcecekler.UseVisualStyleBackColor = false;
            this.btnIcecekler.Click += new System.EventHandler(this.btnIcecekler_Click);
            // 
            // btnSalatalar
            // 
            this.btnSalatalar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalatalar.BackgroundImage = global::Restorant_Projesi.Properties.Resources.salata;
            this.btnSalatalar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalatalar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalatalar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalatalar.Location = new System.Drawing.Point(148, 145);
            this.btnSalatalar.Name = "btnSalatalar";
            this.btnSalatalar.Size = new System.Drawing.Size(123, 121);
            this.btnSalatalar.TabIndex = 0;
            this.btnSalatalar.UseVisualStyleBackColor = false;
            this.btnSalatalar.Click += new System.EventHandler(this.btnSalatalar_Click);
            // 
            // btnFastfood
            // 
            this.btnFastfood.BackColor = System.Drawing.Color.Transparent;
            this.btnFastfood.BackgroundImage = global::Restorant_Projesi.Properties.Resources.fastfood;
            this.btnFastfood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFastfood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFastfood.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFastfood.Location = new System.Drawing.Point(19, 272);
            this.btnFastfood.Name = "btnFastfood";
            this.btnFastfood.Size = new System.Drawing.Size(123, 121);
            this.btnFastfood.TabIndex = 0;
            this.btnFastfood.UseVisualStyleBackColor = false;
            this.btnFastfood.Click += new System.EventHandler(this.btnFastfood_Click);
            // 
            // btnMakarnalar
            // 
            this.btnMakarnalar.BackColor = System.Drawing.Color.Transparent;
            this.btnMakarnalar.BackgroundImage = global::Restorant_Projesi.Properties.Resources.makarna;
            this.btnMakarnalar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMakarnalar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMakarnalar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMakarnalar.Location = new System.Drawing.Point(19, 399);
            this.btnMakarnalar.Name = "btnMakarnalar";
            this.btnMakarnalar.Size = new System.Drawing.Size(123, 121);
            this.btnMakarnalar.TabIndex = 0;
            this.btnMakarnalar.UseVisualStyleBackColor = false;
            this.btnMakarnalar.Click += new System.EventHandler(this.btnMakarnalar_Click);
            // 
            // btnTatlilar
            // 
            this.btnTatlilar.BackColor = System.Drawing.Color.Transparent;
            this.btnTatlilar.BackgroundImage = global::Restorant_Projesi.Properties.Resources.tatlilar;
            this.btnTatlilar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTatlilar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTatlilar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTatlilar.Location = new System.Drawing.Point(19, 145);
            this.btnTatlilar.Name = "btnTatlilar";
            this.btnTatlilar.Size = new System.Drawing.Size(123, 121);
            this.btnTatlilar.TabIndex = 0;
            this.btnTatlilar.UseVisualStyleBackColor = false;
            this.btnTatlilar.Click += new System.EventHandler(this.btnTatlilar_Click);
            // 
            // btnCorbalar
            // 
            this.btnCorbalar.BackColor = System.Drawing.Color.Transparent;
            this.btnCorbalar.BackgroundImage = global::Restorant_Projesi.Properties.Resources.corba;
            this.btnCorbalar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCorbalar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCorbalar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCorbalar.Location = new System.Drawing.Point(148, 272);
            this.btnCorbalar.Name = "btnCorbalar";
            this.btnCorbalar.Size = new System.Drawing.Size(123, 121);
            this.btnCorbalar.TabIndex = 0;
            this.btnCorbalar.UseVisualStyleBackColor = false;
            this.btnCorbalar.Click += new System.EventHandler(this.btnCorbalar_Click);
            // 
            // btnAraSicaklar
            // 
            this.btnAraSicaklar.BackColor = System.Drawing.Color.Transparent;
            this.btnAraSicaklar.BackgroundImage = global::Restorant_Projesi.Properties.Resources.arasicak;
            this.btnAraSicaklar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAraSicaklar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAraSicaklar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAraSicaklar.Location = new System.Drawing.Point(148, 399);
            this.btnAraSicaklar.Name = "btnAraSicaklar";
            this.btnAraSicaklar.Size = new System.Drawing.Size(123, 121);
            this.btnAraSicaklar.TabIndex = 0;
            this.btnAraSicaklar.UseVisualStyleBackColor = false;
            this.btnAraSicaklar.Click += new System.EventHandler(this.btnAraSicaklar_Click);
            // 
            // chRapor
            // 
            this.chRapor.BackColor = System.Drawing.Color.Transparent;
            this.chRapor.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea9.Name = "ChartArea1";
            this.chRapor.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chRapor.Legends.Add(legend9);
            this.chRapor.Location = new System.Drawing.Point(19, 36);
            this.chRapor.Name = "chRapor";
            this.chRapor.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series9.ChartArea = "ChartArea1";
            series9.Label = "Satislar";
            series9.Legend = "Legend1";
            series9.Name = "Satislar";
            this.chRapor.Series.Add(series9);
            this.chRapor.Size = new System.Drawing.Size(526, 332);
            this.chRapor.TabIndex = 0;
            this.chRapor.Text = "chart1";
            // 
            // lvIstatistik
            // 
            this.lvIstatistik.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvIstatistik.GridLines = true;
            this.lvIstatistik.Location = new System.Drawing.Point(657, 12);
            this.lvIstatistik.Name = "lvIstatistik";
            this.lvIstatistik.Size = new System.Drawing.Size(297, 201);
            this.lvIstatistik.TabIndex = 4;
            this.lvIstatistik.UseCompatibleStateImageBehavior = false;
            this.lvIstatistik.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Urun Adı";
            this.columnHeader1.Width = 201;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Urun Adedi";
            this.columnHeader2.Width = 106;
            // 
            // btnTumurunler
            // 
            this.btnTumurunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTumurunler.Location = new System.Drawing.Point(342, 528);
            this.btnTumurunler.Name = "btnTumurunler";
            this.btnTumurunler.Size = new System.Drawing.Size(108, 86);
            this.btnTumurunler.TabIndex = 5;
            this.btnTumurunler.Text = "Tum Ürünler";
            this.btnTumurunler.UseVisualStyleBackColor = true;
            this.btnTumurunler.Click += new System.EventHandler(this.btnTumurunler_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnCikis.BackgroundImage = global::Restorant_Projesi.Properties.Resources.cikis1;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCikis.Location = new System.Drawing.Point(225, 641);
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
            this.btnGeridon.BackgroundImage = global::Restorant_Projesi.Properties.Resources.geridon;
            this.btnGeridon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeridon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGeridon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeridon.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGeridon.Location = new System.Drawing.Point(120, 641);
            this.btnGeridon.Margin = new System.Windows.Forms.Padding(5);
            this.btnGeridon.Name = "btnGeridon";
            this.btnGeridon.Size = new System.Drawing.Size(67, 60);
            this.btnGeridon.TabIndex = 7;
            this.btnGeridon.UseVisualStyleBackColor = false;
            this.btnGeridon.Click += new System.EventHandler(this.btnGeridon_Click);
            // 
            // frmRaporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Restorant_Projesi.Properties.Resources._01;
            this.ClientSize = new System.Drawing.Size(1015, 715);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGeridon);
            this.Controls.Add(this.btnTumurunler);
            this.Controls.Add(this.lvIstatistik);
            this.Controls.Add(this.grpIstatistik);
            this.Controls.Add(this.grpMenuBaslik);
            this.Controls.Add(this.dtBitis);
            this.Controls.Add(this.dtBaslangic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRaporlar";
            this.Text = "frmRaporlar";
            this.grpMenuBaslik.ResumeLayout(false);
            this.grpIstatistik.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chRapor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtBaslangic;
        private System.Windows.Forms.DateTimePicker dtBitis;
        private System.Windows.Forms.GroupBox grpMenuBaslik;
        private System.Windows.Forms.GroupBox grpIstatistik;
        private System.Windows.Forms.Button btnAraSicaklar;
        private System.Windows.Forms.Button btnTatlilar;
        private System.Windows.Forms.Button btnCorbalar;
        private System.Windows.Forms.Button btnAnaYemek;
        private System.Windows.Forms.Button btnIcecekler;
        private System.Windows.Forms.Button btnMakarnalar;
        private System.Windows.Forms.Button btnSalatalar;
        private System.Windows.Forms.Button btnFastfood;
        private System.Windows.Forms.DataVisualization.Charting.Chart chRapor;
        private System.Windows.Forms.ListView lvIstatistik;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnTumurunler;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGeridon;
    }
}
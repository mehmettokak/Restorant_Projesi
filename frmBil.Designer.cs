namespace Restorant_Projesi
{
    partial class frmBil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBil));
            this.gbIndirim = new System.Windows.Forms.GroupBox();
            this.chkIndirim = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblKdv = new System.Windows.Forms.Label();
            this.lblOdenecek = new System.Windows.Forms.Label();
            this.lblIndirim = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbTicket = new System.Windows.Forms.RadioButton();
            this.rbKrediKarti = new System.Windows.Forms.RadioButton();
            this.rbNakit = new System.Windows.Forms.RadioButton();
            this.lvUrunler = new System.Windows.Forms.ListView();
            this.coloumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnHesapOzeti = new System.Windows.Forms.Button();
            this.btnHesapKapat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAdisyonId = new System.Windows.Forms.Label();
            this.gbOzelAktivite = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIndirimTutari = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.gbIndirim.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbOzelAktivite.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbIndirim
            // 
            this.gbIndirim.BackColor = System.Drawing.Color.Transparent;
            this.gbIndirim.Controls.Add(this.chkIndirim);
            this.gbIndirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbIndirim.ForeColor = System.Drawing.Color.Black;
            this.gbIndirim.Location = new System.Drawing.Point(709, 223);
            this.gbIndirim.Name = "gbIndirim";
            this.gbIndirim.Size = new System.Drawing.Size(180, 72);
            this.gbIndirim.TabIndex = 0;
            this.gbIndirim.TabStop = false;
            this.gbIndirim.Text = "Özel İndirim";
            // 
            // chkIndirim
            // 
            this.chkIndirim.AutoSize = true;
            this.chkIndirim.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.chkIndirim.Location = new System.Drawing.Point(23, 35);
            this.chkIndirim.Name = "chkIndirim";
            this.chkIndirim.Size = new System.Drawing.Size(106, 22);
            this.chkIndirim.TabIndex = 0;
            this.chkIndirim.Text = "Özel İndirim";
            this.chkIndirim.UseVisualStyleBackColor = true;
            this.chkIndirim.CheckedChanged += new System.EventHandler(this.chkIndirim_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.lblToplamTutar);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.lblKdv);
            this.groupBox3.Controls.Add(this.lblOdenecek);
            this.groupBox3.Controls.Add(this.lblIndirim);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(526, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(365, 170);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ödeme Bilgileri";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(172, 83);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(15, 18);
            this.lblToplamTutar.TabIndex = 0;
            this.lblToplamTutar.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(248, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "TL";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(248, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "TL";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(248, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "TL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(248, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "TL";
            // 
            // lblKdv
            // 
            this.lblKdv.AutoSize = true;
            this.lblKdv.Location = new System.Drawing.Point(172, 60);
            this.lblKdv.Name = "lblKdv";
            this.lblKdv.Size = new System.Drawing.Size(15, 18);
            this.lblKdv.TabIndex = 0;
            this.lblKdv.Text = "0";
            // 
            // lblOdenecek
            // 
            this.lblOdenecek.AutoSize = true;
            this.lblOdenecek.Location = new System.Drawing.Point(172, 106);
            this.lblOdenecek.Name = "lblOdenecek";
            this.lblOdenecek.Size = new System.Drawing.Size(15, 18);
            this.lblOdenecek.TabIndex = 0;
            this.lblOdenecek.Text = "0";
            // 
            // lblIndirim
            // 
            this.lblIndirim.AutoSize = true;
            this.lblIndirim.Location = new System.Drawing.Point(172, 37);
            this.lblIndirim.Name = "lblIndirim";
            this.lblIndirim.Size = new System.Drawing.Size(15, 18);
            this.lblIndirim.TabIndex = 0;
            this.lblIndirim.Text = "0";
            this.lblIndirim.TextChanged += new System.EventHandler(this.lblIndirim_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "AraToplam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fiyat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "KDV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "İndirim";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox4.Controls.Add(this.rbTicket);
            this.groupBox4.Controls.Add(this.rbKrediKarti);
            this.groupBox4.Controls.Add(this.rbNakit);
            this.groupBox4.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(526, 223);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(177, 170);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ödeme Türü";
            // 
            // rbTicket
            // 
            this.rbTicket.AutoSize = true;
            this.rbTicket.Location = new System.Drawing.Point(30, 120);
            this.rbTicket.Name = "rbTicket";
            this.rbTicket.Size = new System.Drawing.Size(70, 22);
            this.rbTicket.TabIndex = 2;
            this.rbTicket.TabStop = true;
            this.rbTicket.Text = "TİCKET";
            this.rbTicket.UseVisualStyleBackColor = true;
            // 
            // rbKrediKarti
            // 
            this.rbKrediKarti.AutoSize = true;
            this.rbKrediKarti.Location = new System.Drawing.Point(30, 75);
            this.rbKrediKarti.Name = "rbKrediKarti";
            this.rbKrediKarti.Size = new System.Drawing.Size(107, 22);
            this.rbKrediKarti.TabIndex = 1;
            this.rbKrediKarti.TabStop = true;
            this.rbKrediKarti.Text = "KREDİ KARTI";
            this.rbKrediKarti.UseVisualStyleBackColor = true;
            // 
            // rbNakit
            // 
            this.rbNakit.AutoSize = true;
            this.rbNakit.Location = new System.Drawing.Point(30, 35);
            this.rbNakit.Name = "rbNakit";
            this.rbNakit.Size = new System.Drawing.Size(67, 22);
            this.rbNakit.TabIndex = 0;
            this.rbNakit.TabStop = true;
            this.rbNakit.Text = "NAKİT";
            this.rbNakit.UseVisualStyleBackColor = true;
            // 
            // lvUrunler
            // 
            this.lvUrunler.BackgroundImage = global::Restorant_Projesi.Properties.Resources.lw;
            this.lvUrunler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvUrunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coloumnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvUrunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvUrunler.FullRowSelect = true;
            this.lvUrunler.GridLines = true;
            this.lvUrunler.Location = new System.Drawing.Point(24, 43);
            this.lvUrunler.Name = "lvUrunler";
            this.lvUrunler.Size = new System.Drawing.Size(496, 350);
            this.lvUrunler.TabIndex = 0;
            this.lvUrunler.UseCompatibleStateImageBehavior = false;
            this.lvUrunler.View = System.Windows.Forms.View.Details;
            // 
            // coloumnHeader1
            // 
            this.coloumnHeader1.Text = "Urun Adı";
            this.coloumnHeader1.Width = 158;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adet";
            this.columnHeader2.Width = 62;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Urun Id";
            this.columnHeader3.Width = 76;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fiyat";
            this.columnHeader4.Width = 128;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Satıs Id";
            this.columnHeader5.Width = 166;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Restorant_Projesi.Properties.Resources.geridon2;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(683, 641);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 58);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::Restorant_Projesi.Properties.Resources.exit1;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(794, 641);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 58);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnHesapOzeti
            // 
            this.btnHesapOzeti.BackColor = System.Drawing.Color.Transparent;
            this.btnHesapOzeti.BackgroundImage = global::Restorant_Projesi.Properties.Resources.hozeti;
            this.btnHesapOzeti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHesapOzeti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHesapOzeti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHesapOzeti.Location = new System.Drawing.Point(556, 445);
            this.btnHesapOzeti.Name = "btnHesapOzeti";
            this.btnHesapOzeti.Size = new System.Drawing.Size(110, 87);
            this.btnHesapOzeti.TabIndex = 1;
            this.btnHesapOzeti.UseVisualStyleBackColor = false;
            this.btnHesapOzeti.Click += new System.EventHandler(this.btnHesapOzeti_Click);
            // 
            // btnHesapKapat
            // 
            this.btnHesapKapat.BackColor = System.Drawing.Color.Transparent;
            this.btnHesapKapat.BackgroundImage = global::Restorant_Projesi.Properties.Resources.hkapat;
            this.btnHesapKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHesapKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHesapKapat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHesapKapat.Location = new System.Drawing.Point(732, 445);
            this.btnHesapKapat.Name = "btnHesapKapat";
            this.btnHesapKapat.Size = new System.Drawing.Size(110, 87);
            this.btnHesapKapat.TabIndex = 1;
            this.btnHesapKapat.UseVisualStyleBackColor = false;
            this.btnHesapKapat.Click += new System.EventHandler(this.btnHesapKapat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(39, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Siparisler";
            // 
            // lblAdisyonId
            // 
            this.lblAdisyonId.AutoSize = true;
            this.lblAdisyonId.BackColor = System.Drawing.Color.Transparent;
            this.lblAdisyonId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdisyonId.ForeColor = System.Drawing.Color.DarkRed;
            this.lblAdisyonId.Location = new System.Drawing.Point(137, 7);
            this.lblAdisyonId.Name = "lblAdisyonId";
            this.lblAdisyonId.Size = new System.Drawing.Size(27, 24);
            this.lblAdisyonId.TabIndex = 0;
            this.lblAdisyonId.Text = "Id";
            // 
            // gbOzelAktivite
            // 
            this.gbOzelAktivite.BackColor = System.Drawing.Color.Transparent;
            this.gbOzelAktivite.Controls.Add(this.label7);
            this.gbOzelAktivite.Controls.Add(this.label6);
            this.gbOzelAktivite.Controls.Add(this.txtIndirimTutari);
            this.gbOzelAktivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbOzelAktivite.ForeColor = System.Drawing.Color.Black;
            this.gbOzelAktivite.Location = new System.Drawing.Point(709, 301);
            this.gbOzelAktivite.Name = "gbOzelAktivite";
            this.gbOzelAktivite.Size = new System.Drawing.Size(180, 92);
            this.gbOzelAktivite.TabIndex = 0;
            this.gbOzelAktivite.TabStop = false;
            this.gbOzelAktivite.Text = "Özel Aktivite";
            this.gbOzelAktivite.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(4, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "İndirim Tutarı Giriniz";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 1;
            // 
            // txtIndirimTutari
            // 
            this.txtIndirimTutari.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtIndirimTutari.Location = new System.Drawing.Point(8, 25);
            this.txtIndirimTutari.Name = "txtIndirimTutari";
            this.txtIndirimTutari.Size = new System.Drawing.Size(134, 25);
            this.txtIndirimTutari.TabIndex = 0;
            this.txtIndirimTutari.TextChanged += new System.EventHandler(this.txtIndirimTutari_TextChanged);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // frmBil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Restorant_Projesi.Properties.Resources._01;
            this.ClientSize = new System.Drawing.Size(900, 720);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnHesapKapat);
            this.Controls.Add(this.btnHesapOzeti);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvUrunler);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbOzelAktivite);
            this.Controls.Add(this.gbIndirim);
            this.Controls.Add(this.lblAdisyonId);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBil";
            this.Load += new System.EventHandler(this.frmBil_Load);
            this.gbIndirim.ResumeLayout(false);
            this.gbIndirim.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gbOzelAktivite.ResumeLayout(false);
            this.gbOzelAktivite.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbIndirim;
        private System.Windows.Forms.CheckBox chkIndirim;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblKdv;
        private System.Windows.Forms.Label lblOdenecek;
        private System.Windows.Forms.Label lblIndirim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbTicket;
        private System.Windows.Forms.RadioButton rbKrediKarti;
        private System.Windows.Forms.RadioButton rbNakit;
        private System.Windows.Forms.ListView lvUrunler;
        private System.Windows.Forms.ColumnHeader coloumnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnHesapOzeti;
        private System.Windows.Forms.Button btnHesapKapat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAdisyonId;
        private System.Windows.Forms.GroupBox gbOzelAktivite;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIndirimTutari;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
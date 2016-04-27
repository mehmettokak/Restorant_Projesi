namespace Restorant_Projesi
{
    partial class frmKasaIslemleri
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new Restorant_Projesi.DataSet1();
            this.DataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rpvAylik = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rpvGunluk = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTable1TableAdapter = new Restorant_Projesi.DataSet1TableAdapters.DataTable1TableAdapter();
            this.DataTable2TableAdapter = new Restorant_Projesi.DataSet1TableAdapters.DataTable2TableAdapter();
            this.btnAylik = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable2BindingSource
            // 
            this.DataTable2BindingSource.DataMember = "DataTable2";
            this.DataTable2BindingSource.DataSource = this.DataSet1;
            // 
            // rpvAylik
            // 
            this.rpvAylik.BackgroundImage = global::Restorant_Projesi.Properties.Resources.lw;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.DataTable1BindingSource;
            this.rpvAylik.LocalReport.DataSources.Add(reportDataSource3);
            this.rpvAylik.LocalReport.ReportEmbeddedResource = "Restorant_Projesi.Report1.rdlc";
            this.rpvAylik.Location = new System.Drawing.Point(151, 48);
            this.rpvAylik.Name = "rpvAylik";
            this.rpvAylik.Size = new System.Drawing.Size(721, 413);
            this.rpvAylik.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::Restorant_Projesi.Properties.Resources.exit1;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(791, 616);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 53);
            this.button2.TabIndex = 8;
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
            this.button1.Location = new System.Drawing.Point(682, 616);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 53);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(510, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "AYLIK RAPOR";
            // 
            // rpvGunluk
            // 
            this.rpvGunluk.BackgroundImage = global::Restorant_Projesi.Properties.Resources.lw;
            this.rpvGunluk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.DataTable2BindingSource;
            this.rpvGunluk.LocalReport.DataSources.Add(reportDataSource4);
            this.rpvGunluk.LocalReport.ReportEmbeddedResource = "Restorant_Projesi.Report2.rdlc";
            this.rpvGunluk.Location = new System.Drawing.Point(138, 48);
            this.rpvGunluk.Name = "rpvGunluk";
            this.rpvGunluk.Size = new System.Drawing.Size(734, 413);
            this.rpvGunluk.TabIndex = 11;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // DataTable2TableAdapter
            // 
            this.DataTable2TableAdapter.ClearBeforeFill = true;
            // 
            // btnAylik
            // 
            this.btnAylik.BackColor = System.Drawing.Color.Transparent;
            this.btnAylik.BackgroundImage = global::Restorant_Projesi.Properties.Resources.hozeti;
            this.btnAylik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAylik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAylik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAylik.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAylik.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAylik.Location = new System.Drawing.Point(12, 48);
            this.btnAylik.Name = "btnAylik";
            this.btnAylik.Size = new System.Drawing.Size(109, 116);
            this.btnAylik.TabIndex = 12;
            this.btnAylik.Text = "Aylık Rapor";
            this.btnAylik.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAylik.UseVisualStyleBackColor = false;
            this.btnAylik.Click += new System.EventHandler(this.button3_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::Restorant_Projesi.Properties.Resources.hozeti;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(12, 338);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 123);
            this.button3.TabIndex = 13;
            this.button3.Text = "Gunluk Rapor";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // frmKasaIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Restorant_Projesi.Properties.Resources._01;
            this.ClientSize = new System.Drawing.Size(900, 720);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnAylik);
            this.Controls.Add(this.rpvGunluk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rpvAylik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKasaIslemleri";
            this.Text = "frmKasaIslemleri";
            this.Load += new System.EventHandler(this.frmKasaIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvAylik;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer rpvGunluk;
        private System.Windows.Forms.BindingSource DataTable2BindingSource;
        private DataSet1TableAdapters.DataTable2TableAdapter DataTable2TableAdapter;
        private System.Windows.Forms.Button btnAylik;
        private System.Windows.Forms.Button button3;
    }
}
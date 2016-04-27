using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restorant_Projesi
{
    public partial class frmKasaIslemleri : Form
    {
        public frmKasaIslemleri()
        {
            InitializeComponent();
        }

        private void frmKasaIslemleri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.DataTable2' table. You can move, or remove it, as needed.//otmtk olustu
            this.DataTable2TableAdapter.Fill(this.DataSet1.DataTable2);//otmtk olustu
            // TODO: This line of code loads data into the 'DataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.DataSet1.DataTable1);//otmtk olustu

            this.rpvAylik.RefreshReport();//otmtk olustu
            this.rpvGunluk.RefreshReport();//otmtk olustu
            rpvGunluk.Visible = false;
            label1.Text = "AYLIK RAOPOR";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            this.Close();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Çıkmak istediğinize eminmisiniz?", "Uyarı!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "AYLIK RAOPOR";
            rpvAylik.Visible = true;
            rpvGunluk.Visible = false;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            label1.Text = "GUNLUK RAOPOR";
            rpvAylik.Visible = false;
            rpvGunluk.Visible = true;

        }
    }
}

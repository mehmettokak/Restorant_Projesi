using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restorant_Projesi
{
    public partial class frmMasaSiparis : Form
    {
        public frmMasaSiparis()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinize eminmisiniz?", "Uyarı!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnGeridon_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            this.Close();
            frm.Show();
        }

        private void btnMasa1_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa1.Text.Length;
            cGenel._ButtonValue = btnMasa1.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = btnMasa1.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa2_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa2.Text.Length;
            cGenel._ButtonValue = btnMasa2.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = btnMasa2.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa3_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa3.Text.Length;
            cGenel._ButtonValue = btnMasa3.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = btnMasa3.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa4_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa4.Text.Length;
            cGenel._ButtonValue = btnMasa4.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = btnMasa4.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa5_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa5.Text.Length;
            cGenel._ButtonValue = btnMasa5.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = btnMasa5.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa6_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa6.Text.Length;
            cGenel._ButtonValue = btnMasa6.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = btnMasa6.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa7_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa7.Text.Length;
            cGenel._ButtonValue = btnMasa7.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = btnMasa7.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa8_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa8.Text.Length;
            cGenel._ButtonValue = btnMasa8.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = btnMasa8.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa9_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa9.Text.Length;
            cGenel._ButtonValue = btnMasa9.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = btnMasa9.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa10_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa10.Text.Length;
            cGenel._ButtonValue = btnMasa10.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = btnMasa10.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void frmMasaSiparis_Load(object sender, EventArgs e)
        {
            try
            {
                FormLoad();
            }
            catch (Exception ex)
            {
                ex.ShowError();
            }
        }

        private void FormLoad()
        {
            SqlConnection con = new SqlConnection(cGenel.conStirng);
            SqlCommand cmd = new SqlCommand("Select MASA_DURUM,ID from MASALAR", con);
            SqlDataReader dr = null;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                foreach (Control item in this.Controls)
                {
                    if (item is Button)
                    {
                        if (item.Name == "btnMasa" + dr["ID"] && dr["MASA_DURUM"].ToString() == "1")
                        {                                                                    //cıkıs1 yerine bos masa resmin adı glck
                            item.BackgroundImage = (System.Drawing.Image)(Properties.Resources.bos);
                        }
                        else if (item.Name == "btnMasa" + dr["ID"] && dr["MASA_DURUM"].ToString() == "2")
                        {
                            cMasalar Mslr = new cMasalar();
                            DateTime dt1 = Mslr.SessionSum(2, dr["ID"].ToString()).ToDateTime();
                            DateTime dt2 = DateTime.Now;
                            string st1 = Mslr.SessionSum(2, dr["ID"].ToString()).ToDateTime().ToShortTimeString();
                            string st2 = DateTime.Now.ToShortTimeString();
                            DateTime t1 = dt1.AddMinutes(st1.ToDateTime().TimeOfDay.TotalMinutes);
                            DateTime t2 = dt2.AddMinutes(st2.ToDateTime().TimeOfDay.TotalMinutes);
                            var fark = t2 - t1;
                            item.Text = string.Format("{0}{1}{2}",
                                fark.Days > 0 ? string.Format("{0} Gün", fark.Days) : "",
                                fark.Hours > 0 ? string.Format("{0} Saat", fark.Hours) : "",
                                fark.Minutes > 0 ? string.Format("{0} Dakika", fark.Minutes) : ""
                                ).Trim() + "\n\n\nMasa" + dr["ID"].ToString();
                            //ayarlar yerine dolu resim masası adı geleck
                            item.BackgroundImage = (System.Drawing.Image)(Properties.Resources.masa);

                        }
                        else if (item.Name == "btnMasa" + dr["ID"] && dr["MASA_DURUM"].ToString() == "3")
                        {                                                       //giris yerine acık rezerve masa resmi adı gele
                            item.BackgroundImage = (System.Drawing.Image)(Properties.Resources.giris);
                        }
                        else if (item.Name == "btnMasa" + dr["ID"] && dr["MASA_DURUM"].ToString() == "4")
                        {                                                               //arkaplan yerine rezerve masa resmi adı geleck
                            item.BackgroundImage = (System.Drawing.Image)(Properties.Resources.arkaplan);
                        }
                    }
                }
            }
        }




    }
}

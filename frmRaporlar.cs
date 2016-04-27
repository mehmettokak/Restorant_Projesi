using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Restorant_Projesi
{
    public partial class frmRaporlar : Form
    {
        public frmRaporlar()
        {
            InitializeComponent();
        }

        private void btnGeridon_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            this.Close();
            frm.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Çıkmak İstediğinize Eminmisiniz? ?", "Uyarı!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnAnaYemek_Click(object sender, EventArgs e)
        {
            istatikler("Ana Yemekler Satış Grafiği", 3, Color.Red);

        }

        private void btnIcecekler_Click(object sender, EventArgs e)
        {
            istatikler("İçecekler Satış Grafiği", 8, Color.Yellow);

        }

        private void istatikler(string grfname, int katId, Color renk)
        {
            chRapor.Palette = ChartColorPalette.None;//rengini kaldırdık.//cahrtta palette ıle ulasablırz
            chRapor.Series[0].EmptyPointStyle.Color = Color.Transparent;
            chRapor.Series[0].EmptyPointStyle.Color = renk;
            cUrunler u = new cUrunler();
            lvIstatistik.Items.Clear();
            u.urunListeleIstatiklereGoreUrunKatId(lvIstatistik, dtBaslangic, dtBitis, katId);
            grpIstatistik.Text = grfname;
            if (lvIstatistik.Items.Count > 0)
            {
                chRapor.Series["Satislar"].Points.Clear(); //chartın ıcını temızlyoruz.satıslar kendı atadımız strıng dır..verı tabanyla alakalı degıl.
                for (int i = 0; i < lvIstatistik.Items.Count; i++)
                {
                    chRapor.Series["Satislar"].Points.AddXY(lvIstatistik.Items[i].SubItems[0].Text, lvIstatistik.Items[i].SubItems[1].Text);

                }
            }
            else
            {
                MessageBox.Show("Gösterilecek istatistik yok.Başka bir zaman dilimi seçiniz.");
            }
        }

        private void btnTatlilar_Click(object sender, EventArgs e)
        {
            istatikler("Tatlilar Satış Grafiği", 7, Color.Orange);

        }

        private void btnSalatalar_Click(object sender, EventArgs e)
        {
            istatikler("Salatalar Satış Grafiği", 6, Color.Green);

        }

        private void btnFastfood_Click(object sender, EventArgs e)
        {
            istatikler("FastFood Satış Grafiği", 5, Color.IndianRed);
        }

        private void btnCorbalar_Click(object sender, EventArgs e)
        {
            istatikler("Çorbalar  Satış Grafiği", 1, Color.Gold);
        }

        private void btnMakarnalar_Click(object sender, EventArgs e)
        {
            istatikler("Makarnalar Satış Grafiği", 4, Color.Khaki);
        }

        private void btnAraSicaklar_Click(object sender, EventArgs e)
        {
            istatikler("Ara Sıcaklar Satış Grafiği", 2, Color.LightBlue);
        }

        private void btnTumurunler_Click(object sender, EventArgs e)
        {
            chRapor.Palette = ChartColorPalette.None;//rengini kaldırdık.//cahrtta palette ıle ulasablırz
            chRapor.Series[0].EmptyPointStyle.Color = Color.Transparent;
            chRapor.Series[0].EmptyPointStyle.Color = Color.LightCyan;
            cUrunler u = new cUrunler();
            lvIstatistik.Items.Clear();
            u.urunListeleIstatiklereGore(lvIstatistik, dtBaslangic, dtBitis);
            grpIstatistik.Text = "Tüm Ürünler Satış Grafiği .";
            if (lvIstatistik.Items.Count > 0)
            {
                chRapor.Series["Satislar"].Points.Clear(); //chartın ıcını temızlyoruz.satıslar kendı atadımız strıng dır..verı tabanyla alakalı degıl.
                for (int i = 0; i < lvIstatistik.Items.Count; i++)
                {
                    chRapor.Series["Satislar"].Points.AddXY(lvIstatistik.Items[i].SubItems[0].Text, lvIstatistik.Items[i].SubItems[1].Text);

                }
            }
            else
            {
                MessageBox.Show("Gösterilecek istatistik yok.Başka bir zaman dilimi seçiniz.");
            }
        }
    }
}

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
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
            btnCikis.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            btnGiris.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }



        private void btnGiris_Click(object sender, EventArgs e)
        {
            cPersoneller p = new cPersoneller();
            bool result = p.personelEntryControl(textSifre.Text, cGenel._personelId);
            if (result)
            {  //--form menunun acılmasi-giris formun gizlenmesi
                this.Hide();
                frmMenu menu = new frmMenu();
                menu.Show();
                //---------------------------------cpersonelhareketleri
                cPersonelHareketleri ch = new cPersonelHareketleri();
                ch.PersonelId = cGenel._personelId;
                ch.Islem = "Giriş Yapıldı.";
                ch.Tarih = DateTime.Now;
                ch.PersonelActionSave(ch);
            }
            else
            {
                MessageBox.Show("Sifreniz Yanlış Girilmiştir.","Uyarı!!!",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinize eminmisiniz?", "Uyarı!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {
            cPersoneller p = new cPersoneller();
            p.personelGetbyInformation(cbKullanici);
        }

        private void cbKullanici_SelectedIndexChanged(object sender, EventArgs e)
        {
            cPersoneller p = (cPersoneller)cbKullanici.SelectedItem;
            cGenel._personelId = p.PersonelId;
            cGenel._gorevId = p.PersonelGorevId;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

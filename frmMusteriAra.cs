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
    public partial class frmMusteriAra : Form
    {
        public frmMusteriAra()
        {
            InitializeComponent();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            this.Close();
            frm.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinize eminmisiniz?", "Uyarı!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnYeniMusteri_Click(object sender, EventArgs e)
        {
            frmMusteriEkleme m = new frmMusteriEkleme();
            cGenel._musteriEkleme = 1;
            btnYeniMusteri.Visible = true;
            btnM_Guncelle.Visible = false;
            m.Show();
        }

        private void frmMusteriArama_Load(object sender, EventArgs e)
        {
            //müsterileri cagıracagız.
            cMusteriler c = new cMusteriler();
            c.musteriBilgileriGetir(lvMusteriler);

        }

        private void btnMustriSec_Click(object sender, EventArgs e)
        {
            //lvmusteri ye cift tıkalandıgında veya mesteri sec butonu tıklandı zaman bilgileri yayınlaması


        }

        private void btnM_Guncelle_Click(object sender, EventArgs e)
        {            //lvmusteri ye cift tıkalandıgında veya mesteri sec butonu tıklandı zaman bilgileri guncelenmesi
            if (lvMusteriler.SelectedItems.Count > 0)//lv secili ise
            {
                cGenel._musteriEkleme = 1;
                cGenel._musteriId = Convert.ToInt32(lvMusteriler.SelectedItems[0].SubItems[0].Text);//lv de gizli olan müsteri nodan alıyoruz.

                frmMusteriEkleme frm = new frmMusteriEkleme();
              
                this.Close();
                frm.Show();
            }
        }

        private void btnM_Geridon_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            this.Close();
            frm.Show();
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            cMusteriler c = new cMusteriler();
            c.musteriBilgileriAdGoreGetir(lvMusteriler, txtAd.Text);
        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {
            cMusteriler c = new cMusteriler();
            c.musteriBilgileriSoyAdGoreGetir(lvMusteriler, txtSoyad.Text);
        }

        private void txtTlf_TextChanged(object sender, EventArgs e)
        {
            cMusteriler c = new cMusteriler();
            c.musteriBilgileriTlfNoGoreGetir(lvMusteriler, txtTlf.Text);
        }

        private void btnM_AdisyonBul_Click(object sender, EventArgs e)
        {
            if (txtAdisyonID.Text != "")
            {
                cGenel._AdisyonId = txtAdisyonID.Text;
                cPaketler c = new cPaketler();
                bool sonuc = c.acıkAdisyonIdKontrol((Convert.ToInt32(txtAdisyonID.Text)));
                if (sonuc)//boyle bırsey varsa--burda sonuc donerse ıslemedeavm eder.
                {
                    frmBil frm = new frmBil();
                    cGenel._ServisturNo = 2;
                    frm.Show();
                }
                else
                {
                    new Exception(txtAdisyonID.Text + " No'lu Adisyon Bulunamadı.").ShowError("Adisyon Hatası!!!");
                }
            }
            else
            {
                new Exception("Aramak İstediğiniz  Adisyon Id Yazınız.").ShowError("Adisyon Hatası!!!");

            }
        }

        //isme gore arama yapıyorsak soyad ve telf gore aramayı engellıcez.click event la yapıyoruz.
        private void txtAd_Click(object sender, EventArgs e)
        {
            txtSoyad.Enabled = false;
            txtTlf.Enabled = false;
            txtAd.Enabled = true;
        }
        //soyada gore arama yapıyorsak ad ve telf gore aramayı engellıcez.click event la yapıyoruz.

        private void txtSoyad_Click(object sender, EventArgs e)
        {
            txtSoyad.Enabled = true;
            txtTlf.Enabled = false;
            txtAd.Enabled = false;
        }

        //Tlf gore arama yapıyorsak soyad ve ad gore aramayı engellıcez.click event la yapıyoruz.

        private void txtTlf_Click(object sender, EventArgs e)
        {
            txtSoyad.Enabled = false;
            txtTlf.Enabled = true;
            txtAd.Enabled = false;
        }

        private void btrnM_Siparis_Click(object sender, EventArgs e)
        {
            frmSiparisKontrol frm = new frmSiparisKontrol();
            this.Close();
            frm.Show();
        }




    }
}

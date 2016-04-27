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
    public partial class frmAyarlar : Form
    {
        public frmAyarlar()
        {
            InitializeComponent();
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            this.Close();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinize eminmisiniz?", "Uyarı!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmAyarlar_Load(object sender, EventArgs e)
        {
            cPersoneller cp = new cPersoneller();
            cPersonelGorevAyar cpg = new cPersonelGorevAyar();
            string gorev = cpg.PersonelGorevTanım(cGenel._gorevId);
            if (gorev == "Mudur")
            {
                cp.personelGetbyInformation(cbPersonel);
                cpg.PersonelGorevGetir(cbGorevi);
                cp.persbilglistViewdeGetir(lvPersoneller);
                btnYeni.Enabled = true;
                btnsil.Enabled = true;
                btnBilgiDegistir.Enabled = true;
                btnEkleKaydet.Enabled = false;
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = false;
                groupBox4.Visible = true;
                txtSifre.ReadOnly = true;
                txtSifreTkrar.ReadOnly = true;
                lblBilgi.Text = "Mevki : Müdür /Yetki Sınırsız / Kullanıcı :" + cp.personelBilgiGetirIsim(cGenel._personelId);
            }
            else
            {
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = true;
                groupBox4.Visible = false;
                lblBilgi.Text = "Mevki : Personel /Yetki Sınırlı / Kullanıcı :" + cp.personelBilgiGetirIsim(cGenel._personelId);

            }
        }

        private void btn1Degistir_Click(object sender, EventArgs e)
        {
            if (txtYeniSifre.Text.Trim() != "" && txtYenisifreTkrr.Text.Trim() != "")
            {
                if (txtYeniSifre.Text == txtYenisifreTkrr.Text)
                {
                    if (txtPersonelId1.Text != "")
                    {
                        cPersoneller c = new cPersoneller();
                        bool sonuc = c.personelSifreDegistir(Convert.ToInt32(txtPersonelId1.Text), txtYeniSifre.Text);
                        if (sonuc)
                        {
                            MessageBox.Show("Şifre Değiştirme İşlemi Başarıyla Gerçekleşmistir.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Personel Seçiniz.!!!");
                    }
                }
                else
                {
                    MessageBox.Show("Girmiş Oldugunuz Şifreler Aynı Degildir.");
                }
            }
            else
            {
                MessageBox.Show("Şifre Alanını Boş Bırakmayınız.!!!");
            }
        }

        private void cbGorevi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cPersonelGorevAyar c = (cPersonelGorevAyar)cbGorevi.SelectedItem;
            txtGorevId.Text = Convert.ToString(c.PersonelGorevId1);
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnYeni.Enabled = false;
            btnEkleKaydet.Enabled = true;
            btnBilgiDegistir.Enabled = false;
            btnsil.Enabled = false;
            txtSifreTkrar.ReadOnly = false;
            txtSifre.ReadOnly = false;
        }

        private void cbPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {
            cPersoneller c = (cPersoneller)cbPersonel.SelectedItem;//metot override ile calısacak.
            txtPersonelId1.Text = Convert.ToString(c.PersonelId);
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek  istediğinize eminmisiniz?", "Uyarı!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (lvPersoneller.SelectedItems.Count > 0)
                {
                    cPersoneller c = new cPersoneller();
                    bool sonuc = c.personelSil(Convert.ToInt32(lvPersoneller.SelectedItems[0].Text));
                    if (sonuc)
                    {
                        MessageBox.Show("Silme İşlemi Başarıyla Gerçeklesöiştir.");
                        c.persbilglistViewdeGetir(lvPersoneller);
                    }
                    else
                    {
                        MessageBox.Show("Silme İşlemi Sırasında Bir Hata Olustu.");
                    }
                }
                else
                {
                    MessageBox.Show("Önce Bir Kayıt Seçiniz.!!!");
                }
            }
        }

        private void btnEkleKaydet_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != "" && txtsoyad.Text != "" && txtSifre.Text != "" && txtSifreTkrar.Text != "" && txtGorevId.Text != "")
            {
                if ((txtSifreTkrar.Text.Trim() == txtSifre.Text.Trim()) && (txtSifre.Text.Length > 5 && txtSifreTkrar.Text.Length > 5))
                {
                    cPersoneller c = new cPersoneller();
                    c.PersonelAd = txtAd.Text.Trim();
                    c.PersonelSoyad = txtsoyad.Text.Trim();
                    c.PersonelParola = txtSifre.Text;
                    c.PersonelGorevId = Convert.ToInt32(txtGorevId.Text);
                    bool sonuc = c.personelEkle(c);
                    if (sonuc)
                    {
                        MessageBox.Show("Kayıt Başarıyla Eklenmiştir.");
                        c.persbilglistViewdeGetir(lvPersoneller);
                    }
                    else
                    {
                        MessageBox.Show("Kayıt Eklenirken Bir Hata Olustu.!!!");
                    }
                }
                else
                {
                    MessageBox.Show("Girdiniz Şifreler Aynı Değildir.!!!");
                }
            }
            else
            {
                MessageBox.Show("Boş Alanlarını doldurunuz.!!!");
            }
        }

        private void btnBilgiDegistir_Click(object sender, EventArgs e)
        {
            if (lvPersoneller.SelectedItems.Count > 0)
            {


                if (txtAd.Text != "" && txtsoyad.Text != "" && txtSifre.Text != "" && txtSifreTkrar.Text != "" && txtGorevId.Text != "")
                {
                    if ((txtSifreTkrar.Text.Trim() == txtSifre.Text.Trim()) && (txtSifre.Text.Length > 5 && txtSifreTkrar.Text.Length > 5))
                    {
                        cPersoneller c = new cPersoneller();
                        c.PersonelAd = txtAd.Text.Trim();
                        c.PersonelSoyad = txtsoyad.Text.Trim();
                        c.PersonelParola = txtSifre.Text;
                        c.PersonelGorevId = Convert.ToInt32(txtGorevId.Text);
                        bool sonuc = c.personelGuncelle(c, Convert.ToInt32(txtPersonelId1.Text));
                        if (sonuc)
                        {
                            MessageBox.Show("Kayıt Başarıyla Eklenmiştir.");
                            c.persbilglistViewdeGetir(lvPersoneller);
                        }
                        else
                        {
                            MessageBox.Show("Kayıt Eklenirken Bir Hata Olustu.!!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Girdiniz Şifreler Aynı Değildir.!!!");
                    }
                }
                else
                {
                    MessageBox.Show("Boş Alanlarını doldurunuz.!!!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Kayıt Seçiniz.!!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtYeniSifre1.Text.Trim() != "" && txtYeniSifre2.Text.Trim() != "")
            {
                if (txtYeniSifre1.Text == txtYeniSifre2.Text)
                {
                    if (cGenel._personelId.ToString() != "")
                    {
                        cPersoneller c = new cPersoneller();
                        bool sonuc = c.personelSifreDegistir(Convert.ToInt32(cGenel._personelId), txtYeniSifre1.Text);
                        if (sonuc)
                        {
                            MessageBox.Show("Şifre Değiştirme İşlemi Başarıyla Gerçekleşmistir.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Personel Seçiniz.!!!");
                    }
                }
                else
                {
                    MessageBox.Show("Girmiş Oldugunuz Şifreler Aynı Degildir.");
                }
            }
            else
            {
                MessageBox.Show("Şifre Alanını Boş Bırakmayınız.!!!");
            }
        }

        private void lvPersoneller_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPersoneller.SelectedItems.Count > 0)
            {
                btnYeni.Enabled = true;
                btnEkleKaydet.Enabled = true;
                btnBilgiDegistir.Enabled = true;
                btnsil.Enabled = true;
                txtSifreTkrar.ReadOnly = false;
                txtSifre.ReadOnly = false;

                txtPersonelId1.Text = lvPersoneller.SelectedItems[0].SubItems[0].Text;
                cbGorevi.SelectedIndex = Convert.ToInt32(lvPersoneller.SelectedItems[0].SubItems[1].Text)-1;
                txtAd.Text = lvPersoneller.SelectedItems[0].SubItems[3].Text;
                txtsoyad.Text = lvPersoneller.SelectedItems[0].SubItems[4].Text;
            }
           
        }

       



    }
}

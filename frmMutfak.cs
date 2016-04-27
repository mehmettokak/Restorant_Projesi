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
    public partial class frmMutfak : Form
    {
        public frmMutfak()
        {
            InitializeComponent();
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

        private void frmMutfak_Load(object sender, EventArgs e)
        {
            cUrunCesitleri anaKategori = new cUrunCesitleri();
            anaKategori.urunCesitleriGetir(cbKategoriler);
            cbKategoriler.Items.Insert(0, "Tüm Kategoriler");
            cbKategoriler.SelectedIndex = 0;
            lblIstenilenUrun.Visible = false;
            txtArama.Visible = false;
            cUrunler c = new cUrunler();
            c.urunleriListele(lvGıdaListesi);

        }
        private void temizle()
        {
            txtGidaAdi.Clear();
            txtGidaFiyati.Clear();
           txtGidaFiyati.Text = string.Format("{0:##0.00}", 0);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (rbAltKategori.Checked)
            {
                if (txtGidaAdi.Text.Trim() == "" || txtGidaFiyati.Text.Trim() == "" || cbKategoriler1.SelectedItem.ToString() == "Tüm Kategoriler")
                {
                    MessageBox.Show("Gıda Adı Fiyatı veya Kategori Seçilmemiştir.!!!", "Dikkat Eksik Bilgiler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cUrunler c = new cUrunler();
                    c.UrunFiyat = Convert.ToDecimal(txtGidaFiyati.Text);
                    c.UrunAd = txtGidaAdi.Text;
                    c.UrunTurNo = urunturNO;
                    c.UrunAcıklama = "Ürün Eklendi.";
                    int sonuc = c.urunEkle(c);
                    if (sonuc != 0) //işlem basarılı ıse
                    {
                        MessageBox.Show("Ürün Eklenmiştir.");
                        //cbKategoriler_SelectedIndexChanged(sender, e);
                        //cUrunCesitleri uc = new cUrunCesitleri();
                        //uc.urunCesitleriGetir(cbKategoriler);//kategorı ekledıgımız zaman lısteyı yenıler.
                        yenile();
                        temizle();
                    }

                }

            }
            else
            {
                if (txtKategoriAdi.Text.Trim() == "")
                {
                    MessageBox.Show("Lütfen bir kategori ismi giriniz.", "Dikkat.!!! Eksik Bilgi Girdiniz.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cUrunCesitleri gida = new cUrunCesitleri();
                    gida.KategoriAd = txtKategoriAdi.Text;
                    gida.Aciklama = txtAciklama1.Text;
                    int sonuc = gida.urunCesitleriEkle(gida);
                    if (sonuc != 0)
                    {
                        MessageBox.Show("Ürün Eklenmiştir.");
                        cUrunCesitleri uc = new cUrunCesitleri();
                        //uc.urunCesitleriGetir(cbKategoriler);//kategorı ekledıgımız zaman lısteyı yenıler.
                        ////cbkategoriyi getirecez
                        //gida.urunCesitleriGetir(lvKategoriler);//urun eklenınce lstemız yenılensın
                        yenile();
                        temizle();
                    }
                }
            }
        }

        int urunturNO = 0;
        private void cbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            cUrunler u = new cUrunler();
            if (cbKategoriler1.SelectedItem.ToString() == "Tüm Kategoriler")
            {
                u.urunleriListele(lvGıdaListesi);
                cUrunCesitleri cesit = (cUrunCesitleri)cbKategoriler1.SelectedItem;
                urunturNO = cesit.UrunTurNo;
                u.urunleriListeleByUrunId(lvGıdaListesi, urunturNO);

            }
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (rbAltKategori.Checked)
            {
                if (txtGidaAdi.Text.Trim() == "" || txtGidaFiyati.Text.Trim() == "" || cbKategoriler1.SelectedItem.ToString() == "Tüm Kategoriler")
                {
                    MessageBox.Show("Gıda Adı Fiyatı veya Kategori Seçilmemiştir.!!!", "Dikkat Eksik Bilgiler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cUrunler c = new cUrunler();
                    c.UrunFiyat = Convert.ToDecimal(txtGidaFiyati.Text);
                    c.UrunAd = txtGidaAdi.Text;
                    c.UrunId = Convert.ToInt32(txtUrunId.Text);
                    c.UrunTurNo = urunturNO;

                    c.UrunAcıklama = "Ürün Güncellendi.";
                    int sonuc = c.urunBilgiGuncelle(c);
                    if (sonuc != 0) //işlem basarılı ıse
                    {
                        MessageBox.Show("Ürün Güncellendi.");
                        //c.urunleriListele(lvGıdaListesi);
                        //cbkategoriyi getirecez
                        yenile();
                        //cbKategoriler_SelectedIndexChanged(sender, e);
                        temizle();
                    }

                }

            }
            else
            {
                if (txtKategoriId1.Text.Trim() == "")
                {
                    MessageBox.Show("Lütfen bir kategori seciniz.", "Dikkat.!!! Eksik Bilgi Girdiniz.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cUrunCesitleri gida = new cUrunCesitleri();
                    gida.KategoriAd = txtKategoriAdi1.Text;
                    gida.Aciklama = txtAciklama1.Text;
                    gida.UrunTurNo = Convert.ToInt32(txtKategoriId1.Text);
                    int sonuc = gida.urunCesitGuncelle(gida);
                    if (sonuc != 0)
                    {
                        MessageBox.Show("Kategori güncellenmiştir.");
                      
                        gida.urunCesitleriGetir(lvKategoriler);//urun eklenınce lstemız yenılensın

                        temizle();
                    }
                }
            }
        }

        private void lvGıdaListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvGıdaListesi.SelectedItems.Count > 0)
            {
                txtGidaAdi.Text = lvGıdaListesi.SelectedItems[0].SubItems[3].Text;
                txtGidaFiyati.Text = lvGıdaListesi.SelectedItems[0].SubItems[4].Text;
                txtUrunId.Text = lvGıdaListesi.SelectedItems[0].SubItems[0].Text;
                //cbKategoriler.SelectedIndex = Convert.ToInt32(lvGıdaListesi.SelectedItems[0].SubItems[0].Text);

            }
        }

        private void lvKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtKategoriAdi1.Text = lvKategoriler.SelectedItems[0].SubItems[1].Text;
            txtKategoriId1.Text = lvKategoriler.SelectedItems[0].SubItems[0].Text;
            txtAciklama1.Text = lvKategoriler.SelectedItems[0].SubItems[2].Text;
            //cbKategoriler.SelectedIndex = Convert.ToInt32(lvGıdaListesi.SelectedItems[0].SubItems[0].Text);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (rbAltKategori.Checked)//bunu kontrol etmesekte olur.
            {
                if (lvGıdaListesi.SelectedItems.Count > 0)
                {



                    if (MessageBox.Show("Silmek istediğinize eminmisiniz?", "Dikkat!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        cUrunler c = new cUrunler();

                        c.UrunId = Convert.ToInt32(txtUrunId.Text);

                        int sonuc = c.urunSil(c, 2); //kateri 0 degeriydi.0dan farklı olsunkı urun oldugu bellı olsun.2 1 3 4 0 dıdında herhangı bı rakam 
                        if (sonuc != 0) //işlem basarılı ıse
                        {
                            MessageBox.Show("Ürün Silinmistir.");
                            //c.urunleriListele(lvGıdaListesi);
                           
                            //cbkategoriyi getirecez
                            cbKategoriler_SelectedIndexChanged(sender, e);
                            yenile();
                            temizle();
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Silme işlemi yapabilmeniz icin urun seçiniz ?", "Dikkat ürün secmediniz.!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (lvKategoriler.SelectedItems.Count > 0)
                {


                    if (MessageBox.Show("Silmek istediğinize eminmisiniz?", "Dikkat!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        cUrunCesitleri uc = new cUrunCesitleri();

                        int sonuc = uc.urunCesitSil(Convert.ToInt32(txtKategoriId1.Text));
                        if (sonuc != 0) //işlem basarılı ıse
                        {
                            MessageBox.Show("Ürün Silinmistir.");
                            cUrunler u = new cUrunler();
                            u.UrunId = Convert.ToInt32(txtKategoriId);
                            u.urunSil(u,0);//kategori slidigimiz icin 0 gonderdik.ve metok kateogrı ıcındekı butun urunlerı sılecek

                            yenile();
                           
                            temizle();
                        }
                    }
                }

            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            lblIstenilenUrun.Visible = true;
            txtArama.Visible = true;

        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            if (rbAltKategori.Checked)
            {
                cUrunler u = new cUrunler();
                u.urunleriListeleByUrunAdi(lvGıdaListesi,txtArama.Text);//urun adına gore arama

            }
            else
            {
                cUrunCesitleri uc = new cUrunCesitleri();
                uc.urunCesitleriGetir(lvKategoriler,txtArama.Text);
            }
        }

        private void rbAltKategori_CheckedChanged(object sender, EventArgs e)
        {
            panelurun.Visible = true;
            panelAnaKategori.Visible = false;
            lvKategoriler.Visible = false;
            lvGıdaListesi.Visible = true;
            yenile();

        }

        private void AnaKategori_CheckedChanged(object sender, EventArgs e)
        {
            panelurun.Visible = false;
            panelAnaKategori.Visible = true;
            lvKategoriler.Visible = true;
            lvGıdaListesi.Visible = false;

            yenile();
        }

        private void cbKategoriler_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        private void yenile()
        {
            cUrunCesitleri uc = new cUrunCesitleri();
            uc.urunCesitleriGetir(cbKategoriler);
            cbKategoriler.Items.Insert(0,"Tüm Kategoriler");
            cbKategoriler.SelectedIndex = 0;
            uc.urunCesitleriGetir(lvKategoriler);
            cUrunler c = new cUrunler();
            c.urunleriListele(lvGıdaListesi);
        }
    }
}

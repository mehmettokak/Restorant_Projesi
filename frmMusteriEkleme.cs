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
    public partial class frmMusteriEkleme : Form
    {
        public frmMusteriEkleme()
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

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            this.Close();
            frm.Show();
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            

            //oncelikle kontrol yapalım
            if (txtMusteriTlf.Text.Length > 6)//tlf kontrol
            {
                if (txtMusteriAdi.Text == "" || txtMusteriSoyadi.Text == "")//ad ve soyad kontrol.
                {
                    MessageBox.Show("Lütfen Müsteri adı ve Soyad alanlarını doldurunuz.");

                }
                else
                {
                    cMusteriler c = new cMusteriler();
                    bool sonuc = c.musteriVarmi(txtMusteriTlf.Text);
                    if (!sonuc)//false donuyorsa yani musteri yoksa yanı sonuc=0 durumu icın
                    {
                        c.MusteriAd = txtMusteriAdi.Text;
                        c.MusteriSoyad = txtMusteriSoyadi.Text;
                        c.MusteriTlf = txtMusteriTlf.Text;
                        c.MusteriEmail = txtMusteriEmail.Text;
                        c.MusteriAdres = txtMusteriAdres.Text;
                        txtMusteriNo.Text = c.musteriEkle(c).ToString();//musteri ekle metotta donen sonuc yanı musteri ıd =musteri no olacak.
                        if (txtMusteriNo.Text != "")
                        {
                            MessageBox.Show("Müsteri Eklendi.");
                        }
                        else
                        {
                            MessageBox.Show("HATA!!! Müsteri Eklenemedi.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bu bilgilere ait kayıt bulunmaktadır.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen en az 7 haneli bir telefon numarası giriniz.");
            }
        }

        private void btnMustriSec1_Click(object sender, EventArgs e)
        {
            //musterinın gitmesı gerektıgı yerı belırlıce..rezervasonn mu yokmu baska bıseymı.1 se paket siparis
            if (cGenel._musteriEkleme == 0)
            {
                frmRezervasyon frm = new frmRezervasyon();
                cGenel._musteriEkleme = 1;
                this.Close();
                frm.Show();
            }
            else if (cGenel._musteriEkleme == 1)
            {
                frmPaketSiparis frm = new frmPaketSiparis();
                cGenel._musteriEkleme = 0;
                this.Close();
                frm.Show();
            }
        }

        private void btnM_Guncelle1_Click(object sender, EventArgs e)
        {
            if (txtMusteriTlf.Text.Length > 6)//tlf kontrol
            {
                if (txtMusteriAdi.Text == "" || txtMusteriSoyadi.Text == "")//ad ve soyad kontrol.
                {
                    MessageBox.Show("Lütfen Müsteri adı ve Soyad alanlarını doldurunuz.");

                }
                else
                {
                    cMusteriler c = new cMusteriler();
                    c.MusteriAd = txtMusteriAdi.Text;
                    c.MusteriSoyad = txtMusteriSoyadi.Text;
                    c.MusteriTlf = txtMusteriTlf.Text;
                    c.MusteriEmail = txtMusteriEmail.Text;
                    c.MusteriAdres = txtMusteriAdres.Text;
                    int sonuc = 0;
                    if (string.IsNullOrEmpty(txtMusteriNo.Text))
                    {
                        txtMusteriNo.Text = c.musteriEkle(c).ToString();
                        if (string.IsNullOrEmpty(txtMusteriNo.Text))
                            sonuc = 1;
                        else
                            sonuc = 2;
                    }
                    else
                    {
                        c.MusteriId = Convert.ToInt32(txtMusteriNo.Text);
                        sonuc = c.musteriBilgiGuncelle(c) ? 4 : 3;
                    }
                    string message = "";
                    switch (sonuc)
                    {
                        case 1:
                            message = "Yeni müşteri ekleme sırasında hata oluştu";
                            break;
                        case 2:
                            message = "Yeni müşteri eklendi";
                            break;
                        case 3:
                            message = "Müşteri bilgi güncellemesi sırasında hata oluştu";
                            break;
                        case 4:
                            message = "Müşteri bilgileri güncellendi";
                            break;
                        default:
                            message = "Müşteri bilgi ekleme/güncelleme işlemi yapılamadı";
                            break;
                    }
                    MessageBox.Show(message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen en az 7 haneli bir telefon numarası giriniz.");
            }
        }

        private void frmMusteriEkleme_Load(object sender, EventArgs e)
        {
            if (cGenel._musteriId > 0)
            {
                cMusteriler c = new cMusteriler();
                txtMusteriNo.Text = cGenel._musteriId.ToString();
                c.musteriBilgileriIDGoreGetir(Convert.ToInt32(txtMusteriNo.Text), txtMusteriAdi, txtMusteriSoyadi, txtMusteriTlf, txtMusteriEmail, txtMusteriAdres);
            }                                                 //  txtmusterino.tex vardi. cGenel._musteriId                             
        }

        private void btnM_Geridon1_Click(object sender, EventArgs e)
        {
            frmMusteriAra frm = new frmMusteriAra();
            this.Close();
            frm.Show();

        }
    }
}

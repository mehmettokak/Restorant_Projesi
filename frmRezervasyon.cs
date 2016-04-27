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
    public partial class frmRezervasyon : Form
    {
        public frmRezervasyon()
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

        private void frmRezervasyon_Load(object sender, EventArgs e)
        {
            cMusteriler m = new cMusteriler();
            m.musteriBilgileriGetir(lvMusteriler);
            cMasalar masa = new cMasalar();
            masa.MAsaKapasiteVeDurumGetir(cbMasa);
            dtTarih.MinDate = DateTime.Today;
            dtTarih.Format = DateTimePickerFormat.Time;
        }

        private void txtMusteriad_TextChanged(object sender, EventArgs e)
        {
            cMusteriler m = new cMusteriler();
            m.musteriBilgileriAdGoreGetir(lvMusteriler, txtMusteriad.Text);
        }

        private void txtMusteriTlf_TextChanged(object sender, EventArgs e)
        {
            cMusteriler m = new cMusteriler();
            m.musteriBilgileriTlfNoGoreGetir(lvMusteriler, txtMusteriTlf.Text);
        }

        private void txtMusteriAdres_TextChanged(object sender, EventArgs e)
        {
            cMusteriler m = new cMusteriler();
            m.musteriBilgileriAdGoreGetir(lvMusteriler, txtMusteriAdres.Text);//?????
        }
        void teizle() //textboxları temızlemekıcın
        {
            txtMusteriAdres.Clear();
            txtKisisayisi.Clear();
            txtMasa.Clear();
            txtTarih.Clear();

        }

        private void btnRzrvsynAc_Click(object sender, EventArgs e)//btn musteri sec _clik olacak.konrolet!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        {
            cRezervasyon r = new cRezervasyon();
            if (lvMusteriler.SelectedItems.Count > 0)
            {
                bool sonuc = r.rezervasyonAcikmiKontrol(Convert.ToInt32(lvMusteriler.SelectedItems[0].SubItems[0].Text));//lv musterilerdeki mustreı no yu cekiyoruz.
                if (!sonuc)
                {
                    if (txtKisisayisi.Text != "")//kişi sayısı kontrol icin
                    {
                        cMasalar masa = new cMasalar();

                        if (masa.TablegetbyState(Convert.ToInt32(txtMasaNo.Text), 1))
                        {
                            cAdisyon a = new cAdisyon();
                            a.A_Tarih1 = Convert.ToDateTime(txtTarih.Text);
                            a.A_ServisturNo1 = 1;
                            a.A_MasaId1 = Convert.ToInt32(txtMasaNo.Text);
                            a.A_PersonelId1 = cGenel._personelId;
                            r.ClientId = Convert.ToInt32(lvMusteriler.SelectedItems[0].SubItems[0].Text);
                            r.TableId = Convert.ToInt32(txtMasaNo.Text);
                            r.Date = Convert.ToDateTime(txtTarih.Text);
                            r.ClientCount = Convert.ToInt32(txtKisisayisi.Text);
                            r.Description = txtAciklama.Text;
                            r.AdditionId = a.rzrvsyonAdisyonAc(a);
                            sonuc = r.rezervasyonAc(r);//ilk once adisyon acıyoruz sonra rezervasyon acıyoruz.
                            masa.setChanceTableState(txtMasaNo.Text, 3);//rezervasyon masasdır artık.
                            if (sonuc)// işlem basarılı ise
                            {
                                MessageBox.Show("Rezervasyon başarıyla açılmıştır.");
                                teizle();
                            }
                            else
                            {
                                MessageBox.Show("Rezervasyon kaydı gerçekleştirilmedi.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Rezervasyon yapılan masa şuan dolu.");

                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen kişi sayısı seçiniz.!!!");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bir tarih seçiniz.!!!");
                }
            }

            else
            {
                MessageBox.Show("Bu müsteri üzerinde açık bir rezervasyon bulunmaktadır. ");
            }
        }

        private void dtTarih_MouseEnter(object sender, EventArgs e)
        {
            dtTarih.Width = 200;
        }

        private void dtTarih_Enter(object sender, EventArgs e)
        {
            dtTarih.Width = 200;//tıklanıldıgındada bu ıslemı yapsın
        }

        private void dtTarih_MouseLeave(object sender, EventArgs e)
        {
            //uzerinden ayrıldıgında
            dtTarih.Width = 23;
        }

        private void dtTarih_ValueChanged(object sender, EventArgs e)
        {
            txtTarih.Text = dtTarih.Value.ToString();//bu degıstiğinde ordakı degeri aktarsın.
        }

        private void cbKisiSayisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtKisisayisi.Text = cbKisiSayisi.SelectedItem.ToString();
        }

        private void cbMasa_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbKisiSayisi.Enabled = true;
            txtMasa.Text = cbMasa.SelectedItem.ToString();
            //cMasalar msas = new cMasalar();
            //casting işlemi yapıyoruz.
            cMasalar Kapasitesi = (cMasalar)cbMasa.SelectedItem;
            int kapassite = Kapasitesi.KAPASITE;
            txtMasaNo.Text = Convert.ToString(Kapasitesi.ID);//ID masa no dur.
            cbKisiSayisi.Items.Clear();
            for (int i = 0; i < kapassite; i++)
            {
                cbKisiSayisi.Items.Add(i+1);
            }

        }

        private void cbMasa_MouseEnter(object sender, EventArgs e)
        {
            cbMasa.Width = 305;

        }

      

        private void cbKisiSayisi_MouseLeave(object sender, EventArgs e)
        {
            cbKisiSayisi.Width = 23;
        }

        private void cbKisiSayisi_MouseEnter(object sender, EventArgs e)
        {
            cbKisiSayisi.Width = 100;
        }

        private void cbMasa_MouseLeave(object sender, EventArgs e)
        {
            cbMasa.Width = 23;
        }

        private void btnSipariskontrol_Click(object sender, EventArgs e)
        {
            frmSiparisKontrol frm = new frmSiparisKontrol();
            this.Close();
            frm.Show();
        }

        private void btnYeniMusteri_Click(object sender, EventArgs e)
        {
            frmMusteriEkleme frm = new frmMusteriEkleme();
            cGenel._musteriEkleme = 0;
            //me.btnGuncelle.Visible = false;
            //me.btnEkle.Visible = true;
            this.Close();
            frm.Show();

        }

        private void btnMustriGuncelle_Click(object sender, EventArgs e)
        {
            if (lvMusteriler.SelectedItems.Count>0)
            {
                frmMusteriEkleme me = new frmMusteriEkleme();
                cGenel._musteriEkleme = 0;
                cGenel._musteriId = Convert.ToInt32(lvMusteriler.SelectedItems[0].SubItems[0].Text);
                this.Close();
                //me.btnGuncelle.Visible = true;
                //me.btnEkle.Visible = false;
               me.Show();
            }
        }

    }
}
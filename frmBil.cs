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
    public partial class frmBil : Form
    {//1-Masa boş 2-Masa dolu 3-Masa rezerve 4-Dolu rezerve
        public frmBil()
        {
            InitializeComponent();
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            button2.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

        }
        //adisyonId ve servisTurNo kullandık bunları frmsiparis loadında cekicez.
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinize eminmisiniz?", "Uyarı!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            this.Close();
            frm.Show();
        }
        cSiparis cs = new cSiparis(); int OdemeTuru;//servisturno icin
        private void frmBil_Load(object sender, EventArgs e)
        {
            if (cGenel._ServisturNo == 1)//gelen servistur masa ise
            {
                lblAdisyonId.Text = cGenel._AdisyonId;
                txtIndirimTutari.TextChanged += new EventHandler(txtIndirimTutari_TextChanged);//sonradan eklendi.indirim tutarı ıcın event eklendi.
                //siparisleri getimem lazım.metotu cagırıyoruz.
                cs.getByOrder(lvUrunler, Convert.ToInt32(lblAdisyonId.Text));
                if (lvUrunler.Items.Count > 0)//lv urunlerde urun varsa
                {
                    decimal toplam = 0;
                    for (int i = 0; i < lvUrunler.Items.Count; i++)
                    {
                        toplam += Convert.ToDecimal(lvUrunler.Items[i].SubItems[3].Text);//subitem[3] lv urunlerdekı 3 cu ındex yani fiyat olan.
                    }
                    lblToplamTutar.Text = string.Format("{0:0.00}", toplam);//Fiyat icin 0.000 sayıdan sonra 3 rakam daha goster deömek.
                    lblOdenecek.Text = string.Format("{0:0.00}", toplam);//Aratoplam icin " " "
                    decimal kdv = Convert.ToDecimal(lblOdenecek.Text) * 18 / 100;
                    lblKdv.Text = string.Format("{0:0.00}", kdv);
                }
                gbIndirim.Visible = true;
                txtIndirimTutari.Clear();
            }
            else if (cGenel._ServisturNo == 2)
            {
                lblAdisyonId.Text = cGenel._AdisyonId;
                txtIndirimTutari.TextChanged += new EventHandler(txtIndirimTutari_TextChanged);//sonradan eklendi.indirim tutarı ıcın event eklendi.
                //siparisleri getimem lazım.metotu cagırıyoruz.
                cs.getByOrder(lvUrunler, Convert.ToInt32(lblAdisyonId.Text));
                /*Servis tur no ya gore Tur=1 masa--tur=2 paket servis--masa icin gerek yok.paket ıcın musterıye soruulur naskıt mı kredı kartı dıyeodeme turleri icin nakit kredi kartı ticket*/

                cPaketler pc = new cPaketler();
                OdemeTuru = pc.OdemeTurIdGetir(Convert.ToInt32(lblAdisyonId.Text));

                if (OdemeTuru == 1/*kredikartı ise*/) { rbNakit.Checked = true; }
                else if (OdemeTuru == 2) { rbKrediKarti.Checked = true; }
                else if (OdemeTuru == 3) { rbTicket.Checked = true; }






                if (lvUrunler.Items.Count > 0)//lv urunlerde urun varsa
                {
                    decimal toplam = 0;
                    for (int i = 0; i < lvUrunler.Items.Count; i++)
                    {
                        toplam += Convert.ToDecimal(lvUrunler.Items[i].SubItems[3].Text);//subitem[3] lv urunlerdekı 3 cu ındex yani fiyat olan.
                    }
                    lblToplamTutar.Text = string.Format("{0:0.00}", toplam);//Fiyat icin 0.000 sayıdan sonra 3 rakam daha goster deömek.
                    lblOdenecek.Text = string.Format("{0:0.00}", toplam);//Aratoplam icin " " "
                    decimal kdv = Convert.ToDecimal(lblOdenecek.Text) * 18 / 100;
                    lblKdv.Text = string.Format("{0:0.00}", kdv);
                }
                gbIndirim.Visible = true;
                txtIndirimTutari.Clear();
            }
        }

        private void txtIndirimTutari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(txtIndirimTutari.Text) < Convert.ToDecimal(lblToplamTutar.Text))
                {
                    try
                    {
                        lblIndirim.Text = string.Format("{0:0.00}", Convert.ToDecimal(txtIndirimTutari.Text));
                    }
                    catch (Exception)
                    {

                        lblIndirim.Text = string.Format("{0:0.00}", 0);

                    }
                }
                else
                {
                    MessageBox.Show("İndirim Tutari Toplam Tutardan Fazla Olamaz.");
                }

            }
            catch (Exception)
            {

                lblIndirim.Text = string.Format("{0:0.00}", 0);

            }
        }

        private void chkIndirim_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIndirim.Checked)
            {
                gbOzelAktivite.Visible = true;
                txtIndirimTutari.Clear();
            }
            else { gbOzelAktivite.Visible = false; }
        }

        private void lblIndirim_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(lblIndirim.Text) > 0)
            {
                decimal odenecek = 0;
                lblOdenecek.Text = lblToplamTutar.Text;
                odenecek = Convert.ToDecimal(lblOdenecek.Text) - Convert.ToDecimal(lblIndirim.Text);
                lblOdenecek.Text = string.Format("{0:0.00}", odenecek);
            }
            decimal kdv = Convert.ToDecimal(lblOdenecek.Text) * 18 / 100;
            lblKdv.Text = string.Format("{0:0.00}", kdv);
        }


        cMasalar masalar = new cMasalar();
        cRezervasyon rezerve = new cRezervasyon();
        private void btnHesapKapat_Click(object sender, EventArgs e)
        {    
            if(!rbKrediKarti.Checked && !rbNakit.Checked && !rbTicket.Checked)
            {
                new Exception("Ödeme tipi seçiniz").ShowError("Hesap Kapama - Hata");
                return;
            }
            
            //hesap kapama ılgılı ıslemler
            if (cGenel._ServisturNo == 1) //1-musteri masadaysa
            { //Musteri masaya geldi -Bizze masaıd ve musterı ıd lazım
                int masaIdd = masalar.TableGetbyNumber(cGenel._ButtonName);
                int musteriIdd = 0;
                //durum=4 rezervasyonlu musteri masasındadır oturmustur.
                if (masalar.TablegetbyState(masaIdd, 4) == true)
                {
                    musteriIdd = rezerve.musteriIdRezervasyon(masaIdd);
                }
                else
                {
                    musteriIdd = 1;//1 dedık bu standart musterı hep gelen musterı dıyecez.
                }
                int odemeTurIdd = 0;
                if (rbNakit.Checked)
                {
                    odemeTurIdd = 1;//verı tabanda nakıt ıd sı 1 de
                }
                if (rbKrediKarti.Checked == true)
                {
                    odemeTurIdd = 2;//odeme turlerı verıtabanınd kredıkartı ıd 2 oldugu ıcın 2 verdik.
                }
                if (rbTicket.Checked)
                {
                    odemeTurIdd = 3;
                }
                //artık odememizi alabiliriz.
                cOdeme odeme = new cOdeme();
                //   H_O_ADISYONID,H_O_ODEMETURUID,H_O_MUSTERIID,H_O_ARATOPLAM,H_O_KDVTUTARI,H_O_TOPLAMTUTAR,H_O_INDIRIM
                odeme.AdisyonID = Convert.ToInt32(lblAdisyonId.Text);
                odeme.OdemeTurId = odemeTurIdd;
                odeme.MusteriId = musteriIdd;
                odeme.AraToplam = Convert.ToDecimal(lblOdenecek.Text);
                odeme.KdvTutari = Convert.ToDecimal(lblKdv.Text);
                odeme.GenelToplam = Convert.ToDecimal(lblToplamTutar.Text);
                odeme.Indirim = Convert.ToDecimal(lblIndirim.Text);
                //bilgileri aldık.Simdi aldıgımız bilgileri gonderecegız.
                bool result = odeme.hesapKapat(odeme);//odme ıcındekı parametrelere atadıgımız bılglerın hepsi paket olarak odeme icinde toplanır.odeme yı parametre olarak gonderdıkmı butun parametreyı gondemıs oluyoruz.

                if (result == true)//resultakı islemler dogru ıse hata yoksa
                {
                    MessageBox.Show("Hesap Kapatılmıstır.");//hesabı kapattık.simdi masa durumunu degıstirecegız.durumu 1 yap yani kapat bos masa olacak.
                    masalar.setChanceTableState(Convert.ToString(masaIdd), 1);//masayı kapatmaklada ıs bıtmıyor.

                    //rezervasyon kapatıcaz.Bunun ıcın rezervzsonkapat metodu olustracaz.crezrvsyon ıcınde.
                    cRezervasyon cr = new cRezervasyon();
                    cr.rezervasyonKapat(Convert.ToInt32(lblAdisyonId.Text));

                    //sonrasında adisyon kapatıcaz.cs adisyonlarda adısyon kapat metotu olsuturcz.
                    cAdisyon A = new cAdisyon();
                    A.AdisyonKapat(Convert.ToInt32(lblAdisyonId.Text), 0);

                    //Kapaticak baska bırsey kalmadı.dolayısıyla sayfayı kapatıyoruz.işlem bıtıyor.
                    this.Close();
                    frmMasaSiparis frm = new frmMasaSiparis();
                    frm.Show();
                }
                else //işlem basarısız olursa
                {
                    MessageBox.Show("Hesap Kapatılırken Bir Hata Olustu.Lutfen Bir Yetkiliyle Görüşünüz.");
                }
            }
            //Frm menu deki paket servisi için
            else if (cGenel._ServisturNo == 2/*paket sevis ise*/)
            {
                cOdeme odeme = new cOdeme();
                //   H_O_ADISYONID,H_O_ODEMETURUID,H_O_MUSTERIID,H_O_ARATOPLAM,H_O_KDVTUTARI,H_O_TOPLAMTUTAR,H_O_INDIRIM
                odeme.AdisyonID = Convert.ToInt32(lblAdisyonId.Text);
                odeme.OdemeTurId = OdemeTuru;
                odeme.MusteriId = 1;//paketsiparisId gelecek sonrasında
                odeme.AraToplam = Convert.ToDecimal(lblOdenecek.Text);
                odeme.KdvTutari = Convert.ToDecimal(lblKdv.Text);
                odeme.GenelToplam = Convert.ToDecimal(lblToplamTutar.Text);
                odeme.Indirim = Convert.ToDecimal(lblIndirim.Text);
                bool result = odeme.hesapKapat(odeme);//odme ıcındekı parametrelere atadıgımız bılglerın hepsi paket olarak odeme icinde toplanır.odeme yı parametre olarak gonderdıkmı butun parametreyı gondemıs oluyoruz.

                if (result == true)//resultakı islemler dogru ıse hata yoksa
                {
                    MessageBox.Show("Hesap Kapatılmıstır.");//hesabı kapattık.simdi masa durumunu degıstirecegız.durumu 1 yap yani kapat bos masa olacak.
                    //once adisyon kapatacaz
                    cAdisyon A = new cAdisyon();
                    A.AdisyonKapat(Convert.ToInt32(lblAdisyonId.Text), 1);
                    //sonra PAKETSERVISi kapatacaz
                    cPaketler p = new cPaketler();
                    p.PAKETSERVISKapat(Convert.ToInt32(lblAdisyonId.Text));
                  
                    //Kapaticak baska bırsey kalmadı.dolayısıyla sayfayı kapatıyoruz.işlem bıtıyor.
                    this.Close();
                    frmMasaSiparis frm = new frmMasaSiparis();
                    frm.Show();
                }
                else //işlem basarısız olursa
                {
                    MessageBox.Show("Hesap Kapatılırken Bir Hata Olustu.Lutfen Bir Yetkiliyle Görüşünüz.");
                }
            }
        }


        //Hesap Özetleri İcin
        private void btnHesapOzeti_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
        //css kodu gibi  document icin
        Font Baslik = new Font("verdana", 15, FontStyle.Bold);
        Font altBaslik = new Font("verdana", 12, FontStyle.Regular);
        Font icerik = new Font("verdana", 10);
        SolidBrush sb = new SolidBrush(Color.Black);//fırca rengi
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringFormat st = new StringFormat();
            st.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("Mehmet TOKAK", Baslik, sb, 350, 100, st);

            e.Graphics.DrawString("--------------", altBaslik, sb, 350, 120, st);
            e.Graphics.DrawString("Ürün Adı          Adet          Fiyat", altBaslik, sb, 150, 250, st);
            e.Graphics.DrawString("-------------------------------------", altBaslik, sb, 150, 280, st);
            for (int i = 0; i < lvUrunler.Items.Count; i++)
            {
                e.Graphics.DrawString(lvUrunler.Items[i].SubItems[0].Text, icerik, sb, 150, 300 + i * 30, st);
                e.Graphics.DrawString(lvUrunler.Items[i].SubItems[1].Text, icerik, sb, 350, 300 + i * 30, st);
                e.Graphics.DrawString(lvUrunler.Items[i].SubItems[3].Text, icerik, sb, 420, 300 + i * 30, st);
            }
            e.Graphics.DrawString("-----------------------------------------------------", altBaslik, sb, 150, 300 + 30 * lvUrunler.Items.Count, st);
            e.Graphics.DrawString("İndirim Tutarı    :" + lblIndirim.Text + " TL", altBaslik, sb, 250, 300 + 30 * (lvUrunler.Items.Count + 1), st);
            e.Graphics.DrawString("KDV Tutarı        :" + lblKdv.Text + " TL", altBaslik, sb, 150, 300 + 30 * (lvUrunler.Items.Count + 2), st);
            e.Graphics.DrawString("Toplam Tutar      :" + lblToplamTutar.Text + " TL", altBaslik, sb, 150, 300 + 30 * (lvUrunler.Items.Count + 3), st);
            e.Graphics.DrawString("Ödediğiniz tutar  :" + lblOdenecek.Text + " TL", altBaslik, sb, 150, 300 + 30 * (lvUrunler.Items.Count + 4), st);

        }
        //printwievdialogu document property ozellıklerınden printdocumant a bagladık.











    }
}

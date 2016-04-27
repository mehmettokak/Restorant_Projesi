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
    public partial class frmSiparisKontrol : Form
    {
        public frmSiparisKontrol()
        {
            InitializeComponent();
        }

        private void frmSiparisKontrol_Load(object sender, EventArgs e)
        {
            cAdisyon c = new cAdisyon();
            int butonSayisi = c.paketAdisyonIdSayisi();
            //şimdi Musterileri cekecegiz.cadisyonda metodu olusturalım(P_SMUSTERID,M_ADve MSOYAD,Adisyonlardan ID gelecek )
            c.acikPaketAdisyonlar(lvMusteriler);
            //otomatik buton olusturalım.
            int alt = 50;
            int sol = 1;
            int bol = Convert.ToInt32(Math.Ceiling( Math.Sqrt(butonSayisi)));
            for (int i = 1; i <=butonSayisi; i++)
            {
                Button btn = new Button();
                btn.AutoSize=false;
                btn.Size = new Size(179,80);
                btn.FlatStyle = FlatStyle.Flat;
                btn.Name = lvMusteriler.Items[i - 1].SubItems[0].Text;//lv musterilerdeki P_M_MUSTERIID adı gelecek.indexi 0 oan 
                btn.Text = lvMusteriler.Items[i - 1].SubItems[1].Text;//lvmusteri deki musteri dir.buton adı musteri adı oacak   
                btn.Font = new Font(btn.Font.FontFamily.Name,12);
                btn.Location = new Point(sol,alt);
                this.Controls.Add(btn);
                sol += btn.Width + 5;//her seferınde 5 artır genıslıgı
                if (i==2)
                { //her ıkı sırada bir asagı ındırır butonları
                    sol = 1;
                    alt += 50;
                }
                btn.MouseEnter += new EventHandler(dinamikMetot2);
                btn.Click += new EventHandler(dinamikMetot);
               
            
            }

        }
        
        protected void dinamikMetot(object sender,EventArgs e)
        {   cAdisyon c = new cAdisyon();
            Button dinamikButton=(sender as Button);//buton turunden old belırtıyorz.
            //hesap kapatma kısmı oldugu ıcın frmbıll formunaaaaa gıdecek.
            frmBil frm = new frmBil();
            cGenel._AdisyonId =Convert.ToString( c.musterininSonAdisyonIdGetir(Convert.ToInt32(dinamikButton.Name)));
            frm.Show();
        }
      //  bu metotda musteri detayları gormek ıstıruz
        protected void dinamikMetot2(object sender, EventArgs e)
        {
            Button dinamikButton = (sender as Button);//buton turunden old belırtıyorz.
            //hesap kapatma kısmı oldugu ıcın frmbıll formunaaaaa gıdecek.

            cAdisyon c = new cAdisyon();
            c.musteriDetaylar(lvMusteriDetaylari, Convert.ToInt32(dinamikButton.Name));
            sonSiparisTarihi();
            lvSatisDetaylari.Items.Clear();
            cSiparis cs=new cSiparis ();
            cGenel._ServisturNo = 2;
            cGenel._AdisyonId = Convert.ToString(c.musterininSonAdisyonIdGetir(Convert.ToInt32(dinamikButton.Name)));
            lblGenelToplam.Text = cs.genelToplamBul(Convert.ToInt32(dinamikButton.Name)).ToString()+" TL";
        }
        void sonSiparisTarihi()
        {
            int siparisSayisi = lvMusteriDetaylari.Items.Count;
            if (lvMusteriDetaylari.Items.Count>0)
            {
                lblSonSiparisTarihi.Text = lvMusteriDetaylari.Items[siparisSayisi - 1].SubItems[3].Text;
              txtToplamTutar.Text = siparisSayisi + " Adet";
            }
        }
        void Toplam()
        {
            int kayitSayisi = lvSatisDetaylari.Items.Count;
            decimal toplam = 0;
            for (int i = 0; i < kayitSayisi; i++)
            {
               toplam += Convert.ToDecimal(lvSatisDetaylari.Items[i].SubItems[2].Text) * Convert.ToDecimal(lvSatisDetaylari.Items[i].SubItems[3].Text); 
            }
            lblToplamSiparis.Text = toplam.ToString() + " TL";
        }

        private void lvMusteriDetaylari_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvSatisDetaylari.Items.Clear();
            if (lvMusteriDetaylari.SelectedItems.Count>0)
            {
                cSiparis c = new cSiparis();                                                                         //lvmusteridetaydan adisyon ıd cekıcez.sırası 5 oldugu ıcın subitem[4]       
                c.adisyonPaketSiparisDetaylari(lvSatisDetaylari,Convert.ToInt32(lvMusteriDetaylari.SelectedItems[0].SubItems[4].Text));
                Toplam();
                //sonrasında ekledık......1
                lblGenelToplam.Text = c.genelToplamBul(Convert.ToInt32(lvMusteriDetaylari.SelectedItems[0].SubItems[0].Text)).ToString()+" TL";
            } 
        }

        private void lvSatisDetaylari_SelectedIndexChanged(object sender, EventArgs e)
        {

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
    }
}

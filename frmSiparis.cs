using System;
using System.Collections;
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
    public partial class frmSiparis : Form
    {
        public frmSiparis()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğinize Eminmisiniz? ?", "Uyarı!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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

        int TableId; int AdditionId;
        #region Heapislemleri
        void islem(object sender, EventArgs e)//butonları birbiryle iliskılı duruma getırmek ıcın event kullandık
        {
            Button btn = sender as Button;
            //switch case ile butonarı bırbırıne baglayıp event ını kullanıcz.
            switch (btn.Name)
            {
                case "btn1": textAdet.Text += (1).ToString(); break;
                case "btn2": textAdet.Text += (2).ToString(); break;
                case "btn3": textAdet.Text += (3).ToString(); break;
                case "btn4": textAdet.Text += (4).ToString(); break;
                case "btn5": textAdet.Text += (5).ToString(); break;
                case "btn6": textAdet.Text += (6).ToString(); break;
                case "btn7": textAdet.Text += (7).ToString(); break;
                case "btn8": textAdet.Text += (8).ToString(); break;
                case "btn9": textAdet.Text += (9).ToString(); break;
                case "btn0": textAdet.Text += (0).ToString(); break;
                default: MessageBox.Show("Sayı giriniz?"); break;

            }
        }
        #endregion
        private void frmSiparis_Load(object sender, EventArgs e)
        {
            //hesap islemleri butonlarına even eklıyoruz.
            lblMasaNo.Text = cGenel._ButtonValue;
            cMasalar ms = new cMasalar();
            TableId = ms.TableGetbyNumber(cGenel._ButtonName);
            if (ms.TablegetbyState(TableId, 2) == true || ms.TablegetbyState(TableId, 4) == true)
            {
                //hesap ilem butonu masaıdlere gore..durum 2 ve 4 onemli..dolu masa ve musteri masada sparıs beklıyor..ıkısıde dolu masa oluyor.
                //musteri oturmustur.dolayısıyla adısyon ıd lazım..daha oncebu adisyanla ılgılı sparıs verıldıgı ıcın ıd lazım.  

                cAdisyon ads = new cAdisyon();
                AdditionId = ads.getByAddition(TableId); //musaterinin dahaonceden sıparıs ettı urun varsa bunları lısteleyecez.
                cSiparis orders = new cSiparis();
                orders.getByOrder(lvSiparisler, AdditionId);

            }
            btn1.Click += new EventHandler(islem);
            btn2.Click += new EventHandler(islem);
            btn3.Click += new EventHandler(islem);
            btn4.Click += new EventHandler(islem);
            btn5.Click += new EventHandler(islem);
            btn6.Click += new EventHandler(islem);
            btn7.Click += new EventHandler(islem);
            btn8.Click += new EventHandler(islem);
            btn9.Click += new EventHandler(islem);
            btn0.Click += new EventHandler(islem);

        }
        cUrunCesitleri uc = new cUrunCesitleri();
        private void btnAnaYemek3_Click(object sender, EventArgs e)
        {

            uc.getByProductTypes(lvMenu, btnAnaYemek3);
        }

        private void btnIcecekler8_Click(object sender, EventArgs e)
        {

            uc.getByProductTypes(lvMenu, btnIcecekler8);
        }

        private void btnTatlilar7_Click(object sender, EventArgs e)
        {
            uc.getByProductTypes(lvMenu, btnTatlilar7);
        }

        private void btnSalata6_Click(object sender, EventArgs e)
        {
            uc.getByProductTypes(lvMenu, btnSalata6);
        }

        private void btnFastfood5_Click(object sender, EventArgs e)
        {
            uc.getByProductTypes(lvMenu, btnFastfood5);
        }

        private void btnCorba1_Click(object sender, EventArgs e)
        {
            uc.getByProductTypes(lvMenu, btnCorba1);
        }

        private void btnMakarna4_Click(object sender, EventArgs e)
        {
            uc.getByProductTypes(lvMenu, btnMakarna4);
        }

        private void btnAraSicak2_Click(object sender, EventArgs e)
        {
            uc.getByProductTypes(lvMenu, btnAraSicak2);
        }
        int sayac = 0; int sayac2 = 0;
        private void lvMenu_DoubleClick(object sender, EventArgs e)
        {
            if (textAdet.Text == "") //texadet alanı boş ise 1 yazar.
            {
                textAdet.Text = "1";
            }

            if (lvMenu.Items.Count > 0)//itemler secili ise item deger alır odan buyuk olur.
            { //group siparis kısmındakı tablolara deger ataması yapıcaz.bunlar da group menude tıklanan degerlerı ve hesap butandakı secılen degerı alacak
                //urun adı ve urun fıyatı group menuden alıcaz.
                sayac = lvSiparisler.Items.Count;
                lvSiparisler.Items.Add(lvMenu.SelectedItems[0].Text);//urun adi group menuden alıcak
                lvSiparisler.Items[sayac].SubItems.Add(textAdet.Text);//adet bolumu heasp işlem textadettekı degerri alır.
                lvSiparisler.Items[sayac].SubItems.Add((Convert.ToDecimal(lvMenu.SelectedItems[0].SubItems[1].Text) * Convert.ToDecimal(textAdet.Text)).ToString());//Fiyat group menu den alındı.
                //menudeki yemek fıyatı ve hesap butondaki adet sayını aldık.tıpı money oldugu ıcın decımale cevırdık ve adetle carpıp toplm fıyap bulduk
                lvSiparisler.Items[sayac].SubItems.Add(lvMenu.SelectedItems[0].SubItems[2].Text);//urunıd group menuden urun nodan alındı.
                lvSiparisler.Items[sayac].SubItems.Add("0");//masa acıkdegilse 0 verir.

                //yeni ekleenen listwiew icin
                sayac2 = lvYenieklenenler.Items.Count;
                lvSiparisler.Items[sayac].SubItems.Add(sayac2.ToString());

                lvYenieklenenler.Items.Add(AdditionId.ToString());//AdisyonId=additionId
                lvYenieklenenler.Items[sayac2].SubItems.Add(lvMenu.SelectedItems[0].SubItems[2].Text);
                lvYenieklenenler.Items[sayac2].SubItems.Add(textAdet.Text);//adet aldık
                lvYenieklenenler.Items[sayac2].SubItems.Add(TableId.ToString());//MasaId aldık
                lvYenieklenenler.Items[sayac2].SubItems.Add(sayac2.ToString());
                sayac2++;
                textAdet.Text = "";
            }
        }
        ArrayList silinenler = new ArrayList();
        private void btnSiparis_Click(object sender, EventArgs e)
        {

            //masa durumları 1 masa bos 2 masa dolu 3 masa rezerveli
            cMasalar masa = new cMasalar();
            cAdisyon newaddition = new cAdisyon();
            cSiparis saveOrder = new cSiparis();


            frmMasaSiparis ms = new frmMasaSiparis();
            bool sonuc = false;
            if (masa.TablegetbyState(TableId, 1) == true)//masa ıd si bos ise 1 ise metota gonder masa durumu getirsin,
            {
                newaddition.A_ServisturNo1 = 1;
                newaddition.A_PersonelId1 = cGenel._personelId;
                newaddition.A_MasaId1 = TableId;
                newaddition.A_Tarih1 = DateTime.Now;
                sonuc = newaddition.setByAdditionNew(newaddition);
                masa.setChanceTableState(cGenel._ButtonName, 2);//durum 1 ken yani bosken  ve musterı masaya oturdu durumu 2 olrk yanı dolu olrk degıstırdık.
                //simdi bilgileri yazdırma ıslemi
                if (lvSiparisler.Items.Count > 0)
                {
                    for (int i = 0; i < lvSiparisler.Items.Count; i++) //lvsipariste kac kayıt vara hepsini gostersin
                    {//siparişleri veri tabanına yazdırmak ıcın yanı satıslar tablosuna yazmak ıcın yenı bir metot olusturduk cSiparis.cs de yazdık.
                        saveOrder.Satis_MasaId1 = TableId;
                        saveOrder.Satis_UrunId1 = Convert.ToInt32(lvSiparisler.Items[i].SubItems[3].Text);
                        saveOrder.Satis_AdisyonId1 = newaddition.getByAddition(TableId);
                        saveOrder.Satis_Adet1 = Convert.ToInt32(lvSiparisler.Items[i].SubItems[1].Text);
                        saveOrder.setSaverOrder(saveOrder);

                    }
                    this.Close();
                    ms.Show();
                }
            }
            //acık masa da yanlıs sıparıs verıldı onu sılmek icin veya sonradan tekrar aynı masa sıoparıs ıstedi ..
            else if (masa.TablegetbyState(TableId, 2) == true || masa.TablegetbyState(TableId, 4) == true)//masa durumu 2 ile dort aynı durumu ızah edıyor.dolasıyla ıkısı beraber yazdık
            {
              
                if (lvYenieklenenler.Items.Count > 0)
                {
                    for (int i = 0; i < lvYenieklenenler.Items.Count; i++)
                    {
                        saveOrder.Satis_MasaId1 = TableId;
                        saveOrder.Satis_UrunId1 = Convert.ToInt32(lvYenieklenenler.Items[i].SubItems[1].Text);
                        saveOrder.Satis_AdisyonId1 = newaddition.getByAddition(TableId);
                        saveOrder.Satis_Adet1 = Convert.ToInt32(lvYenieklenenler.Items[i].SubItems[2].Text);
                        saveOrder.setSaverOrder(saveOrder);
                    }
           //         cGenel._AdisyonId =Convert.ToString(newaddition.getByAddition(TableId));//sonradan eklendı.frmBil loadı ıcın..adısyonId burdan aldık.
                }
                if (silinenler.Count > 0)
                {
                    foreach (string item in silinenler)
                    {
                        saveOrder.setDeleteOrder(Convert.ToInt32(item));
                    }
                }
                this.Close();
                ms.Show();
            }
            else if (masa.TablegetbyState(TableId, 3) == true)//masa rezerve masa ıse buraya gelicek
            {
                if (masa.TablegetbyState(TableId, 1) == true)//masa ıd si bos ise 1 ise metota gonder masa durumu getirsin,
                {
                    //newaddition.A_ServisturNo1 = 1;
                    //newaddition.A_PersonelId1 = 1;
                    //newaddition.A_MasaId1 = TableId;
                    //newaddition.A_Tarih1 = DateTime.Now;
                    //sonuc = newaddition.setByAdditionNew(newaddition); adisyon ıd ıkıdefa hesaplanmıs oluyor bu sekıl
                    masa.setChanceTableState(cGenel._ButtonName, 4);//durum 1 ken yani bosken  ve musterı masaya oturdu durumu 2 olrk yanı dolu olrk degıstırdık.
                    //simdi bilgileri yazdırma ıslemi
                    if (lvSiparisler.Items.Count > 0)
                    {
                        for (int i = 0; i < lvSiparisler.Items.Count; i++) //lvsipariste kac kayıt vara hepsini gostersin
                        {//siparişleri veri tabanına yazdırmak ıcın yanı satıslar tablosuna yazmak ıcın yenı bir metot olusturduk cSiparis.cs de yazdık.
                            saveOrder.Satis_MasaId1 = TableId;
                            saveOrder.Satis_UrunId1 = Convert.ToInt32(lvSiparisler.Items[i].SubItems[3].Text);
                            saveOrder.Satis_AdisyonId1 = newaddition.getByAddition(TableId);
                            saveOrder.Satis_Adet1 = Convert.ToInt32(lvSiparisler.Items[i].SubItems[1].Text);
                            saveOrder.setSaverOrder(saveOrder);

                        }
                        this.Close();
                        ms.Show();
                    }
                }

            }

        }
        private void lvSiparisler_DoubleClick(object sender, EventArgs e)
        {//cift tıklandıgında urun sılecek.silme işlemi iki durumda olacak.Urun daha once verı tabanında kayıtlı olan urun mu sılınıcek veya verı tabana eklenmeden yanı o an ekledı ve sonra sılınmek ıstnemesı durumları
            if (lvSiparisler.Items.Count > 0)//siparis butona basılıp sonra tekrar gerı donup urunu sılerken
            {
                if (lvSiparisler.SelectedItems[0].SubItems[4].Text != "0") //lvsparıs bos degılse satıd sılınecek
                {
                    cSiparis saveOrderrr = new cSiparis();
                    saveOrderrr.setDeleteOrder(Convert.ToInt32(lvSiparisler.SelectedItems[0].SubItems[4].Text));
                }
                else //silme işlemleri siparis listwievde ve 3uncu lisvivdeki verileri aynı anda ıkısını bırden sılıyor.
                { //Siparis verme butona basmadan once sılınen urunleri kaldırmak
                    for (int i = 0; i < lvYenieklenenler.Items.Count; i++)
                    {
                        if (lvYenieklenenler.Items[i].SubItems[4].Text == lvSiparisler.SelectedItems[0].SubItems[5].Text)//3 listwiewdeki silinenıd==siparislistwiewdeki sılınenıd esit ise
                        {
                            lvYenieklenenler.Items.RemoveAt(i);
                        }
                    }
                }
                lvSiparisler.Items.RemoveAt(lvSiparisler.SelectedItems[0].Index);
            }
        }

        private void textAra_TextChanged(object sender, EventArgs e)
        {
            if (textAra.Text == "")
            {
                textAra.Text = "";
            }
            else
            {
                cUrunCesitleri cu = new cUrunCesitleri();
                cu.getByProductSearch(lvMenu, Convert.ToInt32(textAra.Text));
            }

        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            cGenel._ServisturNo = 1;//sonradan eklendı.frmBill loda kısmı ıcın

            cGenel._AdisyonId = AdditionId.ToString();//sonradan eklendı.frmBil loadı ıcın..adısyonId burdan aldık.

            frmBil frm = new frmBil();
            this.Close();
            frm.Show();
        }









    }
}

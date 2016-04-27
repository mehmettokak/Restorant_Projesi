using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restorant_Projesi
{
    class cAdisyon
    {
        #region Adisyon Field
        private int Id;
        private int A_PersonelId;
        private int A_MasaId;
        private DateTime A_Tarih;
        private bool A_Durum;
        private decimal A_Tutar;//Verı tabanda eklemedık.Sadece burda ekledik
        private int A_ServisturNo;

        #endregion
        #region Adisyon Property
        public int Id1
        {
            get { return Id; }
            set { Id = value; }
        }


        public int A_PersonelId1
        {
            get { return A_PersonelId; }
            set { A_PersonelId = value; }
        }


        public int A_MasaId1
        {
            get { return A_MasaId; }
            set { A_MasaId = value; }
        }


        public DateTime A_Tarih1
        {
            get { return A_Tarih; }
            set { A_Tarih = value; }
        }


        public bool A_Durum1
        {
            get { return A_Durum; }
            set { A_Durum = value; }
        }


        public int A_ServisturNo1
        {
            get { return A_ServisturNo; }
            set { A_ServisturNo = value; }
        }


        public decimal A_Tutar1
        {
            get { return A_Tutar; }
            set { A_Tutar = value; }
        #endregion
        }
        public int getByAddition(int MasaId) //Addisyon bilgileri getir.
        {
            int adisyonId = 0;
            SqlConnection con = new SqlConnection(cGenel.conStirng);
            SqlCommand cmd = new SqlCommand("Select top 1 ID From ADISYON Where A_MASAID=@masaId order by ID desc", con);//Masa ıd git.tablodkı masaıd ve gonderilen masaıd esıt olanlardan buyukten kucuge doge sırala top ıd 1=ıd olarad sadece bir kayıt gerir demek
            cmd.Parameters.Add("@masaId", SqlDbType.Int).Value = MasaId;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                adisyonId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                ex.ShowError("cAdisyon/getByAddition Hatası!!");
            }
            finally
            {
                con.Close();
            }
            return adisyonId;
        }
        public bool setByAdditionNew(cAdisyon bilgiler) //yeni bir adisyon ac-Siparisver kısmı icin
        {
            bool sonuc = false;
            SqlConnection con = new SqlConnection(cGenel.conStirng);
            SqlCommand cmd = new SqlCommand("Insert Into ADISYON(A_SERVİSTURNO,A_TARIH,A_PERSONELID,A_MASAID,A_DURUM) values(@SERVİSTURNO,@TARIH,@PERSONELID,@MASAID,@DURUM)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@SERVİSTURNO", SqlDbType.Int).Value = bilgiler.A_ServisturNo;
                cmd.Parameters.Add("@TARIH", SqlDbType.DateTime).Value = bilgiler.A_Tarih;
                cmd.Parameters.Add("@PERSONELID", SqlDbType.Int).Value = bilgiler.A_PersonelId;
                cmd.Parameters.Add("@MASAID", SqlDbType.Int).Value = bilgiler.A_MasaId;
                cmd.Parameters.Add("@DURUM", SqlDbType.Bit).Value = 0;
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());


            }
            catch (SqlException ex)
            {
                ex.ShowError("cAdisyon/setByAdditionNew Hatası!!");
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
            return sonuc;
        }
        public void AdisyonKapat(int AddisyonID, int durumm)
        {

            SqlConnection con = new SqlConnection(cGenel.conStirng);
            SqlCommand cmd = new SqlCommand("Update ADISYON set A_DURUM=@durum Where ID=@adisyonId", con);//guncelleme yapıcagız ıcın update yazıcaz.
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@adisyonId", SqlDbType.Int).Value = AddisyonID;
                cmd.Parameters.Add("@durum", SqlDbType.Int).Value = durumm;
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                ex.ShowError("cAdisyon/AdisyonKapat Hatası!!");
            }
            finally
            {

                con.Dispose();
                con.Close();
            }

        }

        //frmsiparişKonrol.cs formu icin veri tabanımızda kac tane paket acık adisyon var onu bulan metotu olusturuyoruz.
        //Servisturnoda tac tanae acık adısyon var onu bulacagız
        public int paketAdisyonIdSayisi()
        {
            int miktar = 0;
            SqlConnection con = new SqlConnection(cGenel.conStirng);
            //Adisyonların hepsınde durum_0 ve servisturno=2(2 paket siparis) olanlar kac tanedir.count kactane oldgunu bulur.count a isim verdik kactane diye.
            SqlCommand cmd = new SqlCommand("Select count(*) as kactane from ADISYON where (A_DURUM=0) and (A_SERVİSTURNO=2) ", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                miktar = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch (SqlException ex)
            {
                ex.ShowError("cAdisyon/paketAdisyonIdSayisi Hatası!!");
            }
            finally
            {

                con.Dispose();
                con.Close();
            }
            return miktar;
        }
        //paket servis ve musteriler tablosunun baglantısını olsuruyoruz.sonrasında adısyon.ıd baglantı olusturuyoruz
        public void acikPaketAdisyonlar(ListView lv)
        {
            lv.Clear();

            SqlConnection con = new SqlConnection(cGenel.conStirng); //+' '+ bosluk bırakarak musteri ad ve soy adı bırlestırdık.bunaları musteri diye isme atadık..paket siparisteki musteri ıd ile musterilerdeki ıd birlestiriyoruz.sonra adisyon tablodakı ıd ve PAKETSERVISdeki adisyon ıd birlestiriyoruz.Adisyonıd ye de AdisyonIDD dedik
            SqlCommand cmd = new SqlCommand("Select PAKETSERVIS.P_S_MUSTERIID, MUSTERILER.M_AD+' '+MUSTERILER.M_SOYAD as Musteri,ADISYON.ID as AdisyonIDD from PAKETSERVIS Inner JOIN  MUSTERILER ON  MUSTERILER.ID=PAKETSERVIS.P_S_MUSTERIID Inner join ADISYON on ADISYON.ID=PAKETSERVIS.P_S_ADISYONID where ADISYON.A_DURUM=0 ", con);
            SqlDataReader dr = null;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {  //sqlcommand ıcın dekı kodla olsuan stunlar ["P_S_MUSTERIID"]["Musteri"]["ID"(adisyonlardakı ıd)]
                    lv.Items.Add(dr["P_S_MUSTERIID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["Musteri"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["AdisyonIDD"].ToString());

                }

            }
            catch (SqlException ex)
            {
                ex.ShowError("cAdisyon/acikPaketAdisyonlar Hatası!!");
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();

            }

        }

        public int musterininSonAdisyonIdGetir(int musterId)
        {
            int sonuc = 0;
            SqlConnection con = new SqlConnection(cGenel.conStirng);
            SqlCommand cmd = new SqlCommand("Select ADISYON.ID from ADISYON Inner Join PAKETSERVIS on PAKETSERVIS.P_S_ADISYONID=ADISYON.ID where PAKETSERVIS.P_S_DURUM=0 and ADISYON.A_DURUM=0 and PAKETSERVIS.P_S_MUSTERIID=@musterId ", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@musterId", SqlDbType.Int).Value = musterId;
               
                sonuc = Convert.ToInt32(cmd.ExecuteScalar());


            }
            catch (SqlException ex)
            {
                ex.ShowError("cAdisyon/setByAdditionNew Hatası!!");
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
            return sonuc;
        }

        //musteri detayları icin olusturulan metot
        public void musteriDetaylar(ListView lv,int musteriId)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(cGenel.conStirng);
            SqlCommand cmd = new SqlCommand("SELECT PAKETSERVIS.P_S_MUSTERIID,PAKETSERVIS.P_S_ADISYONID,MUSTERILER.M_AD,MUSTERILER.M_SOYAD,CONVERT(VARCHAR(10),ADISYON.A_TARIH,104) AS Tarih FROM ADISYON LEFT  JOIN PAKETSERVIS ON PAKETSERVIS.P_S_ADISYONID=ADISYON.ID LEFT  JOIN MUSTERILER ON MUSTERILER.ID = PAKETSERVIS.P_S_MUSTERIID WHERE ADISYON.A_SERVİSTURNO=2  AND PAKETSERVIS.P_S_MUSTERIID=@musteriId  ", con);//WHERE ADISYON.A_SERVİSTURNO=2 AND ADISYON.A_DURUM=0 busekildi.durum 0 olanı kaldırdık.
            cmd.Parameters.Add("@musteriId", SqlDbType.Int).Value = musteriId;
                SqlDataReader dr = null;
             if (con.State == ConnectionState.Closed)
                            {
                                con.Open();
                            }
            try
            {
                int sayac = 0;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {  
                    lv.Items.Add(dr["P_S_MUSTERIID"].ToString());
                   
                    lv.Items[sayac].SubItems.Add(dr["M_AD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["M_AD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["Tarih"].ToString());
                     lv.Items[sayac].SubItems.Add(dr["P_S_ADISYONID"].ToString());
                }

            }
            catch (SqlException ex)
            {
                ex.ShowError("cAdisyon/musteriDetaylar Hatası!!");
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
        }
        public int rzrvsyonAdisyonAc(cAdisyon bilgiler)
        {
         
            int sonuc = 0;
            SqlConnection con = new SqlConnection(cGenel.conStirng);
            SqlCommand cmd = new SqlCommand("Insert Into ADISYON(A_SERVİSTURNO,A_TARIH,A_PERSONELID,A_MASAID) values(@SERVİSTURNO,@TARIH,@PERSONELID,@MASAID); Select scope_IDENTITY()", con);//scope_identiity=etkilenen son satırı hak bılgıyı alır.
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@SERVİSTURNO", SqlDbType.Int).Value = bilgiler.A_ServisturNo;
                cmd.Parameters.Add("@TARIH", SqlDbType.DateTime).Value = bilgiler.A_Tarih;
                cmd.Parameters.Add("@PERSONELID", SqlDbType.Int).Value = bilgiler.A_PersonelId;
                cmd.Parameters.Add("@MASAID", SqlDbType.Int).Value = bilgiler.A_MasaId;
                sonuc = Convert.ToInt32(cmd.ExecuteScalar());


            }
            catch (SqlException ex)
            {
                ex.ShowError("cAdisyon/rzrvsyonAdisyonAc Hatası!!");
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
            return sonuc;
        
        }
    }
}

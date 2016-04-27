using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Restorant_Projesi
{
    class cSiparis
    {
        #region Adisyon Field
        private int ID;
        private int Satis_AdisyonId;
        private int Satis_UrunId;
        private int Satis_MasaId;
        private int Satis_Adet;
        #endregion

        #region Adisyon Property
        public int ID1
        {
            get { return ID; }
            set { ID = value; }
        }


        public int Satis_AdisyonId1
        {
            get { return Satis_AdisyonId; }
            set { Satis_AdisyonId = value; }
        }


        public int Satis_UrunId1
        {
            get { return Satis_UrunId; }
            set { Satis_UrunId = value; }
        }


        public int Satis_MasaId1
        {
            get { return Satis_MasaId; }
            set { Satis_MasaId = value; }
        }


        public int Satis_Adet1
        {
            get { return Satis_Adet; }
            set { Satis_Adet = value; }
        }
        #endregion
        //Siparisleri Getir
        public void getByOrder(ListView lv, int AdisyonId)
        {
            SqlConnection con = new SqlConnection(cGenel.conStirng);
            SqlCommand cmd = new SqlCommand("Select U_URUNAD,U_FIYAT,SATISLAR.ID,SATIS_URUNID,SATISLAR.SATIS_ADET From SATISLAR Inner Join URUNLER on SATISLAR.SATIS_URUNID=URUNLER.ID Where SaTIS_ADISYONID=@adisyonId", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@adisyonId", SqlDbType.Int).Value = AdisyonId;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                int sayac = 0;
                while(dr.Read()) //listwiev e deger atama
                {
                    lv.Items.Add(dr["U_URUNAD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["SATIS_ADET"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["SATIS_URUNID"].ToString());
                    lv.Items[sayac].SubItems.Add(Convert.ToString(Convert.ToDecimal(dr["U_FIYAT"]) * Convert.ToDecimal(dr["SATIS_ADET"])));
                    lv.Items[sayac].SubItems.Add(dr["ID"].ToString());
                    sayac++;

                }
            }
            catch (SqlException ex)
            {

                ex.ShowError();
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }

        }
        public bool setSaverOrder(cSiparis Bilgiler)
        {
            bool sonuc = false;
            SqlConnection con = new SqlConnection(cGenel.conStirng);
            SqlCommand cmd = new SqlCommand("Insert Into SATISLAR(SATIS_ADISYONID,SATIS_URUNID,SATIS_ADET,SATIS_MASAID) values (@ADISYONNo,@URUNID,@ADET,@MASAID)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@ADISYONNo", SqlDbType.Int).Value = Bilgiler.Satis_AdisyonId;
                cmd.Parameters.Add("@URUNID", SqlDbType.Int).Value = Bilgiler.Satis_UrunId;
                cmd.Parameters.Add("@ADET", SqlDbType.Int).Value = Bilgiler.Satis_Adet;
                cmd.Parameters.Add("@MASAID", SqlDbType.Int).Value = Bilgiler.Satis_MasaId;
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {

                ex.ShowError();
            }
            finally
            {
               
                con.Dispose();
                con.Close();
            }
            return sonuc;

        }
        public void setDeleteOrder(int satisId)
        {
            SqlConnection con = new SqlConnection(cGenel.conStirng);
            SqlCommand cmd = new SqlCommand("Delete From SATISLAR Where ID=@SatisID", con);
            cmd.Parameters.Add("@SatisID",SqlDbType.Int).Value=satisId;
            if (con.State==ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Dispose();
            con.Close();
        }

        //frmSiparis kontrol.cs deki formu genel toplam icin icin
        public decimal genelToplamBul(int MusteriID)
        {
            decimal geneltoplam = 0;
            SqlConnection con = new SqlConnection(cGenel.conStirng); //sqlcommand kodlar, view bolumunde yazılmıstır.
            //SqlCommand cmd = new SqlCommand("SELECT     SUM(dbo.SATISLAR.SATIS_ADET * dbo.URUNLER.U_FIYAT) AS Fiyatlar FROM dbo.MUSTERILER Inner Join  dbo.PAKETSERVIS on dbo.MUSTERILER.ID=PAKETSERVIS.P_S_MUSTERIID INNER JOIN ADISYON on ADISYON.ID=dbo.PAKETSERVIS.P_S_ADISYONID Inner Join dbo.SATISLAR ON dbo.ADISYON.ID = dbo.SATISLAR.SATIS_ADISYONID INNER JOIN dbo.URUNLER ON SATISLAR.SATIS_URUNID=dbo.URUNLER.ID  WHERE (dbo.PAKETSERVIS.P_S_MUSTERIID =@MusteriID) AND (dbo.PAKETSERVIS.P_S_DURUM = 0)", con);
           //iki kod aynı gorevı goruor.ıkıncı kod daha kısaltımıs halidir.
            SqlCommand cmd = new SqlCommand("Select sum(H_O_TOPLAMTUTAR) from HESAPODEMELERI where H_O_MUSTERIID=@ MusteriID",con);
            cmd.Parameters.Add("@MusteriID",SqlDbType.Int).Value = MusteriID;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
              
          geneltoplam = Convert.ToDecimal(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {

                ex.ShowError("cSiparis/genelToplamBul Hatası!!");
                throw;
            }
            finally
            {

                con.Dispose();
                con.Close();
            }
            return geneltoplam;
        }


       //lvmusteridetayları ıcın uzerıne tıklandıgında lvsatısdetaylarında satıs detayı gozukecek 
        public void adisyonPaketSiparisDetaylari(ListView lv,int adisyonId)
        {
            lv.Items.Clear();//sonradan ekledik.....2

            SqlConnection con = new SqlConnection(cGenel.conStirng); //sqlcommand kodlar, view bolumunde yazılmıstır.
            SqlCommand cmd = new SqlCommand("select SATISLAR.ID as satisID,URUNLER.U_URUNAD, URUNLER.U_FIYAT,SATISLAR.SATIS_ADET from SATISLAR Inner Join ADISYON on ADISYON.ID=SATISLAR.SATIS_ADISYONID Inner Join URUNLER on URUNLER.ID=SATISLAR.SATIS_URUNID where SATISLAR.SATIS_ADISYONID=@adisyonId ", con);
            cmd.Parameters.Add("@adisyonId", SqlDbType.Int).Value = adisyonId;
            SqlDataReader dr = null;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                int i = 0;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lv.Items.Add(dr["satisID"].ToString());//lvsiparisDetaylardaki stun ısımlerin sırasına gore yerlestırılır.
                    lv.Items[i].SubItems.Add(dr["U_URUNAD"].ToString());
                    lv.Items[i].SubItems.Add(dr["SATIS_ADET"].ToString());
                    lv.Items[i].SubItems.Add(dr["U_FIYAT"].ToString());
                }
            }
            catch (SqlException ex)
            {

                ex.ShowError("cSiparis/adisyonPaketSiparisDetaylari Hatası!!");
                throw;
            }
            finally
            {

                con.Dispose();
                con.Close();
            }
            
        }

      
    }
}
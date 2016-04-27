using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Restorant_Projesi
{
    class cOdeme
    {
        #region Field
        
        private int _AdisyonID;
        private int _OdemeTurId;
        private decimal _AraToplam;
        private decimal _Indirim;
        private decimal _KdvTutari;
        private decimal _GenelToplam;
        private DateTime _Tarih;
        private int _MusteriId;
        #endregion
        #region Property
       


        public int AdisyonID
        {
            get { return _AdisyonID; }
            set { _AdisyonID = value; }
        }


        public int OdemeTurId
        {
            get { return _OdemeTurId; }
            set { _OdemeTurId = value; }
        }


        public decimal AraToplam
        {
            get { return _AraToplam; }
            set { _AraToplam = value; }
        }


        public decimal Indirim
        {
            get { return _Indirim; }
            set { _Indirim = value; }
        }


        public decimal KdvTutari
        {
            get { return _KdvTutari; }
            set { _KdvTutari = value; }
        }


        public decimal GenelToplam
        {
            get { return _GenelToplam; }
            set { _GenelToplam = value; }
        }


        public DateTime Tarih
        {
            get { return _Tarih; }
            set { _Tarih = value; }
        }


        public int MusteriId
        {
            get { return _MusteriId; }
            set { _MusteriId = value; }
        }
        #endregion

        //hesap(bill) odemelerı tablosunu dolduracaz.Heap kapatıldıgı zaman bu tablo otomatık calısacak.
        //musterinın masa hesabını kapatıyoruz
        public bool hesapKapat(cOdeme hesap)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(cGenel.conStirng);
            SqlCommand cmd = new SqlCommand("Insert into HESAPODEMELERI(H_O_ADISYONID,H_O_ODEMETURUID,H_O_MUSTERIID,H_O_ARATOPLAM,H_O_KDVTUTARI,H_O_TOPLAMTUTAR,H_O_INDIRIM) values (@H_O_ADISYONID,@H_O_ODEMETURUID,@H_O_MUSTERIID,@H_O_ARATOPLAM,@H_O_KDVTUTARI,@H_O_TOPLAMTUTAR,@H_O_INDIRIM)", con);//tablomuza veri gondermek ıcın ınsert into komutu kullanıyoruz.
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }  //burda sırası onemlı degil
                cmd.Parameters.Add("@H_O_ADISYONID", SqlDbType.Int).Value = hesap.AdisyonID;
                cmd.Parameters.Add("@H_O_ODEMETURUID", SqlDbType.Int).Value = hesap._OdemeTurId;
                cmd.Parameters.Add("@H_O_MUSTERIID", SqlDbType.Int).Value = hesap._MusteriId;
                cmd.Parameters.Add("@H_O_ARATOPLAM", SqlDbType.Money).Value = hesap._AraToplam;
                cmd.Parameters.Add("@H_O_KDVTUTARI", SqlDbType.Money).Value = hesap._KdvTutari;
                cmd.Parameters.Add("@H_O_INDIRIM", SqlDbType.Money).Value = hesap._Indirim;
                cmd.Parameters.Add("@H_O_TOPLAMTUTAR", SqlDbType.Money).Value = hesap._GenelToplam;
                // cmd.Parameters.Add("@H_O_TARIH",SqlDbType.DateTime).Value=hesap._Tarih; veri tabanda default value or binding degerini getdate() yaptıgımız ıcın otomatık o ankı tarıhı eklıyecek.burda kullanmaya gerek yok
                result = Convert.ToBoolean(cmd.ExecuteNonQuery());

            }
            catch (SqlException ex)
            {
                ex.ShowError();
                throw;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
            return result;
        }

        //musterinin toplam harcamasını buluyoruz.
        //musteri id sıne gore toplam parayı hesaplayan metot yazıcaz.
        public decimal musterIdToplamTutar(int musteriIdd)
        {
            decimal total = 0;
            SqlConnection con = new SqlConnection(cGenel.conStirng);  //as oldugu ıcın kendimiz Tplm_Tutar diye tanımladık sum metotu ıcın
            SqlCommand cmd = new SqlCommand("Select sum(H_O_TOPLAMTUTAR) as Tplm_Tutar from HESAPODEMELERI Where H_O_MUSTERIID=@musteriIdd", con);//tablomuza veri gondermek ıcın ınsert into komutu kullanıyoruz.
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@musteriIdd", SqlDbType.Int).Value = musteriIdd;

                total = Convert.ToDecimal(cmd.ExecuteScalar());

            }
            catch (SqlException ex)
            {
                ex.ShowError();
                throw;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
            return total;


        }
    }
}

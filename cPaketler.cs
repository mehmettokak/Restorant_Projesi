using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Restorant_Projesi
{
    class cPaketler
    {
        #region Field
        private int _ID;
        private int _AdditionID;
        private int _ClientId;//musteriid
        private string _Description;//acıklama
        private int _State;
        private int _Paytypeid; //odeme turu
        #endregion
        #region Property
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }


        public int AdditionID
        {
            get { return _AdditionID; }
            set { _AdditionID = value; }
        }


        public int ClientId
        {
            get { return _ClientId; }
            set { _ClientId = value; }
        }


        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }


        public int State
        {
            get { return _State; }
            set { _State = value; }
        }


        public int Paytypeid
        {
            get { return _Paytypeid; }
            set { _Paytypeid = value; }
        }
        #endregion
        //Paket Servis Acma
        public bool PAKETSERVISAcma(cPaketler paket)
        {
            bool sonuc = false;
            SqlConnection con = new SqlConnection(cGenel.conStirng);
            SqlCommand cmd = new SqlCommand("Insert into PAKETSERVIS(P_S_ADISYONID,P_S_MUSTERIID,P_S_ODEMETURUID,P_S_ACIKLAMA)values(@P_S_ADISYONID,@P_S_MUSTERIID,@P_S_ODEMETURUID,@P_S_ACIKLAMA)", con);//veri tabanına ekleme yapılacak.
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@P_S_ADISYONID", SqlDbType.Int).Value = paket._AdditionID;
                cmd.Parameters.Add("@P_S_MUSTERIID", SqlDbType.Int).Value = paket._ClientId;//cliendId musteri Id;
                cmd.Parameters.Add("@P_S_ODEMETURUID", SqlDbType.Int).Value = paket._Paytypeid;
                cmd.Parameters.Add("@P_S_ACIKLAMA", SqlDbType.VarChar).Value = paket._Description;
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());//insert işlemi varsa executenonquery kullanılacak.

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
            return sonuc;

        }
        //Paket Servis Kapama
        public void PAKETSERVISKapat(int AdditionIdd)
        {
           
            SqlConnection con = new SqlConnection(cGenel.conStirng);
            SqlCommand cmd = new SqlCommand("Update PAKETSERVIS set PAKETSERVIS.P_S_DURUM=1  Where PAKETSERVIS.P_S_ADISYONID=@AdditionIdd ", con);//veri tabanına ekleme yapılacak.
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@AdditionIdd", SqlDbType.Int).Value = AdditionIdd;
              
               Convert.ToBoolean(cmd.ExecuteNonQuery());//update işlemi varsa executenonquery kullanılacak.

            }
            catch (SqlException ex)
            {
                ex.ShowError("cPaketler/PAKETSERVISKapat Hatası!!");
                throw;
            }
            finally
            { 
                con.Dispose();
                con.Close();

            }
            

        }
        //adisyon ve Paket servisim odeme bilgilerini getirecez.
        //acılan adisyon ve paketsiparislere ait  girilen odeme turıd bilgisini getirecez.
        public int OdemeTurIdGetir(int AddiyonIdd)
        {
            int odemeTurId = 0;
            SqlConnection con = new SqlConnection(cGenel.conStirng);
            SqlCommand cmd = new SqlCommand("Select PAKETSERVIS.P_S_ODEMETURUID from PAKETSERVIS  Inner Join ADISYON on PAKETSERVIS.P_S_ADISYONID=ADISYON.ID Where ADISYON.ID=@AddiyonIdd ", con);//veri tabanına ekleme yapılacak.
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@AddiyonIdd", SqlDbType.Int).Value = AddiyonIdd;

                odemeTurId = Convert.ToInt32(cmd.ExecuteScalar());//Tek bir işlem yaptıgımız icin executescalar kullanılacak.

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
            return odemeTurId;
        }
        //siparis kontrol icin musteriye ait acık olan en son adisyon no sunu getirilmesi(bir musteriye ait bir siparis olabilir.ikitane olamaz)
        public int musteriSonAdisyonId(int musteriID)
        {
            int no = 0;
            SqlConnection con = new SqlConnection(cGenel.conStirng);
            SqlCommand cmd = new SqlCommand("Select ADISYON.ID from ADISYON Inner Join PAKETSERVIS on PAKETSERVIS.P_S_ADISYONID=ADISYON.ID Where (ADISYON.A_DURUM=0) and (PAKETSERVIS.P_S_DURUM=0) and  PAKETSERVIS.P_S_MUSTERIID=@musteriID ", con);//veri tabanına ekleme yapılacak.
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@musteriID", SqlDbType.Int).Value = musteriID;

               no = Convert.ToInt32(cmd.ExecuteScalar());//Tek bir işlem yaptıgımız icin executescalar kullanılacak.

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
            return no;
            
        }
        //acık adısyon varmı onun kontrolunu yapıcaz.
        //musteri arama ekranında adisyonbul butonu adisyon acıkmı degılmı kontrolu
        public bool acıkAdisyonIdKontrol(int aadisyonID)
        {
            bool sonuc = false;
            SqlConnection con = new SqlConnection(cGenel.conStirng);
            SqlCommand cmd = new SqlCommand("Select * From ADISYON where (A_DURUM=0) and (ID=@aadisyonID)", con);//veri tabanına ekleme yapılacak.
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@aadisyonID", SqlDbType.Int).Value = aadisyonID;
              
                sonuc = Convert.ToBoolean(cmd.ExecuteScalar());//tek deger donecegi icin  executescalar kullanılacak.

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
            return sonuc;

        }

    }
}

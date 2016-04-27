using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Restorant_Projesi
{
    class cMasalar
    {
        #region Field
        private int _ID;
        private bool _ONAY;
        private int _KAPASITE;
        private int _SERVISTURU;
        private int _DURUM;
        private string _masaBilgi;

        public string MasaBilgi
        {
            get { return _masaBilgi; }
            set { _masaBilgi = value; }
        }
        #endregion

        #region Property
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }


        public int KAPASITE
        {
            get { return _KAPASITE; }
            set { _KAPASITE = value; }
        }


        public int SERVISTURU
        {
            get { return _SERVISTURU; }
            set { _SERVISTURU = value; }
        }


        public int DURUM
        {
            get { return _DURUM; }
            set { _DURUM = value; }
        }


        public bool ONAY
        {
            get { return _ONAY; }
            set { _ONAY = value; }
        }
        #endregion
        public string SessionSum(int state,string masaId)
        {
            string dt = "";
            SqlConnection con = new SqlConnection(cGenel.conStirng);
            SqlCommand cmd = new SqlCommand("Select A_TARIH,A_MASAID From ADISYON Right Join MASALAR on ADISYON.A_MASAID=MASALAR.ID Where MASALAR.MASA_DURUM=@durum and ADISYON.A_DURUM=0  and MASALAR.ID=@masaIdd ", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@durum", SqlDbType.Int).Value = state;
           cmd.Parameters.Add("@masaIdd", SqlDbType.Int).Value =Convert.ToInt32(masaId);
             //acık olan masaların dıger masalarıda acık olma sururelerı ayınıdı.bunu cozmek ıcın and MASALAR.ID=@masaId,, cmd.Parameters.Add("@masaID", SqlDbType.Int).Value =Convert.ToInt32(masaId); string masaId ekleenerek sorun cozuldu.cmasasipariş.cs ıcınde sessionsum metoda ıkıncı paratmre olarak dr["ID"].ToString() eklendi
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dt = Convert.ToDateTime(dr["A_TARIH"]).ToString();
                }
            }
            catch (SqlException ex)
            {
                ex.ShowError();
                throw;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
            return dt;
        }
        public int TableGetbyNumber(string TableName)
        {
            string k = TableName;
            int length = k.Length;
            if (length > 8)
            {
               return Convert.ToInt32(k.Substring(length - 2, 2));
            }
            else
            {
               return Convert.ToInt32(k.Substring(length - 1, 1));
            }
            
        }
        public bool TablegetbyState(int buttonName,int state)
        { //hesap ilem butonu masaıdlere gore..durum 2 ve 4 onemli..dolu masa ve musteri masada sparıs beklıyor..ıkısıde dolu masa oluyor.
            bool result = false;
            SqlConnection con = new SqlConnection(cGenel.conStirng);
            SqlCommand cmd = new SqlCommand("Select MASA_DURUM From MASALAR Where ID=@buttonId and MASA_DURUM=@state ",con);
            cmd.Parameters.Add("@buttonId", SqlDbType.Int).Value =buttonName;
            cmd.Parameters.Add("@state", SqlDbType.Int).Value = state;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
          result =Convert.ToBoolean( cmd.ExecuteScalar());
              
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
            return result;
        }
        public void setChanceTableState(string ButtonName, int state) //masadurumunu degistir
        {
            SqlConnection con = new SqlConnection(cGenel.conStirng);
            SqlCommand cmd = new SqlCommand("Update MASALAR Set MASA_DURUM=@Durum where ID=@MasaNo ", con);//Masalartablosundaki ıd deki durumu degistir.
            string masaNo = "";
            if (con.State==ConnectionState.Closed)

            {
                con.Open();
            }
            string bb = ButtonName;
            int uzunluk = bb.Length;
            
            cmd.Parameters.Add("@Durum", SqlDbType.Int).Value = state;
            if (uzunluk>8)
            {
                masaNo = bb.Substring(uzunluk - 2, 2);
            }
            else
            {
                masaNo = bb.Substring(uzunluk - 1, 1);
            }
            cmd.Parameters.Add("@MasaNo", SqlDbType.Int).Value = masaNo;
            cmd.ExecuteNonQuery();
            con.Dispose();
            con.Close();

        }
        public void MAsaKapasiteVeDurumGetir(ComboBox cm)
        {//durum 1 Bos--Durum  2 =dolu durum 3 Rezerveli masa
            cm.Items.Clear();
            string durum = "";
             SqlConnection con = new SqlConnection(cGenel.conStirng);
             SqlCommand cmd = new SqlCommand("Select *From MASALAR ", con);//Masalartablosundaki ıd deki durumu degistir.
            
            if (con.State==ConnectionState.Closed)

            {
                con.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cMasalar c = new cMasalar();
                if (c._DURUM==2)
                {
                    durum = "Dolu";
                }
                else if (c._DURUM==3)
                {
                    durum = "Rezerve";
                }
                c._KAPASITE = Convert.ToInt32( dr["MASA_KAPASITE"]);
                c.MasaBilgi = "Masa No : "+dr["ID"].ToString()+" Kapasitesi : "+dr["MASA_KAPASITE"].ToString();
                c.ID = Convert.ToInt32(dr["ID"]);
                cm.Items.Add(c);
            }

            dr.Close();
            con.Dispose();
            con.Close();

        }
        public override string ToString()
        {
            return MasaBilgi;
        }

    }
    }


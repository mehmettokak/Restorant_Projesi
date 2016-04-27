using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Restorant_Projesi
{
    class cRezervasyon
    {
        #region Field
        private int _ID;
        private int _TableId;
        private int _ClientId;
        private DateTime _Date;
        private int _clientCount;
        private string _Description;
        private int _AdditionId;
        #endregion

        #region Property
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }


        public int TableId
        {
            get { return _TableId; }
            set { _TableId = value; }
        }


        public int ClientId
        {
            get { return _ClientId; }
            set { _ClientId = value; }
        }


        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }


        public int ClientCount
        {
            get { return _clientCount; }
            set { _clientCount = value; }
        }


        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }


        public int AdditionId
        {
            get { return _AdditionId; }
            set { _AdditionId = value; }
        }
        #endregion

        //rezervasyon masa acacagımız ıcın bıze musterı ıd lazım
        //rezervasyonlu musteri
        //musteriıd masa numarasına gore
        public int musteriIdRezervasyon(int tableIdd)
        {
            int musteriIdd = 0;
            SqlConnection con = new SqlConnection(cGenel.conStirng);
            SqlCommand cmd = new SqlCommand("Select top 1 R_MUSTERIID from REZERVASYON where R_MASAID=@maSaId order by R_MUSTERIID Desc", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@maSaId", SqlDbType.Int).Value = tableIdd;

                musteriIdd = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch (SqlException ex)
            {
                ex.ShowError("cRezervasyon/musteriIdRezervasyon Hatsı.!!!");
                throw;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
            return musteriIdd;
        }

        //hesap kapatırken rezervasyonlu masyı kapattık
        public bool rezervasyonKapat(int AddisyonID)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(cGenel.conStirng);
            SqlCommand cmd = new SqlCommand("Update REZERVASYON set R_DURUM=1 Where R_ADİSYONID=@adisyonId", con);//guncelleme yapıcagız ıcın update yazıcaz.
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@adisyonId", SqlDbType.Int).Value = AddisyonID;
                result = Convert.ToBoolean(cmd.ExecuteScalar());

            }
            catch (SqlException ex)
            {
                ex.ShowError("cRezervasyon/rezervasyonKapat Hatsı.!!!");
                throw;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
            return result;
        }
        //Rezervasyonları getir
    public  void musteriIdGetirFromRezervasyon(ListView lv)
        {

            lv.Items.Clear();//ustuste eklenmemesi icin once clear yapılır.
            SqlConnection conn = new SqlConnection(cGenel.conStirng);
            SqlCommand cmd = new SqlCommand("Select  REZERVASYON.R_MUSTERIID,(M_AD+M_SOYAD) as musteribilgi From REZERVASYON Inner Join MUSTERILER on REZERVASYON.R_MUSTERIID=MUSTERILER.ID Where REZERVASYON.R_DURUM=0", conn);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                lv.Items.Add(dr["R_MUSTERIID"].ToString());
                lv.Items[i].SubItems.Add(dr["musteribilgi"].ToString());
                i++;
            }
            dr.Close();
            conn.Dispose();
            conn.Close();
        }
        //Acık rezervasyon Sayısı
    public void acıkRezervasyonGetir(ListView lv,int mID)
    {

        lv.Items.Clear();//ustuste eklenmemesi icin once clear yapılır.
        SqlConnection conn = new SqlConnection(cGenel.conStirng);
        SqlCommand cmd = new SqlCommand("Select  REZERVASYON.R_MUSTERIID,M_AD,M_SOYAD,R_ADİSYONID,R_TARIH From REZERVASYON Inner Join MUSTERILER on REZERVASYON.R_MUSTERIID=MUSTERILER.ID  Where REZERVASYON.REZERVASYON.R_MUSTERIID=@mID and REZERVASYON.R_DURUM=0 order by REZERVASYON.ID Desc", conn);
        cmd.Parameters.Add("@mID", SqlDbType.Int).Value = mID;
        if (conn.State == ConnectionState.Closed)
        {
            conn.Open();
        }
        SqlDataReader dr = cmd.ExecuteReader();
        int i = 0;
        while (dr.Read())
        {
            lv.Items.Add(dr["R_MUSTERIID"].ToString());
            lv.Items[i].SubItems.Add(dr["M_AD"].ToString());
            lv.Items[i].SubItems.Add(dr["M_SOYAD"].ToString());
           lv.Items[i].SubItems.Add(dr["R_TARIH"].ToString());
            lv.Items[i].SubItems.Add(dr["R_ADİSYONID"].ToString());
      
            i++;
        }
        dr.Close();
        conn.Dispose();
        conn.Close();
    }
        //Acık olan rezervasyonlar
    public bool rezervasyonAcikmiKontrol(int mID)
    {
        bool result = false;
        SqlConnection con = new SqlConnection(cGenel.conStirng);
        SqlCommand cmd = new SqlCommand("Select top 1 REZERVASYON.ID from REZERVASYON Where R_MUSTERIID=@mID and R_DURUM=1 order by ID Desc ", con);//guncelleme yapıcagız ıcın update yazıcaz.
        try
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.Parameters.Add("@mID", SqlDbType.Int).Value = mID;
            result = Convert.ToBoolean(cmd.ExecuteScalar());

        }
        catch (SqlException ex)
        {
            ex.ShowError("cRezervasyon/rezervasyonAcikmiKontrol Hatsı.!!!");
            throw;
        }
        finally
        {
            con.Dispose();
            con.Close();
        }
        return result;
    }
    public bool rezervasyonAc(cRezervasyon rzrvsyn)
    {
        bool result = false;
        SqlConnection con = new SqlConnection(cGenel.conStirng);
        SqlCommand cmd = new SqlCommand("Insert Into REZERVASYON (R_MUSTERIID,R_MASAID,R_ADİSYONID,R_KISISAYISI,R_TARIH,R_ACIKLAMA,R_DURUM) values (@R_MUSTERIID,@R_MASAID,@R_ADİSYONID,@R_KISISAYISI,@R_TARIH,@R_ACIKLAMA,1)", con);//guncelleme yapıcagız ıcın update yazıcaz.
        try
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.Parameters.Add("@R_MUSTERIID", SqlDbType.Int).Value = rzrvsyn._ClientId;
            cmd.Parameters.Add("@R_MASAID", SqlDbType.Int).Value = rzrvsyn._TableId;
            cmd.Parameters.Add("@R_ADİSYONID", SqlDbType.Int).Value = rzrvsyn._AdditionId;
            cmd.Parameters.Add("@R_KISISAYISI", SqlDbType.Int).Value = rzrvsyn._clientCount;
            cmd.Parameters.Add("@R_TARIH", SqlDbType.DateTime).Value = rzrvsyn._Date;
            cmd.Parameters.Add("@R_ACIKLAMA", SqlDbType.VarChar).Value = rzrvsyn._Description;
         
            result = Convert.ToBoolean(cmd.ExecuteNonQuery());

        }
        catch (SqlException ex)
        {
            ex.ShowError("cRezervasyon/rezervasyonAc Hatsı.!!!");
            throw;
        }
        finally
        {
            con.Dispose();
            con.Close();
        }
        return result;
    }
    public void RzrvsynMasaIdGetir(int mID)
    {
        int sonuc = 0;

        SqlConnection conn = new SqlConnection(cGenel.conStirng);
        SqlCommand cmd = new SqlCommand("Select  REZERVASYON.R_MASAID from REZERVASYON  Inner Join ADISYON on REZERVASYON.R_ADİSYONID=ADISYON.ID where (REZERVASYON.R_DURUM=1) and ADISYON.A_DURUM=0  and REZERVASYON.R_MUSTERIID=@mID ", conn);
        cmd.Parameters.Add("@mID", SqlDbType.Int).Value = mID;
        if (conn.State == ConnectionState.Closed)
        {
            conn.Open();
        }
        try
        {
            cmd.Parameters.Add("@mID", SqlDbType.Int).Value = mID;
            sonuc = Convert.ToInt32(cmd.ExecuteNonQuery());
        }
        catch (SqlException ex)
        {
            ex.ShowError("cRezervasyon.cs/RzrvsynMasaIdGetir Hatası.!!!");
            throw;
        }

        finally
        {
            conn.Dispose();
            conn.Close();
        }
    }
        //Enson rzrvsyn tarıhı getırelım
    public DateTime enSonRzrvsynTarihi(int mID)
    {
        DateTime Trh=new DateTime();
        Trh = DateTime.Now;

        SqlConnection conn = new SqlConnection(cGenel.conStirng);
        SqlCommand cmd = new SqlCommand("Select R_TARIH from REZERVASYON where REZERVASYON.R_MUSTERIID=@mID order by REZERVASYON .ID Desc ", conn);
        cmd.Parameters.Add("@mID", SqlDbType.Int).Value = mID;
        if (conn.State == ConnectionState.Closed)
        {
            conn.Open();
        }

        Trh = Convert.ToDateTime(cmd.ExecuteScalar());
       
            conn.Dispose();
            conn.Close();
            return Trh;
       
    }
        //acık rezervasyon sayısı.dinamık buton olusturacagımız ıcın bu sayıya ıht var
        public int  acikRzrvsyonSayisi(int mid)
        {
            int sonuc=0;
            SqlConnection conn = new SqlConnection(cGenel.conStirng);
            SqlCommand cmd = new SqlCommand("Select count(*)  from REZERVASYON where  REZERVASYON.R_DURUM=0", conn);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
          try 
	{	        
		sonuc=Convert.ToInt32(cmd.ExecuteNonQuery());
	}
	catch (SqlException ex)
	{
		ex.ShowError("cRezervasyon.cs/acikRzrvsyonSayisi Hatası.!!!");
		throw;
	}
        
            conn.Dispose();
            conn.Close();
            return sonuc;
        }
    }
}

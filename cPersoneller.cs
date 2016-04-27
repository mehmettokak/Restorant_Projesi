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
    class cPersoneller
    {
        //cGenel gnl = new cGenel();
        #region Field
        private int _PersonelId;
        private int _PersonelGorevId;
        private string _PersonelAd;
        private string _PersonelSoyad;
        private string _PersonelParola;
        private string _PersonelKullaniciAdi;
        private bool _PersonelDurum;
        #endregion

        #region Properties
        public int PersonelId
        {
            get { return _PersonelId; }
            set { _PersonelId = value; }
        }


        public int PersonelGorevId
        {
            get { return _PersonelGorevId; }
            set { _PersonelGorevId = value; }
        }


        public string PersonelAd
        {
            get { return _PersonelAd; }
            set { _PersonelAd = value; }
        }


        public string PersonelSoyad
        {
            get { return _PersonelSoyad; }
            set { _PersonelSoyad = value; }
        }


        public string PersonelParola
        {
            get { return _PersonelParola; }
            set { _PersonelParola = value; }
        }


        public string PersonelKullaniciAdi
        {
            get { return _PersonelKullaniciAdi; }
            set { _PersonelKullaniciAdi = value; }
        }


        public bool PersonelDurum
        {
            get { return _PersonelDurum; }
            set { _PersonelDurum = value; }
        }
        #endregion
        public bool personelEntryControl(string password, int UserId)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(cGenel.conStirng);
            SqlCommand cmd = new SqlCommand("Select *from PERSONELLER where ID=@Id and P_PAROLA=@password", con);
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = UserId;
            cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                result = Convert.ToBoolean(cmd.ExecuteScalar());
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
        public void personelGetbyInformation(ComboBox cb)
        {
            cb.Items.Clear();
            SqlConnection con = new SqlConnection(cGenel.conStirng);
            SqlCommand cmd = new SqlCommand("Select * from PERSONELLER ", con);



            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cPersoneller p = new cPersoneller();
                p._PersonelId = Convert.ToInt32(dr["ID"]);
                p._PersonelAd = Convert.ToString(dr["P_AD"]);
                p._PersonelSoyad = Convert.ToString(dr["P_SOYAD"]);
                p._PersonelGorevId = Convert.ToInt32(dr["P_GOREVID"]);
                p._PersonelKullaniciAdi = Convert.ToString(dr["P_KULANICIADI"]);
                p._PersonelParola = Convert.ToString(dr["P_PAROLA"]);
                p._PersonelDurum = Convert.ToBoolean(dr["P_DURUM"]);
                cb.Items.Add(p);

            }
        }
        public override string ToString()
        {
            return PersonelAd + " " + PersonelSoyad;
        }

        //Personelgorev ayarları ıcın
        public void persbilglistViewdeGetir(ListView lv)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(cGenel.conStirng);
            SqlCommand cmd = new SqlCommand("Select PERSONELLER.*,PERSONELGOREVLERI.P_GRV_GOREV from PERSONELLER Inner Join PERSONELGOREVLERI on PERSONELGOREVLERI.ID=PERSONELLER.P_GOREVID where PERSONELLER.P_DURUM=0 ", con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                lv.Items.Add(dr["ID"].ToString());
                lv.Items[i].SubItems.Add(dr["P_GOREVID"].ToString());
                lv.Items[i].SubItems.Add(dr["P_GRV_GOREV"].ToString());
                lv.Items[i].SubItems.Add(dr["P_AD"].ToString());
                lv.Items[i].SubItems.Add(dr["P_SOYAD"].ToString());
                lv.Items[i].SubItems.Add(dr["P_KULANICIADI"].ToString());

                i++;

            }
            dr.Close();
            con.Close();
        }
        public void persbilglistViewdeGetirFromId(ListView lv, int presId)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(cGenel.conStirng);
            SqlCommand cmd = new SqlCommand("Select PERSONELLER.*,PERSONELGOREVLERI.P_GRV_GOREV from PERSONELLER Inner Join PERSONELGOREVLERI on PERSONELGOREVLERI.ID=PERSONELLER.P_GOREVID where PERSONELLER.P_DURUM=0 and PERSONELLER.ID=@perId", con);
            cmd.Parameters.Add("@perId", SqlDbType.Int).Value = presId;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                lv.Items.Add(dr["ID"].ToString());
                lv.Items[i].SubItems.Add(dr["P_GOREVID"].ToString());
                lv.Items[i].SubItems.Add(dr["P_GRV_GOREV"].ToString());
                lv.Items[i].SubItems.Add(dr["P_AD"].ToString());
                lv.Items[i].SubItems.Add(dr["P_SOYAD"].ToString());
                lv.Items[i].SubItems.Add(dr["P_KULANICIADI"].ToString());

                i++;

            }
            dr.Close();
            con.Close();
        }

        public string personelBilgiGetirIsim(int perId)
        {
            string sonuc = "";
            SqlConnection con = new SqlConnection(cGenel.conStirng);
            SqlCommand cmd = new SqlCommand("Select P_AD+P_SOYAD from PERSONELLER  where PERSONELLER.P_DURUM=0 and PERSONELLER.ID=@perId", con);
            cmd.Parameters.Add("@perId", SqlDbType.Int).Value = perId;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                sonuc = Convert.ToString(cmd.ExecuteScalar());

            }
            catch (SqlException ex)
            {
                ex.ShowError("cPersoneller.cs/personelBilgiGetirIsim  Hatası !!!");
                throw;
            }
            con.Dispose();
            con.Close();
            return sonuc;
        }

        public bool personelSifreDegistir(int personelid, string sifre)
        {
            bool sonuc = false;
            SqlConnection con = new SqlConnection(cGenel.conStirng);
            SqlCommand cmd = new SqlCommand("Update PERSONELLER set P_PAROLA=@sifre where ID=@personelid", con);
            cmd.Parameters.Add("@personelid", SqlDbType.Int).Value = personelid;
            cmd.Parameters.Add("@sifre", SqlDbType.VarChar).Value = sifre;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());

            }
            catch (SqlException ex)
            {
                ex.ShowError("cPersoneller.cs/personelSifreDegistir  Hatası !!!");
                throw;
            }
            con.Dispose();
            con.Close();
            return sonuc;
        }
        public bool personelEkle(cPersoneller cp)
        {
            bool sonuc = false;
            SqlConnection con = new SqlConnection(cGenel.conStirng);
            SqlCommand cmd = new SqlCommand("Insert into PERSONELLER (P_AD,P_SOYAD,P_PAROLA,P_GOREVID) values  (@P_AD,@P_SOYAD,@P_PAROLA,@P_GOREVID)", con);
            cmd.Parameters.Add("@P_AD", SqlDbType.VarChar).Value = cp._PersonelAd;
            cmd.Parameters.Add("@P_SOYAD", SqlDbType.VarChar).Value = cp._PersonelSoyad;
            cmd.Parameters.Add("@P_PAROLA", SqlDbType.VarChar).Value = cp._PersonelParola;
            cmd.Parameters.Add("@P_GOREVID", SqlDbType.Int).Value = cp._PersonelGorevId;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());

            }
            catch (SqlException ex)
            {
                ex.ShowError("cPersoneller.cs/personelEkle  Hatası !!!");
                throw;
            }
            con.Dispose();
            con.Close();
            return sonuc;
        }
        public bool personelGuncelle(cPersoneller cp, int perId)
        {
            bool sonuc = false;
            SqlConnection con = new SqlConnection(cGenel.conStirng);
            SqlCommand cmd = new SqlCommand("Update PERSONELLER set  P_AD=@P_AD,P_SOYAD=@P_SOYAD,P_PAROLA=@P_PAROLA,P_GOREVID=@P_GOREVID where ID=@perId", con);
            cmd.Parameters.Add("@perId", SqlDbType.Int).Value = perId;

            cmd.Parameters.Add("@P_AD", SqlDbType.VarChar).Value = cp._PersonelAd;
            cmd.Parameters.Add("@P_SOYAD", SqlDbType.VarChar).Value = cp._PersonelSoyad;
            cmd.Parameters.Add("@P_KULANICIADI", SqlDbType.VarChar).Value = cp._PersonelKullaniciAdi;
            cmd.Parameters.Add("@P_PAROLA", SqlDbType.VarChar).Value = cp._PersonelParola;
            cmd.Parameters.Add("@P_GOREVID", SqlDbType.Int).Value = cp._PersonelGorevId;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());

            }
            catch (SqlException ex)
            {
                ex.ShowError("cPersoneller.cs/personelGuncelle Hatası !!!");
                throw;
            }
            con.Dispose();
            con.Close();
            return sonuc;
        }
        public bool personelSil(int perId)
        {
            bool sonuc = false;
            SqlConnection con = new SqlConnection(cGenel.conStirng);
            SqlCommand cmd = new SqlCommand("Update PERSONELLER set P_DURUM=1 where ID=@perId", con);//burda persnelı gızledık sadece sılme durumu yok..durumu 1 yaparsak tru olur durumu.golasıyla ekranda gozukmez fakat verı tabanında saklıdır.
            cmd.Parameters.Add("@perId", SqlDbType.Int).Value = perId;

           
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());

            }
            catch (SqlException ex)
            {
                ex.ShowError("cPersoneller.cs/personelSil Hatası !!!");
                throw;
            }
            con.Dispose();
            con.Close();
            return sonuc;
        }
    }
}

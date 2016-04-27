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
    class cMusteriler
    {
        #region Field
        private int _musteriId;
        private string _musteriAd;
        private string _musteriSoyad;
        private string _musteriTlf;
        private string _musteriAdres;
        private string _musteriEmail;
        #endregion

        #region Property
        public int MusteriId
        {
            get { return _musteriId; }
            set { _musteriId = value; }
        }


        public string MusteriAd
        {
            get { return _musteriAd; }
            set { _musteriAd = value; }
        }


        public string MusteriSoyad
        {
            get { return _musteriSoyad; }
            set { _musteriSoyad = value; }
        }


        public string MusteriTlf
        {
            get { return _musteriTlf; }
            set { _musteriTlf = value; }
        }


        public string MusteriAdres
        {
            get { return _musteriAdres; }
            set { _musteriAdres = value; }
        }


        public string MusteriEmail
        {
            get { return _musteriEmail; }
            set { _musteriEmail = value; }
        }
        #endregion
        //bunu stored Proceduresle yazılması
        public bool musteriVarmi(string tlf)
        {
            bool sonuc = false;
            SqlConnection con = new SqlConnection(cGenel.conStirng);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "MusteriVarmi";//stored procedures adı.
            cmd.CommandType = CommandType.StoredProcedure;//StoredProcedure işlem yapacagımız ıcın tıp olarak bunu yazıyorz. 
            cmd.Parameters.Add("@telefon", SqlDbType.VarChar).Value = tlf;
            cmd.Parameters.Add("@sonuc", SqlDbType.Int);
            //["@sonuc"] burdakı sonuc store procedurestekı @sonuc=0 ile aynı olacak.
            cmd.Parameters["@sonuc"].Direction = ParameterDirection.Output;//StoredProcedure den cıkan sonucu buraya yazıyoruz.
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                cmd.ExecuteNonQuery();
                sonuc = Convert.ToBoolean(cmd.Parameters["@sonuc"].Value);
            }
            catch (SqlException ex)
            {
                ex.ShowError();
                throw;
            }
            finally { con.Close(); }
            return sonuc;
        }

        public int musteriEkle(cMusteriler m)
        {
            int sonuc = 0;

            SqlConnection con = new SqlConnection(cGenel.conStirng);                                                                                                                     //musteri id sını almak icin =scope_identity();
            SqlCommand cmd = new SqlCommand("Insert Into MUSTERILER(M_AD,M_SOYAD,M_TELEFON,M_ADRES,M_EMAIL) values (@M_AD,@M_SOYAD,@M_TELEFON,@M_ADRES,@M_EMAIL); Select SCOPE_IDENTITY()", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@M_AD", SqlDbType.VarChar).Value = m._musteriAd;
                cmd.Parameters.Add("@M_SOYAD", SqlDbType.VarChar).Value = m._musteriSoyad;
                cmd.Parameters.Add("@M_TELEFON", SqlDbType.VarChar).Value = m._musteriTlf;
                cmd.Parameters.Add("@M_ADRES", SqlDbType.VarChar).Value = m._musteriAdres;
                //cmd.Parameters.Add("@M_ILKSIPARIS", SqlDbType.Int).Value = m.ilksiparis buna gerek yok
                cmd.Parameters.Add("@M_EMAIL", SqlDbType.VarChar).Value = m._musteriEmail;


                sonuc = Convert.ToInt32(cmd.ExecuteScalar());//int sonuc=0 turunde tek deger donderdıgımız ıcın executescalar dedik.
            }
            catch (SqlException ex)
            {

                ex.ShowError("cMusteriler/musteriEkle Hatası!!");
                throw;
            }
            finally
            {

                con.Dispose();
                con.Close();
            }

            return sonuc;//sadece musteri ıd sonucu doncek
        }

        public bool musteriBilgiGuncelle(cMusteriler m)
        {
            bool sonuc = false;

            SqlConnection con = new SqlConnection(cGenel.conStirng);                                                                                                                     //musteri id sını almak icin =scope_identity();
            SqlCommand cmd = new SqlCommand("Update  MUSTERILER set M_AD=@M_AD,M_SOYAD=@M_SOYAD,M_TELEFON=@M_TELEFON,M_ADRES=@M_ADRES,M_EMAIL=@M_EMAIL Where ID=@musteriId", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@M_AD", SqlDbType.VarChar).Value = m._musteriAd;
                cmd.Parameters.Add("@M_SOYAD", SqlDbType.VarChar).Value = m._musteriSoyad;
                cmd.Parameters.Add("@M_TELEFON", SqlDbType.VarChar).Value = m._musteriTlf;
                cmd.Parameters.Add("@M_ADRES", SqlDbType.VarChar).Value = m._musteriAdres;
                //cmd.Parameters.Add("@M_ILKSIPARIS", SqlDbType.Int).Value = m.ilksiparis buna gerek yok
                cmd.Parameters.Add("@M_EMAIL", SqlDbType.VarChar).Value = m._musteriEmail;
                cmd.Parameters.Add("@musteriId", SqlDbType.VarChar).Value = m._musteriId;


                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());//int sonuc=0 turunde tek deger donderdıgımız ıcın executescalar dedik.
            }
            catch (SqlException ex)
            {
                ex.ShowError("cMüsteriler/musteribilgileriGuncelle Hatası!!");
            }
            finally
            {

                con.Dispose();
                con.Close();
            }

            return sonuc;//sadece musteri ıd sonucu doncek
        }

        //frmmuseteriekleme.cs deki listviev dolduracaz.
        public void musteriBilgileriGetir(ListView lv)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(cGenel.conStirng);                                                                                                                     //musteri id sını almak icin =scope_identity();
            SqlCommand cmd = new SqlCommand("Select *from MUSTERILER", con);
            //veriokuyacagız.
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
                {
                    lv.Items.Add(dr["ID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["M_AD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["M_SOYAD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["M_TELEFON"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["M_EMAIL"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["M_ADRES"].ToString());

                    sayac++;

                }
            }
            catch (SqlException ex)
            {
                ex.ShowError("cMüsteriler/mmusteriBilgileriGetir Hatası!!");
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }

        }
        //farklı yoldan musteri bilgileri getirme
        public void musteriBilgileriIDGoreGetir(int musterId, TextBox ad, TextBox soyad, TextBox telefon, TextBox email, TextBox adres)
        {
            SqlConnection con = new SqlConnection(cGenel.conStirng);                                                                                                                     //musteri id sını almak icin =scope_identity();
            SqlCommand cmd = new SqlCommand("Select *from MUSTERILER where ID=@musteriID", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@musteriID", SqlDbType.Int).Value = musterId;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    ad.Text = dr["M_AD"].ToString();
                    soyad.Text = dr["M_SOYAD"].ToString();
                    telefon.Text = dr["M_TELEFON"].ToString();
                    email.Text = dr["M_EMAIL"].ToString();
                    adres.Text = dr["M_ADRES"].ToString();
                    //  musterId = Convert.ToInt32(dr["ID"]);
                }


            }
            catch (SqlException ex)
            {
                ex.ShowError("cMusteriler/musteriBilgileriIDGoreGetir Hatası!!");
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
        }

        //frmMusteriAra formu ıcın ad soyad tlf na gore arama yapılması
              //Musteri Adına Gore Arama
        public void musteriBilgileriAdGoreGetir(ListView lv, string musteriAd)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(cGenel.conStirng);             //@musteriAd+'%' bastaki ime gore--=kullansak bırbır aynısını  olmak zorunda.like ile baskısmı aynı ısıe                                                                                                            //musteri id sını almak icin =scope_identity();
            SqlCommand cmd = new SqlCommand("Select *from MUSTERILER where M_AD like @musteriAd+'%'", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@musteriAd", SqlDbType.VarChar).Value = musteriAd;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    lv.Items.Add(Convert.ToInt32(dr["ID"]).ToString());
                    lv.Items[sayac].SubItems.Add(dr["M_AD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["M_SOYAD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["M_TELEFON"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["M_EMAIL"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["M_ADRES"].ToString());
                    sayac++;
                }
            }
            catch (SqlException ex)
            {

                ex.ShowError("Musteri Bilgilendirme Hatası!!");
                throw;
            }
            finally
            {

                con.Dispose();
                con.Close();
            }

        }
              //Musteri Soyadına Gore Arama
        public void musteriBilgileriSoyAdGoreGetir(ListView lv, string musteriSoyAd)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(cGenel.conStirng);             //@musteriAd+'%' bastaki ime gore--=kullansak bırbır aynısını  olmak zorunda.like ile baskısmı aynı ısıe                                                                                                            //musteri id sını almak icin =scope_identity();
            SqlCommand cmd = new SqlCommand("Select *from MUSTERILER where M_SOYAD like @musteriSoyAd+'%'", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@musteriSoyAd", SqlDbType.VarChar).Value = musteriSoyAd;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    lv.Items.Add(Convert.ToInt32(dr["ID"]).ToString());
                    lv.Items[sayac].SubItems.Add(dr["M_AD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["M_SOYAD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["M_TELEFON"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["M_EMAIL"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["M_ADRES"].ToString());
                    sayac++;
                }
            }
            catch (SqlException ex)
            {

                ex.ShowError("Musteri Bilgilendirme Hatası!!");
                throw;
            }
            finally
            {

                con.Dispose();
                con.Close();
            }

        }
              //Tlf No'ya Göre Arama
        public void musteriBilgileriTlfNoGoreGetir(ListView lv, string TelefonNo)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(cGenel.conStirng);             //@musteriAd+'%' bastaki harflere gore arama yapar--=kullansak bırbır aynısını  olmak zorunda.like ile baskısmı aynı ısıe                                                                                                            //musteri id sını almak icin =scope_identity();
            SqlCommand cmd = new SqlCommand("Select *from MUSTERILER where M_TELEFON like @TelefonNo+'%'", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@TelefonNo", SqlDbType.VarChar).Value = TelefonNo;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    lv.Items.Add(Convert.ToInt32(dr["ID"]).ToString());
                    lv.Items[sayac].SubItems.Add(dr["M_AD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["M_SOYAD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["M_TELEFON"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["M_EMAIL"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["M_ADRES"].ToString());
                    sayac++;
                }
            }
            catch (SqlException ex)
            {

                ex.ShowError("Musteri Bilgilendirme Hatası!!");
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

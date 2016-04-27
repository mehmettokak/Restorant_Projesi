using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Restorant_Projesi
{
    class cUrunCesitleri
    {
        #region UrunKategori Field
        private int _UrunTurNo;
        private string _KategoriAd;
        private string _Aciklama;
        #endregion

        #region UrunKategori Property
        public int UrunTurNo
        {
            get { return _UrunTurNo; }
            set { _UrunTurNo = value; }
        }


        public string KategoriAd
        {
            get { return _KategoriAd; }
            set { _KategoriAd = value; }
        }


        public string Aciklama
        {
            get { return _Aciklama; }
            set { _Aciklama = value; }
        }
        #endregion
        public void getByProductTypes(ListView Cesitler, Button btn)
        {
            Cesitler.Items.Clear();//ustuste eklenmemesi icin once clear yapılır.
            SqlConnection conn = new SqlConnection(cGenel.conStirng);
            SqlCommand cmd = new SqlCommand("Select U_URUNAD,U_FIYAT,URUNLER.ID From URUNKATEGORILERI Inner Join URUNLER ON URUNKATEGORILERI.ID=URUNLER.U_KATEGORIID Where URUNLER.U_KATEGORIID=@KATEGORIID", conn);
            string ff = btn.Name;
            int uzunluk = ff.Length;
            cmd.Parameters.Add("@KATEGORIID", SqlDbType.Int).Value = ff.Substring(uzunluk - 1, 1);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                Cesitler.Items.Add(dr["U_URUNAD"].ToString());
                Cesitler.Items[i].SubItems.Add(dr["U_FIYAT"].ToString());
                Cesitler.Items[i].SubItems.Add(dr["ID"].ToString());
                i++;
            }
            dr.Close();
            conn.Dispose();
            conn.Close();
        }
        public void getByProductSearch(ListView Cesitler, int txt)//hızlı arama
        {
            Cesitler.Items.Clear();//ustuste eklenmemesi icin once clear yapılır.
            SqlConnection conn = new SqlConnection(cGenel.conStirng);
            SqlCommand cmd = new SqlCommand("Select *From  URUNLER Where ID=@ID", conn);

            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = txt;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                Cesitler.Items.Add(dr["U_URUNAD"].ToString());
                Cesitler.Items[i].SubItems.Add(dr["U_FIYAT"].ToString());
                Cesitler.Items[i].SubItems.Add(dr["ID"].ToString());
                i++;
            }
            dr.Close();
            conn.Dispose();
            conn.Close();
        }
        //uruncesitleri getir combobox
        public void urunCesitleriGetir(ComboBox cb)
        {

            cb.Items.Clear();
            SqlConnection con = new SqlConnection(cGenel.conStirng);
            SqlCommand cmd = new SqlCommand("Select * from URUNKATEGORILERI where U_K_DURUM=0", con);
            SqlDataReader dr = null;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {//combobox icin
                    cUrunCesitleri uc = new cUrunCesitleri();
                    uc._UrunTurNo = Convert.ToInt32(dr["ID"]);
                    uc._KategoriAd = dr["U_K_KATEGORIADI"].ToString();
                    uc._Aciklama = dr["U_K_ACIKLAMA"].ToString();
                    cb.Items.Add(uc);




                }
            }
            catch (SqlException ex)
            {
                ex.ShowError("cUrunler/urunCesitleriGetir Hatası!!");
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
        }
        //uruncesitleri getir listview
        public void urunCesitleriGetir(ListView lv)//aynı ısımde mett fakat aldıgı deger farklı
        {

            lv.Items.Clear();
            SqlConnection con = new SqlConnection(cGenel.conStirng);
            SqlCommand cmd = new SqlCommand("Select * from URUNKATEGORILERI where U_K_DURUM=0", con);//sartımızıda durum=0 olanları alıyoruz.cunku sılınenler gozukmesın .
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
                    lv.Items[sayac].SubItems.Add(dr["U_K_KATEGORIADI"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["U_K_ACIKLAMA"].ToString());

                    sayac++;

                }
            }
            catch (SqlException ex)
            {
                ex.ShowError("cUrunler/urunleriListele Hatası!!");
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
        }
        // uruncesitleri getir  Arama
        public void urunCesitleriGetir(ListView lv,string arama)
        {

            lv.Items.Clear();
            SqlConnection con = new SqlConnection(cGenel.conStirng);
            SqlCommand cmd = new SqlCommand("Select * from URUNKATEGORILERI where U_K_DURUM=0 and U_K_KATEGORIADI like '%' + @arama +'%' ", con);//sartımızıda durum=0 olanları alıyoruz.cunku sılınenler gozukmesın .
            SqlDataReader dr = null;
            cmd.Parameters.Add("@arama",SqlDbType.VarChar).Value = arama;
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
                    lv.Items[sayac].SubItems.Add(dr["U_K_KATEGORIADI"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["U_K_ACIKLAMA"].ToString());

                    sayac++;

                }
            }
            catch (SqlException ex)
            {
                ex.ShowError("cUrunler/urunleriListele Hatası!!");
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
        }
        //UrunCesitleriEkleme
        public int urunCesitleriEkle(cUrunCesitleri u)
        {

            int sonuc = 0;

            SqlConnection con = new SqlConnection(cGenel.conStirng);                                                                                                                     //musteri id sını almak icin =scope_identity();
            SqlCommand cmd = new SqlCommand("Insert Into URUNKATEGORILERI (U_K_KATEGORIADI,U_K_ACIKLAMA) values (@U_K_KATEGORIADI,@U_K_ACIKLAMA)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@U_K_KATEGORIADI", SqlDbType.VarChar).Value = u._KategoriAd; ;
                cmd.Parameters.Add("@U_K_ACIKLAMA", SqlDbType.VarChar).Value = u._Aciklama;
               



                sonuc = Convert.ToInt32(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {

                ex.ShowError("cUrunler/urunEkle Hatası!!");
                throw;
            }
            finally
            {

                con.Dispose();
                con.Close();
            }

            return sonuc;
        }
        public int urunCesitGuncelle(cUrunCesitleri u)
        {
            int sonuc = 0;

            SqlConnection con = new SqlConnection(cGenel.conStirng);                                                                                                                     //musteri id sını almak icin =scope_identity();
            SqlCommand cmd = new SqlCommand("Update  URUNKATEGORILERI set U_K_KATEGORIADI=@U_K_KATEGORIADI,U_K_ACIKLAMA=@U_K_ACIKLAMA Where ID=@katID", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@U_K_KATEGORIADI", SqlDbType.VarChar).Value = u._KategoriAd;
                cmd.Parameters.Add("@U_K_ACIKLAMA", SqlDbType.VarChar).Value = u._Aciklama;
                cmd.Parameters.Add("@katID", SqlDbType.Int).Value = u._UrunTurNo;


                sonuc = Convert.ToInt32(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                ex.ShowError("cMüsteriler/urunCesitGuncelle Hatası!!");
            }
            finally
            {

                con.Dispose();
                con.Close();
            }

            return sonuc;
        }
        public int urunCesitSil(int id)
        {
            int sonuc = 0;

            SqlConnection con = new SqlConnection(cGenel.conStirng);                                                                                                                     //musteri id sını almak icin =scope_identity();
            SqlCommand cmd = new SqlCommand("Update  URUNKATEGORILERI set U_K_DURUM=1 Where ID=@katID", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@katID", SqlDbType.Int).Value = id;


                sonuc = Convert.ToInt32(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                ex.ShowError("cMüsteriler/urunCesitSil Hatası!!");
            }
            finally
            {

                con.Dispose();
                con.Close();
            }

            return sonuc;
        }
        public override string ToString()
        {
            return _KategoriAd;
        }

    }
}

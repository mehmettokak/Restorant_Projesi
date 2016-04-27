using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Restorant_Projesi
{
    class cUrunler
    {
        #region Field
        private int _urunId;
        private int _urunTurNo;
        private string _urunAd;
        private decimal _urunFiyat;
        private string _urunAcıklama;

        #endregion
        #region Property
        public int UrunId
        {
            get { return _urunId; }
            set { _urunId = value; }
        }


        public int UrunTurNo
        {
            get { return _urunTurNo; }
            set { _urunTurNo = value; }
        }


        public string UrunAd
        {
            get { return _urunAd; }
            set { _urunAd = value; }
        }


        public decimal UrunFiyat
        {
            get { return _urunFiyat; }
            set { _urunFiyat = value; }
        }


        public string UrunAcıklama
        {
            get { return _urunAcıklama; }
            set { _urunAcıklama = value; }
        }
        #endregion

        //urun adına gore listeleme
        public void urunleriListeleByUrunAdi(ListView lv, string urunId)
        {

            lv.Items.Clear();
            SqlConnection con = new SqlConnection(cGenel.conStirng);
            SqlCommand cmd = new SqlCommand("Select *from URUNLER where U_DURUM=0 U_URUNAD like '%'+@urunId+'%'", con);//sartımızıda durum=0 olanları alıyoruz.cunku sılınenler gozukmesın .
            //veriokuyacagız.
            SqlDataReader dr = null;
            cmd.Parameters.Add("@urunId", SqlDbType.VarChar).Value = urunId;
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
                    lv.Items[sayac].SubItems.Add(dr["U_KATEGORIID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["U_URUNAD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["U_ACIKLAMA"].ToString());
                    lv.Items[sayac].SubItems.Add(string.Format("{0:0#00.0}", dr["U_FIYAT"].ToString()));


                    sayac++;

                }
            }
            catch (SqlException ex)
            {
                ex.ShowError("cUrunler/urunleriListeleByUrunAdi Hatası!!");
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
        }

        //urun Ekleme
        public int urunEkle(cUrunler u)
        {

            int sonuc = 0;

            SqlConnection con = new SqlConnection(cGenel.conStirng);                                                                                                                     //musteri id sını almak icin =scope_identity();
            SqlCommand cmd = new SqlCommand("Insert Into URUNLER (U_URUNAD,U_KATEGORIID,U_ACIKLAMA,U_FIYAT) values (@U_URUNAD,@U_KATEGORIID,@U_ACIKLAMA,@U_FIYAT)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@U_URUNAD", SqlDbType.VarChar).Value = u._urunAd;
                cmd.Parameters.Add("@U_KATEGORIID", SqlDbType.Int).Value = u._urunTurNo;
                cmd.Parameters.Add("@U_ACIKLAMA", SqlDbType.VarChar).Value = u._urunAcıklama;
                cmd.Parameters.Add("@U_FIYAT", SqlDbType.Money).Value = u._urunFiyat;



                sonuc = Convert.ToInt32(cmd.ExecuteNonQuery());//int sonuc=0 turunde tek deger donderdıgımız ıcın executescalar dedik.
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
        //Urunler ve kategorileri listeleme
        public void urunleriListele(ListView lv)
        {

            lv.Items.Clear();
            SqlConnection con = new SqlConnection(cGenel.conStirng);
            SqlCommand cmd = new SqlCommand("Select URUNLER.* ,U_K_KATEGORIADI from URUNLER inner join URUNKATEGORILERI on URUNKATEGORILERI.ID=URUNLER.U_KATEGORIID where URUNLER.U_DURUM=0", con);//sartımızıda durum=0 olanları alıyoruz.cunku sılınenler gozukmesın .
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
                    lv.Items[sayac].SubItems.Add(dr["U_KATEGORIID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["U_K_KATEGORIADI"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["U_URUNAD"].ToString());
                    lv.Items[sayac].SubItems.Add(string.Format("{0:0#00.0}", dr["U_FIYAT"].ToString()));
                    lv.Items[sayac].SubItems.Add(dr["U_ACIKLAMA"].ToString());
                  


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
        //Urun Guncelleme
        public int urunBilgiGuncelle(cUrunler u)
        {
            int sonuc = 0;

            SqlConnection con = new SqlConnection(cGenel.conStirng);                                                                                                                     //musteri id sını almak icin =scope_identity();
            SqlCommand cmd = new SqlCommand("Update  URUNLER set U_URUNAD=@U_URUNAD,U_KATEGORIID=@U_KATEGORIID,U_ACIKLAMA=@U_ACIKLAMA,U_FIYAT=@U_FIYAT Where ID=@urunID", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@U_URUNAD", SqlDbType.VarChar).Value = u._urunAd;
                cmd.Parameters.Add("@U_KATEGORIID", SqlDbType.Int).Value = u._urunTurNo;
                cmd.Parameters.Add("@U_ACIKLAMA", SqlDbType.VarChar).Value = u._urunAcıklama;
                cmd.Parameters.Add("@U_FIYAT", SqlDbType.Money).Value = u._urunFiyat;
                cmd.Parameters.Add("@urunID", SqlDbType.Int).Value = u._urunId;


                sonuc = Convert.ToInt32(cmd.ExecuteNonQuery());
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

            return sonuc;
        }
        //Urun silme(saklama)
        public int urunSil(cUrunler u,int kat)
        {
            int sonuc = 0;

            SqlConnection con = new SqlConnection(cGenel.conStirng);
            string sql = "Update URUNLER set U_DURUM=1 where";
            if (kat==0)//gelen urun kategorıden mı yoksa alt kategorıden mı gelır onun konreolu...corbalar mı mercımek corbası mı gıbı
            {
                sql += "U_KATEGORIID=@urunID";
            }
            else
	{
                sql +="ID=@urunID";
	}
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@urunID", SqlDbType.Int).Value = u.UrunId;


                sonuc = Convert.ToInt32(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                ex.ShowError("cUrunler/urunSil Hatası!!");
                throw;
            }
            finally
            {

                con.Dispose();
                con.Close();
            }

            return sonuc;
        }
        //urun id ye gore listeleme
        public void urunleriListeleByUrunId(ListView lv, int urunId)
        {

            lv.Items.Clear();
            SqlConnection con = new SqlConnection(cGenel.conStirng);
            SqlCommand cmd = new SqlCommand("Select URUNLER.* ,U_K_KATEGORIADI from URUNLER inner join URUNKATEGORILERI on URUNKATEGORILERI.ID=URUNLER.U_KATEGORIID where URUNLER.U_DURUM=0  and URUNLER.U_KATEGORIID=@urunId", con);

            SqlDataReader dr = null;
            cmd.Parameters.Add("@urunId", SqlDbType.Int).Value = urunId;
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
                    lv.Items[sayac].SubItems.Add(dr["U_KATEGORIID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["U_K_KATEGORIADI"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["U_URUNAD"].ToString());
              
                    lv.Items[sayac].SubItems.Add(string.Format("{0:0#00.0}", dr["U_FIYAT"].ToString()));


                    sayac++;

                }
            }
            catch (SqlException ex)
            {
                ex.ShowError("cUrunler/urunleriListeleByUrunAdi Hatası!!");
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
        }
        //2 tarih arası butun urunleri getiriyor
        public void urunListeleIstatiklereGore(ListView lv, DateTimePicker baslangic, DateTimePicker bitis)
        {

            lv.Items.Clear();

            SqlConnection con = new SqlConnection(cGenel.conStirng);
            SqlCommand cmd = new SqlCommand("SELECT TOP 10 URUNLER.U_URUNAD,SUM(SATIS_ADET) AS adeT FROM URUNKATEGORILERI INNER JOIN URUNLER ON URUNKATEGORILERI.ID=URUNLER.U_KATEGORIID INNER JOIN SATISLAR ON URUNLER.ID=SATISLAR.SATIS_URUNID INNER JOIN ADISYON ON SATISLAR.SATIS_ADISYONID=ADISYON.ID WHERE (CONVERT(DATETIME,A_TARIH,104) BETWEEN CONVERT(DATETIME,'@baslangic',104) AND CONVERT(DATETIME,'@bitis')) GROUP BY URUNLER.U_URUNAD ORDER BY adeT DESC", con);

            SqlDataReader dr = null;
            cmd.Parameters.Add("@baslangic", SqlDbType.VarChar).Value = baslangic.Value.ToShortTimeString();
            cmd.Parameters.Add("@bitis", SqlDbType.VarChar).Value = bitis.Value.ToShortTimeString();

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
                    lv.Items.Add(dr["U_URUNAD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["adeT"].ToString());


                    sayac++;

                }
            }
            catch (SqlException ex)
            {
                ex.ShowError("cUrunler/urunListeleIstatiklereGore Hatası!!");
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }

        }

        //belli Kategoriye ait urunler/sadece ana yemkler veya sadece icecekler gibi
        public void urunListeleIstatiklereGoreUrunKatId(ListView lv, DateTimePicker baslangic, DateTimePicker bitis, int urunkatId)
        {

            lv.Items.Clear();

            SqlConnection con = new SqlConnection(cGenel.conStirng);
            SqlCommand cmd = new SqlCommand("SELECT TOP 10 URUNLER.U_URUNAD,SUM(SATIS_ADET) AS adeT FROM URUNKATEGORILERI INNER JOIN URUNLER ON URUNKATEGORILERI.ID=URUNLER.U_KATEGORIID INNER JOIN SATISLAR ON URUNLER.ID=SATISLAR.SATIS_URUNID INNER JOIN ADISYON ON SATISLAR.SATIS_ADISYONID=ADISYON.ID WHERE (CONVERT(DATETIME,A_TARIH,104) BETWEEN CONVERT(DATETIME,'@baslangic',104) AND CONVERT(DATETIME,'@bitis',104)) and (URUNLER.U_KATEGORIID=@urunkatId) GROUP BY URUNLER.U_URUNAD ORDER BY adeT DESC", con);

            SqlDataReader dr = null;
            cmd.Parameters.Add("@baslangic", SqlDbType.VarChar).Value = baslangic.Value.ToShortTimeString();
            cmd.Parameters.Add("@bitis", SqlDbType.VarChar).Value = bitis.Value.ToShortTimeString();
            cmd.Parameters.Add("@urunkatId", SqlDbType.Int).Value = urunkatId;


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
                    lv.Items.Add(dr["U_URUNAD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["adeT"].ToString());


                    sayac++;

                }
            }
            catch (SqlException ex)
            {
                ex.ShowError("cUrunler/urunListeleIstatiklereGoreUrunKatId Hatası!!");
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }

        }


       
    }
}

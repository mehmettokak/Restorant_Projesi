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
    // AYARLAR KISMI ICIN-----------------------------------------
    class cPersonelGorevAyar
    {
        cGenel gnl = new cGenel();
        private int PersonelGorevId;
        private string _tanim;

        public int PersonelGorevId1
        {
            get { return PersonelGorevId; }
            set { PersonelGorevId = value; }
        }

        public string Tanim
        {
            get { return _tanim; }
            set { _tanim = value; }
        }

        //Combobox dolduracaz.Gerideger dondermeyecek
        public void PersonelGorevGetir(ComboBox cb)
        {
            cb.Items.Clear();
            SqlConnection con = new SqlConnection(cGenel.conStirng);
            SqlCommand cmd = new SqlCommand("Select *from PERSONELGOREVLERI", con);
            SqlDataReader dr = null;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {//combobox ıcıne nesne atıyoruz.
                    cPersonelGorevAyar c = new cPersonelGorevAyar();
                    c.PersonelGorevId = Convert.ToInt32(dr["ID"].ToString());
                    c._tanim = dr["P_GRV_GOREV"].ToString();
                    cb.Items.Add(c);
                }
            }
            catch (SqlException ex)
            {
                ex.ShowError("cPersonelGorevAyar/PersonelGorevGetir Hatası!!");
                throw;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();

            }
        }
        public string PersonelGorevTanım(int persnl)
        {
            string sonuc = "";
            SqlConnection con = new SqlConnection(cGenel.conStirng);
            SqlCommand cmd = new SqlCommand("Select P_GRV_GOREV from PERSONELGOREVLERI where ID=@persnlId", con);
            cmd.Parameters.Add("@persnlId", SqlDbType.Int).Value = persnl;


            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                sonuc = cmd.ExecuteScalar().ToString();

            }
            catch (SqlException ex)
            {
                ex.ShowError("cPersonelGorevAyar/PersonelGorevTanım Hatası!!");
                throw;
            }
            finally
            {

                con.Dispose();
                con.Close();

            }
            return sonuc;
        }
        //override metotları olusturalım.Yukardaki metotu ezme ıslemı yapıcaz.
        public override string ToString()
        {
            return _tanim;
        }
    }
}

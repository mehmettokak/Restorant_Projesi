using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Restorant_Projesi
{
    class cPersonelHareketleri
    {
        #region Field
        private int _ID;
        private int _PersonelId;
        private string _Islem;
        private DateTime _Tarih;
        private bool _Durum;
        #endregion
        #region Property
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }


        public int PersonelId
        {
            get { return _PersonelId; }
            set { _PersonelId = value; }
        }


        public string Islem
        {
            get { return _Islem; }
            set { _Islem = value; }
        }


        public DateTime Tarih
        {
            get { return _Tarih; }
            set { _Tarih = value; }
        }


        public bool Durum
        {
            get { return _Durum; }
            set { _Durum = value; }
        }
        #endregion
        public bool PersonelActionSave(cPersonelHareketleri ph)
        {
            bool resulut = false;
            SqlConnection con = new SqlConnection(cGenel.conStirng);
            SqlCommand cmd = new SqlCommand("Insert Into PERSONELHAREKETLERI(P_HRKT_PERSONELID,P_HRKT_ISLEM,P_HRKT_TARIH)Values(@A,@B,@C)", con);
            try
            {
                if (con.State==ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@A", SqlDbType.Int).Value = ph._PersonelId;
                cmd.Parameters.Add("@B", SqlDbType.VarChar).Value =ph._Islem;
                cmd.Parameters.Add("@C", SqlDbType.DateTime).Value = ph._Tarih;
                resulut = Convert.ToBoolean(cmd.ExecuteNonQuery());
                
            }
            catch (SqlException ex)
            {
                ex.ShowError();
                throw;
            }
            return resulut;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorant_Projesi
{
    class cGenel
    {
        public static string conStirng = (@"Data Source=(LocalDB)\v11.0;Integrated Security =True;AttachDbFileName='|DataDirectory|\mhmt_rstrnt_uyg.mdf'");//sondakıne ; gerek yok
        public static int _personelId;
        public static int _gorevId;
        //Masa1 siparisler icin 
        public static string _ButtonValue;
        public static string _ButtonName;

        public static int _ServisturNo;//frm bill formu odeme kısımı ıcın
        public static string _AdisyonId;//frm bill formu odeme kısımı ıcın
        //Musteri ekleme icin
        public static int _musteriEkleme;
        //musteri gunceleme icin
        public static int _musteriId;
        

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restorant_Projesi
{
    public static class Helper
    {
        public static DateTime ToDateTime(this object item)
        {
            DateTime date = DateTime.MinValue;
            try
            {
                date = Convert.ToDateTime(item);
            }
            catch { }
            return date;
        }

        public static void ShowError(this Exception ex,string title="Hata")
        {
            MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

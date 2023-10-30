using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Controles
{
    static class cambiosControles
    {
        // Manejar PlaceHolders
        #region Manejar Place Holders
        public static void placeHolder_Set(Control control, string placeHolder)
        {
            control.Text = placeHolder;
            control.ForeColor = Color.FromArgb(90, 92, 230);
            if (control.Text == placeHolder)
            {
                control.Text = "";
            }        
        }

        public static void placeHolder_Reset(Control control, string placeHolder)
        {
            if (control.Text == "" || control.Text == placeHolder)
            {
                control.Text = placeHolder;
                control.ForeColor = Color.FromArgb(191, 205, 219);
            }
            else
            {
                control.ForeColor = Color.FromArgb(39, 39, 39);
            }
        }
        #endregion


    }
}

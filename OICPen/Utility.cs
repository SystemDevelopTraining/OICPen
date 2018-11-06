using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OICPen
{
    //MaskedTextboxをクリックした際カーソルが先頭に行くようになる、文字が入っている場合はクリックした場所から
    static class Utility
    {
        public static void maskedTboxStart(MaskedTextBox x)
        {
            if (x.Text == "")
                x.SelectionStart = 0;
        }
    }


}

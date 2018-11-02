using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace OICPen
{
    public partial class Items : Form
    {
        public Items()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void searchItemIdTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), "[0-9]")/*!Char.IsDigit(e.KeyChar)*/ && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void searchItemNameTbox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}

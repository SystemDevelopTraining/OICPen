using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OICPen
{
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            searchIdTbox.Text = "";
            searchNameTbox.Text = "";
            searchHuriganaTbox.Text = "";
        }
    }
}

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
    public partial class Frame : Form
    {
        public Frame()
        {
            InitializeComponent();
           /* var f=new login();
            f.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.Show();

            f.BringToFront();*/
        }

        private void Frame_Shown(object sender, EventArgs e)
        {
         /*   MessageBox.Show(splitContainer2.Panel2.Width.ToString());
            MessageBox.Show(splitContainer2.Panel2.Height.ToString());*/
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}

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
            /*To know the length and width of the screen*/
           // var f=new login();
          //var f = new sales();
            /* f.TopLevel = false;
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

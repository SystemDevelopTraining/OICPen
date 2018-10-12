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

        
        private void takeorderBtn_Click(object sender, EventArgs e)
        {
            var f = new TakeOrder();
            f.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.Show();

            f.BringToFront();
        }

        private void salesBtn_Click(object sender, EventArgs e)
        {
            var f = new Sales();
            f.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.Show();

            f.BringToFront();
        }

        private void shipBtn_Click(object sender, EventArgs e)
        {
            var f = new Ship();
            f.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.Show();

            f.BringToFront();
        }

        private void incomingBtn_Click(object sender, EventArgs e)
        {
            var f = new InComing();
            f.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.Show();

            f.BringToFront();
        }

        private void giveorderBtn_Click(object sender, EventArgs e)
        {
            var f = new GiveOrder();
            f.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.Show();

            f.BringToFront();
        }
     
private void stockBtn_Click(object sender, EventArgs e)
        {
            var f = new Stock();
            f.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.Show();

            f.BringToFront();
        }

        private void itemsBtn_Click(object sender, EventArgs e)
        {
            var f = new Items();
            f.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.Show();

            f.BringToFront();
        }

        private void clientsBtn_Click(object sender, EventArgs e)
        {
            var f = new Clients();
            f.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.Show();

            f.BringToFront();
        }

        private void staffsBtn_Click(object sender, EventArgs e)
        {
            var f = new Staffs();
            f.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.Show();

            f.BringToFront();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

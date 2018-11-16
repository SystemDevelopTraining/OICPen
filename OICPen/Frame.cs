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
        public void SetUserName(string userName)
        {
            staffsNameLbl.Text = userName;
        }
        public Frame()
        {
            InitializeComponent();
        }

        private void Frame_Shown(object sender, EventArgs e)
        {

            label1.Text = DateTime.Now.ToString("yyyy/MM/dd(ddd) HH:mm");

            var login =new login(this);
            ChangeForm(login);
            var btnList=new Button[] {
                takeorderBtn,salesBtn,shipBtn,incomingBtn,giveorderBtn,stockBtn,itemsBtn,clientsBtn,staffsBtn,logoutBtn
            };
            var formList = new Form[] {
                new TakeOrder(),new Sales(),new Ship(),new InComing(),
                new GiveOrder(),new Stock(),new Items(),new Clients(),new Staffs(),login
            };
            btnList.Zip(formList,(btn,form)=>{
                btn.Click += (_,__) => ChangeForm(form);
                return 0;
            }).ToArray();
        }

        private void ChangeForm(Form f)
        {
            f.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.Show();
            f.BringToFront();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
                Close();
        }

        private void Frame_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("終了しますか？", "終了", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("yyyy/MM/dd(ddd) HH:mm");
        }
    }
}

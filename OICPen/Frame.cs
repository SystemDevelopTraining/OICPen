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

        Models.StaffT loginStaff;
        Button[] btnList;
        Login login;

        public void SetUser(Models.StaffT staff)
        {
            staffsNameLbl.Text = staff.Name;
            loginStaff = staff;
            BtnSetEnable(true);
        }
        public Frame()
        {
            InitializeComponent();
        }

        //ボタンの有効化、無効化
        void BtnSetEnable(bool flag)
        {
            foreach(var btn in btnList)
            {
                btn.Enabled = flag;
                if (flag == false)
                {
                    btn.BackColor = System.Drawing.SystemColors.Control;
                    logoutBtn.Enabled = false;
                    logoutBtn.BackColor = System.Drawing.SystemColors.Control;
                }
                else
                {
                    btn.BackColor = Color.Black;
                    logoutBtn.Enabled = true;
                    logoutBtn.BackColor = Color.Black;
                }
            }
        }

        private void Frame_Shown(object sender, EventArgs e)
        {

            staffsNameLbl.Text = "";

            label1.Text = DateTime.Now.ToString("yyyy/MM/dd(ddd) HH:mm");

            login =new Login(this);
            ChangeForm(login);
            btnList=new Button[] {
                takeorderBtn,salesBtn,shipBtn,incomingBtn,giveorderBtn,stockBtn,itemsBtn,clientsBtn,staffsBtn
            };
            BtnSetEnable(false);
            var formList = new Form[] {
                new TakeOrder(),new Sales(),new Ship(),new InComing(),
                new GiveOrder(),new Stock(),new Items(),new Clients(),new Staffs()
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


        //ログアウトボタンが押された時の処理
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            BtnSetEnable(false);
            staffsNameLbl.Text = "";
            loginStaff = null;
            login = new Login(this);
            login.Dispose();
            login = new Login(this);
            login.Show();
            ChangeForm(login);
        }
    }
}

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
        Models.OICPenDbContext dbcontext = new Models.OICPenDbContext();

        Models.StaffT loginStaff;
        Button[] btnList;
        Login login;
        GiveOrder giveOrder;
        TakeOrder takeOrder;
        Button beforeBtn = new Button();

        public void SetUser(Models.StaffT staff)
        {
            staffsNameLbl.Text = staff.Name;
            loginStaff = staff;
            BtnSetEnable(true);
            takeOrder.Staff = staff;
            giveOrder.Staff = staff;
        }
        public Frame()
        {
            takeOrder = new TakeOrder(dbcontext);
            giveOrder = new GiveOrder(dbcontext);
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
                    btn.BackColor = Color.Green;
                    logoutBtn.Enabled = false;
                    logoutBtn.BackColor = Color.Green;
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
                takeOrder,new Sales(),new Ship(dbcontext),new InComing(dbcontext),
                giveOrder,new Stock(dbcontext),new Items(dbcontext),new Clients(dbcontext),new Staffs(dbcontext)
            };
            btnList.Zip(formList,(btn,form)=>{
                btn.Click += (_,__) => ChangeForm(form,btn);
                return 0;
            }).ToArray();
        }

        private void ChangeForm(Form f,Button btn = null)
        {
            f.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.Show();
            f.BringToFront();

            //開いているフレームのボタンをdisableに
            if(btn != null){
                if(beforeBtn != null)
                {
                    beforeBtn.Enabled = true;
                    beforeBtn.BackColor = Color.Black;
                }
                btn.Enabled = false;
                btn.BackColor = Color.Red;
                beforeBtn = btn;
            }
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
            login.Dispose();
            login = new Login(this);
            ChangeForm(login);
        }
    }
}

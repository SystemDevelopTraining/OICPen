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
        Clients clients;
        Staffs staffs;
        Button beforeBtn = new Button();
        Items items;
        InComing inComing;

        public void SetUser(Models.StaffT staff)
        {
            nowLoginLbl.Visible = true;
            staffsNameLbl.Text = staff.Name;
            loginStaff = staff;
            BtnSetEnable(true);
            takeOrder.Staff = staff;
            giveOrder.Staff = staff;
            items.Staff = staff;
            clients.Staff = staff;
            staffs.Staff = staff;
            inComing.Staff = staff;
            if (staff.Permission != Models.Permission.God)
            {
                if (staff.Permission != Models.Permission.ClientControl)
                    BtnSetDisableColor(takeorderBtn);
                if (staff.Permission != Models.Permission.ProductControl)
                    BtnSetDisableColor(giveorderBtn);
            }

        }
        public Frame()
        {
            takeOrder = new TakeOrder(dbcontext);
            giveOrder = new GiveOrder(dbcontext);
            items = new Items(dbcontext);
            clients = new Clients(dbcontext);
            staffs = new Staffs(dbcontext);
            inComing = new InComing(dbcontext);
            InitializeComponent();
            timer1.Start();
        }
        
        //ボタンをEnableにし、色を変更する
        void BtnSetEnableColor(Button b)
        {
            b.Enabled = true;
            b.BackColor = Color.Black;
        }

        //ボタンをDisableにし、色を変更する
        void BtnSetDisableColor(Button b)
        {
            b.Enabled = false;
            b.BackColor = Color.Green;
        }

        //ボタンの有効化、無効化
        void BtnSetEnable(bool flag)
        {
            foreach(var btn in btnList)
            {
                btn.Enabled = flag;
                if (flag == false)
                {
                    BtnSetDisableColor(btn);
                    BtnSetDisableColor(logoutBtn);
                }
                else
                {
                    BtnSetEnableColor(btn);
                    BtnSetEnableColor(logoutBtn);
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
                takeOrder,new Sales(),new Ship(dbcontext),inComing,
                giveOrder,new Stock(dbcontext), items,clients,staffs
            };
            btnList.Zip(formList,(btn,form)=>{
                btn.Click += (_,__) => ChangeForm(form,btn);
                return 0;
            }).ToArray();
        }

        private void ChangeForm(Form f,Button btn = null)
        {
            f.TopLevel = false;
            frameScon.Panel2.Controls.Clear();
            frameScon.Panel2.Controls.Add(f);
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
                BtnSetDisableColor(btn);
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
            nowLoginLbl.Visible = false;
            BtnSetEnable(false);
            staffsNameLbl.Text = "";
            loginStaff = null;
            login.Dispose();
            login = new Login(this);
            ChangeForm(login);
        }

    }
}

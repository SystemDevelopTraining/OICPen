using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace OICPen
{
    public partial class Frame : Form
    {
        Models.OICPenDbContext dbcontext;

        Models.StaffT loginStaff;
        Button[] btnList;
        Button beforeBtn = new Button();

        Login login;

        MyForm[] forms;
       

        public void SetUser(Models.StaffT staff)
        {
            nowLoginLbl.Visible = true;
            staffsNameLbl.Text = staff.Name;
            loginStaff = staff;
            BtnSetEnable(true);
            foreach (var form in forms)
                form.Staff = staff;
            
            if (staff.Permission != Models.Permission.God)
            {
                if (staff.Permission != Models.Permission.ClientControl)
                    BtnSetDisableColor(takeorderBtn);
                if (staff.Permission != Models.Permission.ProductControl)
                    BtnSetDisableColor(giveorderBtn);
            }

        }

        //各フォームの生成
        void CreateFrames()
        {
            forms = new MyForm[] {
                new TakeOrder(dbcontext),
                new Sales(dbcontext),
                new Ship(dbcontext),
                new InComing(dbcontext),
                new GiveOrder(dbcontext),
                new Stock(dbcontext),
                new Items(dbcontext),
                new Clients(dbcontext),
                new Staffs(dbcontext)
            };
            foreach(var x in forms)
                ((Form)x).Enabled = false;
        }

        //各フォームの削除
        void DisposeFrames()
        {
            foreach (var form in forms)
                form.Dispose();
        }

        public Frame(Models.OICPenDbContext dbcontext)
        {
            Thread t = new Thread(new ThreadStart(SplashStart));
            t.Start();
            Thread.Sleep(5000);

            this.dbcontext = dbcontext;
            CreateFrames();
            InitializeComponent();
            t.Abort();
        }

        public void SplashStart()
        {
            Application.Run(new Splash());
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
            for (var i = 0; i < btnList.Length; i++)
            {
                var ii = i;
                btnList[i].Click += (_, __) => ChangeForm(forms[ii], btnList[ii]);
            }

            string fileName = @"warning.txt";
            if (System.IO.File.Exists(fileName))
            {
                
            }
            else
            {
                StreamWriter sw = File.CreateText("warning.txt");
            sw.WriteLine("店長からのメッセージ");
            sw.Close();
            }

            

            StreamReader sr = new StreamReader(
        "warning.txt", Encoding.GetEncoding("UTF-8"));

            string text = sr.ReadToEnd();

            sr.Close();
            warningLbl.Text = text;


        }

        private void ChangeForm(MyForm myf, Button btn = null)
        {
            ChangeForm((Form)myf,btn);
        }

        private void ChangeForm(Form f,Button btn = null)
        {
            f.TopLevel = false;
            if(frameScon.Panel2.Controls.Count>0)
            frameScon.Panel2.Controls[0].Enabled = false;
            frameScon.Panel2.Controls.Clear();
            frameScon.Panel2.Controls.Add(f);
            f.Enabled = true;
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
            DisposeFrames();
            CreateFrames();
            ChangeForm(login);
        }

    }
}

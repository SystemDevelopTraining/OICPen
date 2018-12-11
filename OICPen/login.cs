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
    public partial class Login : Form
    {
        private Frame frame;
        Services.StaffService service = new Services.StaffService(new Models.OICPenDbContext());

        public Login(Frame frm)
        {
            InitializeComponent();
            frame = frm;
        }

        void login()
        {
            try
            {
                int staffId = int.Parse(staffIdTbox.Text);
                var staff = service.FindByID(staffId);
                if (staff.Password == staffPassTbox.Text)
                {
                    frame.SetUser(staff);
                    staffPassTbox.Enabled = false;
                    staffIdTbox.Enabled = false;
                    loginBtn.Enabled = false;
                    return;
                }
                MessageBox.Show("パスワードが違います", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                staffPassTbox.Focus();
                staffPassTbox.SelectAll();
            }
            catch
            {
                MessageBox.Show("該当する社員が存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            login();
        }

        private void staffPassTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                login();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            staffIdTbox.Focus();
        }
    }
}

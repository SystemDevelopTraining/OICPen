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

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int staffId = int.Parse(StaffIdTbox.Text);
                var staff = service.FindByID(staffId);
                if (staff.Password == staffPassTbox.Text)
                {
                    frame.SetUser(staff);
                    StaffIdTbox.Text = null;
                    staffPassTbox.Text = null;
                    staffPassTbox.Enabled = false;
                    StaffIdTbox.Enabled = false;
                    loginBtn.Enabled = false;
                    return;
                }
                MessageBox.Show("パスワードが違います", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("該当する社員が存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

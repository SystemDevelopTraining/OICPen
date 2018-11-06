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
    public partial class Staffs : Form
    {
        public Staffs()
        {
            InitializeComponent();
        }

        private void idTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.textBoxDigitCheck(idTbox,e);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (idTbox.Text == "" && searchNameTbox.Text == "" )
            {
                MessageBox.Show("検索内容を入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}

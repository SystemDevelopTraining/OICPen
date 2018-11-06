using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace OICPen
{
    public partial class Items : Form
    {
        public Items()
        {
            InitializeComponent();
        }

       
        private void searchItemIdTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.textBoxDigitCheck(searchItemIdTbox,e);
        }

        private void searchJanTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.textBoxDigitCheck(searchJanTbox, e);
        }

        private void purchasePriceTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.textBoxDigitCheck(purchasePriceTbox, e);
        }

        private void priceTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.textBoxDigitCheck(priceTbox, e);
        }

        private void janTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.textBoxDigitCheck(janTbox, e);
        }

        private void safetyStockTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.textBoxDigitCheck(safetyStockTbox, e);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (searchItemIdTbox.Text == "" && searchItemNameTbox.Text == "" && searchJanTbox.Text == "")
            {
                MessageBox.Show("検索内容を入力してください。", "エラー",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
           
        }
    }
}

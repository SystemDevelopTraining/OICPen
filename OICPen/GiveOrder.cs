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
    public partial class GiveOrder : Form
    {
        public GiveOrder()
        {
            InitializeComponent();
        }

        private void GiveOrder_Load(object sender, EventArgs e)
        {

        }

        //数量チェックが通ったあとの処理
        private void quanitity()
        {
            MessageBox.Show(quantityMaskedTbox.Text, "GOOD", MessageBoxButtons.OK, MessageBoxIcon.Information);
            quantityMaskedTbox.Text = null;
        }

        //数量チェック
        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (quantityMaskedTbox.Text != "")
            {
                if (int.Parse(quantityMaskedTbox.Text) >= 1000)
                {
                    DialogResult result = MessageBox.Show("1000個以上の発注になりますがよろしいですか？",
                        "質問",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button2);

                    if (result == DialogResult.No)
                    {
                        quantityMaskedTbox.Focus();
                        return;
                    }
                }
                quanitity();
            }
            else
                MessageBox.Show("数量を入力して下さい。","エラー",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void quantityMaskedTbox_Click(object sender, EventArgs e)
        {
            Utility.maskedTboxStart(quantityMaskedTbox);
        }

        private void itemIdMaskedTbox_Click(object sender, EventArgs e)
        {
            Utility.maskedTboxStart(itemIdMaskedTbox);
        }
    }
}

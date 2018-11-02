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

        private void quanitity()
        {
            MessageBox.Show(quantityMaskedTbox.Text, "GOOD", MessageBoxButtons.OK, MessageBoxIcon.Information);
            quantityMaskedTbox.Text = null;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {

            if (quantityMaskedTbox.Text != "")
            {
                if (int.Parse(quantityMaskedTbox.Text) >= 1000)
                {

                    //数量確認メッセージボックスを表示する
                    DialogResult result = MessageBox.Show("1000個以上の発注になりますがよろしいですか？",
                        "質問",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button2);

                    //何が選択されたか調べる
                    if (result == DialogResult.Yes)
                    {
                        //「はい」が選択された時
                        quanitity();
                    }
                    else
                    {
                        //「いいえ」が選択された時
                        quantityMaskedTbox.Focus();
                    }
                }
                else
                {
                    quanitity();
                }
            }
            else
            {
                //数量がNullの時
                MessageBox.Show("数量を入力して下さい。","エラー",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}

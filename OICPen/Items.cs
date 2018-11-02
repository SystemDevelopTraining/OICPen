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
    public partial class Items : Form
    {
        public Items()
        {
            InitializeComponent();
        }

      

        private void searchBtn_Click(object sender, EventArgs e)
        {














            int number;
            if (String.IsNullOrEmpty(searchItemNameTbox.Text) && String.IsNullOrEmpty(searchItemIdMaskedTbox.Text) && String.IsNullOrEmpty(searchJanMaskedTbox.Text))
            {
                MessageBox.Show("検索するのに検索条件を最低で一項目が必要です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                
            }
            
     
        
           
           
           
        }

        private void searchItemIdMaskedTbox_Click(object sender, EventArgs e)
        {
            if (searchItemIdMaskedTbox.Text=="") {
                searchItemIdMaskedTbox.Clear();
                searchItemIdMaskedTbox.SelectionStart = 0;
            }
       
        }

        private void searchJanMaskedTbox_Click(object sender, EventArgs e)
        {
            if (searchJanMaskedTbox.Text == "")
            {
                searchJanMaskedTbox.Clear();
                searchJanMaskedTbox.SelectionStart = 0;
            }
        }

        private void registBtn_Click(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(furiganaTbox.Text, @"^\p{IsHiragana}+$"))
            {
                //すべてがひらがなの場合

            }
            else
            {
                //ひらがな以外の文字が入っている場合
                MessageBox.Show("ふりがなにはひらがなのみを入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(furiganaTbox.Text, @"^\p{IsHiragana}+$"))
            {
                //すべてがひらがなの場合

            }
            else
            {
                //ひらがな以外の文字が入っている場合
                MessageBox.Show("ふりがなにはひらがなのみを入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void purchasePriceMaskedTbox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (searchItemIdMaskedTbox.Text == "")
            {
                searchItemIdMaskedTbox.Clear();
                searchItemIdMaskedTbox.SelectionStart = 0;
            }

        }
    }
}


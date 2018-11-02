﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OICPen
{
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
            searchIdMaskdTbox.PromptChar = ' ';
        }


        private void clearBtn_Click(object sender, EventArgs e)
        {
            searchIdMaskdTbox.Text = "";
            searchNameTbox.Text = "";
            searchHuriganaTbox.Text = "";
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            hiraganacheek(searchHuriganaTbox.Text);
        }

        private void registBtn_Click(object sender, EventArgs e)
        {
                       if (nullcheek(nameTbox.Text)
                            &&phonenumbercheek(phoneNumberMaskedTbox.Text)
                            &&postalcode(postalCodeMaskedTbox.Text)
                            &&nullcheek(addressTbox.Text))
                        {
                            hiraganacheek(huriganaTbox.Text);
                        }
//           MessageBox.Show(phoneNumberMaskedTbox.Text, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            hiraganacheek(huriganaTbox.Text);
        }

        private bool hiraganacheek(string text){
            //ひらがなチェック
            if (System.Text.RegularExpressions.Regex.IsMatch(text, @"^\p{IsHiragana}+$"))
            {
                //すべてがひらがなの場合
                return true;
            }
            else
            {
                //ひらがな以外の文字が入っている場合
                MessageBox.Show("ふりがなにはひらがなのみを入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool nullcheek(string text)
        {
            if (text != "")
            {
                return true;
            }

            MessageBox.Show("すべてに記入されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private bool phonenumbercheek(string text)
        {
            if (Regex.IsMatch(text, @"^\d+-\d+-\d+$"))
            {
                return true;

            }

            MessageBox.Show("電話番号が正しく記入されてません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }


        private bool postalcode(string text)
        {
            if (Regex.IsMatch(text, @"^\d+-\d+$"))
            {
                return true;

            }

            MessageBox.Show("住所が正しく記入されてません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }
}

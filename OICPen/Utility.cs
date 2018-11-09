using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OICPen
{
    //MaskedTextboxをクリックした際カーソルが先頭に行くようになる、文字が入っている場合はクリックした場所から
    static class Utility
    {
        public static void MaskedTboxStart(MaskedTextBox x)
        {
            if (x.Text == "")
                x.SelectionStart = 0;
        }

        //textBoxに半角数字しか入らないようにする
        public static void TextBoxDigitCheck(TextBox x,KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), "[0-9]") && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //textBoxが空か判断する
        public static bool TextIsEmpty(string x)
        {
           if(x == "")
            {
                return true;

            }
           return false;

        }

        
        public static string HiraganaCheck(string text)
        {
            //ひらがなチェック
            if (System.Text.RegularExpressions.Regex.IsMatch(text, @"^\p{IsHiragana}+$"))
            {
                //すべてがひらがなの場合
                return "";
            }
            else
            {
                //ひらがな以外の文字が入っている場合
                //                MessageBox.Show("ふりがなにはひらがなのみを入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "ふりがなにはひらがなのみを入力してください";
            }
        }
    }

}

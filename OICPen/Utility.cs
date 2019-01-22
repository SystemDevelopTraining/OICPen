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

        //ひらがなかどうか判断する
        public static string HiraganaCheck(string text)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(text, @"^[\p{IsHiragana}\u30FC]+$"))
            {
                return "";
            }
            else
            {
                return "ふりがなにはひらがなのみを入力してください";
            }
        }

        public static void HiraganaCheckKeyPress(TextBox x,KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"^[\p{IsHiragana}\u30FC]+$") && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static string Hash(string s)
        {
            //文字列をbyte型配列に変換する
            byte[] data = System.Text.Encoding.UTF8.GetBytes(s);

            //MD5CryptoServiceProviderオブジェクトを作成
            var md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();

            //ハッシュ値を計算する
            byte[] bs = md5.ComputeHash(data);

            //リソースを解放する
            md5.Clear();

            //byte型配列を16進数の文字列に変換
            System.Text.StringBuilder result = new System.Text.StringBuilder();
            foreach (byte b in bs)
            {
                result.Append(b.ToString("x2"));
            }
            //ここの部分は次のようにもできる
            //string result = BitConverter.ToString(bs).ToLower().Replace("-","");

            //結果を表示
            return result.ToString();
        }

    }

}

using System;
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
        private Services.ClientService servis=  new Services.ClientService(new Models.OICPenDbContext());

        public Clients()
        {
            InitializeComponent();
        }


        private void clearBtn_Click(object sender, EventArgs e)
        {
            searchIdMaskdTbox.Text = "";
            searchNameTbox.Text = "";
            searchHuriganaTbox.Text = "";
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            uint i=0;
            string[] search=new string[] { searchNameTbox.Text,searchIdMaskdTbox.Text,searchHuriganaTbox.Text };
            var ckecks = new Func<string, string>[] { (x) => "", (x) => "", HiraganaCheek };
            search.Zip(ckecks,(item,check)=> {
                if (NullCheek(item))
                {
                    i++;
                    string erroMessage = check(item);
                    if (erroMessage != "")
                        MessageBox.Show(erroMessage, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return 0;
            }).ToArray();
            if (i != 1) {
                MessageBox.Show("検索項目が１つではありません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; }
        }

        private void registBtn_Click(object sender, EventArgs e)
        {
            var client = new Models.Client();
            client.Name = nameTbox.Text;
            client.Hurigana = huriganaTbox.Text;
            client.PhoneNum = phoneNumberMaskedTbox.Text;
            client.PostNum = phoneNumberMaskedTbox.Text;
            client.Address = addressTbox.Text;
            servis.AddClient(client);
 /*                      if (NullCheek(nameTbox.Text)
                            &&PhoneNumberCheek(phoneNumberMaskedTbox.Text)
                            && PostalCodeCheek(postalCodeMaskedTbox.Text)
                            &&NullCheek(addressTbox.Text))
                        {
                            HiraganaCheek(huriganaTbox.Text);
                        }*/
//           MessageBox.Show(phoneNumberMaskedTbox.Text, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (NullCheek(nameTbox.Text)
                 && PhoneNumberCheek(phoneNumberMaskedTbox.Text)
                 && PostalCodeCheek(postalCodeMaskedTbox.Text)
                 && NullCheek(addressTbox.Text))
            {
                HiraganaCheek(huriganaTbox.Text);
            }
        }

        private string HiraganaCheek(string text){
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

        private bool NullCheek(string text)
        {
            if (text != "")
            {
                return true;
            }

            return false;
        }

        private bool PhoneNumberCheek(string text)
        {
            if (Regex.IsMatch(text, @"^\d+-\d+-\d+$"))
            {
                return true;

            }

            MessageBox.Show("電話番号が正しく記入されてません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }


        private bool PostalCodeCheek(string text)
        {
            if (Regex.IsMatch(text, @"^\d+-\d+$"))
            {
                return true;

            }

            MessageBox.Show("郵便番号が正しく記入されてません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void phoneNumberMaskedTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.KeyChar=(char)0;
        }

        private void postalCodeMaskedTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.KeyChar = (char)0;
        }

        private void searchIdMaskdTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.KeyChar = (char)0;
        }
        
    }
}

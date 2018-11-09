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
            searchIdTbox.Text = "";
            searchNameTbox.Text = "";
            searchHuriganaTbox.Text = "";
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            uint i=0; 
            string[] search=new string[] { searchNameTbox.Text,searchIdTbox.Text,searchHuriganaTbox.Text };
            var checks = new Func<string, string>[] { (x) => "", (x) => "", HiraganaCheck };
            search.Zip(checks,(item,check)=> {
                if (IsNotEmpty(item))
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
            var client = new Models.ClientT();
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
            if (IsNotEmpty(nameTbox.Text)
                 && PhoneNumberCheck(phoneNumberMaskedTbox.Text)
                 && PostalCodeCheck(postalCodeMaskedTbox.Text)
                 && IsNotEmpty(addressTbox.Text))
            {
                HiraganaCheck(huriganaTbox.Text);
            }
        }

        private string HiraganaCheck(string text){
            if (System.Text.RegularExpressions.Regex.IsMatch(text, @"^\p{IsHiragana}+$"))
            {
                return "";
            }
            else
            {
                return "ふりがなにはひらがなのみを入力してください";
            }
        }

        private bool IsNotEmpty(string text)
        {
            if (text != "")
            {
                return true;
            }

            return false;
        }

        private bool PhoneNumberCheck(string text)
        {
            if (Regex.IsMatch(text, @"^\d+-\d+-\d+$"))
            {
                return true;

            }

            MessageBox.Show("電話番号が正しく記入されてません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }


        private bool PostalCodeCheck(string text)
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
                e.KeyChar = (char)0;
            Utility.MaskedTboxStart(phoneNumberMaskedTbox);

        }

        private void postalCodeMaskedTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.KeyChar = (char)0;
          
        }

  
        private void searchIdTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxDigitCheck(searchIdTbox,e);
        }

        private void phoneNumberMaskedTbox_Click(object sender, EventArgs e)
        {
            phoneNumberMaskedTbox.SelectionStart = 0;
        }

        private void postalCodeMaskedTbox_Click(object sender, EventArgs e)
        {
            postalCodeMaskedTbox.SelectionStart = 0;
        }

        private void Clients_Shown(object sender, EventArgs e)
        {
            DataShow();
        }

        private void DataShow()
        {
            clientsDgv.Rows.Clear();
            var dgv = clientsDgv;
            var clients = servis.GetClients();
            foreach (var x in clients)
            {
                dgv.Rows.Add(x.ClientTID, x.Name, x.Hurigana, x.Address, x.PostNum, x.PhoneNum);
            }
        }

    }
}

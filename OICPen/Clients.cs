﻿using OICPen.Models;
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
            DataShow();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            uint i=0,currentIndex=0;
            string erroMessage ="";
            string[] search=new string[] { searchNameTbox.Text,searchIdTbox.Text,searchHuriganaTbox.Text };
            var checks = new Func<string, string>[] { (x) => "", (x) => "", Utility.HiraganaCheck };
            for (uint ii = 0; ii < search.Count(); ii++) {
                if (!Utility.TextIsEmpty(search[ii]))
                {
                    i++;
                    currentIndex = ii;
                    var msg = checks[ii](search[ii]);
                    erroMessage += msg == "" ? msg : msg + "\r\n";
                }
            };
            if (i != 1)
                erroMessage+="検索項目が１つではありません";
            if (erroMessage != "")
            {
                MessageBox.Show(erroMessage, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var clients = servis.GetClients();
            switch (currentIndex)
            {
                case 0:
                    clients = servis.FindByName(searchNameTbox.Text);
                    break;
                case 1:
                    try
                    {
                        clients = new List<ClientT>(new ClientT[] { servis.FindByID(int.Parse(searchIdTbox.Text)) });
                    }
                    catch { return; }
                    break;
                case 2:
                    clients = servis.FindByName(searchHuriganaTbox.Text);
                    break;
            }
            DataShow(clients);
        }

        private void registBtn_Click(object sender, EventArgs e)
        {
            string erroMessage = "";
/*            var checks = new Func<string,bool>[] {Utility.TextIsEmpty,
                 PhoneNumberCheck,
                 PostalCodeCheck,
                Utility.TextIsEmpty};*/
            if (!Utility.TextIsEmpty(nameTbox.Text)
                && PhoneNumberCheck(phoneNumberMaskedTbox.Text)
                && PostalCodeCheck(postalCodeMaskedTbox.Text)
                &&!Utility.TextIsEmpty(addressTbox.Text))
            {
                 if((erroMessage = Utility.HiraganaCheck(huriganaTbox.Text)) == "")
                {
                    servis.AddClient(TextToClient());
                }
                else
                {
                    MessageBox.Show(erroMessage, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            DataShow();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string erroMessage = "";
            if (!Utility.TextIsEmpty(nameTbox.Text)
                && PhoneNumberCheck(phoneNumberMaskedTbox.Text)
                && PostalCodeCheck(postalCodeMaskedTbox.Text)
                && !Utility.TextIsEmpty(addressTbox.Text))
            {
                if ((erroMessage = Utility.HiraganaCheck(huriganaTbox.Text)) == "")
                {
                    int idNumber = 0;
                    if (int.TryParse(idDispLbl.Text, out idNumber)) {
                        var client = TextToClient();
                        client.ClientTID = int.Parse(idNumber.ToString());
                        servis.UpdateItem(client);
                    }
                    else
                    {
                        MessageBox.Show("会員を選択しないままの更新はできません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(erroMessage, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            DataShow();
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

        private void DataShow(List<ClientT> clients)
        {
            clientsDgv.Rows.Clear();
            var dgv = clientsDgv;
            foreach (var x in clients)
            {
                dgv.Rows.Add(x.ClientTID, x.Name, x.Hurigana, x.Address, x.PostNum, x.PhoneNum);
            }
        }

        private ClientT TextToClient()
        {
            var client = new ClientT();
            client.Name = nameTbox.Text;
            client.Hurigana = huriganaTbox.Text;
            client.PhoneNum = phoneNumberMaskedTbox.Text;
            client.PostNum = postalCodeMaskedTbox.Text;
            client.Address = addressTbox.Text;
            return client;
        }

        private void clientsDgv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var client = new ClientT();
            if (clientsDgv.SelectedRows.Count == 0) return;
            var cells = clientsDgv.SelectedRows[0].Cells;
            idDispLbl.Text = cells[0].Value.ToString();
            nameTbox.Text = cells[1].Value.ToString();
            huriganaTbox.Text = cells[2].Value.ToString();
            phoneNumberMaskedTbox.Text = cells[5].Value.ToString();
            postalCodeMaskedTbox.Text = cells[4].Value.ToString();
            addressTbox.Text = cells[3].Value.ToString();
        }

        private void histroryViewBtn_Click(object sender, EventArgs e)
        {
            int idNumber = 0;
            if (int.TryParse(idDispLbl.Text, out idNumber))
            {
                var f = new ClientPurchaseHistory(servis.FindByID(int.Parse(idNumber.ToString())));
                f.Show(this);
            }
            else
            {
                MessageBox.Show("会員を選択しないままの表示はできません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

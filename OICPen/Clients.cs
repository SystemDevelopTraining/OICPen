﻿using OICPen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace OICPen
{
    public partial class Clients : Form,MyForm
    {
        private Services.ClientService servis;

        public Clients(Models.OICPenDbContext dbcontext)
        {
            servis = new Services.ClientService(dbcontext);
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
            List<ClientT> clients = null;
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
                    catch { DataShow(new List<ClientT>()); return; }
                    break;
                case 2:
                    clients = servis.FindByHurigana(searchHuriganaTbox.Text);
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
                && PhoneNumberCheck(phoneNumberTbox.Text)
                && PostalCodeCheck(postalCodeMTbox.Text)
                && !Utility.TextIsEmpty(addressTbox.Text))
            {
                if ((erroMessage = Utility.HiraganaCheck(huriganaTbox.Text)) == "")
                {
                    servis.AddClient(TextToClient());
                    DataShow();
                    addressTbox.Text = "";
                    huriganaTbox.Text = "";
                    nameTbox.Text = "";
                    phoneNumberTbox.Text = "";
                    postalCodeMTbox.Text = "";
                    MessageBox.Show("登録しました", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(erroMessage, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                //  DataShow();
                MessageBox.Show("入力されていない項目があります。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string erroMessage = "";
            if (   !Utility.TextIsEmpty(nameTbox.Text)
                && PhoneNumberCheck(phoneNumberTbox.Text)
                && PostalCodeCheck(postalCodeMTbox.Text)
                && !Utility.TextIsEmpty(addressTbox.Text))
            {

                if ((erroMessage = Utility.HiraganaCheck(huriganaTbox.Text)) == "")
                {
                    int idNumber = 0;
                    if (int.TryParse(idDispLbl.Text, out idNumber))      
                    {
                        var client = TextToClient();
                        client.ClientTID = int.Parse(idNumber.ToString());
                        servis.UpdateItem(client);

                        DataShow();
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
            else
            {
                
                MessageBox.Show("入力されていない項目があります。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
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
     
       
        private void postalCodeMaskedTbox_Click(object sender, EventArgs e)
        {
            postalCodeMTbox.SelectionStart = 0;
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
                dgv.Rows.Add(x.ClientTID, x.Name, x.Hurigana,  x.PhoneNum,x.PostNum, x.Address);
            }
        }

        private void DataShow(List<ClientT> clients)
        {
            clientsDgv.Rows.Clear();
            var dgv = clientsDgv;
            foreach (var x in clients)
            {
                dgv.Rows.Add(x.ClientTID, x.Name, x.Hurigana,  x.PhoneNum,x.PostNum,x.Address );
            }
        }

        private ClientT TextToClient()
        {
            var client = new ClientT();
            client.Name = nameTbox.Text;
            client.Hurigana = huriganaTbox.Text;
            client.PhoneNum = phoneNumberTbox.Text;
            client.PostNum = postalCodeMTbox.Text;
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
            phoneNumberTbox.Text = cells[3].Value.ToString();
            postalCodeMTbox.Text = cells[4].Value.ToString();
            addressTbox.Text = cells[5].Value.ToString();
        }

        private void historyViewBtn_Click(object sender, EventArgs e)
        {
            int idNumber = 0;
            if (int.TryParse(idDispLbl.Text, out idNumber))
            {
                var f = new ClientPurchaseHistory(servis.FindByID(int.Parse(idNumber.ToString())));
                f.ShowDialog();

            }
            else
            {
                MessageBox.Show("会員を選択しないままの表示はできません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public StaffT Staff
        {
            set
            {
                if (value.Permission != Permission.God
                    && value.Permission != Permission.ClientControl)
                {
                    registBtn.Enabled = false;
                    updateBtn.Enabled = false;
                }
                else
                {
                    registBtn.Enabled = true;
                    updateBtn.Enabled = true;
                }
            }
        }

        private void phoneNumberTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.KeyChar = (char)0;
            if (phoneNumberTbox.Text == "")
                phoneNumberTbox.SelectionStart = 0;
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            searchNameTbox.Focus();
        }
        private void postalCodeMaskedTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.KeyChar = (char)0;
        }

        private void searchIdTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.AlphaMode(searchIdTbox,e);
            Utility.TextBoxDigitCheck(searchIdTbox, e);
        }

        private void searchIdTbox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Utility.AlphaMode(searchIdTbox,e);
            Utility.TextBoxDigitCheck(searchIdTbox, e);
        }

        private void huriganaTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.HiraganaMode(huriganaTbox,e);
            Utility.HiraganaCheckKeyPress(huriganaTbox, e);
        }

        private void searchHuriganaTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.HiraganaMode(searchHuriganaTbox,e);
            Utility.HiraganaCheckKeyPress(searchHuriganaTbox, e);
        }

        private void searchNameTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.HiraganaMode(searchNameTbox, e);
        }

        private void nameTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.HiraganaMode(nameTbox,e);
        }

        private void phoneNumberTbox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Utility.AlphaMode(phoneNumberTbox,e);
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"^[0-9\-]+$") && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void addressTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.HiraganaMode(addressTbox,e);        }
    }
}

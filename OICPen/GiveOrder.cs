﻿using System;
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
       // private Services.StockService stockServis = new Services.StockService(new Models.OICPenDbContext());
        private Services.ItemService itemServis = new Services.ItemService(new Models.OICPenDbContext());

        public GiveOrder()
        {
            InitializeComponent();
        }

        private void GiveOrder_Load(object sender, EventArgs e)
        {
            foreach (var item in itemServis.GetAllItems())
            {
                itemsViewDgv.Rows.Add(item.ItemTID,item.Name,"0");//在庫表示未完成
            }
        }

        //数量チェック
        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (quantityTbox.Text != "")
            {
                if (int.Parse(quantityTbox.Text) >= 1000)
                {
                    DialogResult result = MessageBox.Show("1000個以上の発注になりますがよろしいですか？",
                        "質問",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button2);

                    if (result == DialogResult.No)
                    {
                        quantityTbox.Focus();
                        return;
                    }
                }
                quantityTbox.Text = null;
            }
            else
                MessageBox.Show("数量を入力して下さい。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void itemIdTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxDigitCheck(itemIdTbox, e);
        }

        private void quantityTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxDigitCheck(quantityTbox,e);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (itemNameTbox.Text == "" && itemIdTbox.Text == "")
            {
                MessageBox.Show("検索内容を入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

      
    }
}

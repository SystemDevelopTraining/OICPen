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
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }

        private void itemsCodeTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxDigitCheck(itemsCodeTbox,e);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (itemsCodeTbox.Text == "" && itemsNameTbox.Text == "")
            {
                MessageBox.Show("検索内容を入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}

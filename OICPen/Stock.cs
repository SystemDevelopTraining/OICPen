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
    public partial class Stock : Form
    {
        private Services.StockService servis = new Services.StockService(new Models.OICPenDbContext());

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
            else
                
            {
                stockDgv.Rows.Clear();
                foreach (var stock in servis.GetAllStocks())
                {

                    if (itemsCodeTbox.Text == stock.ItemTID.ToString() || itemsNameTbox.Text == stock.ItemT.Name)
                    {
                        stockDgv.Rows.Add(stock.Date, stock.ItemTID, stock.ItemT.Name, stock.Quantity);
                    }
                }
            }
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            foreach (var stock in servis.GetAllStocks())
            {
                stockDgv.Rows.Add(stock.Date,stock.ItemTID,stock.ItemT.Name,stock.Quantity);
              
            }
        }
    }
}
           


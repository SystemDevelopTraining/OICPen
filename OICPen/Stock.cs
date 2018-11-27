using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;


namespace OICPen
{
    public partial class Stock : Form
    {
        private Services.StockService servis ;

        public Stock(Models.OICPenDbContext dbcontext)
        {
            InitializeComponent();
            servis = new Services.StockService(dbcontext);
        }

        private void itemsCodeTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxDigitCheck(itemsCodeTbox,e);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

            uint i = 0;
            string errorMessage = "";
            string[] search = new string[] { itemsCodeTbox.Text, itemsNameTbox.Text };
            var checks = new Func<string, string>[] { (x) => "", (x) => "" };
            search.Zip(checks, (item, check) =>
            {
                if (!Utility.TextIsEmpty(item))
                {
                    i++;
                    var msg = check(item);
                    errorMessage += msg == "" ? msg : msg + "\r\n";
                }
                return 0;
            }).ToArray();
            if (i != 1)
                errorMessage += "検索項目が１つではありません";
            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (itemsCodeTbox.Text != "" && itemsNameTbox.Text == "")
            {
                stockDgv.Rows.Clear();
                try
                {
                    var stock = service.FindByID(int.Parse(itemsCodeTbox.Text));
                    stockDgv.Rows.Add(stock.ItemTID, stock.Name, service.NowStock(stock));
                }
                catch
                {

                }
            }
            else
            {
                stockDgv.Rows.Clear();
                try
                {
                    var items = service.FindByName(itemsNameTbox.Text);
                    foreach (var item in items)
                    {
                        stockDgv.Rows.Add(item.ItemTID, item.Name, service.NowStock(item));

                    }
                }
                catch
                {

                }
            }
        }
      

        private void Stock_Load(object sender, EventArgs e)
        {
            stockDgv.Rows.Clear();
            foreach (var item in service.GetAllItems())
            {
                stockDgv.Rows.Add(item.ItemTID, item.Name, service.NowStock(item));

            }
        }

        private void stockViewBtn_Click(object sender, EventArgs e)
        {
            stockDgv.Rows.Clear();
            foreach (var item in service.GetAllItems())
            {
                stockDgv.Rows.Add(item.ItemTID, item.Name, service.NowStock(item));

            }
        }

        private void stockDangerViewBtn_Click(object sender, EventArgs e)
        {
            stockDgv.Rows.Clear();
            foreach (var item in service.GetAllItems())
            {
                if (service.NowStock(item) < item.SafetyStock)
                {
                    stockDgv.Rows.Add(item.ItemTID, item.Name, service.NowStock(item));
                }
            }
        }
    }
}

           


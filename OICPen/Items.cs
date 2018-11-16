using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace OICPen
{
    public partial class Items : Form
    {
        private Services.ItemService service = new Services.ItemService(new Models.OICPenDbContext());

        public Items()
        {
            InitializeComponent();
        }

       
        private void searchItemIdTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxDigitCheck(searchItemIdTbox,e);
        }

        private void searchJanTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxDigitCheck(searchJanTbox, e);
        }

        private void purchasePriceTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxDigitCheck(purchasePriceTbox, e);
        }

        private void priceTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxDigitCheck(priceTbox, e);
        }

        private void janTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxDigitCheck(janTbox, e);
        }

        private void safetyStockTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxDigitCheck(safetyStockTbox, e);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var items = new string[] { searchItemIdTbox.Text, searchItemNameTbox.Text, searchJanTbox.Text };
            var processes = new Action[]
            {
                //IDでの検索
                () =>
                {
                    itemDgv.Rows.Add(service.FindByID(int.Parse(searchItemIdTbox.Text)));
                },
                //名前での検索
                () =>
                {
                    itemDgv.Rows.Add(service.FindByName(searchItemNameTbox.Text));
                },
                //JANコードでの検索
                () =>
                {
                    itemDgv.Rows.Add(service.FindByJAN(searchJanTbox.Text));
                }

            };

            uint itemCount = 0;
            uint currentIndex = 0;
            for(uint i = 0; i < items.Length; i++)
            {
                if (items[i] != "")
                {
                    i++;
                    currentIndex = i;
                }
            }

            if (itemCount != 1)
            {
                MessageBox.Show("検索項目が一つではありません", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                processes[currentIndex]();
            }

        }

        private void registBtn_Click(object sender, EventArgs e)
        {
            Models.ItemT item = new Models.ItemT();
            item.Name = "お芋";
            item.Hurigana = "おいも";
            item.JAN = "111111111111";
            item.PurchasePrice = 1000;
            item.Price = 1080;
            item.IsDeleted = false;
            item.SafetyStock = 70;
            item.RegistDate = DateTime.Now;
            item.Note = "おいしい";


            service.AddItem(item);
            itemDgv.Rows.Add(service.GetItems());
        }

        private void ShowDgv(List<Models.ItemT>)
        {
            //Todo
        }

        
    }
}

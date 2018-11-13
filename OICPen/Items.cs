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
using OICPen.Services;

namespace OICPen
{
    public partial class Items : Form
    {

        private Services.ItemService service=new Services.ItemService(new Models.OICPenDbContext());

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

        void SetDataGridView(List<Models.ItemT> items)
        {
            itemDgv.Rows.Clear();
            items.ForEach(item => {
                itemDgv.Rows.Add(item.Name, item.JAN, item.Price, item.PurchasePrice, item.SafetyStock, item.Hurigana, item.RegistDate, item.Note, item.IsDeleted);
            });
        } 

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var items = new string[] { searchItemIdTbox.Text, searchItemNameTbox.Text, searchJanTbox.Text };
            var processes = new Action[]
            {
                //IDでの検索
                () =>
                {

                },
                //名前での検索
                () =>
                {
                    
                },
                //JANコードでの検索
                () =>
                {
                    
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
            item.Name = itemNameTbox.Text;
            item.JAN = janTbox.Text;
            item.Price = uint.Parse(priceTbox.Text);
            item.PurchasePrice = uint.Parse(purchasePriceTbox.Text);
            item.SafetyStock = uint.Parse(safetyStockTbox.Text);
            item.Hurigana = furiganaTbox.Text;
            item.RegistDate = DateTime.Now;
            item.Note = noteTbox.Text;
            item.IsDeleted = false;
            service.AddItem(item);
            SetDataGridView(service.GetAllItems());
        }

        private void itemsUpdateBtn_Click(object sender, EventArgs e)
        {
            SetDataGridView(service.GetAllItems());
        }
    }
}

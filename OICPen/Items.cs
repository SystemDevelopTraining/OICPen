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

        private Services.ItemService service;

        public Items(Models.OICPenDbContext dbcontext)
        {
            service = new Services.ItemService(dbcontext);
            InitializeComponent();
            SetDataGridView(service.GetItems());
        }

        public Models.StaffT Staff
        {
            set
            {
                if(value.Permission != Models.Permission.ProductControl && value.Permission != Models.Permission.God)
                {
                    registBtn.Enabled = false;
                    updateBtn.Enabled = false;
                    deleteBtn.Enabled = false;
                }else
                {
                    registBtn.Enabled = true;
                    updateBtn.Enabled = true;
                    deleteBtn.Enabled = true;
                }
            }
        }

        /*バリエーションチェック*/
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
            if (Regex.IsMatch(purchasePriceTbox.Text, @"^0+"))
                purchasePriceTbox.Text = "";

        }

        private void priceTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxDigitCheck(priceTbox, e);
            if (Regex.IsMatch(priceTbox.Text, @"^0+"))
                priceTbox.Text="";
        }

        private void janTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxDigitCheck(janTbox, e);
        }

        private void safetyStockTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxDigitCheck(safetyStockTbox, e);
        }

        /*データグリッドビューセット*/
        void SetDataGridView(List<Models.ItemT> items)
        {
            itemDgv.Rows.Clear();
            items.ForEach(item => {
                itemDgv.Rows.Add(
                    item.ItemTID,
                    item.Name,
                    item.Hurigana,
                    item.PurchasePrice,
                    item.Price,
                    item.JAN,
                    item.SafetyStock,
                    item.Note,
                    item.RegistDate);
            });
        } 

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var items = new string[] { searchItemIdTbox.Text, searchItemNameTbox.Text, searchJanTbox.Text };
            var processes = new Func<List<Models.ItemT>>[]
            {
                //IDでの検索
                () =>
            new List<Models.ItemT>(
                        new Models.ItemT[] { service.FindByID(int.Parse(searchItemIdTbox.Text)) }
                    ),
                //名前での検索
                () =>
                    service.FindByName(searchItemNameTbox.Text)
                ,
                //JANコードでの検索
                () =>
                   new List<Models.ItemT>(
                        new Models.ItemT[] { service.FindByJAN(searchJanTbox.Text) }
                    )

            };

            uint itemCount = 0;
            uint currentIndex = 0;
            for(uint i = 0; i < items.Length; i++)
            {
                if (items[i] != "")
                {
                    itemCount++;
                    currentIndex = i;
                }
            }

            if (itemCount != 1)
            {
                MessageBox.Show("検索項目が一つではありません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                try
                {
                    SetDataGridView(processes[currentIndex]());
                }
                catch
                {
                    SetDataGridView(new List<Models.ItemT>());
                }
            }
        }

        /*テキストボックスからItemTを生成する*/
        Models.ItemT TextboxToItemT()
        {
            var item = new Models.ItemT();
            item.Name = itemNameTbox.Text;
            item.JAN = janTbox.Text;
            item.Price = int.Parse(priceTbox.Text);
            item.PurchasePrice = int.Parse(purchasePriceTbox.Text);
            item.SafetyStock = int.Parse(safetyStockTbox.Text);
            item.Hurigana = furiganaTbox.Text;
            item.RegistDate = DateTime.Now;
            item.Note = noteTbox.Text;
            return item;
        }

        /*選択中の行からItemTを生成する*/
        Models.ItemT DgvToItemT()
        {
            var item = new Models.ItemT();
            if (itemDgv.SelectedRows.Count == 0) return null;
            var cells = itemDgv.SelectedRows[0].Cells;
            item.ItemTID = int.Parse(cells[0].Value.ToString());
            item.Name = cells[1].Value.ToString();
            item.Hurigana = cells[2].Value.ToString();
            item.PurchasePrice = int.Parse(cells[3].Value.ToString());
            item.Price = int.Parse(cells[4].Value.ToString());
            item.JAN = cells[5].Value.ToString();
            item.SafetyStock = int.Parse(cells[6].Value.ToString());
            item.Note = cells[7].Value.ToString();
            item.RegistDate = (DateTime)cells[8].Value;
            return item;
        }

        /*商品登録*/
        private void registBtn_Click(object sender, EventArgs e)
        {
            string errorMessage = "";
            if (!Utility.TextIsEmpty(itemNameTbox.Text)
                && !Utility.TextIsEmpty(purchasePriceTbox.Text)
                && !Utility.TextIsEmpty(priceTbox.Text)
                && !Utility.TextIsEmpty(janTbox.Text)
                && !Utility.TextIsEmpty(safetyStockTbox.Text))
            {
                if ((errorMessage = Utility.HiraganaCheck(furiganaTbox.Text)) == "")
                {
                    service.AddItem(TextboxToItemT());
                    SetDataGridView(service.GetItems());
                    TextboxDelete();
                }
            }
            else
            {
                errorMessage += "設定されていない項目があります";
            }
            if (errorMessage != "") MessageBox.Show(errorMessage, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /*商品一覧更新*/
        private void itemsUpdateBtn_Click(object sender, EventArgs e)
        {
            SetDataGridView(service.GetItems());
        }

        /*行選択*/
        private void itemDgv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var item = DgvToItemT();
            if (item==null) return; 
            itemNameTbox.Text = item.Name;
            furiganaTbox.Text = item.Hurigana;
            purchasePriceTbox.Text = item.PurchasePrice.ToString();
            priceTbox.Text = item.Price.ToString();
            janTbox.Text = item.JAN;
            safetyStockTbox.Text = item.SafetyStock.ToString();
            noteTbox.Text = item.Note;
        }

        /*商品更新*/
        private void updateBtn_Click(object sender, EventArgs e)
        {
            var dgvItem = DgvToItemT();
            if (dgvItem == null) return;
            string errorMessage = "";
            if (!Utility.TextIsEmpty(itemNameTbox.Text)
                && !Utility.TextIsEmpty(furiganaTbox.Text)
                && !Utility.TextIsEmpty(purchasePriceTbox.Text)
                && !Utility.TextIsEmpty(priceTbox.Text)
                && !Utility.TextIsEmpty(janTbox.Text)
                && !Utility.TextIsEmpty(safetyStockTbox.Text))
            {
                if ((errorMessage = Utility.HiraganaCheck(furiganaTbox.Text)) == "")
                {
                    var item = TextboxToItemT();
                    item.ItemTID = dgvItem.ItemTID;
                    item.RegistDate = dgvItem.RegistDate;
                    service.UpdateItem(item);
                    SetDataGridView(service.GetItems());
                }
            }
            else
            {
                errorMessage += "設定されていない項目があります";
            }
            if (errorMessage != "") MessageBox.Show(errorMessage, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /*商品の削除*/
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult m = MessageBox.Show("削除してもよろしいですか。", "注意", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (m == DialogResult.OK)
            {
                var dgvItem = DgvToItemT();
                if (dgvItem == null) return;
                service.DeleteItem(dgvItem.ItemTID);
                SetDataGridView(service.GetItems());
                TextboxDelete();
            }
        }
        
        private void furiganaTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.HiraganaCheckKeyPress(furiganaTbox, e);
        }

        /*テキストボックスを削除する*/
        private void TextboxDelete()
        {
            itemNameTbox.Text="";
            janTbox.Text="";
            priceTbox.Text="";
            purchasePriceTbox.Text="";
            safetyStockTbox.Text="";
            furiganaTbox.Text="";
            noteTbox.Text="";
        }
    }
}

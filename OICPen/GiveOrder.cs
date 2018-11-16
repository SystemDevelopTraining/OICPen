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
    public partial class GiveOrder : Form
    {
       // private Services.StockService stockServis = new Services.StockService(new Models.OICPenDbContext());
        private Services.ItemService itemServis = new Services.ItemService(new Models.OICPenDbContext());
        private Services.GiveOrderService orderServis  = new Services.GiveOrderService(new Models.OICPenDbContext());

        public GiveOrder()
        {
            InitializeComponent();
        }

        private void GiveOrder_Load(object sender, EventArgs e)
        {
            SetDataGridView(itemServis.GetAllItems());
            
        }

        //数量チェック
        private void confirmBtn_Click(object sender, EventArgs e)
        {
          
          // giveOrderListDgv.Rows.Add(itemsViewDgv.SelectedRows[0].Cells[0].Value, itemsViewDgv.SelectedRows[0].Cells[1].Value,quantityTbox.Text);
           


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
                        giveOrderListDgv.Rows.Add(itemsViewDgv.SelectedRows[0].Cells[0].Value, itemsViewDgv.SelectedRows[0].Cells[1].Value, quantityTbox.Text);

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

        private void allItemBtn_Click(object sender, EventArgs e)
        {
            SetDataGridView(itemServis.GetAllItems());
        }


        private void searchBtn_Click(object sender, EventArgs e)
        {

            var items = new string[] { itemNameTbox.Text, itemIdTbox.Text};
            var processes = new Func<List<Models.ItemT>>[]
            {

                 //名前での検索
                () =>
                    itemServis.FindByName(itemNameTbox.Text),
                
                //IDでの検索
                () =>
                    new List<Models.ItemT>(
                        new Models.ItemT[] { itemServis.FindByID(int.Parse(itemIdTbox.Text)) }
                    )
               
            };


            uint itemCount = 0;
            uint currentIndex = 0;
            for (uint i = 0; i < items.Length; i++)
            {
                if (items[i] != "")
                {
                    itemCount++;
                    currentIndex = i;
                }
            }

            if (itemCount != 1)
            {
                MessageBox.Show("検索項目が一つではありません", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SetDataGridView(processes[currentIndex]());
                }
                catch
                {

                }
            }

        }


        /*データグリッドビューセット*/
        void SetDataGridView(List<Models.ItemT> items)
        {
            itemsViewDgv.Rows.Clear();
            items.ForEach(item =>
            {
                itemsViewDgv.Rows.Add(
                    item.ItemTID,
                    item.Name,
                    "0");//在庫表示未完成
            });
            
        }

        
    }
}

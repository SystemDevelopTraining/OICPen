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
        private Services.StaffService staffServis = new Services.StaffService(new Models.OICPenDbContext());
        private Services.ItemService itemServis = new Services.ItemService(new Models.OICPenDbContext());
        private Services.GiveOrderService orderServis  = new Services.GiveOrderService(new Models.OICPenDbContext());
        private Services.GiveOrderDetailService orderDetailServis = new Services.GiveOrderDetailService(new Models.OICPenDbContext());
        private Models.StaffT staff;
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
            if (quantityTbox.Text != "" && int.Parse(quantityTbox.Text) !=0)
            {
               
                if (int.Parse(quantityTbox.Text) >= 1000)
                {
                    DialogResult result = MessageBox.Show("1000個以上の発注になりますがよろしいですか？","警告",
                                          MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button2);

                    if (result == DialogResult.No)
                    {
                        
                        quantityTbox.Focus();
                        return;
                    }
                }
                        //検索結果DataGridViewのitemから発注リストDataGridViewに表示される
                        giveOrderListDgv.Rows.Add(itemsViewDgv.SelectedRows[0].Cells[0].Value, itemsViewDgv.SelectedRows[0].Cells[1].Value,int.Parse(quantityTbox.Text));

                quantityTbox.Text = null;
            }
            else
                MessageBox.Show("数量を入力して下さい。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    quantityTbox.Text = null;
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
                    new List<Models.ItemT>
                    (
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
                MessageBox.Show("検索項目が一つではありません", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        private void clearBtn_Click(object sender, EventArgs e)
        {
           if (giveOrderListDgv.SelectedRows.Count == 0) return;
            
            DialogResult result = MessageBox.Show("選択された行を削除します","警告",MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                giveOrderListDgv.Rows.RemoveAt(giveOrderListDgv.SelectedRows[0].Index);
            }
       
        }

        private void allClearBtn_Click(object sender, EventArgs e)
        {
            if (giveOrderListDgv.SelectedRows.Count == 0) return;
            DialogResult result = MessageBox.Show("発注リストを削除します", "警告", MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
                giveOrderListDgv.Rows.Clear();
        }

        private void completeBtn_Click(object sender, EventArgs e)
        {
            if (giveOrderListDgv.SelectedRows.Count == 0) return;

            var addGiverOrderItem = new Models.GiveOrderT
            {
                GiveOrdDate = DateTime.Now,//発注日
                StaffTID = 1,//社員ID(未完成)
            };

            var giveOrderId = orderServis.AddGiveOrderst(addGiverOrderItem).GiveOrderTID;
            var Controls = new Control[] { itemIdTbox,itemNameTbox,quantityTbox };
            foreach(var value in Controls)
            {
                value.ResetText();
            }
            itemsViewDgv.Rows.Clear();
           SetDataGridView(itemServis.GetAllItems());

            foreach(DataGridViewRow row in giveOrderListDgv.Rows)
            {
                var itemId = Convert.ToInt32(row.Cells[0].Value.ToString());
                var itemName = row.Cells[1].Value;
                var quantity = Convert.ToInt32(row.Cells[2].Value.ToString());

                var addGiveOrder = new Models.GiveOrderDetailT
                {
                    GiveOrderTID = giveOrderId,
                    ItemTID = itemId,
                    Quantity = quantity,
                };
                orderDetailServis.AddGiveOrderDetail(addGiveOrder);

            }

            //orderServis.AddGiveOrderst(addGiverOrderItem);

            MessageBox.Show("発注完了しました。","警告");
            giveOrderListDgv.Rows.Clear();

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

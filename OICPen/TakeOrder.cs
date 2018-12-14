using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OICPen.Models;
using System.Collections;

namespace OICPen
{
    public partial class TakeOrder : Form
    {
        private Models.StaffT staff;
        private Services.TakeOrderService servis;
        private Services.ClientService clientservis;
        private Services.ItemService itemservis;
        private Services.TakeOrderDetailService takeorderdetailservice;
        public StaffT Staff
        {
            set
            {
                staff = value;
            }
        }

        //private Services.TakeOrderDetailService takeOrderService = new Services.TakeOrderDetailService(new Models.OICPenDbContext());
        public TakeOrder(OICPenDbContext dbcontext)
        {
            servis = new Services.TakeOrderService(dbcontext);
            clientservis = new Services.ClientService(dbcontext);
            itemservis = new Services.ItemService(dbcontext);
            takeorderdetailservice = new Services.TakeOrderDetailService(dbcontext);
            InitializeComponent();
        }

        private void CompleteOrdersDgvClear()
        {
            completeOrdersDgv.Rows.Clear();
            ComputeTotalPrice();
        }

        private void clientsIdCheckBtn_Click(object sender, EventArgs e)
        {
            if (completeOrdersDgv.Rows.Count != 0)
            {

                DialogResult m = MessageBox.Show("会員IDは変更しますが注文もクリアしますか？", "注意", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);

                if (m == DialogResult.Cancel)
                    return;
                else if (m == DialogResult.Yes)
                    CompleteOrdersDgvClear();
            }

            bool found = false; //clientが確認できなかったらMessageBoxを表示するのに利用される。
            foreach (var client in clientservis.GetClients())
            {
                if (clientsIdTbox.Text == client.ClientTID.ToString())
                {
                    clientsIdViewLbl.Text = client.ClientTID.ToString();
                    clientsNameViewLbl.Text = client.Name;
                    clientsPhoneNoViewLbl.Text = client.PhoneNum;
                    found = true;
                }
            }
            if (found == false)
            {
                MessageBox.Show("入力されたIDは存在しません。もう一度確認の上入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var Controls = new Control[] { itemsViewDgv, completeOrdersDgv, itemNameTbox, itemIdTbox, searchBtn, countsTbox, confirmBtn, allItemBtn, itemsViewDgv, completeOrdersDgv };
                foreach (var i in Controls)
                {
                    i.Enabled = true;
                }
            }
        }

        private void clientsIdTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxDigitCheck(clientsIdTbox, e);
        }

        private void itemIdTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxDigitCheck(itemIdTbox, e);
        }

        void SetDataGridView(List<Models.ItemT> items)
        {
            itemsViewDgv.Rows.Clear();
            items.ForEach(item =>
            {
                itemsViewDgv.Rows.Add(
                    item.ItemTID,
                    item.Name,
                    item.SafetyStock,
                    item.Price
                    );
            });
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var items = new string[] { itemNameTbox.Text, itemIdTbox.Text };
            var processes = new Func<List<Models.ItemT>>[]
            {
                 //名前での検索
                () =>
                   itemservis.FindByName(itemNameTbox.Text)
                ,
                //IDでの検索
                () =>
                    new List<Models.ItemT>(
                        new Models.ItemT[] { itemservis.FindByID(int.Parse(itemIdTbox.Text)) }
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
                MessageBox.Show("検索項目が一つではありません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void TakeOrder_Load(object sender, EventArgs e)
        {
            clientsIdTbox.Focus();
            SetDataGridView(itemservis.GetAllItems());
        }

        //注文明細の合計金額設定
        private void ComputeTotalPrice()
        {
            var value =
                completeOrdersDgv.Rows.Cast<DataGridViewRow>()
                .Aggregate(0, (acc, row) => acc + int.Parse(row.Cells[4].Value.ToString())
            );
            totalPriceLbl.Text = "合計:"+value+ "円";
        }

        //DGVから注文明細一覧に注文IDを付与して取得する
        private TakeOrderDetailT[] GetTakeOrderDetailTFromDgv(int takeOrderId = 0)
        {
            return completeOrdersDgv.Rows.Cast<DataGridViewRow>().Select(row =>
            {
                var itemId = int.Parse(row.Cells[0].Value.ToString());
                var itemName = row.Cells[1].Value;
                var quantity = int.Parse(row.Cells[2].Value.ToString());

                return new TakeOrderDetailT
                {
                    TakeOrderTID = takeOrderId,
                    ItemTID = itemId,
                    Quantity = quantity,
                };
            }).ToArray();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (countsTbox.Text != "" && int.Parse(countsTbox.Text) != 0)
            {
                if (int.Parse(countsTbox.Text) >= 1000)
                {
                    DialogResult m = MessageBox.Show("1000個以上の注文になりますがよろしいですか?", "注意", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (m == DialogResult.Cancel)
                    {
                        countsTbox.Focus();
                        return;
                    }
                }
                var counts=int.Parse(countsTbox.Text);
                completeOrdersDgv.Rows.Add(
                    itemsViewDgv.SelectedRows[0].Cells[0].Value,
                    itemsViewDgv.SelectedRows[0].Cells[1].Value,
                    counts,
                    itemsViewDgv.SelectedRows[0].Cells[3].Value,
                    int.Parse(itemsViewDgv.SelectedRows[0].Cells[3].Value.ToString())*counts);
                ComputeTotalPrice();

                countsTbox.Clear();
                delBtn.Enabled = true;
                clearBtn.Enabled = true;
                completeBtn.Enabled = true;
            }
            else
            {
                MessageBox.Show("数量をもう一度確認のうえ入力してください！", "エラー", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
       }

        Models.ItemT TextboxToItemT()
        {
            var item = new Models.ItemT();
            item.Name = itemNameTbox.Text;
            return item;
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (completeOrdersDgv.SelectedRows.Count == 0) return;
            DialogResult m = MessageBox.Show("消去されてしまいますが、よろしいですか？", "注意!", MessageBoxButtons.YesNo,MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (m ==DialogResult.Yes)
            {
                if (this.completeOrdersDgv.SelectedRows.Count > 0)
                {
                    completeOrdersDgv.Rows.RemoveAt(this.completeOrdersDgv.SelectedRows[0].Index);
                    ComputeTotalPrice();
                }
                if (completeOrdersDgv.SelectedRows.Count == 0)
                {
                    delBtn.Enabled = false;
                    clearBtn.Enabled = false;
                    completeBtn.Enabled = false;
                }
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            if (completeOrdersDgv.SelectedRows.Count == 0) return;
            DialogResult m = MessageBox.Show("全部消去されてしまいますが、よろしいですか？", "注意!", MessageBoxButtons.YesNo,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2);
            if (m == DialogResult.Yes)
            {
                CompleteOrdersDgvClear();
                delBtn.Enabled = false;
                clearBtn.Enabled = false;
                completeBtn.Enabled = false;
            }
        }

        private void completeBtn_Click(object sender, EventArgs e)
        {
            if (completeOrdersDgv.SelectedRows.Count == 0) return;
            var g = new Models.TakeOrderT
            {
                TakeOrderDate = DateTime.Now,// 注文日
                ClientTID = int.Parse(clientsIdViewLbl.Text),// 会員ID
                StaffTID = staff.StaffTID,  //社員ID
            };

            var takeOrderId = servis.AddTakeOrder(g).TakeOrderTID;           //完了したら入力されたTextとDGVの内容を消すため
            var Controls = new Control[] { clientsIdViewLbl, clientsNameViewLbl, clientsPhoneNoViewLbl, itemNameTbox, itemIdTbox, countsTbox, clientsIdTbox };

            foreach (var i in Controls)
                i.ResetText();

            itemsViewDgv.Rows.Clear();
            SetDataGridView(itemservis.GetAllItems());

            
            foreach (var x in GetTakeOrderDetailTFromDgv(takeOrderId))
                takeorderdetailservice.AddTakeOrderDetail(x);

            MessageBox.Show("注文が承りました", "終了", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CompleteOrdersDgvClear();

            var Controls2 = new Control[] { itemsViewDgv, completeOrdersDgv, itemNameTbox, itemIdTbox, searchBtn, countsTbox, confirmBtn, allItemBtn, completeBtn, clearBtn, delBtn };
            foreach (var i in Controls2)
                i.Enabled = false;

            delBtn.Enabled = false;
            clearBtn.Enabled = false;
            completeBtn.Enabled = false;
        }

        private void allItemBtn_Click(object sender, EventArgs e)
        {
            itemsViewDgv.Rows.Clear();
            SetDataGridView(itemservis.GetAllItems());
            itemIdTbox.Clear();
            itemNameTbox.Clear();
        }

        private void countsTbox_KeyPress(object sender, KeyPressEventArgs e)
        {

            Utility.TextBoxDigitCheck(countsTbox, e);

        }

        private void clientsIdTbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                clientsIdCheckBtn.PerformClick();
            }
        }

        private void itemNameTbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchBtn.PerformClick();
            }
        }

        private void itemIdTbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchBtn.PerformClick();
            }
        }

        private void confirmBtn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                clientsIdCheckBtn.PerformClick();
            }
        }

        private void countsTbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                confirmBtn.PerformClick();
            }
        }
    }
}

  
 


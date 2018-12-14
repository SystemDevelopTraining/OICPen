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

        public TakeOrder(OICPenDbContext dbcontext)
        {
            servis = new Services.TakeOrderService(dbcontext);
            clientservis = new Services.ClientService(dbcontext);
            itemservis = new Services.ItemService(dbcontext);
            takeorderdetailservice = new Services.TakeOrderDetailService(dbcontext);
            InitializeComponent();
         }

        private void clientsIdCheckBtn_Click(object sender, EventArgs e)
        {
            if(completeOrdersDgv.Rows.Count!=0 && clientsIdViewLbl.Text!=clientsIdTbox.Text)
            {
               
                DialogResult m=MessageBox.Show("会員IDは変更しますが注文もクリアしますか？", "注意", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning,MessageBoxDefaultButton.Button3);
                if (m == DialogResult.Cancel)
                    return;
                else if (m == DialogResult.Yes)
                    completeOrdersDgv.Rows.Clear();
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
                var Controls = new Control[] { itemsViewDgv, completeOrdersDgv, itemNameTbox, itemIdTbox, searchBtn,allItemBtn,countsTbox,confirmBtn, itemsViewDgv, completeOrdersDgv };
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
                    item.SafetyStock
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
                    itemsViewDgv.Rows.Clear();
                    SetDataGridView(processes[currentIndex]());
                }
                catch
                {                  
                }
            }
            if (itemsViewDgv.Rows.Count != 0)
            {
                countsTbox.Enabled = true;
                confirmBtn.Enabled = true;
            }
            else
            {
                countsTbox.Enabled = false;
                confirmBtn.Enabled = false;
            }
        }

        private void TakeOrder_Load(object sender, EventArgs e)
        {
            clientsIdTbox.Focus();
            SetDataGridView(itemservis.GetAllItems());
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (countsTbox.Text != "" && int.Parse(countsTbox.Text) != 0)
            {
                //数量が1000個超えたら確認為メッセージを表示する機能
                if (int.Parse(countsTbox.Text) >= 1000)
                {
                    DialogResult m = MessageBox.Show("1000個以上の注文になりますがよろしいですか?", "注意", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (m == DialogResult.Cancel)
                    {
                        countsTbox.Focus();
                        return;
                    }
                }
                //data grid view に重複する商品IDあったら、新しい追加ではなく数量だけ変える機能
                DataGridViewRow duplicate_row = null;
                try
                {
                    duplicate_row=completeOrdersDgv.Rows.Cast<DataGridViewRow>().Single(row => row.Cells[0].Value == itemsViewDgv.SelectedRows[0].Cells[0].Value);
                }
                catch { }
                        if (duplicate_row==null)
                        {
                            completeOrdersDgv.Rows.Add(itemsViewDgv.SelectedRows[0].Cells[0].Value, itemsViewDgv.SelectedRows[0].Cells[1].Value, int.Parse(countsTbox.Text));
                            countsTbox.Clear();
                            delBtn.Enabled = true;
                            clearBtn.Enabled = true;
                            completeBtn.Enabled = true;
                            countsTbox.ResetText();
                        }
                        else
                        {
                    DialogResult a=MessageBox.Show("同じ商品がもうすでに追加されています。数量の入れ替えだけであればNoを、数量を足して入れ替えりたいならばYesを押してください", "注意", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information,MessageBoxDefaultButton.Button3);
                    if (a == DialogResult.Yes)
                    {                     
                        duplicate_row.Cells[2].Value = int.Parse(countsTbox.Text)+ int.Parse(duplicate_row.Cells[2].Value.ToString());
                    }
                    else if (a == DialogResult.No){
                        duplicate_row.Cells[2].Value = int.Parse(countsTbox.Text);
                        countsTbox.ResetText();
                    }
                }              
            }
            else
            {
                MessageBox.Show("数量をもう一度確認のうえ入力してください！", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                completeOrdersDgv.Rows.Clear();
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
                TakeOrdDate = DateTime.Now,// 注文日
                ClientTID = int.Parse(clientsIdViewLbl.Text),// 会員ID
                StaffTID = staff.StaffTID,  //社員ID
            };

            var takeOrderId = servis.AddTakeOrder(g).TakeOrderTID;           //完了したら入力されたTextとDGVの内容を消すため
            var Controls = new Control[] { clientsIdViewLbl, clientsNameViewLbl, clientsPhoneNoViewLbl, itemNameTbox, itemIdTbox, countsTbox, clientsIdTbox };
            foreach (var i in Controls)
            {
                i.ResetText();
            }
            itemsViewDgv.Rows.Clear();
            SetDataGridView(itemservis.GetAllItems());

            foreach (DataGridViewRow row in completeOrdersDgv.Rows)
            {
                var itemId = int.Parse(row.Cells[0].Value.ToString());
                var itemName = row.Cells[1].Value;
                var quantity = int.Parse(row.Cells[2].Value.ToString());

                var a = new Models.TakeOrderDetailT
                {
                    TakeOrderTID = takeOrderId,
                    ItemTID = itemId,
                    Quantity = quantity,
                };
                takeorderdetailservice.AddTakeOrderDetail(a);
            }

            MessageBox.Show("注文が承りました", "終了", MessageBoxButtons.OK, MessageBoxIcon.Information);

            completeOrdersDgv.Rows.Clear();
            var Controls2 = new Control[] { itemsViewDgv, completeOrdersDgv, itemNameTbox, itemIdTbox, searchBtn, countsTbox, confirmBtn, allItemBtn, completeBtn, clearBtn, delBtn };
            foreach (var i in Controls2)
            {
                i.Enabled = false;
            }
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
            countsTbox.Enabled = true;
            confirmBtn.Enabled = true;
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


  
 


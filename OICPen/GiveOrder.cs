﻿using OICPen.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace OICPen
{
    public partial class GiveOrder : Form,MyForm
    {
        private Services.StaffService staffServis ;
        private Services.ItemService itemServis ;
        private Services.GiveOrderService orderServis ;
        private Services.GiveOrderDetailService orderDetailServis ;
        private Models.StaffT staff;
        public GiveOrder(Models.OICPenDbContext dbcontext)
        {
            staffServis = new Services.StaffService(dbcontext);
            itemServis = new Services.ItemService(dbcontext);
            orderServis = new Services.GiveOrderService(dbcontext);
            orderDetailServis = new Services.GiveOrderDetailService(dbcontext);
            InitializeComponent();
        }
       public StaffT Staff
        {
            set
            {
                staff = value;
            }
        }     

       
        //数量チェック
        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (itemsViewDgv.SelectedRows.Count > 0)
            {
                if (quantityTbox.Text != "" && int.Parse(quantityTbox.Text) != 0)
                {
                    if (int.Parse(quantityTbox.Text) >= 1000)
                    {
                        DialogResult result = MessageBox.Show("1000個以上の発注になりますがよろしいですか？", "警告",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                        if (result == DialogResult.No)
                        {
                            quantityTbox.Focus();
                            return;
                        }
                    }

                    //検索結果DataGridViewのitemから発注リストDataGridViewに表示される
                    //data grid view に重複する商品IDあったら、新しい追加ではなく数量だけ変える機能
                    DataGridViewRow duplicate_row = null;
                    try
                    {
                        duplicate_row = giveOrderListDgv.Rows.Cast<DataGridViewRow>().Single(row => row.Cells[0].Value == itemsViewDgv.SelectedRows[0].Cells[0].Value);
                    }
                    catch { }
                    var counts = int.Parse(quantityTbox.Text);
                    if (duplicate_row == null)
                    {
                          giveOrderListDgv.Rows.Add(
                            itemsViewDgv.SelectedRows[0].Cells[0].Value,
                            itemsViewDgv.SelectedRows[0].Cells[1].Value,
                            counts
                        );
                        quantityTbox.Clear();
                        allClearBtn.Enabled = true;
                        clearBtn.Enabled = true;
                        completeBtn.Enabled = true;
                        quantityTbox.ResetText();
                    }
                    else
                    {
                       quantityTbox.ResetText();
                        duplicate_row.Cells[2].Value = counts;
                    }                   
                }
                else
                {
                    MessageBox.Show("数量を入力して下さい。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    quantityTbox.Text = null;
                }
            }
        }
        private void allItemBtn_Click(object sender, EventArgs e)
        {
            SetDataGridView(itemServis.GetItems());
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
                MessageBox.Show("検索項目が一つではありません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }


        private void clearBtn_Click(object sender, EventArgs e)
        {
            if (giveOrderListDgv.SelectedRows.Count == 0)
                return;
            
            DialogResult result = MessageBox.Show("削除しますがよろしいですか？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                giveOrderListDgv.Rows.RemoveAt(giveOrderListDgv.SelectedRows[0].Index);
                if (itemsViewDgv.SelectedRows.Count != 0)
                {
                    confirmBtn.Enabled = true;
                }
            }
            if (giveOrderListDgv.SelectedRows.Count == 0)
            {
                clearBtn.Enabled = false;
                allClearBtn.Enabled = false;
                completeBtn.Enabled = false;
            } 
        }

        private void allClearBtn_Click(object sender, EventArgs e)
        {
            if (giveOrderListDgv.SelectedRows.Count == 0) return;
            DialogResult result = MessageBox.Show("全部消去しますがよろしいですか？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                giveOrderListDgv.Rows.Clear();
                clearBtn.Enabled = false;
                allClearBtn.Enabled = false;
                completeBtn.Enabled = false;
            }               
        }

        private void completeBtn_Click(object sender, EventArgs e)
        {
            if (giveOrderListDgv.SelectedRows.Count == 0) return;

            DialogResult result = MessageBox.Show("発注してもよろしいですか？", "発注",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                var addGiverOrderItem = new Models.GiveOrderT
                {
                    GiveOrderDate = DateTime.Now,//発注日
                    StaffTID = staff.StaffTID,//社員ID

                };

                var giveOrderId = orderServis.AddGiveOrderst(addGiverOrderItem).GiveOrderTID;
                var Controls = new Control[] { itemIdTbox, itemNameTbox, quantityTbox };
                foreach (var value in Controls)
                {
                    value.ResetText();
                }
                itemsViewDgv.Rows.Clear();
                SetDataGridView(itemServis.GetItems());

                foreach (DataGridViewRow row in giveOrderListDgv.Rows)
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

                MessageBox.Show("発注完了しました。", "発注");
                giveOrderListDgv.Rows.Clear();
                clearBtn.Enabled = false;
                allClearBtn.Enabled = false;
                completeBtn.Enabled = false;
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

        private void itemNameTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.HiraganaMode(itemNameTbox,e);
        }
        private void itemIdTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.AlphaMode(itemIdTbox,e);
            Utility.TextBoxDigitCheck(itemIdTbox, e);
        }

        private void quantityTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.AlphaMode(quantityTbox,e);
            Utility.TextBoxDigitCheck(quantityTbox, e);
        }

        private void GiveOrder_Activated(object sender, EventArgs e)
        {

        }

        private void GiveOrder_EnabledChanged(object sender, EventArgs e)
        {
            if (Enabled == false)
                return;
            itemNameTbox.Focus();
            SetDataGridView(itemServis.GetItems());

        }
    }
}

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
    public partial class TakeOrder : Form
    {
        private Services.TakeOrderService servis = new Services.TakeOrderService(new Models.OICPenDbContext());
        private Services.ClientService clientservis = new Services.ClientService(new Models.OICPenDbContext());
        private Services.ItemService itemservis = new Services.ItemService(new Models.OICPenDbContext());
        private Services.TakeOrderDetailService takeOrderService = new Services.TakeOrderDetailService(new Models.OICPenDbContext());
        public TakeOrder()
        {
            InitializeComponent();
        }

        private void clientsIdCheckBtn_Click(object sender, EventArgs e)
        {
            bool found = false;
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
                    ,
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
            foreach (var item in itemservis.GetAllItems())
            {
                itemsViewDgv.Rows.Add(item.ItemTID, item.Name, "0");//在庫数表示未完成
            }
        }

        void SetDataGridView2(List<Models.ItemT> items)
        {

            itemsViewDgv.Rows.Clear();
            items.ForEach(item =>
            {
                itemsViewDgv.Rows.Add(
                    item.ItemTID,
                    item.Name

                   );
            });
        }
        private void confirmBtn_Click(object sender, EventArgs e)
        {
            completeOrdersDgv.Rows.Add(itemsViewDgv.SelectedRows[0].Cells[0].Value, itemsViewDgv.SelectedRows[0].Cells[1].Value, countsTbox.Text);
        }

        Models.ItemT TextboxToItemT()
        {
            var item = new Models.ItemT();
            item.Name = itemNameTbox.Text;
            return item;
        }

    }
}

  
 


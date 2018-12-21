using OICPen.Models;
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
    public partial class Sales : Form
    {
        private Models.StaffT staff;
        private Services.ItemService service;

        public StaffT Staff
        {
            set
            {
                staff = value;
            }
        }

        public Sales(OICPenDbContext dbcontext)
        {
            service = new Services.ItemService(dbcontext);
            InitializeComponent();
        }

        //起動時にデータグリッドビューに全期間の売り上げ一覧を表示する
        private void sales_Load(object sender, EventArgs e)
        {
            salesDisplayBtn.Focus();
            SetDataGridView(service.GetItems());
        }

        //データグリッドビューに売り上げ一覧を表示する
        void SetDataGridView(List<Models.ItemT> items)
        {
            salesDgv.Rows.Clear();
            items.ForEach(item =>
            {
                int takeorderAllQuantity = 0;
                int giveOrderAllQuantity = 0;
                foreach (var takeorderdetail in item.TakeOrderDetailTs)
                {
                    takeorderAllQuantity += takeorderdetail.Quantity;
                }
                foreach (var giveorderderdetail in item.GiveOrderDetailTs)
                {
                    giveOrderAllQuantity += giveorderderdetail.Quantity;
                }

                salesDgv.Rows.Add(
                    item.ItemTID,
                    item.Name,
                    item.Price*takeorderAllQuantity,
                    item.Price*takeorderAllQuantity - item.PurchasePrice*giveOrderAllQuantity
                    );
            });
        }

        private void salesDisplayBtn_Click(object sender, EventArgs e)
        {
            SetDataGridView(service.GetItems());
        }
    }
}

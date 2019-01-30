using OICPen.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OICPen
{
    public partial class Sales : Form,MyForm
    {
        private Services.ItemService service;

        public Models.StaffT Staff { set { } }

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
        void SetDataGridView(List<ItemT> items)
        {
            var startDate = salesStartDtp.Value;
            var endDate = salesEndDtp.Value;
            startDate = new DateTime(startDate.Year, startDate.Month, startDate.Day, 0, 0, 0);
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, 23, 59, 59);
            salesDgv.Rows.Clear();
            items.ForEach(item =>
            {
                int takeorderTotalPrice = item.TakeOrderDetailTs == null ? 0 :
                    item.TakeOrderDetailTs
                        .Where(x => x.TakeOrderT.TakeOrderDate >= startDate && x.TakeOrderT.TakeOrderDate <= endDate)
                        .Sum(x => x.Quantity * x.TakeOrderPrice);
                int giveOrderTotalPrice = item.GiveOrderDetailTs == null ? 0 :
                    item.GiveOrderDetailTs
                        .Where(x => x.GiveOrderT.GiveOrderDate >= startDate && x.GiveOrderT.GiveOrderDate <= endDate)
                        .Sum(x => x.Quantity * x.GiveOrderPurchasePrice);

                salesDgv.Rows.Add(
                    item.ItemTID,
                    item.Name,
                    takeorderTotalPrice,
                    takeorderTotalPrice -  giveOrderTotalPrice
                    );
            });
        }

        private void salesDisplayBtn_Click(object sender, EventArgs e)
        {
            SetDataGridView(service.GetItems());
        }
    }
}

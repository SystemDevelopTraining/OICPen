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
        //商品一つに対する売り上げ情報
        struct SaleInfo
        {
            //売上金額
            public int salesTotal;
            //仕入れ合計金額
            public int purchaseTotal;
            //商品情報
            public ItemT item;
            public SaleInfo(int salesTotal, int purchaseTotal,ItemT item)
            {
                this.salesTotal = salesTotal;
                this.purchaseTotal = purchaseTotal;
                this.item = item;
            }
        }
        //指定した期間の商品ごとの売上一覧を配列で返す
         SaleInfo[] SalesInfo(List<ItemT> items,DateTime startDate,DateTime endDate)
        {
            return items.Select(item =>
            {
                //  商品一つに対する売上集計
                int salesTotal = item.TakeOrderDetailTs == null ? 0 :
                    item.TakeOrderDetailTs
                        .Where(x => x.TakeOrderT.TakeOrderDate >= startDate && x.TakeOrderT.TakeOrderDate <= endDate)
                        .Sum(x => x.Quantity * x.TakeOrderPrice);
                int purchaseTotal = item.GiveOrderDetailTs == null ? 0 :
                    item.GiveOrderDetailTs
                        .Where(x => x.GiveOrderT.GiveOrderDate >= startDate && x.GiveOrderT.GiveOrderDate <= endDate)
                        .Sum(x => x.Quantity * x.GiveOrderPurchasePrice);
                return new SaleInfo (salesTotal, purchaseTotal, item );
            }).ToArray();
        }

        //データグリッドビューに売り上げ一覧を表示する
        void SetDataGridView(List<ItemT> items)
        {
            var startDate = salesStartDtp.Value;
            var endDate = salesEndDtp.Value;
            startDate = new DateTime(startDate.Year, startDate.Month, startDate.Day, 0, 0, 0);
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, 23, 59, 59);
            salesDgv.Rows.Clear();
            foreach(var salesInfo in SalesInfo(items, startDate, endDate))
                salesDgv.Rows.Add(
                                salesInfo.item.ItemTID,
                                salesInfo.item.Name,
                                salesInfo.salesTotal,
                                salesInfo.salesTotal - salesInfo.purchaseTotal
                                );           
        }

        private void salesDisplayBtn_Click(object sender, EventArgs e)
        {
            SetDataGridView(service.GetItems());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.chart1.Series["売上"].Points.AddXY("1月",53546);
            this.chart1.Series["売上"].Points.AddXY("2月", 556);
            this.chart1.Series["売上"].Points.AddXY("3月", 15355);
            this.chart1.Series["売上"].Points.AddXY("4月", 53545);
            this.chart1.Series["売上"].Points.AddXY("5月", 2546);
            this.chart1.Series["売上"].Points.AddXY("6月", 535446);
            this.chart1.Series["売上"].Points.AddXY("7月", 53546);
            this.chart1.Series["売上"].Points.AddXY("8月", 5346);
            this.chart1.Series["売上"].Points.AddXY("9月", 5354);
            this.chart1.Series["売上"].Points.AddXY("10月", 53546);
            this.chart1.Series["売上"].Points.AddXY("11月", 53546);
            this.chart1.Series["売上"].Points.AddXY("12月", 53546);

        }
    }
}

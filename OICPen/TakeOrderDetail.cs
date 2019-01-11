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
    public partial class TakeOrderDetail : Form
    {
        Models.TakeOrderT Order;
        public TakeOrderDetail(Models.TakeOrderT Order)
        {
            this.Order = Order;
            InitializeComponent();
        }

        private void TakeOrderDetail_Load(object sender, EventArgs e)
        {
            if (Order.TakeOrderDetailTs == null)
                return;
            foreach(var x in Order.TakeOrderDetailTs)
            {
                TakeOrderDetailDgv.Rows.Add(x.TakeOrderTID, x.ItemTID, x.ItemT.Name, x.Quantity);
            }
        }
    }
}

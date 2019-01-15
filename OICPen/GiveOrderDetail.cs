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
    public partial class GiveOrderDetail : Form
    {
        Models.GiveOrderT Order;
        public GiveOrderDetail(Models.GiveOrderT Order)
        {
            this.Order = Order;
            InitializeComponent();
        }

        private void GiveOrderDetail_Load(object sender, EventArgs e)
        { 
            if (Order.GiveOrderDetailTs == null)
                return;
            foreach (var x in Order.GiveOrderDetailTs)
            {
                GiveOrderDetailDgv.Rows.Add(x.GiveOrderTID, x.ItemTID, x.ItemT.Name, x.Quantity);
            }
        }
    }
}

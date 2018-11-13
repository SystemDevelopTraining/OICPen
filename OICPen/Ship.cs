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
    public partial class Ship : Form
    {
        private Services.TakeOrderService servis = new Services.TakeOrderService(new Models.OICPenDbContext());


        public Ship()
        {
            InitializeComponent();
        }

        //出庫済一覧表示
        private void shippedCheckBtn_Click(object sender, EventArgs e)
        {
            shipDgv.Rows.Clear();
            foreach (var orders in servis.GetAllTakeOrders())
            {
                if (orders.ShipDate != null)
                {
                    shipDgv.Rows.Add(orders.TakeOrderTID, orders.TakeOrdDate, orders.ShipDate, orders.ClientTID);
                }

            }
        }

        private void shipProcessingBtn_Click(object sender, EventArgs e)
        {
            

    }
       
        //　未出庫一覧表示
        private void shipCheckBtn_Click(object sender, EventArgs e)
        {
            shipDgv.Rows.Clear();
            
            foreach (var orders in servis.GetAllTakeOrders())
            {
                if (orders.ShipDate == null)
                {
                    shipDgv.Rows.Add(orders.ClientTID, orders.TakeOrdDate, orders.ShipDate, orders.TakeOrderTID);
                }
            }
        }

        private void shipFixBtn_Click(object sender, EventArgs e)
        {

        }
    }
}

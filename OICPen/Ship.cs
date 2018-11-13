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
            ShipCheck(servis.GetShipedTakeOrders());

        }     
        //　未出庫一覧表示
        private void shipCheckBtn_Click(object sender, EventArgs e)
        {
            shipDgv.Rows.Clear();

            ShipCheck(servis.GetNoShipedTakeOrders());
         }

        
        private void shipProcessingBtn_Click(object sender, EventArgs e)
        {
            
            if (shipDgv.SelectedRows.Count == 0) return;
            var cells = shipDgv.SelectedRows[0].Cells;
            if (cells[3].Value == null)
            {
                servis.Shiping((int)cells[1].Value);
       
            }
            shipDgv.Rows.Clear();
            ShipCheck(servis.GetNoShipedTakeOrders());

        }
        private void shipFixBtn_Click(object sender, EventArgs e)
        {
            
            if (shipDgv.SelectedRows.Count == 0) return;
            var cells = shipDgv.SelectedRows[0].Cells;
            if (cells[3].Value != null)
            {
                servis.ClearShiping((int)cells[1].Value);

            }
            shipDgv.Rows.Clear();
            ShipCheck(servis.GetShipedTakeOrders());

        }


        //出庫済み、未出庫の処理をする。
        public void ShipCheck (List<Models.TakeOrderT> loadShip ) 
        {

            foreach (var orders in loadShip)
            {
                {
                    shipDgv.Rows.Add(orders.ClientTID, orders.TakeOrderTID, orders.TakeOrdDate, orders.ShipDate);
                }
            }
        }


    }
}

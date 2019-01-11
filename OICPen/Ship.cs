using OICPen.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OICPen
{
    public partial class Ship : Form,MyForm
    {
        private Services.TakeOrderService servis;
        private StaffT staff;

        public Ship(Models.OICPenDbContext dbcontext)
        {
            servis = new Services.TakeOrderService(dbcontext);
            InitializeComponent();
        }
        public StaffT Staff
        {
            set
            {
                staff = value;

                shipProcessingBtn.Enabled = false;
                shipFixBtn.Enabled = false;
            }
        }

        private bool PermissionOk()
        {
            return staff.Permission == Permission.God
                   || staff.Permission == Permission.ProductControl;
        }

        private void Ship_Load(object sender, EventArgs e)
        {
            shippedCheckBtn.Focus();
            
           
        }

        //出庫済一覧表示
        private void shippedCheckBtn_Click(object sender, EventArgs e)
        {
            if (PermissionOk())
            {
                shipProcessingBtn.Enabled = false;
                shipFixBtn.Enabled = true;
            }
            SetDataGridView(servis.GetShipedTakeOrders());
        }     
        //　未出庫一覧表示
        private void shipCheckBtn_Click(object sender, EventArgs e)
        {
            if (PermissionOk())
            {
                shipProcessingBtn.Enabled = true;
                shipFixBtn.Enabled = false;
            }

            SetDataGridView(servis.GetNoShipedTakeOrders());
         }

        
        private void shipProcessingBtn_Click(object sender, EventArgs e)
        {

            if (shipDgv.SelectedRows.Count == 0) return;
            var cells = shipDgv.SelectedRows[0].Cells;
            if (cells[3].Value == null)
            {
                servis.Shiping((int)cells[1].Value);
       
            }
            
            SetDataGridView(servis.GetNoShipedTakeOrders());

        }
        private void shipFixBtn_Click(object sender, EventArgs e)
        {
            
            if (shipDgv.SelectedRows.Count == 0) return;
            var cells = shipDgv.SelectedRows[0].Cells;
            if (cells[3].Value != null)
            {
                servis.ClearShiping((int)cells[1].Value);

            }
            
            SetDataGridView(servis.GetShipedTakeOrders());
        }


        //出庫済み、未出庫の処理をする。
        public void SetDataGridView (List<Models.TakeOrderT> loadShip ) 
        {
            shipDgv.Rows.Clear();

            foreach (var orders in loadShip)
            {
                {
                    shipDgv.Rows.Add(orders.ClientTID, orders.TakeOrderTID, orders.TakeOrderDate, orders.ShipDate);
                }
            }
        }

        private void shipDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.Columns[e.ColumnIndex].Name == "Details" && e.ColumnIndex != -1)
            {
                var f = new    TakeOrderDetail(servis.FindByID((int.Parse(dgv.Rows[e.RowIndex].Cells[1].Value.ToString()))));
                f.ShowDialog();
            }
        }
    }
}

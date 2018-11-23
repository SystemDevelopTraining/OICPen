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
    public partial class ClientPurchaseHistory : Form
    {
        Models.ClientT client;
        private Services.TakeOrderService servis = new Services.TakeOrderService(new Models.OICPenDbContext());

        public ClientPurchaseHistory(Models.ClientT client)
        {
            InitializeComponent();
            this.client=client;
        }

        private void ClientPurchaseHistory_Load(object sender, EventArgs e)
        {
            var dgv = PurchaseHistoryDgv;
            if (client.TakeOrderTs == null)
                return;
            foreach (var x in client.TakeOrderTs)
            {
                dgv.Rows.Add(x.TakeOrderTID,x.TakeOrdDate,x.ShipDate);
            }
        }

        private void PurchaseHistoryDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            //"Button"列ならば、ボタンがクリックされた
            if (dgv.Columns[e.ColumnIndex].Name == "clientPurchhaseHistoryMoreDetail"&& e.RowIndex!=-1)
            {
                var f = new ClientPurchhaseHistoryMoreDetail(servis.FindByID(int.Parse(dgv.Rows[e.RowIndex].Cells[0].Value.ToString())));
                f.Show();
            }
        }
    }
}

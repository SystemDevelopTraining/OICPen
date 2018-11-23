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
    public partial class ClientPurchhaseHistoryMoreDetail : Form
    {
        Models.TakeOrderT ID;
        public ClientPurchhaseHistoryMoreDetail(Models.TakeOrderT ID)
        {
            InitializeComponent();
            this.ID = ID;
        }

        private void ClientPurchhaseHistoryMoreDetail_Load(object sender, EventArgs e)
        {
            var dgv = MoreDetailDgv;
            if (ID.TakeOrderDetailTs == null)
                return;
            foreach (var x in ID.TakeOrderDetailTs)
            {
                dgv.Rows.Add(x.TakeOrderDetailTID,x.ItemT.Name,x.ItemTID, x.Quantity);
            }
        }
    }
}

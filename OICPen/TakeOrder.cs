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
    public partial class TakeOrder : Form
    {
        private Services.TakeOrderService servis = new Services.TakeOrderService(new Models.OICPenDbContext());
        private Services.ClientService clientservis = new Services.ClientService(new Models.OICPenDbContext());
        public TakeOrder()
        {
            InitializeComponent();
        }

        private void clientsIdCheckBtn_Click(object sender, EventArgs e)
        {
            foreach(var client in clientservis.GetClients())
            {
                if (clientsIdTbox.Text == client.ClientTID.ToString())
                {
                    clientsIdViewLbl.Text = client.ClientTID.ToString();
                    clientsNameViewLbl.Text = client.Name;
                    clientsPhoneNoViewLbl.Text = client.PhoneNum;

                }

            }
        }

     
    }
}

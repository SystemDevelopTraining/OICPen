﻿using System;
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

        public ClientPurchaseHistory(Models.ClientT client)
        {
            InitializeComponent();
            client = this.client;
        }

    }
}

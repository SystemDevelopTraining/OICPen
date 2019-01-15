namespace OICPen
{
    partial class GiveOrderDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GiveOrderDetailDgv = new System.Windows.Forms.DataGridView();
            this.TakeOrderDetailTId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GiveOrderDetailDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // GiveOrderDetailDgv
            // 
            this.GiveOrderDetailDgv.AllowUserToAddRows = false;
            this.GiveOrderDetailDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GiveOrderDetailDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TakeOrderDetailTId,
            this.ItemID,
            this.ItemName,
            this.quantity});
            this.GiveOrderDetailDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GiveOrderDetailDgv.Enabled = false;
            this.GiveOrderDetailDgv.Location = new System.Drawing.Point(0, 0);
            this.GiveOrderDetailDgv.Name = "GiveOrderDetailDgv";
            this.GiveOrderDetailDgv.RowHeadersVisible = false;
            this.GiveOrderDetailDgv.RowTemplate.Height = 21;
            this.GiveOrderDetailDgv.Size = new System.Drawing.Size(635, 354);
            this.GiveOrderDetailDgv.TabIndex = 0;
            // 
            // TakeOrderDetailTId
            // 
            this.TakeOrderDetailTId.HeaderText = "発注詳細ID";
            this.TakeOrderDetailTId.Name = "TakeOrderDetailTId";
            // 
            // ItemID
            // 
            this.ItemID.HeaderText = "商品ID";
            this.ItemID.Name = "ItemID";
            this.ItemID.Width = 190;
            // 
            // ItemName
            // 
            this.ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemName.HeaderText = "商品名";
            this.ItemName.Name = "ItemName";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "数量";
            this.quantity.Name = "quantity";
            this.quantity.Width = 75;
            // 
            // GiveOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 354);
            this.Controls.Add(this.GiveOrderDetailDgv);
            this.MinimizeBox = false;
            this.Name = "GiveOrderDetail";
            this.Text = "発注詳細";
            this.Load += new System.EventHandler(this.GiveOrderDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GiveOrderDetailDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GiveOrderDetailDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn TakeOrderDetailTId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
    }
}
namespace OICPen
{
    partial class ClientPurchaseHistory
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
            this.PurchaseHistoryDgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientPurchhaseHistoryMoreDetail = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseHistoryDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // PurchaseHistoryDgv
            // 
            this.PurchaseHistoryDgv.AllowUserToAddRows = false;
            this.PurchaseHistoryDgv.AllowUserToDeleteRows = false;
            this.PurchaseHistoryDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PurchaseHistoryDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.clientPurchhaseHistoryMoreDetail});
            this.PurchaseHistoryDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PurchaseHistoryDgv.Location = new System.Drawing.Point(0, 0);
            this.PurchaseHistoryDgv.Name = "PurchaseHistoryDgv";
            this.PurchaseHistoryDgv.ReadOnly = true;
            this.PurchaseHistoryDgv.RowTemplate.Height = 21;
            this.PurchaseHistoryDgv.Size = new System.Drawing.Size(440, 375);
            this.PurchaseHistoryDgv.TabIndex = 0;
            this.PurchaseHistoryDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PurchaseHistoryDgv_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "注文ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "注文日";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "出庫日";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // clientPurchhaseHistoryMoreDetail
            // 
            this.clientPurchhaseHistoryMoreDetail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clientPurchhaseHistoryMoreDetail.HeaderText = "詳細";
            this.clientPurchhaseHistoryMoreDetail.Name = "clientPurchhaseHistoryMoreDetail";
            this.clientPurchhaseHistoryMoreDetail.ReadOnly = true;
            this.clientPurchhaseHistoryMoreDetail.Text = "詳細へ";
            // 
            // ClientPurchaseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 375);
            this.Controls.Add(this.PurchaseHistoryDgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "ClientPurchaseHistory";
            this.Text = "購入履歴";
            this.Load += new System.EventHandler(this.ClientPurchaseHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseHistoryDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PurchaseHistoryDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn clientPurchhaseHistoryMoreDetail;
    }
}
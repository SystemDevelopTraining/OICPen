namespace OICPen
{
    partial class ClientPurchhaseHistoryMoreDetail
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
            this.MoreDetailDgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.MoreDetailDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // MoreDetailDgv
            // 
            this.MoreDetailDgv.AllowUserToAddRows = false;
            this.MoreDetailDgv.AllowUserToDeleteRows = false;
            this.MoreDetailDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MoreDetailDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3});
            this.MoreDetailDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MoreDetailDgv.Location = new System.Drawing.Point(0, 0);
            this.MoreDetailDgv.Name = "MoreDetailDgv";
            this.MoreDetailDgv.ReadOnly = true;
            this.MoreDetailDgv.RowTemplate.Height = 21;
            this.MoreDetailDgv.Size = new System.Drawing.Size(553, 375);
            this.MoreDetailDgv.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.FillWeight = 10.1523F;
            this.Column1.HeaderText = "注文詳細ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.FillWeight = 10.1523F;
            this.Column2.HeaderText = "商品ID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 369.5431F;
            this.Column4.HeaderText = "商品名";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.FillWeight = 10.15228F;
            this.Column3.HeaderText = "数量";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // ClientPurchhaseHistoryMoreDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 375);
            this.Controls.Add(this.MoreDetailDgv);
            this.MinimizeBox = false;
            this.Name = "ClientPurchhaseHistoryMoreDetail";
            this.ShowIcon = false;
            this.Text = "ClientPurchhaseHistoryMoreDetail";
            this.Load += new System.EventHandler(this.ClientPurchhaseHistoryMoreDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MoreDetailDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView MoreDetailDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
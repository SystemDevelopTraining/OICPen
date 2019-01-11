namespace OICPen
{
    partial class TakeOrderDetail
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
            this.TakeOrderDetailDgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TakeOrderDetailDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // TakeOrderDetailDgv
            // 
            this.TakeOrderDetailDgv.AllowUserToAddRows = false;
            this.TakeOrderDetailDgv.AllowUserToDeleteRows = false;
            this.TakeOrderDetailDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TakeOrderDetailDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3});
            this.TakeOrderDetailDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TakeOrderDetailDgv.Location = new System.Drawing.Point(0, 0);
            this.TakeOrderDetailDgv.Name = "TakeOrderDetailDgv";
            this.TakeOrderDetailDgv.RowTemplate.Height = 21;
            this.TakeOrderDetailDgv.Size = new System.Drawing.Size(443, 357);
            this.TakeOrderDetailDgv.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "注文詳細ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "商品ID";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "商品名";
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "数量";
            this.Column3.Name = "Column3";
            // 
            // TakeOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 357);
            this.Controls.Add(this.TakeOrderDetailDgv);
            this.Name = "TakeOrderDetail";
            this.Text = "TakeOrderDetail";
            this.Load += new System.EventHandler(this.TakeOrderDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TakeOrderDetailDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TakeOrderDetailDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
﻿namespace OICPen
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
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseHistoryDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // PurchaseHistoryDgv
            // 
            this.PurchaseHistoryDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PurchaseHistoryDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column2});
            this.PurchaseHistoryDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PurchaseHistoryDgv.Location = new System.Drawing.Point(0, 0);
            this.PurchaseHistoryDgv.Name = "PurchaseHistoryDgv";
            this.PurchaseHistoryDgv.RowTemplate.Height = 21;
            this.PurchaseHistoryDgv.Size = new System.Drawing.Size(471, 315);
            this.PurchaseHistoryDgv.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "注文ID";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "注文日";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "出庫日";
            this.Column4.Name = "Column4";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "詳細";
            this.Column2.Name = "Column2";
            // 
            // ClientPurchaseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 315);
            this.Controls.Add(this.PurchaseHistoryDgv);
            this.Name = "ClientPurchaseHistory";
            this.Text = "MemberPurchaseHistory";
            this.Load += new System.EventHandler(this.ClientPurchaseHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseHistoryDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PurchaseHistoryDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
    }
}
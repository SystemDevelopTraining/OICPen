namespace OICPen
{
    partial class Sales
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
            System.Windows.Forms.DateTimePicker salesEndDtp;
            this.salesLbl = new System.Windows.Forms.Label();
            this.salesDisplayBtn = new System.Windows.Forms.Button();
            this.salesDgv = new System.Windows.Forms.DataGridView();
            this.salesSortBtn = new System.Windows.Forms.Button();
            this.salesStartDtp = new System.Windows.Forms.DateTimePicker();
            this.salesAndLbl = new System.Windows.Forms.Label();
            this.salesBetweenLbl = new System.Windows.Forms.Label();
            salesEndDtp = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.salesDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // salesLbl
            // 
            this.salesLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.salesLbl.AutoSize = true;
            this.salesLbl.BackColor = System.Drawing.Color.Transparent;
            this.salesLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 NP-B", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.salesLbl.ForeColor = System.Drawing.Color.Black;
            this.salesLbl.Location = new System.Drawing.Point(1373, 19);
            this.salesLbl.Name = "salesLbl";
            this.salesLbl.Size = new System.Drawing.Size(212, 48);
            this.salesLbl.TabIndex = 0;
            this.salesLbl.Text = "売上管理";
            // 
            // salesDisplayBtn
            // 
            this.salesDisplayBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.salesDisplayBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.salesDisplayBtn.Location = new System.Drawing.Point(1384, 125);
            this.salesDisplayBtn.Name = "salesDisplayBtn";
            this.salesDisplayBtn.Size = new System.Drawing.Size(186, 58);
            this.salesDisplayBtn.TabIndex = 1;
            this.salesDisplayBtn.Text = "売上表示";
            this.salesDisplayBtn.UseVisualStyleBackColor = true;
            // 
            // salesDgv
            // 
            this.salesDgv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.salesDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesDgv.Location = new System.Drawing.Point(8, 28);
            this.salesDgv.Name = "salesDgv";
            this.salesDgv.RowTemplate.Height = 21;
            this.salesDgv.Size = new System.Drawing.Size(1310, 936);
            this.salesDgv.TabIndex = 0;
            // 
            // salesSortBtn
            // 
            this.salesSortBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.salesSortBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.salesSortBtn.Location = new System.Drawing.Point(1384, 251);
            this.salesSortBtn.Name = "salesSortBtn";
            this.salesSortBtn.Size = new System.Drawing.Size(186, 83);
            this.salesSortBtn.TabIndex = 2;
            this.salesSortBtn.Text = "昇順/降順\r\n切り替え";
            this.salesSortBtn.UseVisualStyleBackColor = true;
            // 
            // salesStartDtp
            // 
            this.salesStartDtp.CustomFormat = "";
            this.salesStartDtp.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.salesStartDtp.Location = new System.Drawing.Point(1370, 741);
            this.salesStartDtp.Name = "salesStartDtp";
            this.salesStartDtp.Size = new System.Drawing.Size(200, 36);
            this.salesStartDtp.TabIndex = 3;
            // 
            // salesEndDtp
            // 
            salesEndDtp.AllowDrop = true;
            salesEndDtp.CustomFormat = "";
            salesEndDtp.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            salesEndDtp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            salesEndDtp.Location = new System.Drawing.Point(1370, 844);
            salesEndDtp.Name = "salesEndDtp";
            salesEndDtp.Size = new System.Drawing.Size(200, 36);
            salesEndDtp.TabIndex = 4;
            salesEndDtp.Tag = "";
            // 
            // salesAndLbl
            // 
            this.salesAndLbl.AutoSize = true;
            this.salesAndLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 NP-B", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.salesAndLbl.Location = new System.Drawing.Point(1453, 797);
            this.salesAndLbl.Name = "salesAndLbl";
            this.salesAndLbl.Size = new System.Drawing.Size(42, 29);
            this.salesAndLbl.TabIndex = 5;
            this.salesAndLbl.Text = "～";
            // 
            // salesBetweenLbl
            // 
            this.salesBetweenLbl.AutoSize = true;
            this.salesBetweenLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 NP-B", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.salesBetweenLbl.Location = new System.Drawing.Point(1394, 665);
            this.salesBetweenLbl.Name = "salesBetweenLbl";
            this.salesBetweenLbl.Size = new System.Drawing.Size(147, 33);
            this.salesBetweenLbl.TabIndex = 6;
            this.salesBetweenLbl.Text = "指定期間";
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1610, 982);
            this.Controls.Add(this.salesBetweenLbl);
            this.Controls.Add(this.salesAndLbl);
            this.Controls.Add(salesEndDtp);
            this.Controls.Add(this.salesStartDtp);
            this.Controls.Add(this.salesDgv);
            this.Controls.Add(this.salesSortBtn);
            this.Controls.Add(this.salesDisplayBtn);
            this.Controls.Add(this.salesLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sales";
            this.Text = "sales";
            this.Load += new System.EventHandler(this.sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label salesLbl;
        private System.Windows.Forms.Button salesDisplayBtn;
        private System.Windows.Forms.DataGridView salesDgv;
        private System.Windows.Forms.Button salesSortBtn;
        private System.Windows.Forms.DateTimePicker salesStartDtp;
        private System.Windows.Forms.Label salesAndLbl;
        private System.Windows.Forms.Label salesBetweenLbl;
    }
}
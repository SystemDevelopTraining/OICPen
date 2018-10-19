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
            this.salesLbl = new System.Windows.Forms.Label();
            this.salesSelectBtn = new System.Windows.Forms.Button();
            this.salesDgv = new System.Windows.Forms.DataGridView();
            this.salesStartDtp = new System.Windows.Forms.DateTimePicker();
            this.salesEndDtp = new System.Windows.Forms.DateTimePicker();
            this.salesBetweenLbl = new System.Windows.Forms.Label();
            this.rankBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.salesDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // salesLbl
            // 
            this.salesLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.salesLbl.AutoSize = true;
            this.salesLbl.BackColor = System.Drawing.Color.Transparent;
            this.salesLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.salesLbl.ForeColor = System.Drawing.Color.Black;
            this.salesLbl.Location = new System.Drawing.Point(1373, 19);
            this.salesLbl.Name = "salesLbl";
            this.salesLbl.Size = new System.Drawing.Size(212, 48);
            this.salesLbl.TabIndex = 0;
            this.salesLbl.Text = "売上管理";
            // 
            // salesSelectBtn
            // 
            this.salesSelectBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.salesSelectBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.salesSelectBtn.Location = new System.Drawing.Point(1384, 245);
            this.salesSelectBtn.Name = "salesSelectBtn";
            this.salesSelectBtn.Size = new System.Drawing.Size(186, 58);
            this.salesSelectBtn.TabIndex = 1;
            this.salesSelectBtn.Text = "売上表";
            this.salesSelectBtn.UseVisualStyleBackColor = true;
            // 
            // salesDgv
            // 
            this.salesDgv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.salesDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesDgv.Location = new System.Drawing.Point(8, 28);
            this.salesDgv.Name = "salesDgv";
            this.salesDgv.RowTemplate.Height = 21;
            this.salesDgv.Size = new System.Drawing.Size(1310, 936);
            this.salesDgv.TabIndex = 2;
            // 
            // salesStartDtp
            // 
            this.salesStartDtp.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.salesStartDtp.Location = new System.Drawing.Point(1370, 741);
            this.salesStartDtp.Name = "salesStartDtp";
            this.salesStartDtp.Size = new System.Drawing.Size(200, 36);
            this.salesStartDtp.TabIndex = 3;
            // 
            // salesEndDtp
            // 
            this.salesEndDtp.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.salesEndDtp.Location = new System.Drawing.Point(1370, 844);
            this.salesEndDtp.Name = "salesEndDtp";
            this.salesEndDtp.Size = new System.Drawing.Size(200, 36);
            this.salesEndDtp.TabIndex = 4;
            // 
            // salesBetweenLbl
            // 
            this.salesBetweenLbl.AutoSize = true;
            this.salesBetweenLbl.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.salesBetweenLbl.Location = new System.Drawing.Point(1453, 797);
            this.salesBetweenLbl.Name = "salesBetweenLbl";
            this.salesBetweenLbl.Size = new System.Drawing.Size(43, 29);
            this.salesBetweenLbl.TabIndex = 5;
            this.salesBetweenLbl.Text = "～";
            // 
            // rankBtn
            // 
            this.rankBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rankBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rankBtn.Location = new System.Drawing.Point(1384, 107);
            this.rankBtn.Name = "rankBtn";
            this.rankBtn.Size = new System.Drawing.Size(186, 58);
            this.rankBtn.TabIndex = 1;
            this.rankBtn.Text = "ランキング";
            this.rankBtn.UseVisualStyleBackColor = true;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1610, 982);
            this.Controls.Add(this.salesBetweenLbl);
            this.Controls.Add(this.salesEndDtp);
            this.Controls.Add(this.salesStartDtp);
            this.Controls.Add(this.salesDgv);
            this.Controls.Add(this.rankBtn);
            this.Controls.Add(this.salesSelectBtn);
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
        private System.Windows.Forms.Button salesSelectBtn;
        private System.Windows.Forms.DataGridView salesDgv;
        private System.Windows.Forms.DateTimePicker salesStartDtp;
        private System.Windows.Forms.DateTimePicker salesEndDtp;
        private System.Windows.Forms.Label salesBetweenLbl;
        private System.Windows.Forms.Button rankBtn;
    }
}
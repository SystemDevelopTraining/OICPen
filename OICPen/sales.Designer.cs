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
            this.salesFullBtn = new System.Windows.Forms.Button();
            this.salesSelectBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rankBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // salesFullBtn
            // 
            this.salesFullBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.salesFullBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.salesFullBtn.Location = new System.Drawing.Point(1384, 383);
            this.salesFullBtn.Name = "salesFullBtn";
            this.salesFullBtn.Size = new System.Drawing.Size(186, 58);
            this.salesFullBtn.TabIndex = 1;
            this.salesFullBtn.Text = "売上一覧";
            this.salesFullBtn.UseVisualStyleBackColor = true;
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
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(1310, 936);
            this.dataGridView1.TabIndex = 2;
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
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rankBtn);
            this.Controls.Add(this.salesSelectBtn);
            this.Controls.Add(this.salesFullBtn);
            this.Controls.Add(this.salesLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sales";
            this.Text = "sales";
            this.Load += new System.EventHandler(this.sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label salesLbl;
        private System.Windows.Forms.Button salesFullBtn;
        private System.Windows.Forms.Button salesSelectBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button rankBtn;
    }
}
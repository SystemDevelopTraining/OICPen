namespace OICPen
{
    partial class Ship
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
            this.shipDgv = new System.Windows.Forms.DataGridView();
            this.shipTitleLbl = new System.Windows.Forms.Label();
            this.shippedCheckBtn = new System.Windows.Forms.Button();
            this.shipProcessingBtn = new System.Windows.Forms.Button();
            this.shipCheckBtn = new System.Windows.Forms.Button();
            this.shipFixBtn = new System.Windows.Forms.Button();
            this.ClientTID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.takeOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.takeOderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.shipDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // shipDgv
            // 
            this.shipDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shipDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientTID,
            this.takeOrderID,
            this.takeOderDate,
            this.shipDate});
            this.shipDgv.Location = new System.Drawing.Point(12, 21);
            this.shipDgv.Name = "shipDgv";
            this.shipDgv.RowTemplate.Height = 21;
            this.shipDgv.Size = new System.Drawing.Size(1310, 949);
            this.shipDgv.TabIndex = 0;
            // 
            // shipTitleLbl
            // 
            this.shipTitleLbl.AutoSize = true;
            this.shipTitleLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.shipTitleLbl.Location = new System.Drawing.Point(1373, 19);
            this.shipTitleLbl.Name = "shipTitleLbl";
            this.shipTitleLbl.Size = new System.Drawing.Size(212, 48);
            this.shipTitleLbl.TabIndex = 2;
            this.shipTitleLbl.Text = "出庫管理";
            // 
            // shippedCheckBtn
            // 
            this.shippedCheckBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.shippedCheckBtn.Location = new System.Drawing.Point(1369, 131);
            this.shippedCheckBtn.Name = "shippedCheckBtn";
            this.shippedCheckBtn.Size = new System.Drawing.Size(224, 58);
            this.shippedCheckBtn.TabIndex = 1;
            this.shippedCheckBtn.Text = "出庫済一覧";
            this.shippedCheckBtn.UseVisualStyleBackColor = true;
            this.shippedCheckBtn.Click += new System.EventHandler(this.shippedCheckBtn_Click);
            // 
            // shipProcessingBtn
            // 
            this.shipProcessingBtn.Font = new System.Drawing.Font("HGS創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.shipProcessingBtn.Location = new System.Drawing.Point(1369, 368);
            this.shipProcessingBtn.Name = "shipProcessingBtn";
            this.shipProcessingBtn.Size = new System.Drawing.Size(224, 58);
            this.shipProcessingBtn.TabIndex = 3;
            this.shipProcessingBtn.Text = "出庫処理実行";
            this.shipProcessingBtn.UseVisualStyleBackColor = true;
            this.shipProcessingBtn.Click += new System.EventHandler(this.shipProcessingBtn_Click);
            // 
            // shipCheckBtn
            // 
            this.shipCheckBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.shipCheckBtn.Location = new System.Drawing.Point(1369, 246);
            this.shipCheckBtn.Name = "shipCheckBtn";
            this.shipCheckBtn.Size = new System.Drawing.Size(224, 58);
            this.shipCheckBtn.TabIndex = 2;
            this.shipCheckBtn.Text = "未出庫一覧";
            this.shipCheckBtn.UseVisualStyleBackColor = true;
            this.shipCheckBtn.Click += new System.EventHandler(this.shipCheckBtn_Click);
            // 
            // shipFixBtn
            // 
            this.shipFixBtn.Font = new System.Drawing.Font("HGS創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.shipFixBtn.Location = new System.Drawing.Point(1374, 490);
            this.shipFixBtn.Name = "shipFixBtn";
            this.shipFixBtn.Size = new System.Drawing.Size(224, 58);
            this.shipFixBtn.TabIndex = 4;
            this.shipFixBtn.Text = "出庫処理取消";
            this.shipFixBtn.UseVisualStyleBackColor = true;
            this.shipFixBtn.Click += new System.EventHandler(this.shipFixBtn_Click);
            // 
            // ClientTID
            // 
            this.ClientTID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClientTID.HeaderText = "会員ID";
            this.ClientTID.Name = "ClientTID";
            // 
            // takeOrderID
            // 
            this.takeOrderID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.takeOrderID.HeaderText = "注文ID";
            this.takeOrderID.Name = "takeOrderID";
            // 
            // takeOderDate
            // 
            this.takeOderDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.takeOderDate.HeaderText = "注文日";
            this.takeOderDate.Name = "takeOderDate";
            // 
            // shipDate
            // 
            this.shipDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.shipDate.HeaderText = "出庫日";
            this.shipDate.Name = "shipDate";
            // 
            // Ship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1610, 982);
            this.Controls.Add(this.shipFixBtn);
            this.Controls.Add(this.shipProcessingBtn);
            this.Controls.Add(this.shipCheckBtn);
            this.Controls.Add(this.shippedCheckBtn);
            this.Controls.Add(this.shipTitleLbl);
            this.Controls.Add(this.shipDgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ship";
            this.Text = "Ship";
            ((System.ComponentModel.ISupportInitialize)(this.shipDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView shipDgv;
        private System.Windows.Forms.Label shipTitleLbl;
        private System.Windows.Forms.Button shippedCheckBtn;
        private System.Windows.Forms.Button shipProcessingBtn;
        private System.Windows.Forms.Button shipCheckBtn;
        private System.Windows.Forms.Button shipFixBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientTID;
        private System.Windows.Forms.DataGridViewTextBoxColumn takeOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn takeOderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipDate;
    }
}
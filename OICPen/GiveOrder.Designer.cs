namespace OICPen
{
    partial class GiveOrder
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
            this.giveorderTitleLbl = new System.Windows.Forms.Label();
            this.giveOrderDgv = new System.Windows.Forms.DataGridView();
            this.dgvTitleLbl = new System.Windows.Forms.Label();
            this.itemsCodeLbl = new System.Windows.Forms.Label();
            this.itemsCodeTbox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.statusBtn = new System.Windows.Forms.Button();
            this.madaBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.giveOrderDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // giveorderTitleLbl
            // 
            this.giveorderTitleLbl.AutoSize = true;
            this.giveorderTitleLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.giveorderTitleLbl.Location = new System.Drawing.Point(1374, 19);
            this.giveorderTitleLbl.Name = "giveorderTitleLbl";
            this.giveorderTitleLbl.Size = new System.Drawing.Size(212, 48);
            this.giveorderTitleLbl.TabIndex = 0;
            this.giveorderTitleLbl.Text = "発注管理";
            // 
            // giveOrderDgv
            // 
            this.giveOrderDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.giveOrderDgv.Location = new System.Drawing.Point(29, 155);
            this.giveOrderDgv.Name = "giveOrderDgv";
            this.giveOrderDgv.RowTemplate.Height = 21;
            this.giveOrderDgv.Size = new System.Drawing.Size(951, 782);
            this.giveOrderDgv.TabIndex = 1;
            // 
            // dgvTitleLbl
            // 
            this.dgvTitleLbl.AutoSize = true;
            this.dgvTitleLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dgvTitleLbl.Location = new System.Drawing.Point(389, 93);
            this.dgvTitleLbl.Name = "dgvTitleLbl";
            this.dgvTitleLbl.Size = new System.Drawing.Size(212, 48);
            this.dgvTitleLbl.TabIndex = 2;
            this.dgvTitleLbl.Text = "発注状況";
            this.dgvTitleLbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // itemsCodeLbl
            // 
            this.itemsCodeLbl.AutoSize = true;
            this.itemsCodeLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.itemsCodeLbl.Location = new System.Drawing.Point(1108, 513);
            this.itemsCodeLbl.Name = "itemsCodeLbl";
            this.itemsCodeLbl.Size = new System.Drawing.Size(158, 29);
            this.itemsCodeLbl.TabIndex = 6;
            this.itemsCodeLbl.Text = "商品コード";
            // 
            // itemsCodeTbox
            // 
            this.itemsCodeTbox.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.itemsCodeTbox.Location = new System.Drawing.Point(1071, 555);
            this.itemsCodeTbox.Name = "itemsCodeTbox";
            this.itemsCodeTbox.Size = new System.Drawing.Size(230, 36);
            this.itemsCodeTbox.TabIndex = 7;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.searchBtn.Location = new System.Drawing.Point(1071, 628);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(230, 54);
            this.searchBtn.TabIndex = 9;
            this.searchBtn.Text = "検索";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // statusBtn
            // 
            this.statusBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.statusBtn.Location = new System.Drawing.Point(1071, 232);
            this.statusBtn.Name = "statusBtn";
            this.statusBtn.Size = new System.Drawing.Size(230, 54);
            this.statusBtn.TabIndex = 10;
            this.statusBtn.Text = "現在状況";
            this.statusBtn.UseVisualStyleBackColor = true;
            // 
            // madaBtn
            // 
            this.madaBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.madaBtn.Location = new System.Drawing.Point(1071, 332);
            this.madaBtn.Name = "madaBtn";
            this.madaBtn.Size = new System.Drawing.Size(230, 54);
            this.madaBtn.TabIndex = 11;
            this.madaBtn.Text = "未入庫一覧";
            this.madaBtn.UseVisualStyleBackColor = true;
            // 
            // GiveOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1610, 982);
            this.Controls.Add(this.madaBtn);
            this.Controls.Add(this.statusBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.itemsCodeTbox);
            this.Controls.Add(this.itemsCodeLbl);
            this.Controls.Add(this.dgvTitleLbl);
            this.Controls.Add(this.giveOrderDgv);
            this.Controls.Add(this.giveorderTitleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GiveOrder";
            this.Text = "GiveOrder";
            ((System.ComponentModel.ISupportInitialize)(this.giveOrderDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label giveorderTitleLbl;
        private System.Windows.Forms.DataGridView giveOrderDgv;
        private System.Windows.Forms.Label dgvTitleLbl;
        private System.Windows.Forms.Label itemsCodeLbl;
        private System.Windows.Forms.TextBox itemsCodeTbox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button statusBtn;
        private System.Windows.Forms.Button madaBtn;
    }
}
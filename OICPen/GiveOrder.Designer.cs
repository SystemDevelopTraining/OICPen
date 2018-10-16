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
            this.giveordertitleLbl = new System.Windows.Forms.Label();
            this.giveorderDgv = new System.Windows.Forms.DataGridView();
            this.dgvtitleLbl = new System.Windows.Forms.Label();
            this.itemscodeLbl = new System.Windows.Forms.Label();
            this.itemscodeTbox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.statusBtn = new System.Windows.Forms.Button();
            this.madaBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.giveorderDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // giveordertitleLbl
            // 
            this.giveordertitleLbl.AutoSize = true;
            this.giveordertitleLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.giveordertitleLbl.Location = new System.Drawing.Point(1374, 19);
            this.giveordertitleLbl.Name = "giveordertitleLbl";
            this.giveordertitleLbl.Size = new System.Drawing.Size(212, 48);
            this.giveordertitleLbl.TabIndex = 0;
            this.giveordertitleLbl.Text = "発注管理";
            // 
            // giveorderDgv
            // 
            this.giveorderDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.giveorderDgv.Location = new System.Drawing.Point(29, 155);
            this.giveorderDgv.Name = "giveorderDgv";
            this.giveorderDgv.RowTemplate.Height = 21;
            this.giveorderDgv.Size = new System.Drawing.Size(726, 782);
            this.giveorderDgv.TabIndex = 1;
            // 
            // dgvtitleLbl
            // 
            this.dgvtitleLbl.AutoSize = true;
            this.dgvtitleLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dgvtitleLbl.Location = new System.Drawing.Point(278, 95);
            this.dgvtitleLbl.Name = "dgvtitleLbl";
            this.dgvtitleLbl.Size = new System.Drawing.Size(212, 48);
            this.dgvtitleLbl.TabIndex = 2;
            this.dgvtitleLbl.Text = "発注状況";
            this.dgvtitleLbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // itemscodeLbl
            // 
            this.itemscodeLbl.AutoSize = true;
            this.itemscodeLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.itemscodeLbl.Location = new System.Drawing.Point(1108, 513);
            this.itemscodeLbl.Name = "itemscodeLbl";
            this.itemscodeLbl.Size = new System.Drawing.Size(158, 29);
            this.itemscodeLbl.TabIndex = 6;
            this.itemscodeLbl.Text = "商品コード";
            // 
            // itemscodeTbox
            // 
            this.itemscodeTbox.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.itemscodeTbox.Location = new System.Drawing.Point(1071, 555);
            this.itemscodeTbox.Name = "itemscodeTbox";
            this.itemscodeTbox.Size = new System.Drawing.Size(230, 36);
            this.itemscodeTbox.TabIndex = 7;
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
            this.Controls.Add(this.itemscodeTbox);
            this.Controls.Add(this.itemscodeLbl);
            this.Controls.Add(this.dgvtitleLbl);
            this.Controls.Add(this.giveorderDgv);
            this.Controls.Add(this.giveordertitleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GiveOrder";
            this.Text = "GiveOrder";
            ((System.ComponentModel.ISupportInitialize)(this.giveorderDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label giveordertitleLbl;
        private System.Windows.Forms.DataGridView giveorderDgv;
        private System.Windows.Forms.Label dgvtitleLbl;
        private System.Windows.Forms.Label itemscodeLbl;
        private System.Windows.Forms.TextBox itemscodeTbox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button statusBtn;
        private System.Windows.Forms.Button madaBtn;
    }
}
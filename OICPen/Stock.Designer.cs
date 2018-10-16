namespace OICPen
{
    partial class Stock
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
            this.stocktitleLbl = new System.Windows.Forms.Label();
            this.stockDgv = new System.Windows.Forms.DataGridView();
            this.itemscodeLbl = new System.Windows.Forms.Label();
            this.itemsnameLbl = new System.Windows.Forms.Label();
            this.itemscodeTbox = new System.Windows.Forms.TextBox();
            this.itemsnameTbox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.stockdangerviewBtn = new System.Windows.Forms.Button();
            this.stockdate1Dtp = new System.Windows.Forms.DateTimePicker();
            this.stockviewBtn = new System.Windows.Forms.Button();
            this.separatorLbl = new System.Windows.Forms.Label();
            this.stockdate2Dtp = new System.Windows.Forms.DateTimePicker();
            this.hebiLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stockDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // stocktitleLbl
            // 
            this.stocktitleLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stocktitleLbl.AutoSize = true;
            this.stocktitleLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.stocktitleLbl.Location = new System.Drawing.Point(1373, 19);
            this.stocktitleLbl.Name = "stocktitleLbl";
            this.stocktitleLbl.Size = new System.Drawing.Size(212, 48);
            this.stocktitleLbl.TabIndex = 0;
            this.stocktitleLbl.Text = "在庫管理";
            // 
            // stockDgv
            // 
            this.stockDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stockDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockDgv.Location = new System.Drawing.Point(52, 66);
            this.stockDgv.Name = "stockDgv";
            this.stockDgv.RowTemplate.Height = 21;
            this.stockDgv.Size = new System.Drawing.Size(800, 852);
            this.stockDgv.TabIndex = 4;
            // 
            // itemscodeLbl
            // 
            this.itemscodeLbl.AutoSize = true;
            this.itemscodeLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.itemscodeLbl.Location = new System.Drawing.Point(1067, 256);
            this.itemscodeLbl.Name = "itemscodeLbl";
            this.itemscodeLbl.Size = new System.Drawing.Size(130, 29);
            this.itemscodeLbl.TabIndex = 5;
            this.itemscodeLbl.Text = "商品ID　";
            // 
            // itemsnameLbl
            // 
            this.itemsnameLbl.AutoSize = true;
            this.itemsnameLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.itemsnameLbl.Location = new System.Drawing.Point(1313, 256);
            this.itemsnameLbl.Name = "itemsnameLbl";
            this.itemsnameLbl.Size = new System.Drawing.Size(129, 29);
            this.itemsnameLbl.TabIndex = 5;
            this.itemsnameLbl.Text = "商品名　";
            // 
            // itemscodeTbox
            // 
            this.itemscodeTbox.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.itemscodeTbox.Location = new System.Drawing.Point(1005, 318);
            this.itemscodeTbox.Name = "itemscodeTbox";
            this.itemscodeTbox.Size = new System.Drawing.Size(218, 36);
            this.itemscodeTbox.TabIndex = 6;
            // 
            // itemsnameTbox
            // 
            this.itemsnameTbox.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.itemsnameTbox.Location = new System.Drawing.Point(1255, 318);
            this.itemsnameTbox.Name = "itemsnameTbox";
            this.itemsnameTbox.Size = new System.Drawing.Size(218, 36);
            this.itemsnameTbox.TabIndex = 6;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.searchBtn.Location = new System.Drawing.Point(1194, 387);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(104, 54);
            this.searchBtn.TabIndex = 8;
            this.searchBtn.Text = "検索";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // stockdangerviewBtn
            // 
            this.stockdangerviewBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.stockdangerviewBtn.Location = new System.Drawing.Point(1024, 774);
            this.stockdangerviewBtn.Name = "stockdangerviewBtn";
            this.stockdangerviewBtn.Size = new System.Drawing.Size(316, 53);
            this.stockdangerviewBtn.TabIndex = 8;
            this.stockdangerviewBtn.Text = "安全在庫数以下一覧";
            this.stockdangerviewBtn.UseVisualStyleBackColor = true;
            // 
            // stockdate1Dtp
            // 
            this.stockdate1Dtp.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.stockdate1Dtp.Location = new System.Drawing.Point(907, 608);
            this.stockdate1Dtp.Name = "stockdate1Dtp";
            this.stockdate1Dtp.Size = new System.Drawing.Size(239, 36);
            this.stockdate1Dtp.TabIndex = 9;
            // 
            // stockviewBtn
            // 
            this.stockviewBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.stockviewBtn.Location = new System.Drawing.Point(1024, 679);
            this.stockviewBtn.Name = "stockviewBtn";
            this.stockviewBtn.Size = new System.Drawing.Size(316, 53);
            this.stockviewBtn.TabIndex = 8;
            this.stockviewBtn.Text = "在庫状況一覧表示";
            this.stockviewBtn.UseVisualStyleBackColor = true;
            this.stockviewBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // separatorLbl
            // 
            this.separatorLbl.BackColor = System.Drawing.Color.Black;
            this.separatorLbl.Location = new System.Drawing.Point(898, 501);
            this.separatorLbl.Name = "separatorLbl";
            this.separatorLbl.Size = new System.Drawing.Size(643, 5);
            this.separatorLbl.TabIndex = 0;
            this.separatorLbl.Text = "label6";
            // 
            // stockdate2Dtp
            // 
            this.stockdate2Dtp.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.stockdate2Dtp.Location = new System.Drawing.Point(1255, 608);
            this.stockdate2Dtp.Name = "stockdate2Dtp";
            this.stockdate2Dtp.Size = new System.Drawing.Size(239, 36);
            this.stockdate2Dtp.TabIndex = 9;
            // 
            // hebiLbl
            // 
            this.hebiLbl.AutoSize = true;
            this.hebiLbl.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.hebiLbl.Location = new System.Drawing.Point(1169, 607);
            this.hebiLbl.Name = "hebiLbl";
            this.hebiLbl.Size = new System.Drawing.Size(54, 37);
            this.hebiLbl.TabIndex = 10;
            this.hebiLbl.Text = "～";
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1610, 982);
            this.Controls.Add(this.hebiLbl);
            this.Controls.Add(this.separatorLbl);
            this.Controls.Add(this.stockdate2Dtp);
            this.Controls.Add(this.stockdate1Dtp);
            this.Controls.Add(this.stockviewBtn);
            this.Controls.Add(this.stockdangerviewBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.itemsnameTbox);
            this.Controls.Add(this.itemscodeTbox);
            this.Controls.Add(this.itemsnameLbl);
            this.Controls.Add(this.itemscodeLbl);
            this.Controls.Add(this.stockDgv);
            this.Controls.Add(this.stocktitleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Stock";
            this.Text = "Stock";
            ((System.ComponentModel.ISupportInitialize)(this.stockDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stocktitleLbl;
        private System.Windows.Forms.DataGridView stockDgv;
        private System.Windows.Forms.Label itemscodeLbl;
        private System.Windows.Forms.Label itemsnameLbl;
        private System.Windows.Forms.TextBox itemscodeTbox;
        private System.Windows.Forms.TextBox itemsnameTbox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button stockdangerviewBtn;
        private System.Windows.Forms.DateTimePicker stockdate1Dtp;
        private System.Windows.Forms.Button stockviewBtn;
        private System.Windows.Forms.Label separatorLbl;
        private System.Windows.Forms.DateTimePicker stockdate2Dtp;
        private System.Windows.Forms.Label hebiLbl;
    }
}
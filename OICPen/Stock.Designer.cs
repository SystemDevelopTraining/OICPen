﻿namespace OICPen
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
            this.stockTitleLbl = new System.Windows.Forms.Label();
            this.stockDgv = new System.Windows.Forms.DataGridView();
            this.itemsCodeLbl = new System.Windows.Forms.Label();
            this.itemsNameLbl = new System.Windows.Forms.Label();
            this.itemsCodeTbox = new System.Windows.Forms.TextBox();
            this.itemsNameTbox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.stockDangerViewBtn = new System.Windows.Forms.Button();
            this.stockDate1Dtp = new System.Windows.Forms.DateTimePicker();
            this.stockViewBtn = new System.Windows.Forms.Button();
            this.separatorLbl = new System.Windows.Forms.Label();
            this.stockDate2Dtp = new System.Windows.Forms.DateTimePicker();
            this.hebiLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stockDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // stockTitleLbl
            // 
            this.stockTitleLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stockTitleLbl.AutoSize = true;
            this.stockTitleLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.stockTitleLbl.Location = new System.Drawing.Point(1373, 19);
            this.stockTitleLbl.Name = "stockTitleLbl";
            this.stockTitleLbl.Size = new System.Drawing.Size(212, 48);
            this.stockTitleLbl.TabIndex = 0;
            this.stockTitleLbl.Text = "在庫管理";
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
            // itemsCodeLbl
            // 
            this.itemsCodeLbl.AutoSize = true;
            this.itemsCodeLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.itemsCodeLbl.Location = new System.Drawing.Point(1067, 256);
            this.itemsCodeLbl.Name = "itemsCodeLbl";
            this.itemsCodeLbl.Size = new System.Drawing.Size(130, 29);
            this.itemsCodeLbl.TabIndex = 5;
            this.itemsCodeLbl.Text = "商品ID　";
            // 
            // itemsNameLbl
            // 
            this.itemsNameLbl.AutoSize = true;
            this.itemsNameLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.itemsNameLbl.Location = new System.Drawing.Point(1313, 256);
            this.itemsNameLbl.Name = "itemsNameLbl";
            this.itemsNameLbl.Size = new System.Drawing.Size(129, 29);
            this.itemsNameLbl.TabIndex = 5;
            this.itemsNameLbl.Text = "商品名　";
            // 
            // itemsCodeTbox
            // 
            this.itemsCodeTbox.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.itemsCodeTbox.Location = new System.Drawing.Point(1005, 318);
            this.itemsCodeTbox.MaxLength = 6;
            this.itemsCodeTbox.Name = "itemsCodeTbox";
            this.itemsCodeTbox.Size = new System.Drawing.Size(218, 36);
            this.itemsCodeTbox.TabIndex = 6;
            // 
            // itemsNameTbox
            // 
            this.itemsNameTbox.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.itemsNameTbox.Location = new System.Drawing.Point(1255, 318);
            this.itemsNameTbox.MaxLength = 50;
            this.itemsNameTbox.Name = "itemsNameTbox";
            this.itemsNameTbox.Size = new System.Drawing.Size(218, 36);
            this.itemsNameTbox.TabIndex = 6;
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
            // stockDangerViewBtn
            // 
            this.stockDangerViewBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.stockDangerViewBtn.Location = new System.Drawing.Point(1024, 774);
            this.stockDangerViewBtn.Name = "stockDangerViewBtn";
            this.stockDangerViewBtn.Size = new System.Drawing.Size(316, 53);
            this.stockDangerViewBtn.TabIndex = 8;
            this.stockDangerViewBtn.Text = "安全在庫数以下一覧";
            this.stockDangerViewBtn.UseVisualStyleBackColor = true;
            // 
            // stockDate1Dtp
            // 
            this.stockDate1Dtp.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.stockDate1Dtp.Location = new System.Drawing.Point(907, 608);
            this.stockDate1Dtp.Name = "stockDate1Dtp";
            this.stockDate1Dtp.Size = new System.Drawing.Size(239, 36);
            this.stockDate1Dtp.TabIndex = 9;
            // 
            // stockViewBtn
            // 
            this.stockViewBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.stockViewBtn.Location = new System.Drawing.Point(1024, 679);
            this.stockViewBtn.Name = "stockViewBtn";
            this.stockViewBtn.Size = new System.Drawing.Size(316, 53);
            this.stockViewBtn.TabIndex = 8;
            this.stockViewBtn.Text = "在庫状況一覧表示";
            this.stockViewBtn.UseVisualStyleBackColor = true;
            this.stockViewBtn.Click += new System.EventHandler(this.button2_Click);
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
            // stockDate2Dtp
            // 
            this.stockDate2Dtp.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.stockDate2Dtp.Location = new System.Drawing.Point(1255, 608);
            this.stockDate2Dtp.Name = "stockDate2Dtp";
            this.stockDate2Dtp.Size = new System.Drawing.Size(239, 36);
            this.stockDate2Dtp.TabIndex = 9;
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
            this.Controls.Add(this.stockDate2Dtp);
            this.Controls.Add(this.stockDate1Dtp);
            this.Controls.Add(this.stockViewBtn);
            this.Controls.Add(this.stockDangerViewBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.itemsNameTbox);
            this.Controls.Add(this.itemsCodeTbox);
            this.Controls.Add(this.itemsNameLbl);
            this.Controls.Add(this.itemsCodeLbl);
            this.Controls.Add(this.stockDgv);
            this.Controls.Add(this.stockTitleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Stock";
            this.Text = "Stock";
            ((System.ComponentModel.ISupportInitialize)(this.stockDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stockTitleLbl;
        private System.Windows.Forms.DataGridView stockDgv;
        private System.Windows.Forms.Label itemsCodeLbl;
        private System.Windows.Forms.Label itemsNameLbl;
        private System.Windows.Forms.TextBox itemsCodeTbox;
        private System.Windows.Forms.TextBox itemsNameTbox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button stockDangerViewBtn;
        private System.Windows.Forms.DateTimePicker stockDate1Dtp;
        private System.Windows.Forms.Button stockViewBtn;
        private System.Windows.Forms.Label separatorLbl;
        private System.Windows.Forms.DateTimePicker stockDate2Dtp;
        private System.Windows.Forms.Label hebiLbl;
    }
}
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
            this.stockViewBtn = new System.Windows.Forms.Button();
            this.separatorLbl = new System.Windows.Forms.Label();
            this.商品ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.現在在庫数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.stockDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.商品ID,
            this.商品名,
            this.現在在庫数});
            this.stockDgv.Location = new System.Drawing.Point(12, 21);
            this.stockDgv.Name = "stockDgv";
            this.stockDgv.RowTemplate.Height = 21;
            this.stockDgv.Size = new System.Drawing.Size(800, 949);
            this.stockDgv.TabIndex = 6;
            this.stockDgv.TabStop = false;
            this.stockDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stockDgv_CellContentClick);
            // 
            // itemsCodeLbl
            // 
            this.itemsCodeLbl.AutoSize = true;
            this.itemsCodeLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.itemsCodeLbl.Location = new System.Drawing.Point(1000, 228);
            this.itemsCodeLbl.Name = "itemsCodeLbl";
            this.itemsCodeLbl.Size = new System.Drawing.Size(159, 29);
            this.itemsCodeLbl.TabIndex = 5;
            this.itemsCodeLbl.Text = "商品ID：　";
            // 
            // itemsNameLbl
            // 
            this.itemsNameLbl.AutoSize = true;
            this.itemsNameLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.itemsNameLbl.Location = new System.Drawing.Point(1001, 316);
            this.itemsNameLbl.Name = "itemsNameLbl";
            this.itemsNameLbl.Size = new System.Drawing.Size(158, 29);
            this.itemsNameLbl.TabIndex = 5;
            this.itemsNameLbl.Text = "商品名：　";
            // 
            // itemsCodeTbox
            // 
            this.itemsCodeTbox.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.itemsCodeTbox.Location = new System.Drawing.Point(1165, 228);
            this.itemsCodeTbox.MaxLength = 6;
            this.itemsCodeTbox.Name = "itemsCodeTbox";
            this.itemsCodeTbox.Size = new System.Drawing.Size(218, 36);
            this.itemsCodeTbox.TabIndex = 1;
            this.itemsCodeTbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.itemsCodeTbox_KeyPress);
            // 
            // itemsNameTbox
            // 
            this.itemsNameTbox.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.itemsNameTbox.Location = new System.Drawing.Point(1165, 314);
            this.itemsNameTbox.MaxLength = 50;
            this.itemsNameTbox.Name = "itemsNameTbox";
            this.itemsNameTbox.Size = new System.Drawing.Size(358, 36);
            this.itemsNameTbox.TabIndex = 2;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.searchBtn.Location = new System.Drawing.Point(1174, 378);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(104, 54);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "検索";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // stockDangerViewBtn
            // 
            this.stockDangerViewBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.stockDangerViewBtn.Location = new System.Drawing.Point(1046, 732);
            this.stockDangerViewBtn.Name = "stockDangerViewBtn";
            this.stockDangerViewBtn.Size = new System.Drawing.Size(316, 53);
            this.stockDangerViewBtn.TabIndex = 5;
            this.stockDangerViewBtn.Text = "安全在庫数以下一覧";
            this.stockDangerViewBtn.UseVisualStyleBackColor = true;
            // 
            // stockViewBtn
            // 
            this.stockViewBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.stockViewBtn.Location = new System.Drawing.Point(1046, 618);
            this.stockViewBtn.Name = "stockViewBtn";
            this.stockViewBtn.Size = new System.Drawing.Size(316, 53);
            this.stockViewBtn.TabIndex = 4;
            this.stockViewBtn.Text = "在庫状況一覧表示";
            this.stockViewBtn.UseVisualStyleBackColor = true;
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
            // 商品ID
            // 
            this.商品ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.商品ID.HeaderText = "商品ID";
            this.商品ID.Name = "商品ID";
            this.商品ID.ReadOnly = true;
            this.商品ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // 商品名
            // 
            this.商品名.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.商品名.HeaderText = "商品名";
            this.商品名.Name = "商品名";
            // 
            // 現在在庫数
            // 
            this.現在在庫数.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.現在在庫数.HeaderText = "現在在庫数";
            this.現在在庫数.Name = "現在在庫数";
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1610, 982);
            this.Controls.Add(this.separatorLbl);
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
        private System.Windows.Forms.Button stockViewBtn;
        private System.Windows.Forms.Label separatorLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 現在在庫数;
    }
}
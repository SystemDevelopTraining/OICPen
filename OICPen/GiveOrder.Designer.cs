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
            this.completeOrdersTitleLbl = new System.Windows.Forms.Label();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.completeOrdersViewDgv = new System.Windows.Forms.DataGridView();
            this.searchBtn = new System.Windows.Forms.Button();
            this.itemNameTbox = new System.Windows.Forms.TextBox();
            this.itemsViewDgv = new System.Windows.Forms.DataGridView();
            this.allClearBtn = new System.Windows.Forms.Button();
            this.completeBtn = new System.Windows.Forms.Button();
            this.countsTbox = new System.Windows.Forms.TextBox();
            this.itemIdTbox = new System.Windows.Forms.TextBox();
            this.countsLbl = new System.Windows.Forms.Label();
            this.itemNameLbl = new System.Windows.Forms.Label();
            this.itemIdLbl = new System.Windows.Forms.Label();
            this.searchResultLbl = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.completeOrdersViewDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsViewDgv)).BeginInit();
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
            // completeOrdersTitleLbl
            // 
            this.completeOrdersTitleLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.completeOrdersTitleLbl.AutoSize = true;
            this.completeOrdersTitleLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.completeOrdersTitleLbl.Location = new System.Drawing.Point(949, 181);
            this.completeOrdersTitleLbl.Name = "completeOrdersTitleLbl";
            this.completeOrdersTitleLbl.Size = new System.Drawing.Size(260, 48);
            this.completeOrdersTitleLbl.TabIndex = 0;
            this.completeOrdersTitleLbl.Text = "発注リスト";
            // 
            // confirmBtn
            // 
            this.confirmBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.confirmBtn.Location = new System.Drawing.Point(629, 613);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(83, 54);
            this.confirmBtn.TabIndex = 5;
            this.confirmBtn.Text = "確定";
            this.confirmBtn.UseVisualStyleBackColor = true;
            // 
            // completeOrdersViewDgv
            // 
            this.completeOrdersViewDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.completeOrdersViewDgv.Location = new System.Drawing.Point(789, 241);
            this.completeOrdersViewDgv.Name = "completeOrdersViewDgv";
            this.completeOrdersViewDgv.RowTemplate.Height = 21;
            this.completeOrdersViewDgv.Size = new System.Drawing.Size(535, 593);
            this.completeOrdersViewDgv.TabIndex = 0;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.searchBtn.Location = new System.Drawing.Point(286, 370);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(104, 54);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "検索";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // itemNameTbox
            // 
            this.itemNameTbox.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.itemNameTbox.Location = new System.Drawing.Point(286, 228);
            this.itemNameTbox.Name = "itemNameTbox";
            this.itemNameTbox.Size = new System.Drawing.Size(218, 36);
            this.itemNameTbox.TabIndex = 1;
            // 
            // itemsViewDgv
            // 
            this.itemsViewDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsViewDgv.Location = new System.Drawing.Point(157, 534);
            this.itemsViewDgv.Name = "itemsViewDgv";
            this.itemsViewDgv.RowTemplate.Height = 21;
            this.itemsViewDgv.Size = new System.Drawing.Size(378, 351);
            this.itemsViewDgv.TabIndex = 0;
            // 
            // allClearBtn
            // 
            this.allClearBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.allClearBtn.Location = new System.Drawing.Point(1388, 534);
            this.allClearBtn.Name = "allClearBtn";
            this.allClearBtn.Size = new System.Drawing.Size(138, 54);
            this.allClearBtn.TabIndex = 7;
            this.allClearBtn.Text = "クリア";
            this.allClearBtn.UseVisualStyleBackColor = true;
            // 
            // completeBtn
            // 
            this.completeBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.completeBtn.Location = new System.Drawing.Point(1388, 639);
            this.completeBtn.Name = "completeBtn";
            this.completeBtn.Size = new System.Drawing.Size(138, 54);
            this.completeBtn.TabIndex = 8;
            this.completeBtn.Text = "完了";
            this.completeBtn.UseVisualStyleBackColor = true;
            // 
            // countsTbox
            // 
            this.countsTbox.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.countsTbox.Location = new System.Drawing.Point(629, 554);
            this.countsTbox.Name = "countsTbox";
            this.countsTbox.Size = new System.Drawing.Size(83, 36);
            this.countsTbox.TabIndex = 4;
            // 
            // itemIdTbox
            // 
            this.itemIdTbox.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.itemIdTbox.Location = new System.Drawing.Point(286, 298);
            this.itemIdTbox.Name = "itemIdTbox";
            this.itemIdTbox.Size = new System.Drawing.Size(218, 36);
            this.itemIdTbox.TabIndex = 2;
            // 
            // countsLbl
            // 
            this.countsLbl.AutoSize = true;
            this.countsLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.countsLbl.Location = new System.Drawing.Point(641, 501);
            this.countsLbl.Name = "countsLbl";
            this.countsLbl.Size = new System.Drawing.Size(71, 29);
            this.countsLbl.TabIndex = 0;
            this.countsLbl.Text = "数量";
            // 
            // itemNameLbl
            // 
            this.itemNameLbl.AutoSize = true;
            this.itemNameLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.itemNameLbl.Location = new System.Drawing.Point(101, 235);
            this.itemNameLbl.Name = "itemNameLbl";
            this.itemNameLbl.Size = new System.Drawing.Size(158, 29);
            this.itemNameLbl.TabIndex = 0;
            this.itemNameLbl.Text = "商品名：　";
            // 
            // itemIdLbl
            // 
            this.itemIdLbl.AutoSize = true;
            this.itemIdLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.itemIdLbl.Location = new System.Drawing.Point(101, 305);
            this.itemIdLbl.Name = "itemIdLbl";
            this.itemIdLbl.Size = new System.Drawing.Size(159, 29);
            this.itemIdLbl.TabIndex = 0;
            this.itemIdLbl.Text = "商品ID：　";
            // 
            // searchResultLbl
            // 
            this.searchResultLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchResultLbl.AutoSize = true;
            this.searchResultLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.searchResultLbl.Location = new System.Drawing.Point(248, 470);
            this.searchResultLbl.Name = "searchResultLbl";
            this.searchResultLbl.Size = new System.Drawing.Size(212, 48);
            this.searchResultLbl.TabIndex = 0;
            this.searchResultLbl.Text = "検索結果";
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.clearBtn.Location = new System.Drawing.Point(1388, 432);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(138, 54);
            this.clearBtn.TabIndex = 6;
            this.clearBtn.Text = "削除";
            this.clearBtn.UseVisualStyleBackColor = true;
            // 
            // GiveOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1610, 982);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.searchResultLbl);
            this.Controls.Add(this.itemNameLbl);
            this.Controls.Add(this.itemIdLbl);
            this.Controls.Add(this.completeOrdersTitleLbl);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.completeOrdersViewDgv);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.itemNameTbox);
            this.Controls.Add(this.itemsViewDgv);
            this.Controls.Add(this.allClearBtn);
            this.Controls.Add(this.completeBtn);
            this.Controls.Add(this.countsTbox);
            this.Controls.Add(this.itemIdTbox);
            this.Controls.Add(this.countsLbl);
            this.Controls.Add(this.giveorderTitleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GiveOrder";
            this.Text = "GiveOrder";
            this.Load += new System.EventHandler(this.GiveOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.completeOrdersViewDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsViewDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label giveorderTitleLbl;
        private System.Windows.Forms.Label completeOrdersTitleLbl;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.DataGridView completeOrdersViewDgv;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox itemNameTbox;
        private System.Windows.Forms.DataGridView itemsViewDgv;
        private System.Windows.Forms.Button allClearBtn;
        private System.Windows.Forms.Button completeBtn;
        private System.Windows.Forms.TextBox countsTbox;
        private System.Windows.Forms.TextBox itemIdTbox;
        private System.Windows.Forms.Label countsLbl;
        private System.Windows.Forms.Label itemNameLbl;
        private System.Windows.Forms.Label itemIdLbl;
        private System.Windows.Forms.Label searchResultLbl;
        private System.Windows.Forms.Button clearBtn;
    }
}
namespace OICPen
{
    partial class TakeOrder
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
            this.takeOrdersTitleLbl = new System.Windows.Forms.Label();
            this.clientsIdLbl = new System.Windows.Forms.Label();
            this.separatorLbl = new System.Windows.Forms.Label();
            this.receptionLbl = new System.Windows.Forms.Label();
            this.itemIdLbl = new System.Windows.Forms.Label();
            this.itemIdTbox = new System.Windows.Forms.TextBox();
            this.countsLbl = new System.Windows.Forms.Label();
            this.countsTbox = new System.Windows.Forms.TextBox();
            this.completeBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.clientsIdTbox = new System.Windows.Forms.TextBox();
            this.clientsIdCheckBtn = new System.Windows.Forms.Button();
            this.itemNameLbl = new System.Windows.Forms.Label();
            this.itemNameTbox = new System.Windows.Forms.TextBox();
            this.clientsIdViewLbl = new System.Windows.Forms.Label();
            this.clientsNameViewLbl = new System.Windows.Forms.Label();
            this.itemsViewDgv = new System.Windows.Forms.DataGridView();
            this.searchBtn = new System.Windows.Forms.Button();
            this.completeOrdersDgv = new System.Windows.Forms.DataGridView();
            this.clientsPhoneNoViewLbl = new System.Windows.Forms.Label();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.completeOrdersTitleLbl = new System.Windows.Forms.Label();
            this.delBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.itemsViewDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.completeOrdersDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // takeOrdersTitleLbl
            // 
            this.takeOrdersTitleLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.takeOrdersTitleLbl.AutoSize = true;
            this.takeOrdersTitleLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.takeOrdersTitleLbl.Location = new System.Drawing.Point(2517, 33);
            this.takeOrdersTitleLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.takeOrdersTitleLbl.Name = "takeOrdersTitleLbl";
            this.takeOrdersTitleLbl.Size = new System.Drawing.Size(371, 84);
            this.takeOrdersTitleLbl.TabIndex = 1;
            this.takeOrdersTitleLbl.Text = "注文管理";
            // 
            // clientsIdLbl
            // 
            this.clientsIdLbl.AutoSize = true;
            this.clientsIdLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.clientsIdLbl.Location = new System.Drawing.Point(928, 285);
            this.clientsIdLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.clientsIdLbl.Name = "clientsIdLbl";
            this.clientsIdLbl.Size = new System.Drawing.Size(278, 51);
            this.clientsIdLbl.TabIndex = 6;
            this.clientsIdLbl.Text = "会員ID：　";
            // 
            // separatorLbl
            // 
            this.separatorLbl.BackColor = System.Drawing.Color.Black;
            this.separatorLbl.Location = new System.Drawing.Point(200, 410);
            this.separatorLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.separatorLbl.Name = "separatorLbl";
            this.separatorLbl.Size = new System.Drawing.Size(2636, 18);
            this.separatorLbl.TabIndex = 8;
            this.separatorLbl.Click += new System.EventHandler(this.separatorLbl_Click);
            // 
            // receptionLbl
            // 
            this.receptionLbl.AutoSize = true;
            this.receptionLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.receptionLbl.ForeColor = System.Drawing.Color.Red;
            this.receptionLbl.Location = new System.Drawing.Point(711, 458);
            this.receptionLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.receptionLbl.Name = "receptionLbl";
            this.receptionLbl.Size = new System.Drawing.Size(226, 51);
            this.receptionLbl.TabIndex = 10;
            this.receptionLbl.Text = "注文受付";
            // 
            // itemIdLbl
            // 
            this.itemIdLbl.AutoSize = true;
            this.itemIdLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.itemIdLbl.Location = new System.Drawing.Point(176, 919);
            this.itemIdLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.itemIdLbl.Name = "itemIdLbl";
            this.itemIdLbl.Size = new System.Drawing.Size(278, 51);
            this.itemIdLbl.TabIndex = 6;
            this.itemIdLbl.Text = "商品ID：　";
            // 
            // itemIdTbox
            // 
            this.itemIdTbox.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.itemIdTbox.Location = new System.Drawing.Point(477, 919);
            this.itemIdTbox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.itemIdTbox.Name = "itemIdTbox";
            this.itemIdTbox.Size = new System.Drawing.Size(396, 58);
            this.itemIdTbox.TabIndex = 7;
            // 
            // countsLbl
            // 
            this.countsLbl.AutoSize = true;
            this.countsLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.countsLbl.Location = new System.Drawing.Point(1089, 1316);
            this.countsLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.countsLbl.Name = "countsLbl";
            this.countsLbl.Size = new System.Drawing.Size(124, 51);
            this.countsLbl.TabIndex = 6;
            this.countsLbl.Text = "数量";
            // 
            // countsTbox
            // 
            this.countsTbox.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.countsTbox.Location = new System.Drawing.Point(1098, 1410);
            this.countsTbox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.countsTbox.Name = "countsTbox";
            this.countsTbox.Size = new System.Drawing.Size(149, 58);
            this.countsTbox.TabIndex = 7;
            // 
            // completeBtn
            // 
            this.completeBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.completeBtn.Location = new System.Drawing.Point(2503, 1272);
            this.completeBtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.completeBtn.Name = "completeBtn";
            this.completeBtn.Size = new System.Drawing.Size(229, 94);
            this.completeBtn.TabIndex = 11;
            this.completeBtn.Text = "完了";
            this.completeBtn.UseVisualStyleBackColor = true;
            this.completeBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.clearBtn.Location = new System.Drawing.Point(2503, 1078);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(229, 94);
            this.clearBtn.TabIndex = 12;
            this.clearBtn.Text = "クリア";
            this.clearBtn.UseVisualStyleBackColor = true;
            // 
            // clientsIdTbox
            // 
            this.clientsIdTbox.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.clientsIdTbox.Location = new System.Drawing.Point(1247, 282);
            this.clientsIdTbox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.clientsIdTbox.Name = "clientsIdTbox";
            this.clientsIdTbox.Size = new System.Drawing.Size(396, 58);
            this.clientsIdTbox.TabIndex = 7;
            // 
            // clientsIdCheckBtn
            // 
            this.clientsIdCheckBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.clientsIdCheckBtn.Location = new System.Drawing.Point(1712, 264);
            this.clientsIdCheckBtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.clientsIdCheckBtn.Name = "clientsIdCheckBtn";
            this.clientsIdCheckBtn.Size = new System.Drawing.Size(191, 94);
            this.clientsIdCheckBtn.TabIndex = 13;
            this.clientsIdCheckBtn.Text = "確認";
            this.clientsIdCheckBtn.UseVisualStyleBackColor = true;
            // 
            // itemNameLbl
            // 
            this.itemNameLbl.AutoSize = true;
            this.itemNameLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.itemNameLbl.Location = new System.Drawing.Point(176, 796);
            this.itemNameLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.itemNameLbl.Name = "itemNameLbl";
            this.itemNameLbl.Size = new System.Drawing.Size(277, 51);
            this.itemNameLbl.TabIndex = 15;
            this.itemNameLbl.Text = "商品名：　";
            // 
            // itemNameTbox
            // 
            this.itemNameTbox.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.itemNameTbox.Location = new System.Drawing.Point(477, 796);
            this.itemNameTbox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.itemNameTbox.Name = "itemNameTbox";
            this.itemNameTbox.Size = new System.Drawing.Size(396, 58);
            this.itemNameTbox.TabIndex = 16;
            // 
            // clientsIdViewLbl
            // 
            this.clientsIdViewLbl.AutoSize = true;
            this.clientsIdViewLbl.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.clientsIdViewLbl.Location = new System.Drawing.Point(176, 572);
            this.clientsIdViewLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.clientsIdViewLbl.Name = "clientsIdViewLbl";
            this.clientsIdViewLbl.Size = new System.Drawing.Size(386, 51);
            this.clientsIdViewLbl.TabIndex = 17;
            this.clientsIdViewLbl.Text = "{会員IDが表示}";
            // 
            // clientsNameViewLbl
            // 
            this.clientsNameViewLbl.AutoSize = true;
            this.clientsNameViewLbl.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.clientsNameViewLbl.Location = new System.Drawing.Point(594, 572);
            this.clientsNameViewLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.clientsNameViewLbl.Name = "clientsNameViewLbl";
            this.clientsNameViewLbl.Size = new System.Drawing.Size(386, 51);
            this.clientsNameViewLbl.TabIndex = 18;
            this.clientsNameViewLbl.Text = "{会員名が表示}";
            // 
            // itemsViewDgv
            // 
            this.itemsViewDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsViewDgv.Location = new System.Drawing.Point(237, 1200);
            this.itemsViewDgv.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.itemsViewDgv.Name = "itemsViewDgv";
            this.itemsViewDgv.RowTemplate.Height = 21;
            this.itemsViewDgv.Size = new System.Drawing.Size(693, 457);
            this.itemsViewDgv.TabIndex = 14;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.searchBtn.Location = new System.Drawing.Point(477, 1045);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(191, 94);
            this.searchBtn.TabIndex = 19;
            this.searchBtn.Text = "検索";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // completeOrdersDgv
            // 
            this.completeOrdersDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.completeOrdersDgv.Location = new System.Drawing.Point(1404, 620);
            this.completeOrdersDgv.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.completeOrdersDgv.Name = "completeOrdersDgv";
            this.completeOrdersDgv.RowTemplate.Height = 21;
            this.completeOrdersDgv.Size = new System.Drawing.Size(981, 1038);
            this.completeOrdersDgv.TabIndex = 20;
            // 
            // clientsPhoneNoViewLbl
            // 
            this.clientsPhoneNoViewLbl.AutoSize = true;
            this.clientsPhoneNoViewLbl.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.clientsPhoneNoViewLbl.Location = new System.Drawing.Point(1023, 572);
            this.clientsPhoneNoViewLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.clientsPhoneNoViewLbl.Name = "clientsPhoneNoViewLbl";
            this.clientsPhoneNoViewLbl.Size = new System.Drawing.Size(282, 51);
            this.clientsPhoneNoViewLbl.TabIndex = 22;
            this.clientsPhoneNoViewLbl.Text = "{電話番号}";
            // 
            // confirmBtn
            // 
            this.confirmBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.confirmBtn.Location = new System.Drawing.Point(1098, 1514);
            this.confirmBtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(152, 94);
            this.confirmBtn.TabIndex = 23;
            this.confirmBtn.Text = "確定";
            this.confirmBtn.UseVisualStyleBackColor = true;
            // 
            // completeOrdersTitleLbl
            // 
            this.completeOrdersTitleLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.completeOrdersTitleLbl.AutoSize = true;
            this.completeOrdersTitleLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.completeOrdersTitleLbl.Location = new System.Drawing.Point(1698, 514);
            this.completeOrdersTitleLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.completeOrdersTitleLbl.Name = "completeOrdersTitleLbl";
            this.completeOrdersTitleLbl.Size = new System.Drawing.Size(455, 84);
            this.completeOrdersTitleLbl.TabIndex = 24;
            this.completeOrdersTitleLbl.Text = "注文リスト";
            // 
            // delBtn
            // 
            this.delBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.delBtn.Location = new System.Drawing.Point(2503, 887);
            this.delBtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(229, 94);
            this.delBtn.TabIndex = 25;
            this.delBtn.Text = "削除";
            this.delBtn.UseVisualStyleBackColor = true;
            // 
            // TakeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(2908, 1718);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.completeOrdersTitleLbl);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.clientsPhoneNoViewLbl);
            this.Controls.Add(this.completeOrdersDgv);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.clientsNameViewLbl);
            this.Controls.Add(this.clientsIdViewLbl);
            this.Controls.Add(this.itemNameTbox);
            this.Controls.Add(this.itemNameLbl);
            this.Controls.Add(this.itemsViewDgv);
            this.Controls.Add(this.clientsIdCheckBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.completeBtn);
            this.Controls.Add(this.receptionLbl);
            this.Controls.Add(this.separatorLbl);
            this.Controls.Add(this.countsTbox);
            this.Controls.Add(this.itemIdTbox);
            this.Controls.Add(this.clientsIdTbox);
            this.Controls.Add(this.countsLbl);
            this.Controls.Add(this.itemIdLbl);
            this.Controls.Add(this.clientsIdLbl);
            this.Controls.Add(this.takeOrdersTitleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "TakeOrder";
            this.Text = "TakeOrder";
            this.Load += new System.EventHandler(this.TakeOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemsViewDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.completeOrdersDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label takeOrdersTitleLbl;
        private System.Windows.Forms.Label clientsIdLbl;
        private System.Windows.Forms.Label separatorLbl;
        private System.Windows.Forms.Label receptionLbl;
        private System.Windows.Forms.Label itemIdLbl;
        private System.Windows.Forms.TextBox itemIdTbox;
        private System.Windows.Forms.Label countsLbl;
        private System.Windows.Forms.TextBox countsTbox;
        private System.Windows.Forms.Button completeBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.TextBox clientsIdTbox;
        private System.Windows.Forms.Button clientsIdCheckBtn;
        private System.Windows.Forms.Label itemNameLbl;
        private System.Windows.Forms.TextBox itemNameTbox;
        private System.Windows.Forms.Label clientsIdViewLbl;
        private System.Windows.Forms.Label clientsNameViewLbl;
        private System.Windows.Forms.DataGridView itemsViewDgv;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.DataGridView completeOrdersDgv;
        private System.Windows.Forms.Label clientsPhoneNoViewLbl;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Label completeOrdersTitleLbl;
        private System.Windows.Forms.Button delBtn;
    }
}
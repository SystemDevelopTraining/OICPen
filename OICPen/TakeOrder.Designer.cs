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
            this.titleLbl = new System.Windows.Forms.Label();
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
            this.itemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchBtn = new System.Windows.Forms.Button();
            this.completeOrdersDgv = new System.Windows.Forms.DataGridView();
            this.ItemID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsPhoneNoViewLbl = new System.Windows.Forms.Label();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.completeOrdersTitleLbl = new System.Windows.Forms.Label();
            this.delBtn = new System.Windows.Forms.Button();
            this.clientIdLbl = new System.Windows.Forms.Label();
            this.clientNameLbl = new System.Windows.Forms.Label();
            this.phoneNoLbl = new System.Windows.Forms.Label();
            this.allItemBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.itemsViewDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.completeOrdersDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.titleLbl.Location = new System.Drawing.Point(1373, 19);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(212, 48);
            this.titleLbl.TabIndex = 1;
            this.titleLbl.Text = "注文管理";
            // 
            // clientsIdLbl
            // 
            this.clientsIdLbl.AutoSize = true;
            this.clientsIdLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.clientsIdLbl.Location = new System.Drawing.Point(561, 122);
            this.clientsIdLbl.Name = "clientsIdLbl";
            this.clientsIdLbl.Size = new System.Drawing.Size(159, 29);
            this.clientsIdLbl.TabIndex = 6;
            this.clientsIdLbl.Text = "会員ID：　";
            // 
            // separatorLbl
            // 
            this.separatorLbl.BackColor = System.Drawing.Color.Black;
            this.separatorLbl.Location = new System.Drawing.Point(109, 186);
            this.separatorLbl.Name = "separatorLbl";
            this.separatorLbl.Size = new System.Drawing.Size(1438, 5);
            this.separatorLbl.TabIndex = 8;
            // 
            // receptionLbl
            // 
            this.receptionLbl.AutoSize = true;
            this.receptionLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.receptionLbl.ForeColor = System.Drawing.Color.Red;
            this.receptionLbl.Location = new System.Drawing.Point(388, 210);
            this.receptionLbl.Name = "receptionLbl";
            this.receptionLbl.Size = new System.Drawing.Size(129, 29);
            this.receptionLbl.TabIndex = 10;
            this.receptionLbl.Text = "注文受付";
            // 
            // itemIdLbl
            // 
            this.itemIdLbl.AutoSize = true;
            this.itemIdLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.itemIdLbl.Location = new System.Drawing.Point(96, 454);
            this.itemIdLbl.Name = "itemIdLbl";
            this.itemIdLbl.Size = new System.Drawing.Size(159, 29);
            this.itemIdLbl.TabIndex = 6;
            this.itemIdLbl.Text = "商品ID：　";
            // 
            // itemIdTbox
            // 
            this.itemIdTbox.Enabled = false;
            this.itemIdTbox.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.itemIdTbox.Location = new System.Drawing.Point(260, 454);
            this.itemIdTbox.MaxLength = 6;
            this.itemIdTbox.Name = "itemIdTbox";
            this.itemIdTbox.Size = new System.Drawing.Size(104, 36);
            this.itemIdTbox.TabIndex = 4;
            this.itemIdTbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.itemIdTbox_KeyDown);
            this.itemIdTbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.itemIdTbox_KeyPress);
            // 
            // countsLbl
            // 
            this.countsLbl.AutoSize = true;
            this.countsLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.countsLbl.Location = new System.Drawing.Point(594, 634);
            this.countsLbl.Name = "countsLbl";
            this.countsLbl.Size = new System.Drawing.Size(71, 29);
            this.countsLbl.TabIndex = 6;
            this.countsLbl.Text = "数量";
            // 
            // countsTbox
            // 
            this.countsTbox.Enabled = false;
            this.countsTbox.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.countsTbox.Location = new System.Drawing.Point(581, 675);
            this.countsTbox.MaxLength = 6;
            this.countsTbox.Name = "countsTbox";
            this.countsTbox.Size = new System.Drawing.Size(101, 36);
            this.countsTbox.TabIndex = 6;
            this.countsTbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.countsTbox_KeyDown);
            this.countsTbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.countsTbox_KeyPress);
            // 
            // completeBtn
            // 
            this.completeBtn.Enabled = false;
            this.completeBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.completeBtn.Location = new System.Drawing.Point(1365, 675);
            this.completeBtn.Name = "completeBtn";
            this.completeBtn.Size = new System.Drawing.Size(125, 54);
            this.completeBtn.TabIndex = 11;
            this.completeBtn.Text = "完了";
            this.completeBtn.UseVisualStyleBackColor = true;
            this.completeBtn.Click += new System.EventHandler(this.completeBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Enabled = false;
            this.clearBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.clearBtn.Location = new System.Drawing.Point(1365, 564);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(125, 54);
            this.clearBtn.TabIndex = 10;
            this.clearBtn.Text = "クリア";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // clientsIdTbox
            // 
            this.clientsIdTbox.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.clientsIdTbox.Location = new System.Drawing.Point(733, 120);
            this.clientsIdTbox.MaxLength = 6;
            this.clientsIdTbox.Name = "clientsIdTbox";
            this.clientsIdTbox.Size = new System.Drawing.Size(97, 36);
            this.clientsIdTbox.TabIndex = 1;
            this.clientsIdTbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.clientsIdTbox_KeyDown);
            this.clientsIdTbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.clientsIdTbox_KeyPress);
            // 
            // clientsIdCheckBtn
            // 
            this.clientsIdCheckBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.clientsIdCheckBtn.Location = new System.Drawing.Point(843, 110);
            this.clientsIdCheckBtn.Name = "clientsIdCheckBtn";
            this.clientsIdCheckBtn.Size = new System.Drawing.Size(104, 54);
            this.clientsIdCheckBtn.TabIndex = 2;
            this.clientsIdCheckBtn.Text = "確認";
            this.clientsIdCheckBtn.UseVisualStyleBackColor = true;
            this.clientsIdCheckBtn.Click += new System.EventHandler(this.clientsIdCheckBtn_Click);
            // 
            // itemNameLbl
            // 
            this.itemNameLbl.AutoSize = true;
            this.itemNameLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.itemNameLbl.Location = new System.Drawing.Point(96, 384);
            this.itemNameLbl.Name = "itemNameLbl";
            this.itemNameLbl.Size = new System.Drawing.Size(158, 29);
            this.itemNameLbl.TabIndex = 15;
            this.itemNameLbl.Text = "商品名：　";
            // 
            // itemNameTbox
            // 
            this.itemNameTbox.Enabled = false;
            this.itemNameTbox.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.itemNameTbox.Location = new System.Drawing.Point(260, 384);
            this.itemNameTbox.MaxLength = 50;
            this.itemNameTbox.Name = "itemNameTbox";
            this.itemNameTbox.Size = new System.Drawing.Size(218, 36);
            this.itemNameTbox.TabIndex = 3;
            this.itemNameTbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.itemNameTbox_KeyDown);
            // 
            // clientsIdViewLbl
            // 
            this.clientsIdViewLbl.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.clientsIdViewLbl.Location = new System.Drawing.Point(106, 321);
            this.clientsIdViewLbl.Name = "clientsIdViewLbl";
            this.clientsIdViewLbl.Size = new System.Drawing.Size(138, 29);
            this.clientsIdViewLbl.TabIndex = 17;
            this.clientsIdViewLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clientsNameViewLbl
            // 
            this.clientsNameViewLbl.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.clientsNameViewLbl.Location = new System.Drawing.Point(282, 321);
            this.clientsNameViewLbl.Name = "clientsNameViewLbl";
            this.clientsNameViewLbl.Size = new System.Drawing.Size(223, 29);
            this.clientsNameViewLbl.TabIndex = 18;
            this.clientsNameViewLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemsViewDgv
            // 
            this.itemsViewDgv.AllowUserToAddRows = false;
            this.itemsViewDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsViewDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemID,
            this.itemName,
            this.quantity});
            this.itemsViewDgv.Enabled = false;
            this.itemsViewDgv.Location = new System.Drawing.Point(30, 634);
            this.itemsViewDgv.Name = "itemsViewDgv";
            this.itemsViewDgv.ReadOnly = true;
            this.itemsViewDgv.RowTemplate.Height = 21;
            this.itemsViewDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemsViewDgv.Size = new System.Drawing.Size(487, 313);
            this.itemsViewDgv.TabIndex = 0;
            this.itemsViewDgv.TabStop = false;
            // 
            // itemID
            // 
            this.itemID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemID.HeaderText = "商品ID";
            this.itemID.Name = "itemID";
            this.itemID.ReadOnly = true;
            // 
            // itemName
            // 
            this.itemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemName.HeaderText = "商品名";
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantity.HeaderText = "在庫数";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // searchBtn
            // 
            this.searchBtn.Enabled = false;
            this.searchBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.searchBtn.Location = new System.Drawing.Point(300, 517);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(104, 54);
            this.searchBtn.TabIndex = 5;
            this.searchBtn.Text = "検索";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // completeOrdersDgv
            // 
            this.completeOrdersDgv.AllowUserToAddRows = false;
            this.completeOrdersDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.completeOrdersDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID2,
            this.ItemName2,
            this.quantity2});
            this.completeOrdersDgv.Enabled = false;
            this.completeOrdersDgv.Location = new System.Drawing.Point(789, 316);
            this.completeOrdersDgv.Name = "completeOrdersDgv";
            this.completeOrdersDgv.RowTemplate.Height = 21;
            this.completeOrdersDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.completeOrdersDgv.Size = new System.Drawing.Size(535, 593);
            this.completeOrdersDgv.TabIndex = 0;
            this.completeOrdersDgv.TabStop = false;
            // 
            // ItemID2
            // 
            this.ItemID2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemID2.HeaderText = "商品ID";
            this.ItemID2.Name = "ItemID2";
            this.ItemID2.ReadOnly = true;
            // 
            // ItemName2
            // 
            this.ItemName2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemName2.HeaderText = "商品名";
            this.ItemName2.Name = "ItemName2";
            this.ItemName2.ReadOnly = true;
            // 
            // quantity2
            // 
            this.quantity2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantity2.HeaderText = "数量";
            this.quantity2.Name = "quantity2";
            this.quantity2.ReadOnly = true;
            // 
            // clientsPhoneNoViewLbl
            // 
            this.clientsPhoneNoViewLbl.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.clientsPhoneNoViewLbl.Location = new System.Drawing.Point(511, 321);
            this.clientsPhoneNoViewLbl.Name = "clientsPhoneNoViewLbl";
            this.clientsPhoneNoViewLbl.Size = new System.Drawing.Size(234, 29);
            this.clientsPhoneNoViewLbl.TabIndex = 22;
            this.clientsPhoneNoViewLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirmBtn
            // 
            this.confirmBtn.Enabled = false;
            this.confirmBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.confirmBtn.Location = new System.Drawing.Point(582, 717);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(100, 55);
            this.confirmBtn.TabIndex = 7;
            this.confirmBtn.Text = "確定";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            this.confirmBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.confirmBtn_KeyDown);
            // 
            // completeOrdersTitleLbl
            // 
            this.completeOrdersTitleLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.completeOrdersTitleLbl.AutoSize = true;
            this.completeOrdersTitleLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.completeOrdersTitleLbl.Location = new System.Drawing.Point(926, 232);
            this.completeOrdersTitleLbl.Name = "completeOrdersTitleLbl";
            this.completeOrdersTitleLbl.Size = new System.Drawing.Size(260, 48);
            this.completeOrdersTitleLbl.TabIndex = 24;
            this.completeOrdersTitleLbl.Text = "注文リスト";
            // 
            // delBtn
            // 
            this.delBtn.Enabled = false;
            this.delBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.delBtn.Location = new System.Drawing.Point(1365, 454);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(125, 54);
            this.delBtn.TabIndex = 9;
            this.delBtn.Text = "削除";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // clientIdLbl
            // 
            this.clientIdLbl.AutoSize = true;
            this.clientIdLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.clientIdLbl.Location = new System.Drawing.Point(159, 251);
            this.clientIdLbl.Name = "clientIdLbl";
            this.clientIdLbl.Size = new System.Drawing.Size(101, 29);
            this.clientIdLbl.TabIndex = 26;
            this.clientIdLbl.Text = "会員ID";
            // 
            // clientNameLbl
            // 
            this.clientNameLbl.AutoSize = true;
            this.clientNameLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.clientNameLbl.Location = new System.Drawing.Point(393, 251);
            this.clientNameLbl.Name = "clientNameLbl";
            this.clientNameLbl.Size = new System.Drawing.Size(100, 29);
            this.clientNameLbl.TabIndex = 27;
            this.clientNameLbl.Text = "会員名";
            // 
            // phoneNoLbl
            // 
            this.phoneNoLbl.AutoSize = true;
            this.phoneNoLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.phoneNoLbl.Location = new System.Drawing.Point(576, 251);
            this.phoneNoLbl.Name = "phoneNoLbl";
            this.phoneNoLbl.Size = new System.Drawing.Size(129, 29);
            this.phoneNoLbl.TabIndex = 28;
            this.phoneNoLbl.Text = "電話番号";
            // 
            // allItemBtn
            // 
            this.allItemBtn.Enabled = false;
            this.allItemBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.allItemBtn.Location = new System.Drawing.Point(544, 841);
            this.allItemBtn.Name = "allItemBtn";
            this.allItemBtn.Size = new System.Drawing.Size(176, 54);
            this.allItemBtn.TabIndex = 8;
            this.allItemBtn.Text = "全商品一覧";
            this.allItemBtn.UseVisualStyleBackColor = true;
            this.allItemBtn.Click += new System.EventHandler(this.allItemBtn_Click);
            // 
            // TakeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1610, 982);
            this.Controls.Add(this.allItemBtn);
            this.Controls.Add(this.phoneNoLbl);
            this.Controls.Add(this.clientNameLbl);
            this.Controls.Add(this.clientIdLbl);
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
            this.Controls.Add(this.titleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TakeOrder";
            this.Text = "TakeOrder";
            this.Load += new System.EventHandler(this.TakeOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemsViewDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.completeOrdersDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
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
        private System.Windows.Forms.Label clientIdLbl;
        private System.Windows.Forms.Label clientNameLbl;
        private System.Windows.Forms.Label phoneNoLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity2;
        private System.Windows.Forms.Button allItemBtn;
    }
}
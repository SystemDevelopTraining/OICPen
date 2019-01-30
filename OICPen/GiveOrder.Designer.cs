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
            this.titleLbl = new System.Windows.Forms.Label();
            this.giveOrderListLbl = new System.Windows.Forms.Label();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.giveOrderListDgv = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchBtn = new System.Windows.Forms.Button();
            this.itemNameTbox = new System.Windows.Forms.TextBox();
            this.itemsViewDgv = new System.Windows.Forms.DataGridView();
            this.itemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allClearBtn = new System.Windows.Forms.Button();
            this.completeBtn = new System.Windows.Forms.Button();
            this.quantityLbl = new System.Windows.Forms.Label();
            this.itemNameLbl = new System.Windows.Forms.Label();
            this.itemIdLbl = new System.Windows.Forms.Label();
            this.searchResultLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.itemIdTbox = new System.Windows.Forms.TextBox();
            this.quantityTbox = new System.Windows.Forms.TextBox();
            this.allItemBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.giveOrderListDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsViewDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.titleLbl.Location = new System.Drawing.Point(1374, 19);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(212, 48);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "発注管理";
            // 
            // giveOrderListLbl
            // 
            this.giveOrderListLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.giveOrderListLbl.AutoSize = true;
            this.giveOrderListLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.giveOrderListLbl.Location = new System.Drawing.Point(949, 181);
            this.giveOrderListLbl.Name = "giveOrderListLbl";
            this.giveOrderListLbl.Size = new System.Drawing.Size(260, 48);
            this.giveOrderListLbl.TabIndex = 0;
            this.giveOrderListLbl.Text = "発注リスト";
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
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // giveOrderListDgv
            // 
            this.giveOrderListDgv.AllowUserToAddRows = false;
            this.giveOrderListDgv.AllowUserToDeleteRows = false;
            this.giveOrderListDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.giveOrderListDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.giveOrderListDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.name2,
            this.orderQuantity});
            this.giveOrderListDgv.Location = new System.Drawing.Point(789, 241);
            this.giveOrderListDgv.MultiSelect = false;
            this.giveOrderListDgv.Name = "giveOrderListDgv";
            this.giveOrderListDgv.ReadOnly = true;
            this.giveOrderListDgv.RowTemplate.Height = 21;
            this.giveOrderListDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.giveOrderListDgv.Size = new System.Drawing.Size(535, 593);
            this.giveOrderListDgv.TabIndex = 0;
            this.giveOrderListDgv.TabStop = false;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.HeaderText = "商品ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // name2
            // 
            this.name2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name2.HeaderText = "商品名";
            this.name2.Name = "name2";
            this.name2.ReadOnly = true;
            // 
            // orderQuantity
            // 
            this.orderQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orderQuantity.HeaderText = "発注数";
            this.orderQuantity.Name = "orderQuantity";
            this.orderQuantity.ReadOnly = true;
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
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // itemNameTbox
            // 
            this.itemNameTbox.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.itemNameTbox.Location = new System.Drawing.Point(286, 228);
            this.itemNameTbox.MaxLength = 30;
            this.itemNameTbox.Name = "itemNameTbox";
            this.itemNameTbox.Size = new System.Drawing.Size(218, 36);
            this.itemNameTbox.TabIndex = 1;
            this.itemNameTbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.itemNameTbox_KeyPress);
            // 
            // itemsViewDgv
            // 
            this.itemsViewDgv.AllowUserToAddRows = false;
            this.itemsViewDgv.AllowUserToDeleteRows = false;
            this.itemsViewDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsViewDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemID,
            this.itemName,
            this.quantity});
            this.itemsViewDgv.Location = new System.Drawing.Point(30, 534);
            this.itemsViewDgv.MultiSelect = false;
            this.itemsViewDgv.Name = "itemsViewDgv";
            this.itemsViewDgv.ReadOnly = true;
            this.itemsViewDgv.RowTemplate.Height = 21;
            this.itemsViewDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemsViewDgv.Size = new System.Drawing.Size(573, 374);
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
            // allClearBtn
            // 
            this.allClearBtn.Enabled = false;
            this.allClearBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.allClearBtn.Location = new System.Drawing.Point(1388, 534);
            this.allClearBtn.Name = "allClearBtn";
            this.allClearBtn.Size = new System.Drawing.Size(138, 54);
            this.allClearBtn.TabIndex = 8;
            this.allClearBtn.Text = "クリア";
            this.allClearBtn.UseVisualStyleBackColor = true;
            this.allClearBtn.Click += new System.EventHandler(this.allClearBtn_Click);
            // 
            // completeBtn
            // 
            this.completeBtn.Enabled = false;
            this.completeBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.completeBtn.Location = new System.Drawing.Point(1388, 639);
            this.completeBtn.Name = "completeBtn";
            this.completeBtn.Size = new System.Drawing.Size(138, 54);
            this.completeBtn.TabIndex = 9;
            this.completeBtn.Text = "完了";
            this.completeBtn.UseVisualStyleBackColor = true;
            this.completeBtn.Click += new System.EventHandler(this.completeBtn_Click);
            // 
            // quantityLbl
            // 
            this.quantityLbl.AutoSize = true;
            this.quantityLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.quantityLbl.Location = new System.Drawing.Point(639, 501);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(71, 29);
            this.quantityLbl.TabIndex = 0;
            this.quantityLbl.Text = "数量";
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
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // clearBtn
            // 
            this.clearBtn.Enabled = false;
            this.clearBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.clearBtn.Location = new System.Drawing.Point(1388, 432);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(138, 54);
            this.clearBtn.TabIndex = 7;
            this.clearBtn.Text = "削除";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // itemIdTbox
            // 
            this.itemIdTbox.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.itemIdTbox.Location = new System.Drawing.Point(286, 305);
            this.itemIdTbox.MaxLength = 6;
            this.itemIdTbox.Name = "itemIdTbox";
            this.itemIdTbox.Size = new System.Drawing.Size(218, 36);
            this.itemIdTbox.TabIndex = 2;
            this.itemIdTbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.itemIdTbox_KeyPress);
            // 
            // quantityTbox
            // 
            this.quantityTbox.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.quantityTbox.Location = new System.Drawing.Point(618, 561);
            this.quantityTbox.MaxLength = 6;
            this.quantityTbox.Name = "quantityTbox";
            this.quantityTbox.Size = new System.Drawing.Size(108, 36);
            this.quantityTbox.TabIndex = 4;
            this.quantityTbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantityTbox_KeyPress);
            // 
            // allItemBtn
            // 
            this.allItemBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.allItemBtn.Location = new System.Drawing.Point(609, 854);
            this.allItemBtn.Name = "allItemBtn";
            this.allItemBtn.Size = new System.Drawing.Size(176, 54);
            this.allItemBtn.TabIndex = 6;
            this.allItemBtn.Text = "全商品一覧";
            this.allItemBtn.UseVisualStyleBackColor = true;
            this.allItemBtn.Click += new System.EventHandler(this.allItemBtn_Click);
            // 
            // GiveOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1610, 982);
            this.Controls.Add(this.allItemBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.searchResultLbl);
            this.Controls.Add(this.itemNameLbl);
            this.Controls.Add(this.itemIdLbl);
            this.Controls.Add(this.giveOrderListLbl);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.giveOrderListDgv);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.itemIdTbox);
            this.Controls.Add(this.quantityTbox);
            this.Controls.Add(this.itemNameTbox);
            this.Controls.Add(this.itemsViewDgv);
            this.Controls.Add(this.allClearBtn);
            this.Controls.Add(this.completeBtn);
            this.Controls.Add(this.quantityLbl);
            this.Controls.Add(this.titleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GiveOrder";
            this.Text = "GiveOrder";
            this.Activated += new System.EventHandler(this.GiveOrder_Activated);
            this.EnabledChanged += new System.EventHandler(this.GiveOrder_EnabledChanged);
            ((System.ComponentModel.ISupportInitialize)(this.giveOrderListDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsViewDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label giveOrderListLbl;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.DataGridView giveOrderListDgv;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox itemNameTbox;
        private System.Windows.Forms.DataGridView itemsViewDgv;
        private System.Windows.Forms.Button allClearBtn;
        private System.Windows.Forms.Button completeBtn;
        private System.Windows.Forms.Label quantityLbl;
        private System.Windows.Forms.Label itemNameLbl;
        private System.Windows.Forms.Label itemIdLbl;
        private System.Windows.Forms.Label searchResultLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.TextBox itemIdTbox;
        private System.Windows.Forms.TextBox quantityTbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.Button allItemBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name2;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderQuantity;
    }
}
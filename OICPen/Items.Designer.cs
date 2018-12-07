namespace OICPen
{
    partial class Items
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
            this.itemTitleLbl = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.registBtn = new System.Windows.Forms.Button();
            this.itemDgv = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.janCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchBtn = new System.Windows.Forms.Button();
            this.itemNameTbox = new System.Windows.Forms.TextBox();
            this.itemNameLbl = new System.Windows.Forms.Label();
            this.searchItemIdLbl = new System.Windows.Forms.Label();
            this.searchItemIdTbox = new System.Windows.Forms.TextBox();
            this.janLbl = new System.Windows.Forms.Label();
            this.noteLbl = new System.Windows.Forms.Label();
            this.safetyStockLbl = new System.Windows.Forms.Label();
            this.furiganaLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.janTbox = new System.Windows.Forms.TextBox();
            this.priceTbox = new System.Windows.Forms.TextBox();
            this.noteTbox = new System.Windows.Forms.TextBox();
            this.safetyStockTbox = new System.Windows.Forms.TextBox();
            this.furiganaTbox = new System.Windows.Forms.TextBox();
            this.searchItemNameLbl = new System.Windows.Forms.Label();
            this.searchJanLbl = new System.Windows.Forms.Label();
            this.searchItemNameTbox = new System.Windows.Forms.TextBox();
            this.searchJanTbox = new System.Windows.Forms.TextBox();
            this.itemsUpdateBtn = new System.Windows.Forms.Button();
            this.separatorLbl = new System.Windows.Forms.Label();
            this.searchItemLbl = new System.Windows.Forms.Label();
            this.itemRegistLbl = new System.Windows.Forms.Label();
            this.purchasePriceLbl = new System.Windows.Forms.Label();
            this.purchasePriceTbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.itemDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // itemTitleLbl
            // 
            this.itemTitleLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.itemTitleLbl.AutoSize = true;
            this.itemTitleLbl.BackColor = System.Drawing.Color.Transparent;
            this.itemTitleLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.itemTitleLbl.ForeColor = System.Drawing.Color.Black;
            this.itemTitleLbl.Location = new System.Drawing.Point(1371, 19);
            this.itemTitleLbl.Name = "itemTitleLbl";
            this.itemTitleLbl.Size = new System.Drawing.Size(212, 48);
            this.itemTitleLbl.TabIndex = 1;
            this.itemTitleLbl.Text = "商品管理";
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F);
            this.updateBtn.Location = new System.Drawing.Point(1163, 900);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(186, 58);
            this.updateBtn.TabIndex = 13;
            this.updateBtn.Text = "更新";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F);
            this.deleteBtn.Location = new System.Drawing.Point(1355, 900);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(186, 58);
            this.deleteBtn.TabIndex = 14;
            this.deleteBtn.Text = "削除";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // registBtn
            // 
            this.registBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F);
            this.registBtn.Location = new System.Drawing.Point(971, 900);
            this.registBtn.Name = "registBtn";
            this.registBtn.Size = new System.Drawing.Size(186, 58);
            this.registBtn.TabIndex = 12;
            this.registBtn.Text = "商品登録";
            this.registBtn.UseVisualStyleBackColor = true;
            this.registBtn.Click += new System.EventHandler(this.registBtn_Click);
            // 
            // itemDgv
            // 
            this.itemDgv.AllowUserToAddRows = false;
            this.itemDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.productName,
            this.Column4,
            this.Column2,
            this.Column1,
            this.janCode,
            this.Column3,
            this.Column6,
            this.Column5});
            this.itemDgv.Location = new System.Drawing.Point(12, 21);
            this.itemDgv.MultiSelect = false;
            this.itemDgv.Name = "itemDgv";
            this.itemDgv.ReadOnly = true;
            this.itemDgv.RowTemplate.Height = 21;
            this.itemDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemDgv.Size = new System.Drawing.Size(920, 949);
            this.itemDgv.TabIndex = 0;
            this.itemDgv.TabStop = false;
            this.itemDgv.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemDgv_RowEnter);
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.HeaderText = "ID";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // productName
            // 
            this.productName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productName.HeaderText = "商品名";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "ふりがな";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "仕入れ価格";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "販売価格";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // janCode
            // 
            this.janCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.janCode.HeaderText = "JAN";
            this.janCode.Name = "janCode";
            this.janCode.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "安全在庫数";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "備考";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "登録日";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F);
            this.searchBtn.Location = new System.Drawing.Point(1204, 289);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(158, 56);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "検索";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // itemNameTbox
            // 
            this.itemNameTbox.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F);
            this.itemNameTbox.Location = new System.Drawing.Point(1163, 464);
            this.itemNameTbox.MaxLength = 50;
            this.itemNameTbox.Name = "itemNameTbox";
            this.itemNameTbox.Size = new System.Drawing.Size(284, 36);
            this.itemNameTbox.TabIndex = 5;
            // 
            // itemNameLbl
            // 
            this.itemNameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.itemNameLbl.AutoSize = true;
            this.itemNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.itemNameLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.itemNameLbl.ForeColor = System.Drawing.Color.Black;
            this.itemNameLbl.Location = new System.Drawing.Point(1011, 467);
            this.itemNameLbl.Name = "itemNameLbl";
            this.itemNameLbl.Size = new System.Drawing.Size(147, 33);
            this.itemNameLbl.TabIndex = 8;
            this.itemNameLbl.Text = "商品名：";
            // 
            // searchItemIdLbl
            // 
            this.searchItemIdLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchItemIdLbl.AutoSize = true;
            this.searchItemIdLbl.BackColor = System.Drawing.Color.Transparent;
            this.searchItemIdLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.searchItemIdLbl.ForeColor = System.Drawing.Color.Black;
            this.searchItemIdLbl.Location = new System.Drawing.Point(1010, 152);
            this.searchItemIdLbl.Name = "searchItemIdLbl";
            this.searchItemIdLbl.Size = new System.Drawing.Size(148, 33);
            this.searchItemIdLbl.TabIndex = 9;
            this.searchItemIdLbl.Text = "商品ID：";
            // 
            // searchItemIdTbox
            // 
            this.searchItemIdTbox.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F);
            this.searchItemIdTbox.Location = new System.Drawing.Point(1163, 153);
            this.searchItemIdTbox.MaxLength = 6;
            this.searchItemIdTbox.Name = "searchItemIdTbox";
            this.searchItemIdTbox.Size = new System.Drawing.Size(284, 36);
            this.searchItemIdTbox.TabIndex = 1;
            this.searchItemIdTbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchItemIdTbox_KeyPress);
            // 
            // janLbl
            // 
            this.janLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.janLbl.AutoSize = true;
            this.janLbl.BackColor = System.Drawing.Color.Transparent;
            this.janLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.janLbl.ForeColor = System.Drawing.Color.Black;
            this.janLbl.Location = new System.Drawing.Point(1058, 631);
            this.janLbl.Name = "janLbl";
            this.janLbl.Size = new System.Drawing.Size(99, 33);
            this.janLbl.TabIndex = 11;
            this.janLbl.Text = "JAN：";
            // 
            // noteLbl
            // 
            this.noteLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.noteLbl.AutoSize = true;
            this.noteLbl.BackColor = System.Drawing.Color.Transparent;
            this.noteLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.noteLbl.ForeColor = System.Drawing.Color.Black;
            this.noteLbl.Location = new System.Drawing.Point(1043, 718);
            this.noteLbl.Name = "noteLbl";
            this.noteLbl.Size = new System.Drawing.Size(114, 33);
            this.noteLbl.TabIndex = 13;
            this.noteLbl.Text = "備考：";
            // 
            // safetyStockLbl
            // 
            this.safetyStockLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.safetyStockLbl.AutoSize = true;
            this.safetyStockLbl.BackColor = System.Drawing.Color.Transparent;
            this.safetyStockLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.safetyStockLbl.ForeColor = System.Drawing.Color.Black;
            this.safetyStockLbl.Location = new System.Drawing.Point(944, 673);
            this.safetyStockLbl.Name = "safetyStockLbl";
            this.safetyStockLbl.Size = new System.Drawing.Size(213, 33);
            this.safetyStockLbl.TabIndex = 14;
            this.safetyStockLbl.Text = "安全在庫数：";
            // 
            // furiganaLbl
            // 
            this.furiganaLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.furiganaLbl.AutoSize = true;
            this.furiganaLbl.BackColor = System.Drawing.Color.Transparent;
            this.furiganaLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.furiganaLbl.ForeColor = System.Drawing.Color.Black;
            this.furiganaLbl.Location = new System.Drawing.Point(978, 509);
            this.furiganaLbl.Name = "furiganaLbl";
            this.furiganaLbl.Size = new System.Drawing.Size(180, 33);
            this.furiganaLbl.TabIndex = 15;
            this.furiganaLbl.Text = "ふりがな：";
            // 
            // priceLbl
            // 
            this.priceLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.priceLbl.AutoSize = true;
            this.priceLbl.BackColor = System.Drawing.Color.Transparent;
            this.priceLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.priceLbl.ForeColor = System.Drawing.Color.Black;
            this.priceLbl.Location = new System.Drawing.Point(978, 592);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(180, 33);
            this.priceLbl.TabIndex = 16;
            this.priceLbl.Text = "販売価格：";
            // 
            // janTbox
            // 
            this.janTbox.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F);
            this.janTbox.Location = new System.Drawing.Point(1163, 632);
            this.janTbox.MaxLength = 13;
            this.janTbox.Name = "janTbox";
            this.janTbox.Size = new System.Drawing.Size(284, 36);
            this.janTbox.TabIndex = 9;
            this.janTbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.janTbox_KeyPress);
            // 
            // priceTbox
            // 
            this.priceTbox.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F);
            this.priceTbox.Location = new System.Drawing.Point(1163, 589);
            this.priceTbox.MaxLength = 6;
            this.priceTbox.Name = "priceTbox";
            this.priceTbox.Size = new System.Drawing.Size(284, 36);
            this.priceTbox.TabIndex = 8;
            this.priceTbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceTbox_KeyPress);
            // 
            // noteTbox
            // 
            this.noteTbox.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F);
            this.noteTbox.Location = new System.Drawing.Point(1163, 715);
            this.noteTbox.MaxLength = 30;
            this.noteTbox.Multiline = true;
            this.noteTbox.Name = "noteTbox";
            this.noteTbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.noteTbox.Size = new System.Drawing.Size(284, 155);
            this.noteTbox.TabIndex = 11;
            // 
            // safetyStockTbox
            // 
            this.safetyStockTbox.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F);
            this.safetyStockTbox.Location = new System.Drawing.Point(1163, 673);
            this.safetyStockTbox.MaxLength = 6;
            this.safetyStockTbox.Name = "safetyStockTbox";
            this.safetyStockTbox.Size = new System.Drawing.Size(284, 36);
            this.safetyStockTbox.TabIndex = 10;
            this.safetyStockTbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.safetyStockTbox_KeyPress);
            // 
            // furiganaTbox
            // 
            this.furiganaTbox.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F);
            this.furiganaTbox.Location = new System.Drawing.Point(1163, 506);
            this.furiganaTbox.MaxLength = 30;
            this.furiganaTbox.Name = "furiganaTbox";
            this.furiganaTbox.Size = new System.Drawing.Size(284, 36);
            this.furiganaTbox.TabIndex = 6;
            // 
            // searchItemNameLbl
            // 
            this.searchItemNameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchItemNameLbl.AutoSize = true;
            this.searchItemNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.searchItemNameLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.searchItemNameLbl.ForeColor = System.Drawing.Color.Black;
            this.searchItemNameLbl.Location = new System.Drawing.Point(1010, 240);
            this.searchItemNameLbl.Name = "searchItemNameLbl";
            this.searchItemNameLbl.Size = new System.Drawing.Size(147, 33);
            this.searchItemNameLbl.TabIndex = 22;
            this.searchItemNameLbl.Text = "商品名：";
            // 
            // searchJanLbl
            // 
            this.searchJanLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchJanLbl.AutoSize = true;
            this.searchJanLbl.BackColor = System.Drawing.Color.Transparent;
            this.searchJanLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.searchJanLbl.ForeColor = System.Drawing.Color.Black;
            this.searchJanLbl.Location = new System.Drawing.Point(1058, 198);
            this.searchJanLbl.Name = "searchJanLbl";
            this.searchJanLbl.Size = new System.Drawing.Size(99, 33);
            this.searchJanLbl.TabIndex = 23;
            this.searchJanLbl.Text = "JAN：";
            // 
            // searchItemNameTbox
            // 
            this.searchItemNameTbox.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F);
            this.searchItemNameTbox.Location = new System.Drawing.Point(1163, 237);
            this.searchItemNameTbox.MaxLength = 50;
            this.searchItemNameTbox.Name = "searchItemNameTbox";
            this.searchItemNameTbox.Size = new System.Drawing.Size(284, 36);
            this.searchItemNameTbox.TabIndex = 3;
            // 
            // searchJanTbox
            // 
            this.searchJanTbox.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F);
            this.searchJanTbox.Location = new System.Drawing.Point(1163, 195);
            this.searchJanTbox.MaxLength = 13;
            this.searchJanTbox.Name = "searchJanTbox";
            this.searchJanTbox.Size = new System.Drawing.Size(284, 36);
            this.searchJanTbox.TabIndex = 2;
            this.searchJanTbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchJanTbox_KeyPress);
            // 
            // itemsUpdateBtn
            // 
            this.itemsUpdateBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F);
            this.itemsUpdateBtn.Location = new System.Drawing.Point(938, 21);
            this.itemsUpdateBtn.Name = "itemsUpdateBtn";
            this.itemsUpdateBtn.Size = new System.Drawing.Size(240, 58);
            this.itemsUpdateBtn.TabIndex = 0;
            this.itemsUpdateBtn.TabStop = false;
            this.itemsUpdateBtn.Text = "商品一覧更新";
            this.itemsUpdateBtn.UseVisualStyleBackColor = true;
            this.itemsUpdateBtn.Click += new System.EventHandler(this.itemsUpdateBtn_Click);
            // 
            // separatorLbl
            // 
            this.separatorLbl.BackColor = System.Drawing.Color.Black;
            this.separatorLbl.Location = new System.Drawing.Point(982, 367);
            this.separatorLbl.Name = "separatorLbl";
            this.separatorLbl.Size = new System.Drawing.Size(591, 3);
            this.separatorLbl.TabIndex = 24;
            // 
            // searchItemLbl
            // 
            this.searchItemLbl.AutoSize = true;
            this.searchItemLbl.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.searchItemLbl.Location = new System.Drawing.Point(1219, 92);
            this.searchItemLbl.Name = "searchItemLbl";
            this.searchItemLbl.Size = new System.Drawing.Size(133, 29);
            this.searchItemLbl.TabIndex = 25;
            this.searchItemLbl.Text = "商品検索";
            // 
            // itemRegistLbl
            // 
            this.itemRegistLbl.AutoSize = true;
            this.itemRegistLbl.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.itemRegistLbl.Location = new System.Drawing.Point(1199, 383);
            this.itemRegistLbl.Name = "itemRegistLbl";
            this.itemRegistLbl.Size = new System.Drawing.Size(208, 29);
            this.itemRegistLbl.TabIndex = 25;
            this.itemRegistLbl.Text = "商品登録 変更";
            // 
            // purchasePriceLbl
            // 
            this.purchasePriceLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.purchasePriceLbl.AutoSize = true;
            this.purchasePriceLbl.BackColor = System.Drawing.Color.Transparent;
            this.purchasePriceLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.purchasePriceLbl.ForeColor = System.Drawing.Color.Black;
            this.purchasePriceLbl.Location = new System.Drawing.Point(978, 551);
            this.purchasePriceLbl.Name = "purchasePriceLbl";
            this.purchasePriceLbl.Size = new System.Drawing.Size(180, 33);
            this.purchasePriceLbl.TabIndex = 16;
            this.purchasePriceLbl.Text = "仕入価格：";
            // 
            // purchasePriceTbox
            // 
            this.purchasePriceTbox.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F);
            this.purchasePriceTbox.Location = new System.Drawing.Point(1163, 548);
            this.purchasePriceTbox.MaxLength = 6;
            this.purchasePriceTbox.Name = "purchasePriceTbox";
            this.purchasePriceTbox.Size = new System.Drawing.Size(284, 36);
            this.purchasePriceTbox.TabIndex = 7;
            this.purchasePriceTbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.purchasePriceTbox_KeyPress);
            // 
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1610, 982);
            this.Controls.Add(this.itemRegistLbl);
            this.Controls.Add(this.searchItemLbl);
            this.Controls.Add(this.separatorLbl);
            this.Controls.Add(this.itemsUpdateBtn);
            this.Controls.Add(this.searchJanTbox);
            this.Controls.Add(this.searchItemNameTbox);
            this.Controls.Add(this.searchJanLbl);
            this.Controls.Add(this.searchItemNameLbl);
            this.Controls.Add(this.furiganaTbox);
            this.Controls.Add(this.safetyStockTbox);
            this.Controls.Add(this.noteTbox);
            this.Controls.Add(this.purchasePriceTbox);
            this.Controls.Add(this.priceTbox);
            this.Controls.Add(this.purchasePriceLbl);
            this.Controls.Add(this.janTbox);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.furiganaLbl);
            this.Controls.Add(this.safetyStockLbl);
            this.Controls.Add(this.noteLbl);
            this.Controls.Add(this.janLbl);
            this.Controls.Add(this.searchItemIdTbox);
            this.Controls.Add(this.searchItemIdLbl);
            this.Controls.Add(this.itemNameLbl);
            this.Controls.Add(this.itemNameTbox);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.itemDgv);
            this.Controls.Add(this.registBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.itemTitleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(1546, 19);
            this.Name = "Items";
            this.Text = "Items";
            ((System.ComponentModel.ISupportInitialize)(this.itemDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itemTitleLbl;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button registBtn;
        private System.Windows.Forms.DataGridView itemDgv;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox itemNameTbox;
        private System.Windows.Forms.Label itemNameLbl;
        private System.Windows.Forms.Label searchItemIdLbl;
        private System.Windows.Forms.TextBox searchItemIdTbox;
        private System.Windows.Forms.Label janLbl;
        private System.Windows.Forms.Label noteLbl;
        private System.Windows.Forms.Label safetyStockLbl;
        private System.Windows.Forms.Label furiganaLbl;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.TextBox janTbox;
        private System.Windows.Forms.TextBox priceTbox;
        private System.Windows.Forms.TextBox noteTbox;
        private System.Windows.Forms.TextBox safetyStockTbox;
        private System.Windows.Forms.TextBox furiganaTbox;
        private System.Windows.Forms.Label searchItemNameLbl;
        private System.Windows.Forms.Label searchJanLbl;
        private System.Windows.Forms.TextBox searchItemNameTbox;
        private System.Windows.Forms.TextBox searchJanTbox;
        private System.Windows.Forms.Button itemsUpdateBtn;
        private System.Windows.Forms.Label separatorLbl;
        private System.Windows.Forms.Label searchItemLbl;
        private System.Windows.Forms.Label itemRegistLbl;
        private System.Windows.Forms.Label purchasePriceLbl;
        private System.Windows.Forms.TextBox purchasePriceTbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn janCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
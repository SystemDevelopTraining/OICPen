namespace OICPen
{
    partial class InComing
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
            this.components = new System.ComponentModel.Container();
            this.incomingTitleLbl = new System.Windows.Forms.Label();
            this.incomingDgv = new System.Windows.Forms.DataGridView();
            this.orderCheckBtn = new System.Windows.Forms.Button();
            this.itemsLbl = new System.Windows.Forms.Label();
            this.incomingTbox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.registerBtn = new System.Windows.Forms.Button();
            this.fixBtn = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.incomingDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // incomingTitleLbl
            // 
            this.incomingTitleLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.incomingTitleLbl.AutoSize = true;
            this.incomingTitleLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.incomingTitleLbl.ForeColor = System.Drawing.Color.Black;
            this.incomingTitleLbl.Location = new System.Drawing.Point(1373, 19);
            this.incomingTitleLbl.Name = "incomingTitleLbl";
            this.incomingTitleLbl.Size = new System.Drawing.Size(212, 48);
            this.incomingTitleLbl.TabIndex = 0;
            this.incomingTitleLbl.Text = "入庫管理";
            // 
            // incomingDgv
            // 
            this.incomingDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.incomingDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incomingDgv.Location = new System.Drawing.Point(44, 55);
            this.incomingDgv.Name = "incomingDgv";
            this.incomingDgv.RowTemplate.Height = 21;
            this.incomingDgv.Size = new System.Drawing.Size(800, 852);
            this.incomingDgv.TabIndex = 3;
            // 
            // orderCheckBtn
            // 
            this.orderCheckBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.orderCheckBtn.Location = new System.Drawing.Point(1374, 116);
            this.orderCheckBtn.Name = "orderCheckBtn";
            this.orderCheckBtn.Size = new System.Drawing.Size(224, 58);
            this.orderCheckBtn.TabIndex = 4;
            this.orderCheckBtn.Text = "入庫済一覧";
            this.orderCheckBtn.UseVisualStyleBackColor = true;
            // 
            // itemsLbl
            // 
            this.itemsLbl.AutoSize = true;
            this.itemsLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.itemsLbl.Location = new System.Drawing.Point(902, 324);
            this.itemsLbl.Name = "itemsLbl";
            this.itemsLbl.Size = new System.Drawing.Size(159, 29);
            this.itemsLbl.TabIndex = 1;
            this.itemsLbl.Text = "商品ID　：";
            // 
            // incomingTbox
            // 
            this.incomingTbox.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.incomingTbox.Location = new System.Drawing.Point(1111, 322);
            this.incomingTbox.Name = "incomingTbox";
            this.incomingTbox.Size = new System.Drawing.Size(230, 36);
            this.incomingTbox.TabIndex = 5;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.searchBtn.Location = new System.Drawing.Point(1381, 324);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(85, 42);
            this.searchBtn.TabIndex = 6;
            this.searchBtn.Text = "検索";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // registerBtn
            // 
            this.registerBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.registerBtn.Location = new System.Drawing.Point(907, 411);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(154, 54);
            this.registerBtn.TabIndex = 7;
            this.registerBtn.Text = "入庫完了";
            this.registerBtn.UseVisualStyleBackColor = true;
            // 
            // fixBtn
            // 
            this.fixBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.fixBtn.Location = new System.Drawing.Point(1111, 411);
            this.fixBtn.Name = "fixBtn";
            this.fixBtn.Size = new System.Drawing.Size(223, 54);
            this.fixBtn.TabIndex = 7;
            this.fixBtn.Text = "入庫取り消し";
            this.fixBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(1374, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 58);
            this.button1.TabIndex = 8;
            this.button1.Text = "未入庫一覧";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // InComing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1610, 982);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fixBtn);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.incomingTbox);
            this.Controls.Add(this.orderCheckBtn);
            this.Controls.Add(this.incomingDgv);
            this.Controls.Add(this.itemsLbl);
            this.Controls.Add(this.incomingTitleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InComing";
            this.Text = "InComing";
            ((System.ComponentModel.ISupportInitialize)(this.incomingDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label incomingTitleLbl;
        private System.Windows.Forms.DataGridView incomingDgv;
        private System.Windows.Forms.Button orderCheckBtn;
        private System.Windows.Forms.Label itemsLbl;
        private System.Windows.Forms.TextBox incomingTbox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Button fixBtn;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button1;
    }
}
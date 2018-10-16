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
            this.incomingtitleLbl = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.incomingDtp = new System.Windows.Forms.DateTimePicker();
            this.incomingDgv = new System.Windows.Forms.DataGridView();
            this.ordercheckBtn = new System.Windows.Forms.Button();
            this.itemsLbl = new System.Windows.Forms.Label();
            this.incomingTbox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.registerBtn = new System.Windows.Forms.Button();
            this.fixBtn = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.incomingDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // incomingtitleLbl
            // 
            this.incomingtitleLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.incomingtitleLbl.AutoSize = true;
            this.incomingtitleLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.incomingtitleLbl.ForeColor = System.Drawing.Color.Black;
            this.incomingtitleLbl.Location = new System.Drawing.Point(1373, 19);
            this.incomingtitleLbl.Name = "incomingtitleLbl";
            this.incomingtitleLbl.Size = new System.Drawing.Size(212, 48);
            this.incomingtitleLbl.TabIndex = 0;
            this.incomingtitleLbl.Text = "入庫管理";
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateLbl.Location = new System.Drawing.Point(902, 324);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(116, 29);
            this.dateLbl.TabIndex = 1;
            this.dateLbl.Text = "日付  :";
            // 
            // incomingDtp
            // 
            this.incomingDtp.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.incomingDtp.Location = new System.Drawing.Point(1113, 324);
            this.incomingDtp.Name = "incomingDtp";
            this.incomingDtp.Size = new System.Drawing.Size(230, 36);
            this.incomingDtp.TabIndex = 2;
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
            // ordercheckBtn
            // 
            this.ordercheckBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ordercheckBtn.Location = new System.Drawing.Point(907, 209);
            this.ordercheckBtn.Name = "ordercheckBtn";
            this.ordercheckBtn.Size = new System.Drawing.Size(265, 47);
            this.ordercheckBtn.TabIndex = 4;
            this.ordercheckBtn.Text = "発注状況確認";
            this.ordercheckBtn.UseVisualStyleBackColor = true;
            // 
            // itemsLbl
            // 
            this.itemsLbl.AutoSize = true;
            this.itemsLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.itemsLbl.Location = new System.Drawing.Point(902, 401);
            this.itemsLbl.Name = "itemsLbl";
            this.itemsLbl.Size = new System.Drawing.Size(159, 29);
            this.itemsLbl.TabIndex = 1;
            this.itemsLbl.Text = "商品ID　：";
            // 
            // incomingTbox
            // 
            this.incomingTbox.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.incomingTbox.Location = new System.Drawing.Point(1113, 401);
            this.incomingTbox.Name = "incomingTbox";
            this.incomingTbox.Size = new System.Drawing.Size(230, 36);
            this.incomingTbox.TabIndex = 5;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.searchBtn.Location = new System.Drawing.Point(1363, 401);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(85, 42);
            this.searchBtn.TabIndex = 6;
            this.searchBtn.Text = "検索";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // registerBtn
            // 
            this.registerBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.registerBtn.Location = new System.Drawing.Point(907, 489);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(104, 54);
            this.registerBtn.TabIndex = 7;
            this.registerBtn.Text = "登録";
            this.registerBtn.UseVisualStyleBackColor = true;
            // 
            // fixBtn
            // 
            this.fixBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.fixBtn.Location = new System.Drawing.Point(1068, 489);
            this.fixBtn.Name = "fixBtn";
            this.fixBtn.Size = new System.Drawing.Size(104, 54);
            this.fixBtn.TabIndex = 7;
            this.fixBtn.Text = "修正";
            this.fixBtn.UseVisualStyleBackColor = true;
            // 
            // InComing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1610, 982);
            this.Controls.Add(this.fixBtn);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.incomingTbox);
            this.Controls.Add(this.ordercheckBtn);
            this.Controls.Add(this.incomingDgv);
            this.Controls.Add(this.incomingDtp);
            this.Controls.Add(this.itemsLbl);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.incomingtitleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InComing";
            this.Text = "InComing";
            ((System.ComponentModel.ISupportInitialize)(this.incomingDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label incomingtitleLbl;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.DateTimePicker incomingDtp;
        private System.Windows.Forms.DataGridView incomingDgv;
        private System.Windows.Forms.Button ordercheckBtn;
        private System.Windows.Forms.Label itemsLbl;
        private System.Windows.Forms.TextBox incomingTbox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Button fixBtn;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}
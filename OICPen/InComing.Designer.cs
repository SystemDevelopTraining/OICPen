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
            this.titleLbl = new System.Windows.Forms.Label();
            this.incomingDgv = new System.Windows.Forms.DataGridView();
            this.GiveOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiveOrdDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompleteDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffTID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giveOrderedCheckBtn = new System.Windows.Forms.Button();
            this.giveOrderLbl = new System.Windows.Forms.Label();
            this.incomingTbox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.registerBtn = new System.Windows.Forms.Button();
            this.fixBtn = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.giveOrderCheckBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.incomingDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.titleLbl.ForeColor = System.Drawing.Color.Black;
            this.titleLbl.Location = new System.Drawing.Point(1373, 19);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(212, 48);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "入庫管理";
            // 
            // incomingDgv
            // 
            this.incomingDgv.AllowUserToAddRows = false;
            this.incomingDgv.AllowUserToDeleteRows = false;
            this.incomingDgv.AllowUserToResizeColumns = false;
            this.incomingDgv.AllowUserToResizeRows = false;
            this.incomingDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.incomingDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.incomingDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incomingDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GiveOrderID,
            this.GiveOrdDate,
            this.CompleteDate,
            this.StaffTID});
            this.incomingDgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.incomingDgv.Location = new System.Drawing.Point(12, 21);
            this.incomingDgv.MultiSelect = false;
            this.incomingDgv.Name = "incomingDgv";
            this.incomingDgv.ReadOnly = true;
            this.incomingDgv.RowTemplate.Height = 21;
            this.incomingDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.incomingDgv.Size = new System.Drawing.Size(1310, 949);
            this.incomingDgv.TabIndex = 0;
            this.incomingDgv.TabStop = false;
            // 
            // GiveOrderID
            // 
            this.GiveOrderID.HeaderText = "ID";
            this.GiveOrderID.Name = "GiveOrderID";
            this.GiveOrderID.ReadOnly = true;
            // 
            // GiveOrdDate
            // 
            this.GiveOrdDate.HeaderText = "発注日";
            this.GiveOrdDate.Name = "GiveOrdDate";
            this.GiveOrdDate.ReadOnly = true;
            // 
            // CompleteDate
            // 
            this.CompleteDate.HeaderText = "入庫日";
            this.CompleteDate.Name = "CompleteDate";
            this.CompleteDate.ReadOnly = true;
            // 
            // StaffTID
            // 
            this.StaffTID.HeaderText = "担当社員";
            this.StaffTID.Name = "StaffTID";
            this.StaffTID.ReadOnly = true;
            // 
            // giveOrderedCheckBtn
            // 
            this.giveOrderedCheckBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.giveOrderedCheckBtn.Location = new System.Drawing.Point(1374, 116);
            this.giveOrderedCheckBtn.Name = "giveOrderedCheckBtn";
            this.giveOrderedCheckBtn.Size = new System.Drawing.Size(224, 58);
            this.giveOrderedCheckBtn.TabIndex = 1;
            this.giveOrderedCheckBtn.Text = "入庫済一覧";
            this.giveOrderedCheckBtn.UseVisualStyleBackColor = true;
            this.giveOrderedCheckBtn.Click += new System.EventHandler(this.giveOrderedCheckBtn_Click);
            // 
            // giveOrderLbl
            // 
            this.giveOrderLbl.AutoSize = true;
            this.giveOrderLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.giveOrderLbl.Location = new System.Drawing.Point(1427, 506);
            this.giveOrderLbl.Name = "giveOrderLbl";
            this.giveOrderLbl.Size = new System.Drawing.Size(101, 29);
            this.giveOrderLbl.TabIndex = 0;
            this.giveOrderLbl.Text = "発注ID";
            // 
            // incomingTbox
            // 
            this.incomingTbox.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.incomingTbox.Location = new System.Drawing.Point(1374, 577);
            this.incomingTbox.MaxLength = 8;
            this.incomingTbox.Name = "incomingTbox";
            this.incomingTbox.Size = new System.Drawing.Size(224, 36);
            this.incomingTbox.TabIndex = 3;
            this.incomingTbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.incomingTbox_KeyPress);
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.searchBtn.Location = new System.Drawing.Point(1432, 660);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(112, 58);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "検索";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // registerBtn
            // 
            this.registerBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.registerBtn.Location = new System.Drawing.Point(1374, 854);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(224, 58);
            this.registerBtn.TabIndex = 6;
            this.registerBtn.Text = "入庫完了";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // fixBtn
            // 
            this.fixBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.fixBtn.Location = new System.Drawing.Point(1374, 755);
            this.fixBtn.Name = "fixBtn";
            this.fixBtn.Size = new System.Drawing.Size(224, 58);
            this.fixBtn.TabIndex = 5;
            this.fixBtn.Text = "入庫取り消し";
            this.fixBtn.UseVisualStyleBackColor = true;
            this.fixBtn.Click += new System.EventHandler(this.fixBtn_Click);
            // 
            // giveOrderCheckBtn
            // 
            this.giveOrderCheckBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.giveOrderCheckBtn.Location = new System.Drawing.Point(1374, 220);
            this.giveOrderCheckBtn.Name = "giveOrderCheckBtn";
            this.giveOrderCheckBtn.Size = new System.Drawing.Size(224, 58);
            this.giveOrderCheckBtn.TabIndex = 2;
            this.giveOrderCheckBtn.Text = "未入庫一覧";
            this.giveOrderCheckBtn.UseVisualStyleBackColor = true;
            this.giveOrderCheckBtn.Click += new System.EventHandler(this.giveOrderCheckBtn_Click);
            // 
            // InComing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1610, 982);
            this.Controls.Add(this.giveOrderCheckBtn);
            this.Controls.Add(this.fixBtn);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.incomingTbox);
            this.Controls.Add(this.giveOrderedCheckBtn);
            this.Controls.Add(this.incomingDgv);
            this.Controls.Add(this.giveOrderLbl);
            this.Controls.Add(this.titleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InComing";
            this.Text = "InComing";
            this.Load += new System.EventHandler(this.InComing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.incomingDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.DataGridView incomingDgv;
        private System.Windows.Forms.Button giveOrderedCheckBtn;
        private System.Windows.Forms.Label giveOrderLbl;
        private System.Windows.Forms.TextBox incomingTbox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Button fixBtn;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button giveOrderCheckBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiveOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiveOrdDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompleteDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffTID;
    }
}
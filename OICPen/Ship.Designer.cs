namespace OICPen
{
    partial class Ship
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
            this.shipDgv = new System.Windows.Forms.DataGridView();
            this.shipTitleLbl = new System.Windows.Forms.Label();
            this.shipCheckBtn = new System.Windows.Forms.Button();
            this.shipProcessingBtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.shipfixBtn = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.shipDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // shipDgv
            // 
            this.shipDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shipDgv.Location = new System.Drawing.Point(33, 34);
            this.shipDgv.Name = "shipDgv";
            this.shipDgv.RowTemplate.Height = 21;
            this.shipDgv.Size = new System.Drawing.Size(1310, 936);
            this.shipDgv.TabIndex = 0;
            // 
            // shipTitleLbl
            // 
            this.shipTitleLbl.AutoSize = true;
            this.shipTitleLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.shipTitleLbl.Location = new System.Drawing.Point(1373, 19);
            this.shipTitleLbl.Name = "shipTitleLbl";
            this.shipTitleLbl.Size = new System.Drawing.Size(212, 48);
            this.shipTitleLbl.TabIndex = 2;
            this.shipTitleLbl.Text = "出庫管理";
            // 
            // shipCheckBtn
            // 
            this.shipCheckBtn.Font = new System.Drawing.Font("HGP創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.shipCheckBtn.Location = new System.Drawing.Point(1374, 227);
            this.shipCheckBtn.Name = "shipCheckBtn";
            this.shipCheckBtn.Size = new System.Drawing.Size(224, 58);
            this.shipCheckBtn.TabIndex = 3;
            this.shipCheckBtn.Text = "出庫情報確認";
            this.shipCheckBtn.UseVisualStyleBackColor = true;
            // 
            // shipProcessingBtn
            // 
            this.shipProcessingBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.shipProcessingBtn.Location = new System.Drawing.Point(1374, 336);
            this.shipProcessingBtn.Name = "shipProcessingBtn";
            this.shipProcessingBtn.Size = new System.Drawing.Size(224, 58);
            this.shipProcessingBtn.TabIndex = 4;
            this.shipProcessingBtn.Text = "出庫処理実行";
            this.shipProcessingBtn.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateTimePicker1.Location = new System.Drawing.Point(1374, 140);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(224, 36);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // shipfixBtn
            // 
            this.shipfixBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.shipfixBtn.Location = new System.Drawing.Point(1374, 445);
            this.shipfixBtn.Name = "shipfixBtn";
            this.shipfixBtn.Size = new System.Drawing.Size(224, 58);
            this.shipfixBtn.TabIndex = 4;
            this.shipfixBtn.Text = "出庫日修正";
            this.shipfixBtn.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateTimePicker2.Location = new System.Drawing.Point(1374, 140);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(224, 36);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // Ship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1610, 982);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.shipfixBtn);
            this.Controls.Add(this.shipProcessingBtn);
            this.Controls.Add(this.shipCheckBtn);
            this.Controls.Add(this.shipTitleLbl);
            this.Controls.Add(this.shipDgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ship";
            this.Text = "Ship";
            ((System.ComponentModel.ISupportInitialize)(this.shipDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView shipDgv;
        private System.Windows.Forms.Label shipTitleLbl;
        private System.Windows.Forms.Button shipCheckBtn;
        private System.Windows.Forms.Button shipProcessingBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button shipfixBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}
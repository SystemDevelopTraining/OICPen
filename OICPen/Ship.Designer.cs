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
            this.shiptitleLbl = new System.Windows.Forms.Label();
            this.shipcheckBtn = new System.Windows.Forms.Button();
            this.shipprocessingBtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
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
            // shiptitleLbl
            // 
            this.shiptitleLbl.AutoSize = true;
            this.shiptitleLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.shiptitleLbl.Location = new System.Drawing.Point(1373, 19);
            this.shiptitleLbl.Name = "shiptitleLbl";
            this.shiptitleLbl.Size = new System.Drawing.Size(212, 48);
            this.shiptitleLbl.TabIndex = 2;
            this.shiptitleLbl.Text = "出庫管理";
            // 
            // shipcheckBtn
            // 
            this.shipcheckBtn.Font = new System.Drawing.Font("HGP創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.shipcheckBtn.Location = new System.Drawing.Point(1374, 227);
            this.shipcheckBtn.Name = "shipcheckBtn";
            this.shipcheckBtn.Size = new System.Drawing.Size(224, 58);
            this.shipcheckBtn.TabIndex = 3;
            this.shipcheckBtn.Text = "出庫情報確認";
            this.shipcheckBtn.UseVisualStyleBackColor = true;
            // 
            // shipprocessingBtn
            // 
            this.shipprocessingBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.shipprocessingBtn.Location = new System.Drawing.Point(1374, 336);
            this.shipprocessingBtn.Name = "shipprocessingBtn";
            this.shipprocessingBtn.Size = new System.Drawing.Size(224, 58);
            this.shipprocessingBtn.TabIndex = 4;
            this.shipprocessingBtn.Text = "出庫処理実行";
            this.shipprocessingBtn.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateTimePicker1.Location = new System.Drawing.Point(1374, 140);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(224, 36);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button3.Location = new System.Drawing.Point(1374, 445);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(224, 58);
            this.button3.TabIndex = 4;
            this.button3.Text = "出庫日修正";
            this.button3.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.button3);
            this.Controls.Add(this.shipprocessingBtn);
            this.Controls.Add(this.shipcheckBtn);
            this.Controls.Add(this.shiptitleLbl);
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
        private System.Windows.Forms.Label shiptitleLbl;
        private System.Windows.Forms.Button shipcheckBtn;
        private System.Windows.Forms.Button shipprocessingBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}
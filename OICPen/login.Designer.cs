namespace OICPen
{
    partial class Login
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.staffIdTbox = new System.Windows.Forms.TextBox();
            this.staffPassTbox = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.staffPassLbl = new System.Windows.Forms.Label();
            this.staffIdLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // staffIdTbox
            // 
            this.staffIdTbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.staffIdTbox.BackColor = System.Drawing.Color.White;
            this.staffIdTbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.staffIdTbox.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.staffIdTbox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.staffIdTbox.Location = new System.Drawing.Point(155, 357);
            this.staffIdTbox.MaxLength = 6;
            this.staffIdTbox.Name = "staffIdTbox";
            this.staffIdTbox.Size = new System.Drawing.Size(196, 36);
            this.staffIdTbox.TabIndex = 1;
            this.staffIdTbox.Tag = "";
            this.staffIdTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // staffPassTbox
            // 
            this.staffPassTbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.staffPassTbox.BackColor = System.Drawing.Color.White;
            this.staffPassTbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.staffPassTbox.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F);
            this.staffPassTbox.Location = new System.Drawing.Point(155, 553);
            this.staffPassTbox.MaxLength = 20;
            this.staffPassTbox.Name = "staffPassTbox";
            this.staffPassTbox.PasswordChar = '*';
            this.staffPassTbox.Size = new System.Drawing.Size(196, 36);
            this.staffPassTbox.TabIndex = 2;
            this.staffPassTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.staffPassTbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.staffPassTbox_KeyPress);
            // 
            // loginBtn
            // 
            this.loginBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.loginBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginBtn.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(155, 631);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(196, 46);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "ログイン";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.BackgroundImage = global::OICPen.Properties.Resources.Login_Screen_Background_Wood_51;
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel2.Controls.Add(this.staffPassLbl);
            this.splitContainer1.Panel2.Controls.Add(this.staffIdLbl);
            this.splitContainer1.Panel2.Controls.Add(this.staffIdTbox);
            this.splitContainer1.Panel2.Controls.Add(this.loginBtn);
            this.splitContainer1.Panel2.Controls.Add(this.staffPassTbox);
            this.splitContainer1.Size = new System.Drawing.Size(1610, 982);
            this.splitContainer1.SplitterDistance = 1156;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::OICPen.Properties.Resources.colored_pencils91;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(195, 108);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(656, 816);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::OICPen.Properties.Resources.fc3ec593_dffc_411c_8717_21f97af10a68;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(888, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 186);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // staffPassLbl
            // 
            this.staffPassLbl.AutoSize = true;
            this.staffPassLbl.BackColor = System.Drawing.Color.Transparent;
            this.staffPassLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.staffPassLbl.ForeColor = System.Drawing.Color.Snow;
            this.staffPassLbl.Location = new System.Drawing.Point(161, 489);
            this.staffPassLbl.Name = "staffPassLbl";
            this.staffPassLbl.Size = new System.Drawing.Size(190, 35);
            this.staffPassLbl.TabIndex = 12;
            this.staffPassLbl.Text = "パスワード";
            // 
            // staffIdLbl
            // 
            this.staffIdLbl.AutoSize = true;
            this.staffIdLbl.BackColor = System.Drawing.Color.Transparent;
            this.staffIdLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.staffIdLbl.ForeColor = System.Drawing.Color.Snow;
            this.staffIdLbl.Location = new System.Drawing.Point(180, 298);
            this.staffIdLbl.Name = "staffIdLbl";
            this.staffIdLbl.Size = new System.Drawing.Size(121, 35);
            this.staffIdLbl.TabIndex = 11;
            this.staffIdLbl.Text = "社員ID";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1610, 982);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("ＭＳ 明朝", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "ログイン画面";
            this.Load += new System.EventHandler(this.Login_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox staffIdTbox;
        private System.Windows.Forms.TextBox staffPassTbox;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label staffPassLbl;
        private System.Windows.Forms.Label staffIdLbl;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}


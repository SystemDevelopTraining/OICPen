﻿namespace OICPen
{
    partial class Staffs
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
            this.staffsDgv = new System.Windows.Forms.DataGridView();
            this.registerBtn = new System.Windows.Forms.Button();
            this.titleLbl = new System.Windows.Forms.Label();
            this.idTbox = new System.Windows.Forms.TextBox();
            this.searchNameLbl = new System.Windows.Forms.Label();
            this.idLbl = new System.Windows.Forms.Label();
            this.searchNameTbox = new System.Windows.Forms.TextBox();
            this.fixBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.registerNameTbox = new System.Windows.Forms.TextBox();
            this.registerNameLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.passwordTbox = new System.Windows.Forms.TextBox();
            this.password2Tbox = new System.Windows.Forms.TextBox();
            this.password2Lbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.registerTitleLbl = new System.Windows.Forms.Label();
            this.permissionLbl = new System.Windows.Forms.Label();
            this.searchTitleLbl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.staffsDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // staffsDgv
            // 
            this.staffsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffsDgv.Location = new System.Drawing.Point(36, 32);
            this.staffsDgv.Name = "staffsDgv";
            this.staffsDgv.RowTemplate.Height = 21;
            this.staffsDgv.Size = new System.Drawing.Size(774, 920);
            this.staffsDgv.TabIndex = 0;
            // 
            // registerBtn
            // 
            this.registerBtn.Font = new System.Drawing.Font("UD デジタル 教科書体 NP-B", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.registerBtn.Location = new System.Drawing.Point(1023, 829);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(125, 60);
            this.registerBtn.TabIndex = 2;
            this.registerBtn.Text = "登録";
            this.registerBtn.UseVisualStyleBackColor = true;
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 NP-B", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.titleLbl.Location = new System.Drawing.Point(1373, 19);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(212, 48);
            this.titleLbl.TabIndex = 3;
            this.titleLbl.Text = "社員管理";
            // 
            // idTbox
            // 
            this.idTbox.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.idTbox.Location = new System.Drawing.Point(1180, 201);
            this.idTbox.Multiline = true;
            this.idTbox.Name = "idTbox";
            this.idTbox.Size = new System.Drawing.Size(320, 33);
            this.idTbox.TabIndex = 4;
            // 
            // searchNameLbl
            // 
            this.searchNameLbl.AutoSize = true;
            this.searchNameLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 NP-B", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.searchNameLbl.Location = new System.Drawing.Point(999, 269);
            this.searchNameLbl.Name = "searchNameLbl";
            this.searchNameLbl.Size = new System.Drawing.Size(136, 33);
            this.searchNameLbl.TabIndex = 5;
            this.searchNameLbl.Text = "社員名 :";
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 NP-B", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.idLbl.Location = new System.Drawing.Point(999, 201);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(145, 33);
            this.idLbl.TabIndex = 5;
            this.idLbl.Text = "社員ID :";
            // 
            // searchNameTbox
            // 
            this.searchNameTbox.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.searchNameTbox.Location = new System.Drawing.Point(1180, 269);
            this.searchNameTbox.Multiline = true;
            this.searchNameTbox.Name = "searchNameTbox";
            this.searchNameTbox.Size = new System.Drawing.Size(320, 33);
            this.searchNameTbox.TabIndex = 4;
            this.searchNameTbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // fixBtn
            // 
            this.fixBtn.Font = new System.Drawing.Font("UD デジタル 教科書体 NP-B", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.fixBtn.Location = new System.Drawing.Point(1190, 829);
            this.fixBtn.Name = "fixBtn";
            this.fixBtn.Size = new System.Drawing.Size(125, 60);
            this.fixBtn.TabIndex = 2;
            this.fixBtn.Text = "修正";
            this.fixBtn.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("UD デジタル 教科書体 NP-B", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.searchBtn.Location = new System.Drawing.Point(1190, 327);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(125, 60);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "検索";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("UD デジタル 教科書体 NP-B", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.deleteBtn.Location = new System.Drawing.Point(1358, 829);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(125, 60);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "削除";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // registerNameTbox
            // 
            this.registerNameTbox.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.registerNameTbox.Location = new System.Drawing.Point(1180, 513);
            this.registerNameTbox.Multiline = true;
            this.registerNameTbox.Name = "registerNameTbox";
            this.registerNameTbox.Size = new System.Drawing.Size(320, 33);
            this.registerNameTbox.TabIndex = 4;
            // 
            // registerNameLbl
            // 
            this.registerNameLbl.AutoSize = true;
            this.registerNameLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 NP-B", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.registerNameLbl.Location = new System.Drawing.Point(1000, 513);
            this.registerNameLbl.Name = "registerNameLbl";
            this.registerNameLbl.Size = new System.Drawing.Size(136, 33);
            this.registerNameLbl.TabIndex = 5;
            this.registerNameLbl.Text = "社員名 :";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 NP-B", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.passwordLbl.Location = new System.Drawing.Point(951, 592);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(192, 33);
            this.passwordLbl.TabIndex = 5;
            this.passwordLbl.Text = "パスワード:";
            this.passwordLbl.Click += new System.EventHandler(this.label5_Click);
            // 
            // passwordTbox
            // 
            this.passwordTbox.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.passwordTbox.Location = new System.Drawing.Point(1180, 592);
            this.passwordTbox.Multiline = true;
            this.passwordTbox.Name = "passwordTbox";
            this.passwordTbox.PasswordChar = '*';
            this.passwordTbox.Size = new System.Drawing.Size(320, 33);
            this.passwordTbox.TabIndex = 4;
            // 
            // password2Tbox
            // 
            this.password2Tbox.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.password2Tbox.Location = new System.Drawing.Point(1180, 671);
            this.password2Tbox.Multiline = true;
            this.password2Tbox.Name = "password2Tbox";
            this.password2Tbox.PasswordChar = '*';
            this.password2Tbox.Size = new System.Drawing.Size(320, 33);
            this.password2Tbox.TabIndex = 4;
            // 
            // password2Lbl
            // 
            this.password2Lbl.AutoSize = true;
            this.password2Lbl.Font = new System.Drawing.Font("UD デジタル 教科書体 NP-B", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.password2Lbl.Location = new System.Drawing.Point(851, 671);
            this.password2Lbl.Name = "password2Lbl";
            this.password2Lbl.Size = new System.Drawing.Size(288, 33);
            this.password2Lbl.TabIndex = 5;
            this.password2Lbl.Text = "パスワード(確認):";
            this.password2Lbl.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(832, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(750, 3);
            this.label7.TabIndex = 6;
            this.label7.Text = "label7";
            // 
            // registerTitleLbl
            // 
            this.registerTitleLbl.AutoSize = true;
            this.registerTitleLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 NP-B", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.registerTitleLbl.Location = new System.Drawing.Point(1123, 441);
            this.registerTitleLbl.Name = "registerTitleLbl";
            this.registerTitleLbl.Size = new System.Drawing.Size(180, 33);
            this.registerTitleLbl.TabIndex = 7;
            this.registerTitleLbl.Text = "登録・修正";
            // 
            // permissionLbl
            // 
            this.permissionLbl.AutoSize = true;
            this.permissionLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 NP-B", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.permissionLbl.Location = new System.Drawing.Point(1050, 750);
            this.permissionLbl.Name = "permissionLbl";
            this.permissionLbl.Size = new System.Drawing.Size(93, 33);
            this.permissionLbl.TabIndex = 5;
            this.permissionLbl.Text = "権限:";
            this.permissionLbl.Click += new System.EventHandler(this.label5_Click);
            // 
            // searchTitleLbl
            // 
            this.searchTitleLbl.AutoSize = true;
            this.searchTitleLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 NP-B", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.searchTitleLbl.Location = new System.Drawing.Point(1175, 94);
            this.searchTitleLbl.Name = "searchTitleLbl";
            this.searchTitleLbl.Size = new System.Drawing.Size(81, 33);
            this.searchTitleLbl.TabIndex = 7;
            this.searchTitleLbl.Text = "検索";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "特権管理者",
            "客管理者",
            "社員管理者",
            "商品管理者",
            "入庫管理者"});
            this.comboBox1.Location = new System.Drawing.Point(1181, 750);
            this.comboBox1.MaxDropDownItems = 4;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(176, 37);
            this.comboBox1.TabIndex = 8;
            // 
            // Staffs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1610, 982);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.searchTitleLbl);
            this.Controls.Add(this.registerTitleLbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.permissionLbl);
            this.Controls.Add(this.password2Lbl);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.registerNameLbl);
            this.Controls.Add(this.searchNameLbl);
            this.Controls.Add(this.searchNameTbox);
            this.Controls.Add(this.password2Tbox);
            this.Controls.Add(this.passwordTbox);
            this.Controls.Add(this.registerNameTbox);
            this.Controls.Add(this.idTbox);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.fixBtn);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.staffsDgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Staffs";
            this.Text = "Staffs";
            ((System.ComponentModel.ISupportInitialize)(this.staffsDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView staffsDgv;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.TextBox idTbox;
        private System.Windows.Forms.Label searchNameLbl;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.TextBox searchNameTbox;
        private System.Windows.Forms.Button fixBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox registerNameTbox;
        private System.Windows.Forms.Label registerNameLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox passwordTbox;
        private System.Windows.Forms.TextBox password2Tbox;
        private System.Windows.Forms.Label password2Lbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label registerTitleLbl;
        private System.Windows.Forms.Label permissionLbl;
        private System.Windows.Forms.Label searchTitleLbl;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
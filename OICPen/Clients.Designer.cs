namespace OICPen
{
    partial class Clients
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
            this.ClientsDgv = new System.Windows.Forms.DataGridView();
            this.registBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.IdLbl = new System.Windows.Forms.Label();
            this.idTbox = new System.Windows.Forms.TextBox();
            this.nameTbox = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.phoneNumberTbox = new System.Windows.Forms.TextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.phoneNumberLbl = new System.Windows.Forms.Label();
            this.addressLbl = new System.Windows.Forms.Label();
            this.PostalCodeTbox = new System.Windows.Forms.TextBox();
            this.addressTbox = new System.Windows.Forms.TextBox();
            this.postalCodeLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchHuriganaTbox = new System.Windows.Forms.TextBox();
            this.searchHuriganaLbl = new System.Windows.Forms.Label();
            this.searchNameTbox = new System.Windows.Forms.TextBox();
            this.searchNameLbl = new System.Windows.Forms.Label();
            this.searchIdTbox = new System.Windows.Forms.TextBox();
            this.searchIdLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientsDgv
            // 
            this.ClientsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsDgv.Location = new System.Drawing.Point(12, 12);
            this.ClientsDgv.Name = "ClientsDgv";
            this.ClientsDgv.RowTemplate.Height = 21;
            this.ClientsDgv.Size = new System.Drawing.Size(900, 958);
            this.ClientsDgv.TabIndex = 0;
            // 
            // registBtn
            // 
            this.registBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.registBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 24.75F);
            this.registBtn.Location = new System.Drawing.Point(1105, 732);
            this.registBtn.Name = "registBtn";
            this.registBtn.Size = new System.Drawing.Size(186, 58);
            this.registBtn.TabIndex = 2;
            this.registBtn.Text = "新規登録";
            this.registBtn.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.searchBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.searchBtn.Location = new System.Drawing.Point(1105, 322);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(186, 58);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "検索";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.clearBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.clearBtn.Location = new System.Drawing.Point(1323, 323);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(186, 58);
            this.clearBtn.TabIndex = 5;
            this.clearBtn.Text = "条件クリア";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // IdLbl
            // 
            this.IdLbl.AutoSize = true;
            this.IdLbl.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 24.75F);
            this.IdLbl.Location = new System.Drawing.Point(1033, 437);
            this.IdLbl.Name = "IdLbl";
            this.IdLbl.Size = new System.Drawing.Size(66, 33);
            this.IdLbl.TabIndex = 0;
            this.IdLbl.Text = "ID:";
            // 
            // idTbox
            // 
            this.idTbox.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 24.75F);
            this.idTbox.Location = new System.Drawing.Point(1105, 434);
            this.idTbox.Name = "idTbox";
            this.idTbox.Size = new System.Drawing.Size(404, 40);
            this.idTbox.TabIndex = 1;
            // 
            // nameTbox
            // 
            this.nameTbox.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 24.75F);
            this.nameTbox.Location = new System.Drawing.Point(1105, 480);
            this.nameTbox.Name = "nameTbox";
            this.nameTbox.Size = new System.Drawing.Size(404, 40);
            this.nameTbox.TabIndex = 7;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 24.75F);
            this.nameLbl.Location = new System.Drawing.Point(999, 480);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(100, 33);
            this.nameLbl.TabIndex = 6;
            this.nameLbl.Text = "名前:";
            // 
            // titleLbl
            // 
            this.titleLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLbl.AutoSize = true;
            this.titleLbl.BackColor = System.Drawing.Color.Transparent;
            this.titleLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.titleLbl.ForeColor = System.Drawing.Color.Black;
            this.titleLbl.Location = new System.Drawing.Point(1373, 19);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(212, 48);
            this.titleLbl.TabIndex = 10;
            this.titleLbl.Text = "会員管理";
            // 
            // phoneNumberTbox
            // 
            this.phoneNumberTbox.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 24.75F);
            this.phoneNumberTbox.Location = new System.Drawing.Point(1105, 572);
            this.phoneNumberTbox.Name = "phoneNumberTbox";
            this.phoneNumberTbox.Size = new System.Drawing.Size(404, 40);
            this.phoneNumberTbox.TabIndex = 21;
            // 
            // updateBtn
            // 
            this.updateBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.updateBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 24.75F);
            this.updateBtn.Location = new System.Drawing.Point(1323, 732);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(186, 58);
            this.updateBtn.TabIndex = 15;
            this.updateBtn.Text = "更新";
            this.updateBtn.UseVisualStyleBackColor = true;
            // 
            // phoneNumberLbl
            // 
            this.phoneNumberLbl.AutoSize = true;
            this.phoneNumberLbl.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 24.75F);
            this.phoneNumberLbl.Location = new System.Drawing.Point(931, 575);
            this.phoneNumberLbl.Name = "phoneNumberLbl";
            this.phoneNumberLbl.Size = new System.Drawing.Size(168, 33);
            this.phoneNumberLbl.TabIndex = 20;
            this.phoneNumberLbl.Text = "電話番号:";
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 24.75F);
            this.addressLbl.Location = new System.Drawing.Point(999, 667);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(100, 33);
            this.addressLbl.TabIndex = 16;
            this.addressLbl.Text = "住所:";
            // 
            // PostalCodeTbox
            // 
            this.PostalCodeTbox.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 24.75F);
            this.PostalCodeTbox.Location = new System.Drawing.Point(1105, 618);
            this.PostalCodeTbox.Name = "PostalCodeTbox";
            this.PostalCodeTbox.Size = new System.Drawing.Size(404, 40);
            this.PostalCodeTbox.TabIndex = 19;
            // 
            // addressTbox
            // 
            this.addressTbox.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 24.75F);
            this.addressTbox.Location = new System.Drawing.Point(1105, 664);
            this.addressTbox.Name = "addressTbox";
            this.addressTbox.Size = new System.Drawing.Size(404, 40);
            this.addressTbox.TabIndex = 17;
            // 
            // postalCodeLbl
            // 
            this.postalCodeLbl.AutoSize = true;
            this.postalCodeLbl.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 24.75F);
            this.postalCodeLbl.Location = new System.Drawing.Point(931, 621);
            this.postalCodeLbl.Name = "postalCodeLbl";
            this.postalCodeLbl.Size = new System.Drawing.Size(168, 33);
            this.postalCodeLbl.TabIndex = 18;
            this.postalCodeLbl.Text = "郵便番号:";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(1323, 858);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 58);
            this.button1.TabIndex = 22;
            this.button1.Text = "購入履歴";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 24.75F);
            this.textBox1.Location = new System.Drawing.Point(1105, 526);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(404, 40);
            this.textBox1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 24.75F);
            this.label1.Location = new System.Drawing.Point(931, 529);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 33);
            this.label1.TabIndex = 23;
            this.label1.Text = "ふりがな:";
            // 
            // searchHuriganaTbox
            // 
            this.searchHuriganaTbox.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 24.75F);
            this.searchHuriganaTbox.Location = new System.Drawing.Point(1105, 264);
            this.searchHuriganaTbox.Name = "searchHuriganaTbox";
            this.searchHuriganaTbox.Size = new System.Drawing.Size(404, 40);
            this.searchHuriganaTbox.TabIndex = 30;
            // 
            // searchHuriganaLbl
            // 
            this.searchHuriganaLbl.AutoSize = true;
            this.searchHuriganaLbl.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 24.75F);
            this.searchHuriganaLbl.Location = new System.Drawing.Point(931, 267);
            this.searchHuriganaLbl.Name = "searchHuriganaLbl";
            this.searchHuriganaLbl.Size = new System.Drawing.Size(168, 33);
            this.searchHuriganaLbl.TabIndex = 29;
            this.searchHuriganaLbl.Text = "ふりがな:";
            // 
            // searchNameTbox
            // 
            this.searchNameTbox.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 24.75F);
            this.searchNameTbox.Location = new System.Drawing.Point(1105, 218);
            this.searchNameTbox.Name = "searchNameTbox";
            this.searchNameTbox.Size = new System.Drawing.Size(404, 40);
            this.searchNameTbox.TabIndex = 28;
            // 
            // searchNameLbl
            // 
            this.searchNameLbl.AutoSize = true;
            this.searchNameLbl.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 24.75F);
            this.searchNameLbl.Location = new System.Drawing.Point(999, 218);
            this.searchNameLbl.Name = "searchNameLbl";
            this.searchNameLbl.Size = new System.Drawing.Size(100, 33);
            this.searchNameLbl.TabIndex = 27;
            this.searchNameLbl.Text = "名前:";
            // 
            // searchIdTbox
            // 
            this.searchIdTbox.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 24.75F);
            this.searchIdTbox.Location = new System.Drawing.Point(1105, 172);
            this.searchIdTbox.Name = "searchIdTbox";
            this.searchIdTbox.Size = new System.Drawing.Size(404, 40);
            this.searchIdTbox.TabIndex = 26;
            // 
            // searchIdLbl
            // 
            this.searchIdLbl.AutoSize = true;
            this.searchIdLbl.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 24.75F);
            this.searchIdLbl.Location = new System.Drawing.Point(1033, 175);
            this.searchIdLbl.Name = "searchIdLbl";
            this.searchIdLbl.Size = new System.Drawing.Size(66, 33);
            this.searchIdLbl.TabIndex = 25;
            this.searchIdLbl.Text = "ID:";
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1610, 982);
            this.ControlBox = false;
            this.Controls.Add(this.searchHuriganaTbox);
            this.Controls.Add(this.searchHuriganaLbl);
            this.Controls.Add(this.searchNameTbox);
            this.Controls.Add(this.searchNameLbl);
            this.Controls.Add(this.searchIdTbox);
            this.Controls.Add(this.searchIdLbl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.phoneNumberTbox);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.phoneNumberLbl);
            this.Controls.Add(this.addressLbl);
            this.Controls.Add(this.PostalCodeTbox);
            this.Controls.Add(this.addressTbox);
            this.Controls.Add(this.postalCodeLbl);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.nameTbox);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.idTbox);
            this.Controls.Add(this.IdLbl);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.registBtn);
            this.Controls.Add(this.ClientsDgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clients";
            this.Text = "Clients";
            ((System.ComponentModel.ISupportInitialize)(this.ClientsDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ClientsDgv;
        private System.Windows.Forms.Button registBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label IdLbl;
        private System.Windows.Forms.TextBox idTbox;
        private System.Windows.Forms.TextBox nameTbox;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.TextBox phoneNumberTbox;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label phoneNumberLbl;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.TextBox PostalCodeTbox;
        private System.Windows.Forms.TextBox addressTbox;
        private System.Windows.Forms.Label postalCodeLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchHuriganaTbox;
        private System.Windows.Forms.Label searchHuriganaLbl;
        private System.Windows.Forms.TextBox searchNameTbox;
        private System.Windows.Forms.Label searchNameLbl;
        private System.Windows.Forms.TextBox searchIdTbox;
        private System.Windows.Forms.Label searchIdLbl;
    }
}
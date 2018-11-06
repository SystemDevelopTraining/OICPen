﻿namespace OICPen
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
            this.clientsDgv = new System.Windows.Forms.DataGridView();
            this.registBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.idLbl = new System.Windows.Forms.Label();
            this.nameTbox = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.phoneNumberLbl = new System.Windows.Forms.Label();
            this.addressLbl = new System.Windows.Forms.Label();
            this.addressTbox = new System.Windows.Forms.TextBox();
            this.postalCodeLbl = new System.Windows.Forms.Label();
            this.histroryViewBtn = new System.Windows.Forms.Button();
            this.huriganaTbox = new System.Windows.Forms.TextBox();
            this.huriganaLbl = new System.Windows.Forms.Label();
            this.searchHuriganaTbox = new System.Windows.Forms.TextBox();
            this.searchHuriganaLbl = new System.Windows.Forms.Label();
            this.searchNameTbox = new System.Windows.Forms.TextBox();
            this.searchNameLbl = new System.Windows.Forms.Label();
            this.searchIdLbl = new System.Windows.Forms.Label();
            this.idDispLbl = new System.Windows.Forms.Label();
            this.regAndUpdSubtTtleLbl = new System.Windows.Forms.Label();
            this.searchClientSubTitleLbl = new System.Windows.Forms.Label();
            this.phoneNumberMaskedTbox = new System.Windows.Forms.MaskedTextBox();
            this.postalCodeMaskedTbox = new System.Windows.Forms.MaskedTextBox();
            this.searchIdTbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // clientsDgv
            // 
            this.clientsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsDgv.Location = new System.Drawing.Point(12, 21);
            this.clientsDgv.Name = "clientsDgv";
            this.clientsDgv.RowTemplate.Height = 21;
            this.clientsDgv.Size = new System.Drawing.Size(900, 949);
            this.clientsDgv.TabIndex = 5;
            // 
            // registBtn
            // 
            this.registBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.registBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 24.75F);
            this.registBtn.Location = new System.Drawing.Point(1099, 840);
            this.registBtn.Name = "registBtn";
            this.registBtn.Size = new System.Drawing.Size(186, 58);
            this.registBtn.TabIndex = 11;
            this.registBtn.Text = "新規登録";
            this.registBtn.UseVisualStyleBackColor = true;
            this.registBtn.Click += new System.EventHandler(this.registBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.searchBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.searchBtn.Location = new System.Drawing.Point(1105, 341);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(186, 58);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "検索";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.clearBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.clearBtn.Location = new System.Drawing.Point(1323, 342);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(186, 58);
            this.clearBtn.TabIndex = 0;
            this.clearBtn.Text = "条件クリア";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 24.75F);
            this.idLbl.Location = new System.Drawing.Point(1027, 503);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(66, 33);
            this.idLbl.TabIndex = 0;
            this.idLbl.Text = "ID:";
            // 
            // nameTbox
            // 
            this.nameTbox.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 24.75F);
            this.nameTbox.Location = new System.Drawing.Point(1099, 546);
            this.nameTbox.MaxLength = 30;
            this.nameTbox.Name = "nameTbox";
            this.nameTbox.Size = new System.Drawing.Size(404, 40);
            this.nameTbox.TabIndex = 6;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 24.75F);
            this.nameLbl.Location = new System.Drawing.Point(993, 546);
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
            // updateBtn
            // 
            this.updateBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.updateBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 24.75F);
            this.updateBtn.Location = new System.Drawing.Point(1317, 840);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(186, 58);
            this.updateBtn.TabIndex = 12;
            this.updateBtn.Text = "更新";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // phoneNumberLbl
            // 
            this.phoneNumberLbl.AutoSize = true;
            this.phoneNumberLbl.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 24.75F);
            this.phoneNumberLbl.Location = new System.Drawing.Point(925, 641);
            this.phoneNumberLbl.Name = "phoneNumberLbl";
            this.phoneNumberLbl.Size = new System.Drawing.Size(168, 33);
            this.phoneNumberLbl.TabIndex = 20;
            this.phoneNumberLbl.Text = "電話番号:";
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 24.75F);
            this.addressLbl.Location = new System.Drawing.Point(993, 733);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(100, 33);
            this.addressLbl.TabIndex = 16;
            this.addressLbl.Text = "住所:";
            // 
            // addressTbox
            // 
            this.addressTbox.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 24.75F);
            this.addressTbox.Location = new System.Drawing.Point(1099, 730);
            this.addressTbox.MaxLength = 50;
            this.addressTbox.Multiline = true;
            this.addressTbox.Name = "addressTbox";
            this.addressTbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.addressTbox.Size = new System.Drawing.Size(404, 80);
            this.addressTbox.TabIndex = 10;
            // 
            // postalCodeLbl
            // 
            this.postalCodeLbl.AutoSize = true;
            this.postalCodeLbl.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 24.75F);
            this.postalCodeLbl.Location = new System.Drawing.Point(925, 687);
            this.postalCodeLbl.Name = "postalCodeLbl";
            this.postalCodeLbl.Size = new System.Drawing.Size(168, 33);
            this.postalCodeLbl.TabIndex = 18;
            this.postalCodeLbl.Text = "郵便番号:";
            // 
            // histroryViewBtn
            // 
            this.histroryViewBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.histroryViewBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.histroryViewBtn.Location = new System.Drawing.Point(1317, 912);
            this.histroryViewBtn.Name = "histroryViewBtn";
            this.histroryViewBtn.Size = new System.Drawing.Size(186, 58);
            this.histroryViewBtn.TabIndex = 22;
            this.histroryViewBtn.Text = "購入履歴";
            this.histroryViewBtn.UseVisualStyleBackColor = true;
            // 
            // huriganaTbox
            // 
            this.huriganaTbox.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 24.75F);
            this.huriganaTbox.Location = new System.Drawing.Point(1099, 592);
            this.huriganaTbox.MaxLength = 30;
            this.huriganaTbox.Name = "huriganaTbox";
            this.huriganaTbox.Size = new System.Drawing.Size(404, 40);
            this.huriganaTbox.TabIndex = 7;
            // 
            // huriganaLbl
            // 
            this.huriganaLbl.AutoSize = true;
            this.huriganaLbl.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 24.75F);
            this.huriganaLbl.Location = new System.Drawing.Point(925, 595);
            this.huriganaLbl.Name = "huriganaLbl";
            this.huriganaLbl.Size = new System.Drawing.Size(168, 33);
            this.huriganaLbl.TabIndex = 23;
            this.huriganaLbl.Text = "ふりがな:";
            // 
            // searchHuriganaTbox
            // 
            this.searchHuriganaTbox.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 24.75F);
            this.searchHuriganaTbox.Location = new System.Drawing.Point(1105, 283);
            this.searchHuriganaTbox.MaxLength = 30;
            this.searchHuriganaTbox.Name = "searchHuriganaTbox";
            this.searchHuriganaTbox.Size = new System.Drawing.Size(404, 40);
            this.searchHuriganaTbox.TabIndex = 3;
            // 
            // searchHuriganaLbl
            // 
            this.searchHuriganaLbl.AutoSize = true;
            this.searchHuriganaLbl.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 24.75F);
            this.searchHuriganaLbl.Location = new System.Drawing.Point(931, 286);
            this.searchHuriganaLbl.Name = "searchHuriganaLbl";
            this.searchHuriganaLbl.Size = new System.Drawing.Size(168, 33);
            this.searchHuriganaLbl.TabIndex = 29;
            this.searchHuriganaLbl.Text = "ふりがな:";
            // 
            // searchNameTbox
            // 
            this.searchNameTbox.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 24.75F);
            this.searchNameTbox.Location = new System.Drawing.Point(1105, 191);
            this.searchNameTbox.MaxLength = 30;
            this.searchNameTbox.Name = "searchNameTbox";
            this.searchNameTbox.Size = new System.Drawing.Size(404, 40);
            this.searchNameTbox.TabIndex = 1;
            // 
            // searchNameLbl
            // 
            this.searchNameLbl.AutoSize = true;
            this.searchNameLbl.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 24.75F);
            this.searchNameLbl.Location = new System.Drawing.Point(999, 191);
            this.searchNameLbl.Name = "searchNameLbl";
            this.searchNameLbl.Size = new System.Drawing.Size(100, 33);
            this.searchNameLbl.TabIndex = 27;
            this.searchNameLbl.Text = "名前:";
            // 
            // searchIdLbl
            // 
            this.searchIdLbl.AutoSize = true;
            this.searchIdLbl.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 24.75F);
            this.searchIdLbl.Location = new System.Drawing.Point(1033, 240);
            this.searchIdLbl.Name = "searchIdLbl";
            this.searchIdLbl.Size = new System.Drawing.Size(66, 33);
            this.searchIdLbl.TabIndex = 25;
            this.searchIdLbl.Text = "ID:";
            // 
            // idDispLbl
            // 
            this.idDispLbl.AutoSize = true;
            this.idDispLbl.Font = new System.Drawing.Font("MS UI Gothic", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.idDispLbl.Location = new System.Drawing.Point(1099, 503);
            this.idDispLbl.Name = "idDispLbl";
            this.idDispLbl.Size = new System.Drawing.Size(138, 33);
            this.idDispLbl.TabIndex = 31;
            this.idDispLbl.Text = "idDispLbl";
            // 
            // regAndUpdSubtTtleLbl
            // 
            this.regAndUpdSubtTtleLbl.AutoSize = true;
            this.regAndUpdSubtTtleLbl.Font = new System.Drawing.Font("HGS創英ﾌﾟﾚｾﾞﾝｽEB", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.regAndUpdSubtTtleLbl.Location = new System.Drawing.Point(1214, 470);
            this.regAndUpdSubtTtleLbl.Name = "regAndUpdSubtTtleLbl";
            this.regAndUpdSubtTtleLbl.Size = new System.Drawing.Size(180, 33);
            this.regAndUpdSubtTtleLbl.TabIndex = 32;
            this.regAndUpdSubtTtleLbl.Text = "登録・更新";
            // 
            // searchClientSubTitleLbl
            // 
            this.searchClientSubTitleLbl.AutoSize = true;
            this.searchClientSubTitleLbl.Font = new System.Drawing.Font("HGS創英ﾌﾟﾚｾﾞﾝｽEB", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.searchClientSubTitleLbl.Location = new System.Drawing.Point(1214, 155);
            this.searchClientSubTitleLbl.Name = "searchClientSubTitleLbl";
            this.searchClientSubTitleLbl.Size = new System.Drawing.Size(147, 33);
            this.searchClientSubTitleLbl.TabIndex = 33;
            this.searchClientSubTitleLbl.Text = "会員検索";
            // 
            // phoneNumberMaskedTbox
            // 
            this.phoneNumberMaskedTbox.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 24.75F);
            this.phoneNumberMaskedTbox.Location = new System.Drawing.Point(1099, 637);
            this.phoneNumberMaskedTbox.Mask = "9990-9990-0000";
            this.phoneNumberMaskedTbox.Name = "phoneNumberMaskedTbox";
            this.phoneNumberMaskedTbox.Size = new System.Drawing.Size(295, 40);
            this.phoneNumberMaskedTbox.TabIndex = 8;
            this.phoneNumberMaskedTbox.Click += new System.EventHandler(this.phoneNumberMaskedTbox_Click);
            this.phoneNumberMaskedTbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneNumberMaskedTbox_KeyPress);
            // 
            // postalCodeMaskedTbox
            // 
            this.postalCodeMaskedTbox.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 24.75F);
            this.postalCodeMaskedTbox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.postalCodeMaskedTbox.Location = new System.Drawing.Point(1099, 684);
            this.postalCodeMaskedTbox.Mask = "000-0000";
            this.postalCodeMaskedTbox.Name = "postalCodeMaskedTbox";
            this.postalCodeMaskedTbox.Size = new System.Drawing.Size(192, 40);
            this.postalCodeMaskedTbox.TabIndex = 9;
            this.postalCodeMaskedTbox.Click += new System.EventHandler(this.postalCodeMaskedTbox_Click);
            this.postalCodeMaskedTbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.postalCodeMaskedTbox_KeyPress);
            // 
            // searchIdTbox
            // 
            this.searchIdTbox.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 24.75F);
            this.searchIdTbox.Location = new System.Drawing.Point(1105, 237);
            this.searchIdTbox.MaxLength = 6;
            this.searchIdTbox.Name = "searchIdTbox";
            this.searchIdTbox.Size = new System.Drawing.Size(108, 40);
            this.searchIdTbox.TabIndex = 2;
            this.searchIdTbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchIdTbox_KeyPress);
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1610, 982);
            this.ControlBox = false;
            this.Controls.Add(this.postalCodeMaskedTbox);
            this.Controls.Add(this.phoneNumberMaskedTbox);
            this.Controls.Add(this.searchClientSubTitleLbl);
            this.Controls.Add(this.regAndUpdSubtTtleLbl);
            this.Controls.Add(this.idDispLbl);
            this.Controls.Add(this.searchHuriganaTbox);
            this.Controls.Add(this.searchHuriganaLbl);
            this.Controls.Add(this.searchIdTbox);
            this.Controls.Add(this.searchNameTbox);
            this.Controls.Add(this.searchNameLbl);
            this.Controls.Add(this.searchIdLbl);
            this.Controls.Add(this.huriganaTbox);
            this.Controls.Add(this.huriganaLbl);
            this.Controls.Add(this.histroryViewBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.phoneNumberLbl);
            this.Controls.Add(this.addressLbl);
            this.Controls.Add(this.addressTbox);
            this.Controls.Add(this.postalCodeLbl);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.nameTbox);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.registBtn);
            this.Controls.Add(this.clientsDgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clients";
            this.Text = "Clients";
            ((System.ComponentModel.ISupportInitialize)(this.clientsDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView clientsDgv;
        private System.Windows.Forms.Button registBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.TextBox nameTbox;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label phoneNumberLbl;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.TextBox addressTbox;
        private System.Windows.Forms.Label postalCodeLbl;
        private System.Windows.Forms.Button histroryViewBtn;
        private System.Windows.Forms.TextBox huriganaTbox;
        private System.Windows.Forms.Label huriganaLbl;
        private System.Windows.Forms.TextBox searchHuriganaTbox;
        private System.Windows.Forms.Label searchHuriganaLbl;
        private System.Windows.Forms.TextBox searchNameTbox;
        private System.Windows.Forms.Label searchNameLbl;
        private System.Windows.Forms.Label searchIdLbl;
        private System.Windows.Forms.Label idDispLbl;
        private System.Windows.Forms.Label regAndUpdSubtTtleLbl;
        private System.Windows.Forms.Label searchClientSubTitleLbl;
        private System.Windows.Forms.MaskedTextBox phoneNumberMaskedTbox;
        private System.Windows.Forms.MaskedTextBox postalCodeMaskedTbox;
        private System.Windows.Forms.TextBox searchIdTbox;
    }
}
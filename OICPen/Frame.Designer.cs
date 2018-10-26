namespace OICPen
{
    partial class Frame
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.teamNameLbl = new System.Windows.Forms.Label();
            this.logoPbox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.systemNameLbl = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.staffsBtn = new System.Windows.Forms.Button();
            this.clientsBtn = new System.Windows.Forms.Button();
            this.itemsBtn = new System.Windows.Forms.Button();
            this.stockBtn = new System.Windows.Forms.Button();
            this.takeorderBtn = new System.Windows.Forms.Button();
            this.giveorderBtn = new System.Windows.Forms.Button();
            this.incomingBtn = new System.Windows.Forms.Button();
            this.shipBtn = new System.Windows.Forms.Button();
            this.salesBtn = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.nowLoginLbl = new System.Windows.Forms.Label();
            this.warningLbl = new System.Windows.Forms.Label();
            this.staffsNameLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Black;
            this.splitContainer1.Panel1.Controls.Add(this.teamNameLbl);
            this.splitContainer1.Panel1.Controls.Add(this.logoPbox);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.systemNameLbl);
            this.splitContainer1.Panel1.ForeColor = System.Drawing.Color.DarkRed;
            this.splitContainer1.Panel1MinSize = 10;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1937, 1064);
            this.splitContainer1.SplitterDistance = 63;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // teamNameLbl
            // 
            this.teamNameLbl.AutoSize = true;
            this.teamNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.teamNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamNameLbl.ForeColor = System.Drawing.Color.Orange;
            this.teamNameLbl.Location = new System.Drawing.Point(199, 16);
            this.teamNameLbl.Name = "teamNameLbl";
            this.teamNameLbl.Size = new System.Drawing.Size(100, 37);
            this.teamNameLbl.TabIndex = 4;
            this.teamNameLbl.Text = "IM-21";
            // 
            // logoPbox
            // 
            this.logoPbox.BackColor = System.Drawing.Color.White;
            this.logoPbox.BackgroundImage = global::OICPen.Properties.Resources._0m012d825c5b12705c606812447e243c22686e64752f477d470e7f396f7a3237746837646131373e59;
            this.logoPbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoPbox.Location = new System.Drawing.Point(3, 3);
            this.logoPbox.Name = "logoPbox";
            this.logoPbox.Size = new System.Drawing.Size(190, 57);
            this.logoPbox.TabIndex = 3;
            this.logoPbox.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1586, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "2018/01/01 (月）   0:00";
            // 
            // systemNameLbl
            // 
            this.systemNameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.systemNameLbl.AutoSize = true;
            this.systemNameLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 NP-B", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.systemNameLbl.ForeColor = System.Drawing.Color.White;
            this.systemNameLbl.Location = new System.Drawing.Point(839, 16);
            this.systemNameLbl.Name = "systemNameLbl";
            this.systemNameLbl.Size = new System.Drawing.Size(279, 33);
            this.systemNameLbl.TabIndex = 0;
            this.systemNameLbl.Text = "在庫管理システム";
            this.systemNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.Black;
            this.splitContainer2.Panel1.Controls.Add(this.logoutBtn);
            this.splitContainer2.Panel1.Controls.Add(this.exitBtn);
            this.splitContainer2.Panel1.Controls.Add(this.staffsBtn);
            this.splitContainer2.Panel1.Controls.Add(this.clientsBtn);
            this.splitContainer2.Panel1.Controls.Add(this.itemsBtn);
            this.splitContainer2.Panel1.Controls.Add(this.stockBtn);
            this.splitContainer2.Panel1.Controls.Add(this.takeorderBtn);
            this.splitContainer2.Panel1.Controls.Add(this.giveorderBtn);
            this.splitContainer2.Panel1.Controls.Add(this.incomingBtn);
            this.splitContainer2.Panel1.Controls.Add(this.shipBtn);
            this.splitContainer2.Panel1.Controls.Add(this.salesBtn);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.splitContainer2.Panel2.ForeColor = System.Drawing.Color.Black;
            this.splitContainer2.Size = new System.Drawing.Size(1937, 1000);
            this.splitContainer2.SplitterDistance = 309;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 0;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.Black;
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.Image = global::OICPen.Properties.Resources.icons8_出口_641;
            this.logoutBtn.Location = new System.Drawing.Point(-3, 837);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(309, 70);
            this.logoutBtn.TabIndex = 6;
            this.logoutBtn.Text = "　ログアウト";
            this.logoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.logoutBtn.UseVisualStyleBackColor = false;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Black;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Image = global::OICPen.Properties.Resources.icons8_削除_641;
            this.exitBtn.Location = new System.Drawing.Point(0, 930);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(309, 70);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.Text = "　終了　";
            this.exitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // staffsBtn
            // 
            this.staffsBtn.BackColor = System.Drawing.Color.Black;
            this.staffsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.staffsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.staffsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.staffsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.staffsBtn.ForeColor = System.Drawing.Color.White;
            this.staffsBtn.Image = global::OICPen.Properties.Resources.icons8_社員カード_64;
            this.staffsBtn.Location = new System.Drawing.Point(0, 714);
            this.staffsBtn.Name = "staffsBtn";
            this.staffsBtn.Size = new System.Drawing.Size(309, 90);
            this.staffsBtn.TabIndex = 0;
            this.staffsBtn.Text = "　社員管理";
            this.staffsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.staffsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.staffsBtn.UseVisualStyleBackColor = false;
            // 
            // clientsBtn
            // 
            this.clientsBtn.BackColor = System.Drawing.Color.Black;
            this.clientsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.clientsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clientsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.clientsBtn.ForeColor = System.Drawing.Color.White;
            this.clientsBtn.Image = global::OICPen.Properties.Resources.icons8_ユーザー_64__1_;
            this.clientsBtn.Location = new System.Drawing.Point(0, 624);
            this.clientsBtn.Name = "clientsBtn";
            this.clientsBtn.Size = new System.Drawing.Size(309, 90);
            this.clientsBtn.TabIndex = 0;
            this.clientsBtn.Text = "　会員管理";
            this.clientsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clientsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.clientsBtn.UseVisualStyleBackColor = false;
            // 
            // itemsBtn
            // 
            this.itemsBtn.BackColor = System.Drawing.Color.Black;
            this.itemsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.itemsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.itemsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.itemsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.itemsBtn.ForeColor = System.Drawing.Color.White;
            this.itemsBtn.Image = global::OICPen.Properties.Resources.icons8_製品_641;
            this.itemsBtn.Location = new System.Drawing.Point(0, 534);
            this.itemsBtn.Name = "itemsBtn";
            this.itemsBtn.Size = new System.Drawing.Size(309, 90);
            this.itemsBtn.TabIndex = 0;
            this.itemsBtn.Text = "　商品管理";
            this.itemsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.itemsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.itemsBtn.UseVisualStyleBackColor = false;
            // 
            // stockBtn
            // 
            this.stockBtn.BackColor = System.Drawing.Color.Black;
            this.stockBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stockBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.stockBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stockBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.stockBtn.ForeColor = System.Drawing.Color.White;
            this.stockBtn.Image = global::OICPen.Properties.Resources.icons8_倉庫_64__2_;
            this.stockBtn.Location = new System.Drawing.Point(0, 444);
            this.stockBtn.Name = "stockBtn";
            this.stockBtn.Size = new System.Drawing.Size(309, 90);
            this.stockBtn.TabIndex = 0;
            this.stockBtn.Text = "　在庫管理";
            this.stockBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stockBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.stockBtn.UseVisualStyleBackColor = false;
            // 
            // takeorderBtn
            // 
            this.takeorderBtn.BackColor = System.Drawing.Color.Black;
            this.takeorderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.takeorderBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.takeorderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.takeorderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.takeorderBtn.ForeColor = System.Drawing.Color.White;
            this.takeorderBtn.Image = global::OICPen.Properties.Resources.icons8_ショッピングカート_641;
            this.takeorderBtn.Location = new System.Drawing.Point(0, 354);
            this.takeorderBtn.Name = "takeorderBtn";
            this.takeorderBtn.Size = new System.Drawing.Size(309, 90);
            this.takeorderBtn.TabIndex = 0;
            this.takeorderBtn.Text = "　注文管理";
            this.takeorderBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.takeorderBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.takeorderBtn.UseVisualStyleBackColor = false;
            // 
            // giveorderBtn
            // 
            this.giveorderBtn.BackColor = System.Drawing.Color.Black;
            this.giveorderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.giveorderBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.giveorderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.giveorderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.giveorderBtn.ForeColor = System.Drawing.Color.White;
            this.giveorderBtn.Image = global::OICPen.Properties.Resources.icons8_注文書_641;
            this.giveorderBtn.Location = new System.Drawing.Point(0, 264);
            this.giveorderBtn.Name = "giveorderBtn";
            this.giveorderBtn.Size = new System.Drawing.Size(309, 90);
            this.giveorderBtn.TabIndex = 0;
            this.giveorderBtn.Text = "　発注管理";
            this.giveorderBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.giveorderBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.giveorderBtn.UseVisualStyleBackColor = false;
            // 
            // incomingBtn
            // 
            this.incomingBtn.BackColor = System.Drawing.Color.Black;
            this.incomingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.incomingBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.incomingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.incomingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.incomingBtn.ForeColor = System.Drawing.Color.White;
            this.incomingBtn.Image = global::OICPen.Properties.Resources.icons8_二重左矢印_48__1_;
            this.incomingBtn.Location = new System.Drawing.Point(0, 174);
            this.incomingBtn.Name = "incomingBtn";
            this.incomingBtn.Size = new System.Drawing.Size(309, 90);
            this.incomingBtn.TabIndex = 0;
            this.incomingBtn.Text = "　入庫管理";
            this.incomingBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.incomingBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.incomingBtn.UseVisualStyleBackColor = false;
            // 
            // shipBtn
            // 
            this.shipBtn.BackColor = System.Drawing.Color.Black;
            this.shipBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shipBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.shipBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.shipBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.shipBtn.ForeColor = System.Drawing.Color.White;
            this.shipBtn.Image = global::OICPen.Properties.Resources.icons8_配達_642;
            this.shipBtn.Location = new System.Drawing.Point(0, 84);
            this.shipBtn.Name = "shipBtn";
            this.shipBtn.Size = new System.Drawing.Size(309, 90);
            this.shipBtn.TabIndex = 0;
            this.shipBtn.Text = "　出庫管理　";
            this.shipBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.shipBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.shipBtn.UseVisualStyleBackColor = false;
            // 
            // salesBtn
            // 
            this.salesBtn.BackColor = System.Drawing.Color.Black;
            this.salesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salesBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.salesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.salesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.salesBtn.ForeColor = System.Drawing.Color.White;
            this.salesBtn.Image = global::OICPen.Properties.Resources.icons8_日本円_64;
            this.salesBtn.Location = new System.Drawing.Point(0, 0);
            this.salesBtn.Name = "salesBtn";
            this.salesBtn.Size = new System.Drawing.Size(309, 84);
            this.salesBtn.TabIndex = 0;
            this.salesBtn.Text = "　売上管理　";
            this.salesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.salesBtn.UseVisualStyleBackColor = false;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer3.Panel2.Controls.Add(this.nowLoginLbl);
            this.splitContainer3.Panel2.Controls.Add(this.warningLbl);
            this.splitContainer3.Panel2.Controls.Add(this.staffsNameLbl);
            this.splitContainer3.Size = new System.Drawing.Size(1937, 1100);
            this.splitContainer3.SplitterDistance = 1064;
            this.splitContainer3.SplitterWidth = 1;
            this.splitContainer3.TabIndex = 1;
            // 
            // nowLoginLbl
            // 
            this.nowLoginLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 NP-B", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nowLoginLbl.ForeColor = System.Drawing.Color.Blue;
            this.nowLoginLbl.Location = new System.Drawing.Point(137, 2);
            this.nowLoginLbl.Name = "nowLoginLbl";
            this.nowLoginLbl.Size = new System.Drawing.Size(162, 31);
            this.nowLoginLbl.TabIndex = 1;
            this.nowLoginLbl.Text = "ログイン中";
            this.nowLoginLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // warningLbl
            // 
            this.warningLbl.BackColor = System.Drawing.Color.Yellow;
            this.warningLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 NP-B", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.warningLbl.Location = new System.Drawing.Point(305, 0);
            this.warningLbl.Name = "warningLbl";
            this.warningLbl.Size = new System.Drawing.Size(1632, 33);
            this.warningLbl.TabIndex = 1;
            this.warningLbl.Text = "在庫数警報！または大事な情報または店長からの連絡事項";
            this.warningLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // staffsNameLbl
            // 
            this.staffsNameLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 NP-B", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.staffsNameLbl.Location = new System.Drawing.Point(3, 2);
            this.staffsNameLbl.Name = "staffsNameLbl";
            this.staffsNameLbl.Size = new System.Drawing.Size(135, 31);
            this.staffsNameLbl.TabIndex = 0;
            this.staffsNameLbl.Text = "古谷";
            this.staffsNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1937, 1100);
            this.Controls.Add(this.splitContainer3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frame";
            this.Text = "Frame";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frame_FormClosing);
            this.Shown += new System.EventHandler(this.Frame_Shown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPbox)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button shipBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button staffsBtn;
        private System.Windows.Forms.Button clientsBtn;
        private System.Windows.Forms.Button itemsBtn;
        private System.Windows.Forms.Button stockBtn;
        private System.Windows.Forms.Button takeorderBtn;
        private System.Windows.Forms.Button giveorderBtn;
        private System.Windows.Forms.Button incomingBtn;
        private System.Windows.Forms.Button salesBtn;
        private System.Windows.Forms.Label systemNameLbl;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label staffsNameLbl;
        private System.Windows.Forms.Label nowLoginLbl;
        private System.Windows.Forms.PictureBox logoPbox;
        private System.Windows.Forms.Label teamNameLbl;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label warningLbl;
    }
}
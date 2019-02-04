namespace OICPen
{
    partial class Sales
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.salesEndDtp = new System.Windows.Forms.DateTimePicker();
            this.titleLbl = new System.Windows.Forms.Label();
            this.salesDisplayBtn = new System.Windows.Forms.Button();
            this.salesDgv = new System.Windows.Forms.DataGridView();
            this.itemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemSales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesStartDtp = new System.Windows.Forms.DateTimePicker();
            this.salesAndLbl = new System.Windows.Forms.Label();
            this.salesBetweenLbl = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.salesDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // salesEndDtp
            // 
            this.salesEndDtp.AllowDrop = true;
            this.salesEndDtp.CustomFormat = "";
            this.salesEndDtp.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.salesEndDtp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.salesEndDtp.Location = new System.Drawing.Point(1357, 838);
            this.salesEndDtp.Name = "salesEndDtp";
            this.salesEndDtp.Size = new System.Drawing.Size(228, 36);
            this.salesEndDtp.TabIndex = 3;
            this.salesEndDtp.Tag = "";
            // 
            // titleLbl
            // 
            this.titleLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLbl.AutoSize = true;
            this.titleLbl.BackColor = System.Drawing.Color.Transparent;
            this.titleLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 NP-B", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.titleLbl.ForeColor = System.Drawing.Color.Black;
            this.titleLbl.Location = new System.Drawing.Point(1373, 19);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(212, 48);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "売上管理";
            // 
            // salesDisplayBtn
            // 
            this.salesDisplayBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.salesDisplayBtn.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.salesDisplayBtn.Location = new System.Drawing.Point(1384, 125);
            this.salesDisplayBtn.Name = "salesDisplayBtn";
            this.salesDisplayBtn.Size = new System.Drawing.Size(186, 58);
            this.salesDisplayBtn.TabIndex = 1;
            this.salesDisplayBtn.Text = "売上表示";
            this.salesDisplayBtn.UseVisualStyleBackColor = true;
            this.salesDisplayBtn.Click += new System.EventHandler(this.salesDisplayBtn_Click);
            // 
            // salesDgv
            // 
            this.salesDgv.AllowUserToAddRows = false;
            this.salesDgv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.salesDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemId,
            this.itemName,
            this.itemSales,
            this.gain});
            this.salesDgv.Location = new System.Drawing.Point(12, 21);
            this.salesDgv.Name = "salesDgv";
            this.salesDgv.RowTemplate.Height = 21;
            this.salesDgv.Size = new System.Drawing.Size(1310, 949);
            this.salesDgv.TabIndex = 0;
            this.salesDgv.TabStop = false;
            // 
            // itemId
            // 
            this.itemId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemId.HeaderText = "商品ID";
            this.itemId.Name = "itemId";
            this.itemId.ReadOnly = true;
            // 
            // itemName
            // 
            this.itemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemName.HeaderText = "商品名";
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            // 
            // itemSales
            // 
            this.itemSales.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemSales.HeaderText = "売上";
            this.itemSales.Name = "itemSales";
            this.itemSales.ReadOnly = true;
            // 
            // gain
            // 
            this.gain.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gain.HeaderText = "利益";
            this.gain.Name = "gain";
            this.gain.ReadOnly = true;
            // 
            // salesStartDtp
            // 
            this.salesStartDtp.CustomFormat = "";
            this.salesStartDtp.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.salesStartDtp.Location = new System.Drawing.Point(1357, 740);
            this.salesStartDtp.Name = "salesStartDtp";
            this.salesStartDtp.Size = new System.Drawing.Size(228, 36);
            this.salesStartDtp.TabIndex = 2;
            // 
            // salesAndLbl
            // 
            this.salesAndLbl.AutoSize = true;
            this.salesAndLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 NP-B", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.salesAndLbl.Location = new System.Drawing.Point(1453, 797);
            this.salesAndLbl.Name = "salesAndLbl";
            this.salesAndLbl.Size = new System.Drawing.Size(42, 29);
            this.salesAndLbl.TabIndex = 0;
            this.salesAndLbl.Text = "～";
            // 
            // salesBetweenLbl
            // 
            this.salesBetweenLbl.AutoSize = true;
            this.salesBetweenLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 NP-B", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.salesBetweenLbl.Location = new System.Drawing.Point(1398, 663);
            this.salesBetweenLbl.Name = "salesBetweenLbl";
            this.salesBetweenLbl.Size = new System.Drawing.Size(147, 33);
            this.salesBetweenLbl.TabIndex = 0;
            this.salesBetweenLbl.Text = "指定期間";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(75, 51);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "売上";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1247, 591);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1384, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1610, 982);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.salesBetweenLbl);
            this.Controls.Add(this.salesAndLbl);
            this.Controls.Add(this.salesEndDtp);
            this.Controls.Add(this.salesStartDtp);
            this.Controls.Add(this.salesDgv);
            this.Controls.Add(this.salesDisplayBtn);
            this.Controls.Add(this.titleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sales";
            this.Text = "sales";
            this.Load += new System.EventHandler(this.sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button salesDisplayBtn;
        private System.Windows.Forms.DataGridView salesDgv;
        private System.Windows.Forms.DateTimePicker salesStartDtp;
        private System.Windows.Forms.Label salesAndLbl;
        private System.Windows.Forms.Label salesBetweenLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn gain;
        private System.Windows.Forms.DateTimePicker salesEndDtp;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
    }
}
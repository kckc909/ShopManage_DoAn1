namespace GUI
{
    partial class F_BaoCaoThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart_DoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_DoanhSoNV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.dateStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dateEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cboLoai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnThongKe = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnFooterContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.pnMatHang = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chart_DoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_DoanhSoNV)).BeginInit();
            this.pnFooterContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart_DoanhThu
            // 
            this.chart_DoanhThu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea5.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea5.Name = "ChartArea1";
            this.chart_DoanhThu.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart_DoanhThu.Legends.Add(legend5);
            this.chart_DoanhThu.Location = new System.Drawing.Point(12, 150);
            this.chart_DoanhThu.Name = "chart_DoanhThu";
            this.chart_DoanhThu.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart_DoanhThu.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))))};
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.LegendText = "Chi phí";
            series7.Name = "Series_ChiPhi";
            series7.YValuesPerPoint = 4;
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.LegendText = "Doanh thu";
            series8.Name = "Series_DoanhThu";
            series8.YValuesPerPoint = 4;
            this.chart_DoanhThu.Series.Add(series7);
            this.chart_DoanhThu.Series.Add(series8);
            this.chart_DoanhThu.Size = new System.Drawing.Size(1010, 284);
            this.chart_DoanhThu.TabIndex = 1;
            this.chart_DoanhThu.Text = "chart1";
            title5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            title5.Name = "Title1";
            title5.Text = "Thống kê doanh thu";
            this.chart_DoanhThu.Titles.Add(title5);
            // 
            // chart_DoanhSoNV
            // 
            chartArea6.Name = "ChartArea1";
            this.chart_DoanhSoNV.ChartAreas.Add(chartArea6);
            this.chart_DoanhSoNV.Dock = System.Windows.Forms.DockStyle.Left;
            legend6.Name = "Legend1";
            this.chart_DoanhSoNV.Legends.Add(legend6);
            this.chart_DoanhSoNV.Location = new System.Drawing.Point(0, 0);
            this.chart_DoanhSoNV.MaximumSize = new System.Drawing.Size(900, 300);
            this.chart_DoanhSoNV.MinimumSize = new System.Drawing.Size(500, 300);
            this.chart_DoanhSoNV.Name = "chart_DoanhSoNV";
            this.chart_DoanhSoNV.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart_DoanhSoNV.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.DeepSkyBlue,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))))};
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series9.Legend = "Legend1";
            series9.LegendText = "Doanh số";
            series9.Name = "Series_DoanhSoNV";
            this.chart_DoanhSoNV.Series.Add(series9);
            this.chart_DoanhSoNV.Size = new System.Drawing.Size(500, 300);
            this.chart_DoanhSoNV.TabIndex = 2;
            this.chart_DoanhSoNV.Text = "chart2";
            title6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            title6.Name = "Title1";
            title6.Text = "Doanh số nhân viên";
            this.chart_DoanhSoNV.Titles.Add(title6);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1034, 80);
            this.label2.TabIndex = 3;
            this.label2.Text = "THỐNG KÊ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateStart
            // 
            this.dateStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateStart.Checked = true;
            this.dateStart.FillColor = System.Drawing.Color.White;
            this.dateStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateStart.Location = new System.Drawing.Point(79, 97);
            this.dateStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(200, 36);
            this.dateStart.TabIndex = 5;
            this.dateStart.Value = new System.DateTime(2024, 5, 27, 10, 39, 52, 827);
            // 
            // dateEnd
            // 
            this.dateEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateEnd.Checked = true;
            this.dateEnd.FillColor = System.Drawing.Color.White;
            this.dateEnd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateEnd.Location = new System.Drawing.Point(368, 97);
            this.dateEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(200, 36);
            this.dateEnd.TabIndex = 6;
            this.dateEnd.Value = new System.DateTime(2024, 5, 27, 10, 39, 52, 827);
            // 
            // cboLoai
            // 
            this.cboLoai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboLoai.BackColor = System.Drawing.Color.Transparent;
            this.cboLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLoai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboLoai.ItemHeight = 30;
            this.cboLoai.Items.AddRange(new object[] {
            "Theo ngày",
            "Theo tháng",
            "Theo năm"});
            this.cboLoai.Location = new System.Drawing.Point(839, 97);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(183, 36);
            this.cboLoai.StartIndex = 0;
            this.cboLoai.TabIndex = 7;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThongKe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThongKe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThongKe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThongKe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThongKe.FillColor = System.Drawing.Color.Gray;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(583, 97);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(131, 36);
            this.btnThongKe.TabIndex = 8;
            this.btnThongKe.Text = "Tính toán";
            this.btnThongKe.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(8, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Từ ngày";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(285, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Đến ngày";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(732, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Loại thống kê";
            // 
            // pnFooterContainer
            // 
            this.pnFooterContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnFooterContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnFooterContainer.Controls.Add(this.pnMatHang);
            this.pnFooterContainer.Controls.Add(this.chart_DoanhSoNV);
            this.pnFooterContainer.Location = new System.Drawing.Point(12, 449);
            this.pnFooterContainer.Name = "pnFooterContainer";
            this.pnFooterContainer.Size = new System.Drawing.Size(1010, 300);
            this.pnFooterContainer.TabIndex = 10;
            // 
            // pnMatHang
            // 
            this.pnMatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMatHang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnMatHang.Location = new System.Drawing.Point(500, 0);
            this.pnMatHang.MinimumSize = new System.Drawing.Size(500, 300);
            this.pnMatHang.Name = "pnMatHang";
            this.pnMatHang.Size = new System.Drawing.Size(510, 300);
            this.pnMatHang.TabIndex = 3;
            // 
            // F_BaoCaoThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 761);
            this.Controls.Add(this.pnFooterContainer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.cboLoai);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chart_DoanhThu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_BaoCaoThongKe";
            this.Text = "F_BaoCaoThongKe";
            this.Load += new System.EventHandler(this.F_BaoCaoThongKe_Load);
            this.SizeChanged += new System.EventHandler(this.F_BaoCaoThongKe_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.chart_DoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_DoanhSoNV)).EndInit();
            this.pnFooterContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_DoanhThu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_DoanhSoNV;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateStart;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateEnd;
        private Guna.UI2.WinForms.Guna2ComboBox cboLoai;
        private Guna.UI2.WinForms.Guna2Button btnThongKe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Panel pnFooterContainer;
        private Guna.UI2.WinForms.Guna2Panel pnMatHang;
    }
}
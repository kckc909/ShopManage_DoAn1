namespace GUI
{
    partial class F_TrangChu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.pnLeft_Top = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.chart_DoanhSoNVThangNay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnLeft_Bottom = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.chart_DoanhThuThang = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnRight = new Guna.UI2.WinForms.Guna2Panel();
            this.pnRight_Bottom = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvDSMHCanNhap = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.pnRight_Top = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.picAvatar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnLeft.SuspendLayout();
            this.pnLeft_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_DoanhSoNVThangNay)).BeginInit();
            this.pnLeft_Bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_DoanhThuThang)).BeginInit();
            this.pnRight.SuspendLayout();
            this.pnRight_Bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMHCanNhap)).BeginInit();
            this.pnRight_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnLeft
            // 
            this.pnLeft.Controls.Add(this.pnLeft_Top);
            this.pnLeft.Controls.Add(this.pnLeft_Bottom);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnLeft.Location = new System.Drawing.Point(524, 0);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(510, 690);
            this.pnLeft.TabIndex = 10;
            // 
            // pnLeft_Top
            // 
            this.pnLeft_Top.Controls.Add(this.chart_DoanhSoNVThangNay);
            this.pnLeft_Top.Controls.Add(this.label2);
            this.pnLeft_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLeft_Top.Location = new System.Drawing.Point(0, 0);
            this.pnLeft_Top.Name = "pnLeft_Top";
            this.pnLeft_Top.Size = new System.Drawing.Size(510, 330);
            this.pnLeft_Top.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(510, 71);
            this.label2.TabIndex = 7;
            this.label2.Text = "Doanh số nhân viên tháng này";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart_DoanhSoNVThangNay
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_DoanhSoNVThangNay.ChartAreas.Add(chartArea1);
            this.chart_DoanhSoNVThangNay.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart_DoanhSoNVThangNay.Legends.Add(legend1);
            this.chart_DoanhSoNVThangNay.Location = new System.Drawing.Point(0, 71);
            this.chart_DoanhSoNVThangNay.Name = "chart_DoanhSoNVThangNay";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_DoanhSoNVThangNay.Series.Add(series1);
            this.chart_DoanhSoNVThangNay.Size = new System.Drawing.Size(510, 259);
            this.chart_DoanhSoNVThangNay.TabIndex = 5;
            this.chart_DoanhSoNVThangNay.Text = "chart2";
            // 
            // pnLeft_Bottom
            // 
            this.pnLeft_Bottom.Controls.Add(this.chart_DoanhThuThang);
            this.pnLeft_Bottom.Controls.Add(this.label1);
            this.pnLeft_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnLeft_Bottom.Location = new System.Drawing.Point(0, 336);
            this.pnLeft_Bottom.Name = "pnLeft_Bottom";
            this.pnLeft_Bottom.Size = new System.Drawing.Size(510, 354);
            this.pnLeft_Bottom.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 71);
            this.label1.TabIndex = 6;
            this.label1.Text = "Doanh thu tháng ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart_DoanhThuThang
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_DoanhThuThang.ChartAreas.Add(chartArea2);
            this.chart_DoanhThuThang.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart_DoanhThuThang.Legends.Add(legend2);
            this.chart_DoanhThuThang.Location = new System.Drawing.Point(0, 71);
            this.chart_DoanhThuThang.Name = "chart_DoanhThuThang";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart_DoanhThuThang.Series.Add(series2);
            this.chart_DoanhThuThang.Size = new System.Drawing.Size(510, 283);
            this.chart_DoanhThuThang.TabIndex = 5;
            this.chart_DoanhThuThang.Text = "chart2";
            // 
            // pnRight
            // 
            this.pnRight.Controls.Add(this.pnRight_Bottom);
            this.pnRight.Controls.Add(this.pnRight_Top);
            this.pnRight.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnRight.Location = new System.Drawing.Point(0, 0);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(510, 690);
            this.pnRight.TabIndex = 11;
            // 
            // pnRight_Bottom
            // 
            this.pnRight_Bottom.Controls.Add(this.dgvDSMHCanNhap);
            this.pnRight_Bottom.Controls.Add(this.label3);
            this.pnRight_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnRight_Bottom.Location = new System.Drawing.Point(0, 336);
            this.pnRight_Bottom.Name = "pnRight_Bottom";
            this.pnRight_Bottom.Size = new System.Drawing.Size(510, 354);
            this.pnRight_Bottom.TabIndex = 10;
            // 
            // dgvDSMHCanNhap
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDSMHCanNhap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSMHCanNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSMHCanNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSMHCanNhap.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSMHCanNhap.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDSMHCanNhap.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDSMHCanNhap.Location = new System.Drawing.Point(3, 74);
            this.dgvDSMHCanNhap.Name = "dgvDSMHCanNhap";
            this.dgvDSMHCanNhap.ReadOnly = true;
            this.dgvDSMHCanNhap.RowHeadersVisible = false;
            this.dgvDSMHCanNhap.RowTemplate.Height = 40;
            this.dgvDSMHCanNhap.Size = new System.Drawing.Size(504, 280);
            this.dgvDSMHCanNhap.TabIndex = 7;
            this.dgvDSMHCanNhap.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDSMHCanNhap.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDSMHCanNhap.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDSMHCanNhap.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDSMHCanNhap.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDSMHCanNhap.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDSMHCanNhap.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDSMHCanNhap.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDSMHCanNhap.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDSMHCanNhap.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvDSMHCanNhap.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDSMHCanNhap.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDSMHCanNhap.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvDSMHCanNhap.ThemeStyle.ReadOnly = true;
            this.dgvDSMHCanNhap.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDSMHCanNhap.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDSMHCanNhap.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvDSMHCanNhap.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDSMHCanNhap.ThemeStyle.RowsStyle.Height = 40;
            this.dgvDSMHCanNhap.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDSMHCanNhap.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(510, 71);
            this.label3.TabIndex = 6;
            this.label3.Text = "Danh sách mặt hàng cần nhập";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnRight_Top
            // 
            this.pnRight_Top.Controls.Add(this.btnLamMoi);
            this.pnRight_Top.Controls.Add(this.picAvatar);
            this.pnRight_Top.Controls.Add(this.label8);
            this.pnRight_Top.Controls.Add(this.txtSDT);
            this.pnRight_Top.Controls.Add(this.label5);
            this.pnRight_Top.Controls.Add(this.label6);
            this.pnRight_Top.Controls.Add(this.txtTenNV);
            this.pnRight_Top.Controls.Add(this.txtMaNV);
            this.pnRight_Top.Controls.Add(this.label4);
            this.pnRight_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnRight_Top.Location = new System.Drawing.Point(0, 0);
            this.pnRight_Top.Name = "pnRight_Top";
            this.pnRight_Top.Size = new System.Drawing.Size(510, 330);
            this.pnRight_Top.TabIndex = 11;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.AutoRoundedCorners = true;
            this.btnLamMoi.BorderRadius = 21;
            this.btnLamMoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLamMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLamMoi.FillColor = System.Drawing.Color.Gray;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(24, 255);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(180, 45);
            this.btnLamMoi.TabIndex = 43;
            this.btnLamMoi.Text = "Làm mới";
            // 
            // picAvatar
            // 
            this.picAvatar.ImageRotate = 0F;
            this.picAvatar.Location = new System.Drawing.Point(3, 74);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(211, 162);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 42;
            this.picAvatar.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(246, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 20);
            this.label8.TabIndex = 40;
            this.label8.Text = "SDT";
            // 
            // txtSDT
            // 
            this.txtSDT.AutoRoundedCorners = true;
            this.txtSDT.BorderRadius = 17;
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.DefaultText = "";
            this.txtSDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.Location = new System.Drawing.Point(246, 240);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSDT.MaxLength = 11;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PasswordChar = '\0';
            this.txtSDT.PlaceholderText = "";
            this.txtSDT.SelectedText = "";
            this.txtSDT.Size = new System.Drawing.Size(257, 36);
            this.txtSDT.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(246, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Tên nhân viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(246, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "Mã nhân viên";
            // 
            // txtTenNV
            // 
            this.txtTenNV.AutoRoundedCorners = true;
            this.txtTenNV.BorderRadius = 17;
            this.txtTenNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNV.DefaultText = "";
            this.txtTenNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNV.Location = new System.Drawing.Point(250, 169);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.PasswordChar = '\0';
            this.txtTenNV.PlaceholderText = "";
            this.txtTenNV.SelectedText = "";
            this.txtTenNV.Size = new System.Drawing.Size(253, 36);
            this.txtTenNV.TabIndex = 33;
            // 
            // txtMaNV
            // 
            this.txtMaNV.AutoRoundedCorners = true;
            this.txtMaNV.BorderRadius = 17;
            this.txtMaNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNV.DefaultText = "";
            this.txtMaNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNV.Location = new System.Drawing.Point(250, 98);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.PasswordChar = '\0';
            this.txtMaNV.PlaceholderText = "";
            this.txtMaNV.SelectedText = "";
            this.txtMaNV.Size = new System.Drawing.Size(253, 36);
            this.txtMaNV.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(510, 71);
            this.label4.TabIndex = 7;
            this.label4.Text = "Thông tin nhân viên";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // F_TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 690);
            this.Controls.Add(this.pnLeft);
            this.Controls.Add(this.pnRight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_TrangChu";
            this.Text = "F_TrangChu";
            this.Load += new System.EventHandler(this.F_TrangChu_Load);
            this.SizeChanged += new System.EventHandler(this.F_TrangChu_SizeChanged);
            this.pnLeft.ResumeLayout(false);
            this.pnLeft_Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_DoanhSoNVThangNay)).EndInit();
            this.pnLeft_Bottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_DoanhThuThang)).EndInit();
            this.pnRight.ResumeLayout(false);
            this.pnRight_Bottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMHCanNhap)).EndInit();
            this.pnRight_Top.ResumeLayout(false);
            this.pnRight_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnLeft;
        private Guna.UI2.WinForms.Guna2Panel pnLeft_Top;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_DoanhSoNVThangNay;
        private Guna.UI2.WinForms.Guna2Panel pnLeft_Bottom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_DoanhThuThang;
        private Guna.UI2.WinForms.Guna2Panel pnRight;
        private Guna.UI2.WinForms.Guna2Panel pnRight_Bottom;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDSMHCanNhap;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel pnRight_Top;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
        private Guna.UI2.WinForms.Guna2PictureBox picAvatar;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtSDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtTenNV;
        private Guna.UI2.WinForms.Guna2TextBox txtMaNV;
        private System.Windows.Forms.Label label4;
    }
}
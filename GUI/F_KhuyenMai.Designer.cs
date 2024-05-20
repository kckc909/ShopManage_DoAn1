namespace GUI
{
    partial class F_KhuyenMai
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.pnMain = new Guna.UI2.WinForms.Guna2Panel();
            this.pnApDungKM = new Guna.UI2.WinForms.Guna2Panel();
            this.btnApDungKM = new Guna.UI2.WinForms.Guna2Button();
            this.dtg = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhanTramGiam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btbLamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.dtpNgayKetThuc = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpNgayBatDau = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDatLai = new Guna.UI2.WinForms.Guna2Button();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMoTa = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPhanTramgGiam = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenKM = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaKM = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).BeginInit();
            this.pnLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 80);
            this.label2.TabIndex = 1;
            this.label2.Text = "THÔNG TIN KHUYẾN MÃI";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.pnApDungKM);
            this.pnMain.Controls.Add(this.btnApDungKM);
            this.pnMain.Controls.Add(this.dtg);
            this.pnMain.Controls.Add(this.btbLamMoi);
            this.pnMain.Controls.Add(this.btnXoa);
            this.pnMain.Controls.Add(this.btnTimKiem);
            this.pnMain.Controls.Add(this.btnThem);
            this.pnMain.Controls.Add(this.txtTimKiem);
            this.pnMain.Controls.Add(this.label1);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(634, 690);
            this.pnMain.TabIndex = 3;
            // 
            // pnApDungKM
            // 
            this.pnApDungKM.Location = new System.Drawing.Point(543, 258);
            this.pnApDungKM.Name = "pnApDungKM";
            this.pnApDungKM.Size = new System.Drawing.Size(64, 49);
            this.pnApDungKM.TabIndex = 28;
            this.pnApDungKM.Visible = false;
            // 
            // btnApDungKM
            // 
            this.btnApDungKM.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnApDungKM.AutoRoundedCorners = true;
            this.btnApDungKM.BorderRadius = 28;
            this.btnApDungKM.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnApDungKM.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnApDungKM.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnApDungKM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnApDungKM.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnApDungKM.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnApDungKM.ForeColor = System.Drawing.Color.White;
            this.btnApDungKM.Location = new System.Drawing.Point(235, 619);
            this.btnApDungKM.Name = "btnApDungKM";
            this.btnApDungKM.Size = new System.Drawing.Size(187, 59);
            this.btnApDungKM.TabIndex = 27;
            this.btnApDungKM.Text = "Áp dụng khuyến mãi";
            this.btnApDungKM.Click += new System.EventHandler(this.btnApDungKM_Click);
            // 
            // dtg
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg.ColumnHeadersHeight = 40;
            this.dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKM,
            this.TenKM,
            this.PhanTramGiam});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtg.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtg.Location = new System.Drawing.Point(12, 162);
            this.dtg.Name = "dtg";
            this.dtg.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtg.RowHeadersVisible = false;
            this.dtg.RowTemplate.Height = 40;
            this.dtg.RowTemplate.ReadOnly = true;
            this.dtg.Size = new System.Drawing.Size(612, 442);
            this.dtg.TabIndex = 26;
            this.dtg.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtg.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtg.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtg.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtg.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtg.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtg.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtg.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtg.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtg.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtg.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtg.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtg.ThemeStyle.HeaderStyle.Height = 40;
            this.dtg.ThemeStyle.ReadOnly = true;
            this.dtg.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtg.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtg.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtg.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtg.ThemeStyle.RowsStyle.Height = 40;
            this.dtg.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtg.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtg.SelectionChanged += new System.EventHandler(this.dtg_SelectionChanged);
            // 
            // MaKM
            // 
            this.MaKM.HeaderText = "Mã khuyến mãi";
            this.MaKM.Name = "MaKM";
            this.MaKM.ReadOnly = true;
            // 
            // TenKM
            // 
            this.TenKM.HeaderText = "Tên khuyến mãi";
            this.TenKM.Name = "TenKM";
            this.TenKM.ReadOnly = true;
            // 
            // PhanTramGiam
            // 
            this.PhanTramGiam.HeaderText = "Mức giảm";
            this.PhanTramGiam.Name = "PhanTramGiam";
            this.PhanTramGiam.ReadOnly = true;
            // 
            // btbLamMoi
            // 
            this.btbLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btbLamMoi.AutoRoundedCorners = true;
            this.btbLamMoi.BorderRadius = 28;
            this.btbLamMoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btbLamMoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btbLamMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btbLamMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btbLamMoi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btbLamMoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btbLamMoi.ForeColor = System.Drawing.Color.White;
            this.btbLamMoi.ImageSize = new System.Drawing.Size(40, 40);
            this.btbLamMoi.Location = new System.Drawing.Point(12, 619);
            this.btbLamMoi.Name = "btbLamMoi";
            this.btbLamMoi.Size = new System.Drawing.Size(119, 59);
            this.btbLamMoi.TabIndex = 25;
            this.btbLamMoi.Text = "Làm mới";
            this.btbLamMoi.Click += new System.EventHandler(this.btbLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.AutoRoundedCorners = true;
            this.btnXoa.BorderRadius = 29;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Image = global::GUI.Properties.Resources.icons8_trash_50;
            this.btnXoa.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnXoa.ImageSize = new System.Drawing.Size(40, 40);
            this.btnXoa.Location = new System.Drawing.Point(509, 618);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(98, 60);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.BorderColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimKiem.FillColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTimKiem.ForeColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.Image = global::GUI.Properties.Resources.icons8_search_50;
            this.btnTimKiem.ImageSize = new System.Drawing.Size(40, 40);
            this.btnTimKiem.Location = new System.Drawing.Point(567, 93);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.PressedColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnTimKiem.Size = new System.Drawing.Size(40, 40);
            this.btnTimKiem.TabIndex = 15;
            this.btnTimKiem.UseTransparentBackground = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThem
            // 
            this.btnThem.AutoRoundedCorners = true;
            this.btnThem.BorderRadius = 29;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Image = global::GUI.Properties.Resources.icons8_add_50;
            this.btnThem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThem.ImageSize = new System.Drawing.Size(40, 40);
            this.btnThem.Location = new System.Drawing.Point(12, 83);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(184, 60);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Tạo khuyến mãi";
            this.btnThem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.AutoRoundedCorners = true;
            this.txtTimKiem.BorderRadius = 29;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.IconRight = global::GUI.Properties.Resources.icons8_search_50;
            this.txtTimKiem.IconRightOffset = new System.Drawing.Point(12, 0);
            this.txtTimKiem.IconRightSize = new System.Drawing.Size(40, 40);
            this.txtTimKiem.Location = new System.Drawing.Point(203, 83);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderText = "Mã, tên khuyến mãi";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(421, 60);
            this.txtTimKiem.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(634, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ KHUYẾN MÃI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnLeft
            // 
            this.pnLeft.Controls.Add(this.dtpNgayKetThuc);
            this.pnLeft.Controls.Add(this.dtpNgayBatDau);
            this.pnLeft.Controls.Add(this.label7);
            this.pnLeft.Controls.Add(this.btnDatLai);
            this.pnLeft.Controls.Add(this.btnLuu);
            this.pnLeft.Controls.Add(this.label6);
            this.pnLeft.Controls.Add(this.label8);
            this.pnLeft.Controls.Add(this.label5);
            this.pnLeft.Controls.Add(this.label4);
            this.pnLeft.Controls.Add(this.label3);
            this.pnLeft.Controls.Add(this.txtMoTa);
            this.pnLeft.Controls.Add(this.txtPhanTramgGiam);
            this.pnLeft.Controls.Add(this.txtTenKM);
            this.pnLeft.Controls.Add(this.txtMaKM);
            this.pnLeft.Controls.Add(this.label2);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnLeft.Location = new System.Drawing.Point(634, 0);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(400, 690);
            this.pnLeft.TabIndex = 2;
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.AutoRoundedCorners = true;
            this.dtpNgayKetThuc.BorderRadius = 17;
            this.dtpNgayKetThuc.Checked = true;
            this.dtpNgayKetThuc.FillColor = System.Drawing.Color.White;
            this.dtpNgayKetThuc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(130, 568);
            this.dtpNgayKetThuc.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayKetThuc.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(217, 36);
            this.dtpNgayKetThuc.TabIndex = 24;
            this.dtpNgayKetThuc.Value = new System.DateTime(2024, 5, 4, 23, 36, 48, 597);
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.AutoRoundedCorners = true;
            this.dtpNgayBatDau.BorderRadius = 17;
            this.dtpNgayBatDau.Checked = true;
            this.dtpNgayBatDau.FillColor = System.Drawing.Color.White;
            this.dtpNgayBatDau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(130, 499);
            this.dtpNgayBatDau.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayBatDau.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(217, 36);
            this.dtpNgayBatDau.TabIndex = 23;
            this.dtpNgayBatDau.Value = new System.DateTime(2024, 5, 4, 23, 36, 48, 597);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(8, 579);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Đến ngày";
            // 
            // btnDatLai
            // 
            this.btnDatLai.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDatLai.AutoRoundedCorners = true;
            this.btnDatLai.BorderRadius = 28;
            this.btnDatLai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDatLai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDatLai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDatLai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDatLai.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnDatLai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDatLai.ForeColor = System.Drawing.Color.White;
            this.btnDatLai.Image = global::GUI.Properties.Resources.icons8_restore_50;
            this.btnDatLai.ImageSize = new System.Drawing.Size(40, 40);
            this.btnDatLai.Location = new System.Drawing.Point(216, 619);
            this.btnDatLai.Name = "btnDatLai";
            this.btnDatLai.Size = new System.Drawing.Size(119, 59);
            this.btnDatLai.TabIndex = 21;
            this.btnDatLai.Text = "Đặt lại";
            this.btnDatLai.Click += new System.EventHandler(this.btnDatLai_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLuu.AutoRoundedCorners = true;
            this.btnLuu.BorderRadius = 28;
            this.btnLuu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Image = global::GUI.Properties.Resources.icons8_save_50;
            this.btnLuu.ImageSize = new System.Drawing.Size(40, 40);
            this.btnLuu.Location = new System.Drawing.Point(57, 619);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(119, 59);
            this.btnLuu.TabIndex = 20;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(8, 509);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Từ ngày";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(8, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Mô tả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(8, 441);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mức giảm (%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(8, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tên khuyến mãi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(8, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mã khuyến mãi";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMoTa.BorderRadius = 20;
            this.txtMoTa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoTa.DefaultText = "";
            this.txtMoTa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMoTa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMoTa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoTa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoTa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoTa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMoTa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoTa.Location = new System.Drawing.Point(130, 241);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.PasswordChar = '\0';
            this.txtMoTa.PlaceholderText = "";
            this.txtMoTa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMoTa.SelectedText = "";
            this.txtMoTa.Size = new System.Drawing.Size(257, 167);
            this.txtMoTa.TabIndex = 2;
            // 
            // txtPhanTramgGiam
            // 
            this.txtPhanTramgGiam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhanTramgGiam.AutoRoundedCorners = true;
            this.txtPhanTramgGiam.BorderRadius = 17;
            this.txtPhanTramgGiam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhanTramgGiam.DefaultText = "";
            this.txtPhanTramgGiam.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhanTramgGiam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhanTramgGiam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhanTramgGiam.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhanTramgGiam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhanTramgGiam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPhanTramgGiam.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhanTramgGiam.Location = new System.Drawing.Point(130, 432);
            this.txtPhanTramgGiam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPhanTramgGiam.Name = "txtPhanTramgGiam";
            this.txtPhanTramgGiam.PasswordChar = '\0';
            this.txtPhanTramgGiam.PlaceholderText = "";
            this.txtPhanTramgGiam.SelectedText = "";
            this.txtPhanTramgGiam.Size = new System.Drawing.Size(257, 36);
            this.txtPhanTramgGiam.TabIndex = 2;
            // 
            // txtTenKM
            // 
            this.txtTenKM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenKM.AutoRoundedCorners = true;
            this.txtTenKM.BorderRadius = 17;
            this.txtTenKM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenKM.DefaultText = "";
            this.txtTenKM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenKM.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenKM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKM.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenKM.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKM.Location = new System.Drawing.Point(130, 174);
            this.txtTenKM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenKM.Name = "txtTenKM";
            this.txtTenKM.PasswordChar = '\0';
            this.txtTenKM.PlaceholderText = "";
            this.txtTenKM.SelectedText = "";
            this.txtTenKM.Size = new System.Drawing.Size(257, 36);
            this.txtTenKM.TabIndex = 2;
            // 
            // txtMaKM
            // 
            this.txtMaKM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaKM.AutoRoundedCorners = true;
            this.txtMaKM.BorderRadius = 17;
            this.txtMaKM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaKM.DefaultText = "";
            this.txtMaKM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaKM.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaKM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaKM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaKM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaKM.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaKM.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaKM.Location = new System.Drawing.Point(130, 107);
            this.txtMaKM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaKM.Name = "txtMaKM";
            this.txtMaKM.PasswordChar = '\0';
            this.txtMaKM.PlaceholderText = "";
            this.txtMaKM.SelectedText = "";
            this.txtMaKM.Size = new System.Drawing.Size(257, 36);
            this.txtMaKM.TabIndex = 2;
            // 
            // F_KhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 690);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_KhuyenMai";
            this.Text = "F_KhuyenMai";
            this.Load += new System.EventHandler(this.F_KhuyenMai_Load);
            this.SizeChanged += new System.EventHandler(this.F_KhuyenMai_SizeChanged);
            this.pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).EndInit();
            this.pnLeft.ResumeLayout(false);
            this.pnLeft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnDatLai;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel pnMain;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2CircleButton btnTimKiem;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel pnLeft;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtMaKM;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtTenKM;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayKetThuc;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtPhanTramgGiam;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtMoTa;
        private Guna.UI2.WinForms.Guna2DataGridView dtg;
        private Guna.UI2.WinForms.Guna2Button btbLamMoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhanTramGiam;
        private Guna.UI2.WinForms.Guna2Button btnApDungKM;
        private Guna.UI2.WinForms.Guna2Panel pnApDungKM;
    }
}
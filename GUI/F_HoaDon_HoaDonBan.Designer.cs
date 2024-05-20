namespace GUI
{
    partial class F_HoaDon_HoaDonBan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnTaoHoaDon = new Guna.UI2.WinForms.Guna2Button();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2CircleButton();
            this.txttimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.dtg = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnHDChuaTT = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnHDDaTT = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnTaoHoaDon);
            this.guna2Panel1.Controls.Add(this.btnTimKiem);
            this.guna2Panel1.Controls.Add(this.txttimKiem);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(602, 76);
            this.guna2Panel1.TabIndex = 6;
            // 
            // btnTaoHoaDon
            // 
            this.btnTaoHoaDon.BorderRadius = 30;
            this.btnTaoHoaDon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTaoHoaDon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTaoHoaDon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTaoHoaDon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTaoHoaDon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnTaoHoaDon.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnTaoHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnTaoHoaDon.Image = global::GUI.Properties.Resources.icons8_add_50;
            this.btnTaoHoaDon.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTaoHoaDon.ImageSize = new System.Drawing.Size(45, 45);
            this.btnTaoHoaDon.Location = new System.Drawing.Point(3, 3);
            this.btnTaoHoaDon.Name = "btnTaoHoaDon";
            this.btnTaoHoaDon.Size = new System.Drawing.Size(170, 64);
            this.btnTaoHoaDon.TabIndex = 0;
            this.btnTaoHoaDon.Text = "Hóa đơn mới";
            this.btnTaoHoaDon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnTaoHoaDon.Click += new System.EventHandler(this.btnTaoHoaDon_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.BackColor = System.Drawing.Color.White;
            this.btnTimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimKiem.FillColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTimKiem.ForeColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.Image = global::GUI.Properties.Resources.icons8_search_50;
            this.btnTimKiem.ImageSize = new System.Drawing.Size(40, 40);
            this.btnTimKiem.Location = new System.Drawing.Point(535, 16);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnTimKiem.Size = new System.Drawing.Size(40, 40);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txttimKiem
            // 
            this.txttimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txttimKiem.BorderRadius = 30;
            this.txttimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttimKiem.DefaultText = "";
            this.txttimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txttimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txttimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttimKiem.IconRight = global::GUI.Properties.Resources.icons8_search_50;
            this.txttimKiem.IconRightOffset = new System.Drawing.Point(12, 1);
            this.txttimKiem.IconRightSize = new System.Drawing.Size(40, 40);
            this.txttimKiem.Location = new System.Drawing.Point(180, 2);
            this.txttimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttimKiem.MaxLength = 100;
            this.txttimKiem.Name = "txttimKiem";
            this.txttimKiem.PasswordChar = '\0';
            this.txttimKiem.PlaceholderText = "Tìm theo mã hóa đơn, tên và SDT khách hàng";
            this.txttimKiem.SelectedText = "";
            this.txttimKiem.Size = new System.Drawing.Size(411, 65);
            this.txttimKiem.TabIndex = 2;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.AutoRoundedCorners = true;
            this.btnXoa.BorderRadius = 28;
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
            this.btnXoa.Location = new System.Drawing.Point(496, 598);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(104, 58);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dtg
            // 
            this.dtg.AllowUserToAddRows = false;
            this.dtg.AllowUserToDeleteRows = false;
            this.dtg.AllowUserToOrderColumns = true;
            this.dtg.AllowUserToResizeColumns = false;
            this.dtg.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dtg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dtg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtg.ColumnHeadersHeight = 40;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtg.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtg.Location = new System.Drawing.Point(26, 142);
            this.dtg.Name = "dtg";
            this.dtg.ReadOnly = true;
            this.dtg.RowHeadersVisible = false;
            this.dtg.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtg.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dtg.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtg.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dtg.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.dtg.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtg.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg.RowTemplate.Height = 40;
            this.dtg.RowTemplate.ReadOnly = true;
            this.dtg.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg.Size = new System.Drawing.Size(574, 439);
            this.dtg.TabIndex = 9;
            this.dtg.TabStop = false;
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
            this.dtg.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtg.ThemeStyle.HeaderStyle.Height = 40;
            this.dtg.ThemeStyle.ReadOnly = true;
            this.dtg.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtg.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtg.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtg.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtg.ThemeStyle.RowsStyle.Height = 40;
            this.dtg.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtg.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_CellClick);
            // 
            // btnHDChuaTT
            // 
            this.btnHDChuaTT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHDChuaTT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHDChuaTT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHDChuaTT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHDChuaTT.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHDChuaTT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHDChuaTT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnHDChuaTT.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnHDChuaTT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHDChuaTT.ForeColor = System.Drawing.Color.White;
            this.btnHDChuaTT.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnHDChuaTT.Location = new System.Drawing.Point(79, 99);
            this.btnHDChuaTT.Name = "btnHDChuaTT";
            this.btnHDChuaTT.Size = new System.Drawing.Size(215, 45);
            this.btnHDChuaTT.TabIndex = 7;
            this.btnHDChuaTT.Text = "Hóa đơn chưa thanh toán";
            this.btnHDChuaTT.Click += new System.EventHandler(this.btnHDChuaTT_Click);
            // 
            // btnHDDaTT
            // 
            this.btnHDDaTT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHDDaTT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHDDaTT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHDDaTT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHDDaTT.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHDDaTT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHDDaTT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnHDDaTT.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnHDDaTT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHDDaTT.ForeColor = System.Drawing.Color.White;
            this.btnHDDaTT.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnHDDaTT.Location = new System.Drawing.Point(340, 99);
            this.btnHDDaTT.Name = "btnHDDaTT";
            this.btnHDDaTT.Size = new System.Drawing.Size(215, 45);
            this.btnHDDaTT.TabIndex = 8;
            this.btnHDDaTT.Text = "Hóa đơn đã thanh toán";
            this.btnHDDaTT.Click += new System.EventHandler(this.btnHDDaTT_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BorderRadius = 30;
            this.btnLamMoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLamMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLamMoi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLamMoi.ImageSize = new System.Drawing.Size(45, 45);
            this.btnLamMoi.Location = new System.Drawing.Point(26, 598);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(96, 58);
            this.btnLamMoi.TabIndex = 10;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // F_HoaDon_HoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 668);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.dtg);
            this.Controls.Add(this.btnHDDaTT);
            this.Controls.Add(this.btnHDChuaTT);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_HoaDon_HoaDonBan";
            this.Text = "vcxz";
            this.Load += new System.EventHandler(this.F_HoaDon_QLHoaDon_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnTaoHoaDon;
        private Guna.UI2.WinForms.Guna2CircleButton btnTimKiem;
        private Guna.UI2.WinForms.Guna2TextBox txttimKiem;
        private Guna.UI2.WinForms.Guna2DataGridView dtg;
        private Guna.UI2.WinForms.Guna2GradientButton btnHDDaTT;
        private Guna.UI2.WinForms.Guna2GradientButton btnHDChuaTT;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
    }
}
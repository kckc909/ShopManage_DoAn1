namespace GUI
{
    partial class F_HoaDon
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
            this.pnChiTietThongTin = new Guna.UI2.WinForms.Guna2Panel();
            this.lbTTHD = new System.Windows.Forms.Label();
            this.pnNoiDung = new Guna.UI2.WinForms.Guna2Panel();
            this.TabControl = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpHoaDonBan = new System.Windows.Forms.TabPage();
            this.tpMatHang = new System.Windows.Forms.TabPage();
            this.tpKhachHang = new System.Windows.Forms.TabPage();
            this.lbQLHD = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.tpHoaDonNhap = new System.Windows.Forms.TabPage();
            this.pnChiTietThongTin.SuspendLayout();
            this.pnNoiDung.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnChiTietThongTin
            // 
            this.pnChiTietThongTin.Controls.Add(this.lbTTHD);
            this.pnChiTietThongTin.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnChiTietThongTin.Location = new System.Drawing.Point(634, 0);
            this.pnChiTietThongTin.Name = "pnChiTietThongTin";
            this.pnChiTietThongTin.Size = new System.Drawing.Size(400, 761);
            this.pnChiTietThongTin.TabIndex = 2;
            // 
            // lbTTHD
            // 
            this.lbTTHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTTHD.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTTHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTTHD.Location = new System.Drawing.Point(0, 0);
            this.lbTTHD.Name = "lbTTHD";
            this.lbTTHD.Size = new System.Drawing.Size(400, 80);
            this.lbTTHD.TabIndex = 2;
            this.lbTTHD.Text = "THÔNG TIN HÓA ĐƠN";
            this.lbTTHD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnNoiDung
            // 
            this.pnNoiDung.Controls.Add(this.TabControl);
            this.pnNoiDung.Controls.Add(this.lbQLHD);
            this.pnNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnNoiDung.Location = new System.Drawing.Point(0, 0);
            this.pnNoiDung.Name = "pnNoiDung";
            this.pnNoiDung.Size = new System.Drawing.Size(634, 761);
            this.pnNoiDung.TabIndex = 3;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tpHoaDonBan);
            this.TabControl.Controls.Add(this.tpHoaDonNhap);
            this.TabControl.Controls.Add(this.tpMatHang);
            this.TabControl.Controls.Add(this.tpKhachHang);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.ItemSize = new System.Drawing.Size(150, 40);
            this.TabControl.Location = new System.Drawing.Point(0, 80);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(634, 681);
            this.TabControl.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.TabControl.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.TabControl.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.TabControl.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.TabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.TabControl.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TabControl.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.TabControl.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.TabControl.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.TabControl.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.TabControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.TabControl.TabButtonSize = new System.Drawing.Size(150, 40);
            this.TabControl.TabIndex = 3;
            this.TabControl.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TabControl.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tpHoaDonBan
            // 
            this.tpHoaDonBan.Location = new System.Drawing.Point(4, 44);
            this.tpHoaDonBan.Name = "tpHoaDonBan";
            this.tpHoaDonBan.Padding = new System.Windows.Forms.Padding(3);
            this.tpHoaDonBan.Size = new System.Drawing.Size(626, 633);
            this.tpHoaDonBan.TabIndex = 0;
            this.tpHoaDonBan.Text = "Hóa đơn bán";
            this.tpHoaDonBan.UseVisualStyleBackColor = true;
            // 
            // tpMatHang
            // 
            this.tpMatHang.Location = new System.Drawing.Point(4, 44);
            this.tpMatHang.Name = "tpMatHang";
            this.tpMatHang.Padding = new System.Windows.Forms.Padding(3);
            this.tpMatHang.Size = new System.Drawing.Size(626, 633);
            this.tpMatHang.TabIndex = 1;
            this.tpMatHang.Text = "Mặt hàng";
            this.tpMatHang.UseVisualStyleBackColor = true;
            // 
            // tpKhachHang
            // 
            this.tpKhachHang.AutoScroll = true;
            this.tpKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpKhachHang.Location = new System.Drawing.Point(4, 44);
            this.tpKhachHang.Name = "tpKhachHang";
            this.tpKhachHang.Size = new System.Drawing.Size(626, 633);
            this.tpKhachHang.TabIndex = 2;
            this.tpKhachHang.Text = "Khách hàng";
            this.tpKhachHang.UseVisualStyleBackColor = true;
            // 
            // lbQLHD
            // 
            this.lbQLHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbQLHD.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbQLHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbQLHD.Location = new System.Drawing.Point(0, 0);
            this.lbQLHD.Name = "lbQLHD";
            this.lbQLHD.Size = new System.Drawing.Size(634, 80);
            this.lbQLHD.TabIndex = 2;
            this.lbQLHD.Text = "QUẢN LÝ HÓA ĐƠN";
            this.lbQLHD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // tpHoaDonNhap
            // 
            this.tpHoaDonNhap.Location = new System.Drawing.Point(4, 44);
            this.tpHoaDonNhap.Name = "tpHoaDonNhap";
            this.tpHoaDonNhap.Size = new System.Drawing.Size(626, 633);
            this.tpHoaDonNhap.TabIndex = 3;
            this.tpHoaDonNhap.Text = "Hóa đơn nhập";
            this.tpHoaDonNhap.UseVisualStyleBackColor = true;
            // 
            // F_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 761);
            this.Controls.Add(this.pnNoiDung);
            this.Controls.Add(this.pnChiTietThongTin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_HoaDon";
            this.Text = "F_HoaDon";
            this.SizeChanged += new System.EventHandler(this.F_HoaDon_SizeChanged);
            this.pnChiTietThongTin.ResumeLayout(false);
            this.pnNoiDung.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnChiTietThongTin;
        private System.Windows.Forms.Label lbTTHD;
        private Guna.UI2.WinForms.Guna2Panel pnNoiDung;
        private System.Windows.Forms.Label lbQLHD;
        private Guna.UI2.WinForms.Guna2TabControl TabControl;
        private System.Windows.Forms.TabPage tpHoaDonBan;
        private System.Windows.Forms.TabPage tpMatHang;
        private System.Windows.Forms.TabPage tpKhachHang;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.TabPage tpHoaDonNhap;
    }
}
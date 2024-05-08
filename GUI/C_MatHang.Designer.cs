namespace GUI
{
    partial class C_MatHang
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panel = new Guna.UI2.WinForms.Guna2Panel();
            this.lbKhuyenMai = new System.Windows.Forms.Label();
            this.lbGiaMatHang = new System.Windows.Forms.Label();
            this.lbTenMatHang = new System.Windows.Forms.Label();
            this.picHinhAnh = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // panel
            // 
            this.panel.BorderColor = System.Drawing.Color.Black;
            this.panel.BorderRadius = 20;
            this.panel.BorderThickness = 2;
            this.panel.Controls.Add(this.lbKhuyenMai);
            this.panel.Controls.Add(this.lbGiaMatHang);
            this.panel.Controls.Add(this.lbTenMatHang);
            this.panel.Controls.Add(this.picHinhAnh);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(180, 180);
            this.panel.TabIndex = 3;
            this.panel.Click += new System.EventHandler(this.lbTenMatHang_Click);
            this.panel.MouseEnter += new System.EventHandler(this.AllControl_MouseEnter);
            this.panel.MouseLeave += new System.EventHandler(this.AllControl_MouseLeave);
            // 
            // lbKhuyenMai
            // 
            this.lbKhuyenMai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbKhuyenMai.AutoSize = true;
            this.lbKhuyenMai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbKhuyenMai.Location = new System.Drawing.Point(84, 108);
            this.lbKhuyenMai.Name = "lbKhuyenMai";
            this.lbKhuyenMai.Size = new System.Drawing.Size(87, 20);
            this.lbKhuyenMai.TabIndex = 6;
            this.lbKhuyenMai.Text = "KhuyenMai";
            this.lbKhuyenMai.Click += new System.EventHandler(this.lbTenMatHang_Click);
            this.lbKhuyenMai.MouseEnter += new System.EventHandler(this.AllControl_MouseEnter);
            this.lbKhuyenMai.MouseLeave += new System.EventHandler(this.AllControl_MouseLeave);
            // 
            // lbGiaMatHang
            // 
            this.lbGiaMatHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbGiaMatHang.AutoSize = true;
            this.lbGiaMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbGiaMatHang.Location = new System.Drawing.Point(9, 150);
            this.lbGiaMatHang.Name = "lbGiaMatHang";
            this.lbGiaMatHang.Size = new System.Drawing.Size(100, 20);
            this.lbGiaMatHang.TabIndex = 4;
            this.lbGiaMatHang.Text = "GiaMatHang";
            this.lbGiaMatHang.Click += new System.EventHandler(this.lbTenMatHang_Click);
            this.lbGiaMatHang.MouseEnter += new System.EventHandler(this.AllControl_MouseEnter);
            this.lbGiaMatHang.MouseLeave += new System.EventHandler(this.AllControl_MouseLeave);
            // 
            // lbTenMatHang
            // 
            this.lbTenMatHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTenMatHang.AutoSize = true;
            this.lbTenMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTenMatHang.Location = new System.Drawing.Point(9, 127);
            this.lbTenMatHang.Name = "lbTenMatHang";
            this.lbTenMatHang.Size = new System.Drawing.Size(102, 20);
            this.lbTenMatHang.TabIndex = 5;
            this.lbTenMatHang.Text = "TenMatHang";
            this.lbTenMatHang.Click += new System.EventHandler(this.lbTenMatHang_Click);
            this.lbTenMatHang.MouseEnter += new System.EventHandler(this.AllControl_MouseEnter);
            this.lbTenMatHang.MouseLeave += new System.EventHandler(this.AllControl_MouseLeave);
            // 
            // picHinhAnh
            // 
            this.picHinhAnh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picHinhAnh.AutoRoundedCorners = true;
            this.picHinhAnh.BackgroundImage = global::GUI.Properties.Resources.icons8_image_50;
            this.picHinhAnh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picHinhAnh.BorderRadius = 57;
            this.picHinhAnh.ErrorImage = null;
            this.picHinhAnh.FillColor = System.Drawing.Color.Transparent;
            this.picHinhAnh.ImageRotate = 0F;
            this.picHinhAnh.Location = new System.Drawing.Point(9, 11);
            this.picHinhAnh.Name = "picHinhAnh";
            this.picHinhAnh.Size = new System.Drawing.Size(162, 117);
            this.picHinhAnh.TabIndex = 3;
            this.picHinhAnh.TabStop = false;
            this.picHinhAnh.Click += new System.EventHandler(this.lbTenMatHang_Click);
            this.picHinhAnh.MouseEnter += new System.EventHandler(this.AllControl_MouseEnter);
            this.picHinhAnh.MouseLeave += new System.EventHandler(this.AllControl_MouseLeave);
            // 
            // C_MatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 180);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(180, 180);
            this.MinimumSize = new System.Drawing.Size(180, 180);
            this.Name = "C_MatHang";
            this.Text = "C_MatHang";
            this.MouseEnter += new System.EventHandler(this.AllControl_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.AllControl_MouseLeave);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel panel;
        private System.Windows.Forms.Label lbKhuyenMai;
        private System.Windows.Forms.Label lbGiaMatHang;
        private System.Windows.Forms.Label lbTenMatHang;
        private Guna.UI2.WinForms.Guna2PictureBox picHinhAnh;
    }
}
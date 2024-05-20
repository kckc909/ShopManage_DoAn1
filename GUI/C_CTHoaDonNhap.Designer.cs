using System.Windows.Forms;

namespace GUI
{
    partial class C_CTHoaDonNhap : Form
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
            this.txtTenMH = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSolg = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGiaNhap = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtThanhTien = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnGiam = new Guna.UI2.WinForms.Guna2Button();
            this.btnTang = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // txtTenMH
            // 
            this.txtTenMH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenMH.DefaultText = "";
            this.txtTenMH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenMH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenMH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenMH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenMH.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTenMH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenMH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenMH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenMH.Location = new System.Drawing.Point(0, 0);
            this.txtTenMH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenMH.Multiline = true;
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.PasswordChar = '\0';
            this.txtTenMH.PlaceholderText = "";
            this.txtTenMH.SelectedText = "";
            this.txtTenMH.Size = new System.Drawing.Size(400, 60);
            this.txtTenMH.TabIndex = 0;
            // 
            // txtSolg
            // 
            this.txtSolg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSolg.DefaultText = "1000";
            this.txtSolg.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSolg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSolg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSolg.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSolg.FillColor = System.Drawing.SystemColors.Control;
            this.txtSolg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSolg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSolg.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSolg.Location = new System.Drawing.Point(40, 60);
            this.txtSolg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSolg.Name = "txtSolg";
            this.txtSolg.PasswordChar = '\0';
            this.txtSolg.PlaceholderText = "";
            this.txtSolg.SelectedText = "";
            this.txtSolg.Size = new System.Drawing.Size(55, 40);
            this.txtSolg.TabIndex = 1;
            this.txtSolg.TextChanged += new System.EventHandler(this.txtSolg_TextChanged);
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaNhap.DefaultText = "100.000.000";
            this.txtGiaNhap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGiaNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGiaNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaNhap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaNhap.FillColor = System.Drawing.SystemColors.Control;
            this.txtGiaNhap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaNhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGiaNhap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaNhap.Location = new System.Drawing.Point(135, 60);
            this.txtGiaNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.PasswordChar = '\0';
            this.txtGiaNhap.PlaceholderText = "";
            this.txtGiaNhap.ReadOnly = true;
            this.txtGiaNhap.SelectedText = "";
            this.txtGiaNhap.Size = new System.Drawing.Size(130, 40);
            this.txtGiaNhap.TabIndex = 2;
            this.txtGiaNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThanhTien.DefaultText = "100.000.000";
            this.txtThanhTien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtThanhTien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtThanhTien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThanhTien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThanhTien.FillColor = System.Drawing.SystemColors.Control;
            this.txtThanhTien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThanhTien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtThanhTien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThanhTien.Location = new System.Drawing.Point(265, 60);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.PasswordChar = '\0';
            this.txtThanhTien.PlaceholderText = "";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.SelectedText = "";
            this.txtThanhTien.Size = new System.Drawing.Size(135, 40);
            this.txtThanhTien.TabIndex = 3;
            this.txtThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnGiam
            // 
            this.btnGiam.BorderColor = System.Drawing.Color.Gray;
            this.btnGiam.BorderThickness = 1;
            this.btnGiam.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGiam.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGiam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGiam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGiam.FillColor = System.Drawing.Color.DarkGray;
            this.btnGiam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnGiam.ForeColor = System.Drawing.Color.White;
            this.btnGiam.Location = new System.Drawing.Point(95, 80);
            this.btnGiam.Name = "btnGiam";
            this.btnGiam.Size = new System.Drawing.Size(40, 20);
            this.btnGiam.TabIndex = 5;
            this.btnGiam.Text = "v";
            this.btnGiam.Click += new System.EventHandler(this.btnGiam_Click);
            // 
            // btnTang
            // 
            this.btnTang.BorderColor = System.Drawing.Color.Gray;
            this.btnTang.BorderThickness = 1;
            this.btnTang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTang.FillColor = System.Drawing.Color.DarkGray;
            this.btnTang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTang.ForeColor = System.Drawing.Color.White;
            this.btnTang.Location = new System.Drawing.Point(95, 60);
            this.btnTang.Name = "btnTang";
            this.btnTang.Size = new System.Drawing.Size(40, 20);
            this.btnTang.TabIndex = 4;
            this.btnTang.Text = "^";
            this.btnTang.Click += new System.EventHandler(this.btnTang_Click);
            // 
            // C_CTHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 100);
            this.Controls.Add(this.btnGiam);
            this.Controls.Add(this.btnTang);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.txtGiaNhap);
            this.Controls.Add(this.txtSolg);
            this.Controls.Add(this.txtTenMH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "C_CTHoaDonNhap";
            this.Text = "C_MatHangHoaDon";
            this.Load += new System.EventHandler(this.C_CTHoaDon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtTenMH;
        private Guna.UI2.WinForms.Guna2TextBox txtSolg;
        private Guna.UI2.WinForms.Guna2TextBox txtGiaNhap;
        private Guna.UI2.WinForms.Guna2TextBox txtThanhTien;
        private Guna.UI2.WinForms.Guna2Button btnGiam;
        private Guna.UI2.WinForms.Guna2Button btnTang;
    }
}
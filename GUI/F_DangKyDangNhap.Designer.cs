using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    partial class F_DangKyDangNhap
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.lbDangKyDangNhap = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 411);
            this.panel1.TabIndex = 2;
            // 
            // pnContainer
            // 
            this.pnContainer.Location = new System.Drawing.Point(440, 10);
            this.pnContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(211, 366);
            this.pnContainer.TabIndex = 3;
            // 
            // lbDangKyDangNhap
            // 
            this.lbDangKyDangNhap.AutoSize = true;
            this.lbDangKyDangNhap.Location = new System.Drawing.Point(527, 387);
            this.lbDangKyDangNhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDangKyDangNhap.Name = "lbDangKyDangNhap";
            this.lbDangKyDangNhap.Size = new System.Drawing.Size(47, 13);
            this.lbDangKyDangNhap.TabIndex = 4;
            this.lbDangKyDangNhap.Text = "Đăng ký";
            this.lbDangKyDangNhap.Click += new System.EventHandler(this.lbDangKyDangNhap_Click);
            this.lbDangKyDangNhap.MouseEnter += new System.EventHandler(this.lbDangKyDangNhap_MouseEnter);
            this.lbDangKyDangNhap.MouseLeave += new System.EventHandler(this.lbDangKyDangNhap_MouseLeave);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.White;
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PictureBox1.Image = global::GUI.Properties.Resources.MiniShopLogo;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(436, 411);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // F_DangKyDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(660, 411);
            this.Controls.Add(this.lbDangKyDangNhap);
            this.Controls.Add(this.pnContainer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "F_DangKyDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShopManage";
            this.Load += new System.EventHandler(this.F_DangKyDangNhap_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel pnContainer;
        private Label lbDangKyDangNhap;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}


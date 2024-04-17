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
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 506);
            this.panel1.TabIndex = 2;
            // 
            // pnContainer
            // 
            this.pnContainer.Location = new System.Drawing.Point(587, 12);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(281, 450);
            this.pnContainer.TabIndex = 3;
            // 
            // lbDangKyDangNhap
            // 
            this.lbDangKyDangNhap.AutoSize = true;
            this.lbDangKyDangNhap.Location = new System.Drawing.Point(703, 476);
            this.lbDangKyDangNhap.Name = "lbDangKyDangNhap";
            this.lbDangKyDangNhap.Size = new System.Drawing.Size(56, 16);
            this.lbDangKyDangNhap.TabIndex = 4;
            this.lbDangKyDangNhap.Text = "Đăng ký";
            this.lbDangKyDangNhap.Click += new System.EventHandler(this.lbDangKyDangNhap_Click);
            this.lbDangKyDangNhap.MouseEnter += new System.EventHandler(this.lbDangKyDangNhap_MouseEnter);
            this.lbDangKyDangNhap.MouseLeave += new System.EventHandler(this.lbDangKyDangNhap_MouseLeave);
            // 
            // F_DangKyDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(880, 506);
            this.Controls.Add(this.lbDangKyDangNhap);
            this.Controls.Add(this.pnContainer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "F_DangKyDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShopManage";
            this.Load += new System.EventHandler(this.F_DangKyDangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel pnContainer;
        private Label lbDangKyDangNhap;
    }
}


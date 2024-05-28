namespace GUI
{
    partial class F_MainParent_User
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
            this.pic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnDoiMK = new Guna.UI2.WinForms.Guna2Button();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.lbTenNV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.ImageRotate = 0F;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Name = "pic";
            this.pic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pic.Size = new System.Drawing.Size(100, 100);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDoiMK.AutoRoundedCorners = true;
            this.btnDoiMK.BorderRadius = 15;
            this.btnDoiMK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDoiMK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDoiMK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDoiMK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDoiMK.FillColor = System.Drawing.Color.LightGray;
            this.btnDoiMK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDoiMK.ForeColor = System.Drawing.Color.DimGray;
            this.btnDoiMK.Location = new System.Drawing.Point(30, 114);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(226, 33);
            this.btnDoiMK.TabIndex = 4;
            this.btnDoiMK.Text = "Đổi mật khẩu";
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // lbMaNV
            // 
            this.lbMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaNV.Location = new System.Drawing.Point(106, 0);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(160, 50);
            this.lbMaNV.TabIndex = 5;
            this.lbMaNV.Text = "label1";
            this.lbMaNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTenNV
            // 
            this.lbTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTenNV.Location = new System.Drawing.Point(106, 50);
            this.lbTenNV.Name = "lbTenNV";
            this.lbTenNV.Size = new System.Drawing.Size(160, 50);
            this.lbTenNV.TabIndex = 5;
            this.lbTenNV.Text = "label1";
            this.lbTenNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // F_MainParent_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(278, 158);
            this.Controls.Add(this.lbTenNV);
            this.Controls.Add(this.lbMaNV);
            this.Controls.Add(this.btnDoiMK);
            this.Controls.Add(this.pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_MainParent_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "F_MainParent_User";
            this.Deactivate += new System.EventHandler(this.F_MainParent_User_Deactivate);
            this.Load += new System.EventHandler(this.F_MainParent_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox pic;
        private Guna.UI2.WinForms.Guna2Button btnDoiMK;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.Label lbTenNV;
    }
}
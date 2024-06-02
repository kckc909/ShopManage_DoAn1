using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class F_MainParent_User : Form
    {
        BUS_NhanVien BUS_NhanVien = new BUS_NhanVien();
        private bool isUsing = false;
        tblNhanVien User;
        public F_MainParent_User(tblNhanVien user)
        {
            InitializeComponent();
            User = user;
        }

        void Catch_FormDMKClose(object sender, EventArgs e)
        {
            isUsing = false;
            ((Form)sender).Close();
        }

        private void F_MainParent_User_Load(object sender, EventArgs e)
        {
            lbMaNV.Text = User.MaNV;
            lbTenNV.Text = User.TenNV;
            if (File.Exists(BUS_NhanVien.DuongDanHinhAnh(User.Avatar)))
            {
                pic.Image = Image.FromFile(BUS_NhanVien.DuongDanHinhAnh(User.Avatar));
            }
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            isUsing = true;
            F_NhanVien_TaiKhoan F = new F_NhanVien_TaiKhoan(User);
            F.FormClosed += Catch_FormDMKClose;
            F.ShowDialog();
        }

        private void F_MainParent_User_Deactivate(object sender, EventArgs e)
        {
            if (!isUsing)
            {
                Close();
            }
        }
    }
}

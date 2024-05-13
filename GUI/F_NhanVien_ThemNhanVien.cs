using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class F_NhanVien_ThemNhanVien : Form
    {
        public event EventHandler ThemThanhCong;
        BUS_Quyen BUS_Quyen = new BUS_Quyen();
        BUS_NhanVien BUS_NhanVien = new BUS_NhanVien();
        OpenFileDialog ofd = new OpenFileDialog();

        public F_NhanVien_ThemNhanVien()
        {
            InitializeComponent();
        }

        private void btnChonHinhAnh_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pic.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            tblNhanVien NhanVien = new tblNhanVien();
            NhanVien.MaNV = BUS_NhanVien.MaTuDong();
            if (Equals(txtTenNV.Text, ""))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên!");
                txtTenNV.Focus();
                return;
            }
            else
            {
                NhanVien.TenNV = txtTenNV.Text;
            }
            if (rbtnNam.Checked)
            {
                NhanVien.GioiTinh = 1;
            }
            else if (rbtnNu.Checked)
            {
                NhanVien.GioiTinh = 0;
            }
            else
            {
                MessageBox.Show("Hãy chọn giới tính nhân viên!");
                return;
            }
            if ((Equals(txtSDT.Text, "")))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại nhân viên!");
                txtSDT.Focus();
                return;
            }
            else
            {
                NhanVien.SDT = txtSDT.Text;
            }
            if (Equals(txtEmail.Text, ""))
            {
                MessageBox.Show("Vui lòng nhập email nhân viên!");
                txtEmail.Focus();
                return;
            }
            else
            {
                NhanVien.Email = txtEmail.Text;
            }
            if (cboCapQuyen.SelectedIndex > -1)
            {
                NhanVien.CapQuyen = Convert.ToInt32(cboCapQuyen.SelectedValue);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn quyền nhân viên!");
            }
            NhanVien.DiaChi = txtDiaChi.Text;
            NhanVien.Avatar = BUS_NhanVien.TaoTenHinhAnh(Path.GetExtension(ofd.FileName));
            BUS_NhanVien.CopyHinhAnh(ofd.FileName, NhanVien.Avatar);
            BUS_NhanVien.Them(NhanVien);

            ThemThanhCong.Invoke(this, new EventArgs());
        }

        private void F_NhanVien_ThemNhanVien_Load(object sender, EventArgs e)
        {
            
            cboCapQuyen.DataSource = BUS_Quyen.DanhSachQuyen();
            cboCapQuyen.ValueMember = "CapQuyen";
            cboCapQuyen.DisplayMember = "Ten";
            cboCapQuyen.SelectedValue = 1;
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class F_NhanVien : Form
    {
        BUS_NhanVien BUS_NhanVien = new BUS_NhanVien();
        tblNhanVien Current = null;
        OpenFileDialog OpenFileDialog = new OpenFileDialog();
        bool ImageChange = false;

        public F_NhanVien()
        {
            InitializeComponent();
        }

        private void F_NhanVien_Load(object sender, EventArgs e)
        {
            dtg.AutoGenerateColumns = false;
            Add_Col_DSNV();
            Load_Row_DSNV(BUS_NhanVien.GetAll());
            cboCapQuyen.DataSource = BUS_NhanVien.GetAll_Quyen();
            cboCapQuyen.ValueMember = "CapQuyen";
            cboCapQuyen.DisplayMember = "Ten";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            F_NhanVien_ThemNhanVien f_NhanVien_ThemNhanVien = new F_NhanVien_ThemNhanVien();
            f_NhanVien_ThemNhanVien.ThemThanhCong += Catch_ThemThanhCong;
            f_NhanVien_ThemNhanVien.Show();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Load_Row_DSNV(BUS_NhanVien.GetAll(txtTimKiem.Text));
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (Current != null)
            {
                if (!Equals(F_MainParent.NguoiDung.MaNV, Current.MaNV))
                {
                    if (MessageBox.Show("Bạn có muốn xóa nhân viên này không!", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        BUS_NhanVien.Delete(Current);
                        Load_Row_DSNV(BUS_NhanVien.GetAll());
                    }
                }
                else
                {
                    MessageBox.Show("Bạn không thể xóa chính mình!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên muốn xóa!");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Current != null)
            {
                tblNhanVien nv = Current;
                nv.TenNV = txtTenNV.Text;
                nv.SDT = txtSDT.Text;
                nv.Email = txtEmail.Text;
                nv.CapQuyen = Convert.ToInt16(cboCapQuyen.SelectedValue);
                nv.DiaChi = txtDiaChi.Text;
                if (rbtnNam.Checked)
                {
                    nv.GioiTinh = 1;
                }
                else if (rbtnNu.Checked)
                {
                    nv.GioiTinh = 0;
                }
                if (DateTime.Now.Year - dtpNgaySinh.Value.Year < 16)
                {
                    MessageBox.Show("Không nhận người dưới 16 tuổi!");
                    return;
                }
                else
                {
                    nv.NgaySinh = dtpNgaySinh.Value;
                }
                if (ImageChange)
                {
                    string picName = BUS_NhanVien.TaoTenHinhAnh(OpenFileDialog.FileName);
                    BUS_NhanVien.CopyHinhAnh(OpenFileDialog.FileName, picName);
                    nv.Avatar = picName;
                    ImageChange = false;
                }
                BUS_NhanVien.Update(Current, nv);
            }
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            Load_Info_NV();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                ImageChange = true;
                pic.Image = Image.FromFile(OpenFileDialog.FileName);
            }
        }

        private void dtg_SelectionChanged(object sender, EventArgs e)
        {
            if (dtg.SelectedRows.Count > 0)
            {
                DataGridViewCell cell = dtg.SelectedRows[0].Cells[0];
                if (cell.Value != null)
                {
                    Current = BUS_NhanVien.GetById(cell.Value.ToString());
                    Load_Info_NV();
                }
            }
        }

        void Add_Col_DSNV()
        {
            dtg.Columns.Clear();
            dtg.Columns.Add("MaNV", "Mã nhân viên");
            dtg.Columns.Add("TenNV", "Tên nhân viên");
            dtg.Columns.Add("NgaySinh", "Ngày sinh");
            dtg.Columns.Add("SDT", "Số điện thoại");
        }

        void Load_Row_DSNV(List<tblNhanVien> DSNV)
        {
            dtg.DataSource = DSNV;
            dtg.Columns["MaNV"].DataPropertyName = "MaNV";
            dtg.Columns["TenNV"].DataPropertyName = "TenNV";
            dtg.Columns["NgaySinh"].DataPropertyName = "NgaySinh";
            dtg.Columns["SDT"].DataPropertyName = "SDT";
        }

        void Load_Info_NV()
        {
            if (!(Current is null))
            {
                txtMaNV.Text = Current.MaNV;
                if (Current.TenNV != null)
                {
                    txtTenNV.Text = Current.TenNV;
                }
                else
                {
                    txtTenNV.Clear();
                }
                if (Current.SDT != null)
                {
                    txtSDT.Text = Current.SDT;
                }
                else
                {
                    txtSDT.Clear();
                }
                if (Current.Email != null)
                {
                    txtEmail.Text = Current.Email;
                }
                else
                {
                    txtEmail.Clear();
                }
                if (Current.DiaChi != null)
                {
                    txtDiaChi.Text = Current.DiaChi;
                }
                else
                {
                    txtDiaChi.Clear();
                }
                if (Current.CapQuyen != null)
                {
                    cboCapQuyen.SelectedValue = Current.CapQuyen;
                }
                else
                {
                    cboCapQuyen.SelectedIndex = -1;
                }
                try
                {
                    pic.Image = Image.FromFile(BUS_NhanVien.DuongDanHinhAnh(Current.Avatar));
                }
                catch
                {
                    pic.Image = null;
                }
                if (Current.NgaySinh != null)
                {
                    dtpNgaySinh.Value = Current.NgaySinh.Value;
                }
                else
                {
                    dtpNgaySinh.Value = DateTime.Today;
                }
            }
        }

        void LamMoi()
        {
            Current = null;
            ImageChange = false;
            txtTimKiem.Clear();
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
            cboCapQuyen.SelectedIndex = -1;
            pic.Image = null;
            rbtnNu.Checked = false;
            rbtnNam.Checked = false;
            dtpNgaySinh.Value = DateTime.Today;
            Add_Col_DSNV();
            Load_Row_DSNV(BUS_NhanVien.GetAll());
            dtg.Rows[0].Selected = true;
        }
        
        void Catch_NVTK_Close(object sender, EventArgs e)
        {
            ((Form)sender).Close();
        }

        void Catch_ThemThanhCong(object sender, EventArgs e)
        {
            ((Form)sender).Close();
            MessageBox.Show("Thêm nhân viên thành công!");
            Load_Row_DSNV(BUS_NhanVien.GetAll());
        }

        private void F_NhanVien_SizeChanged(object sender, EventArgs e)
        {
            pnLeft.Width = pnLeft.Width == 400 ? 550 : 400;
            if (pnLeft.Width > pnMain.Width)
            {
                pnLeft.Width = 400;
            }    
        }

        private void btnTaiKhoanNhanVien_Click(object sender, EventArgs e)
        {
            F_NhanVien_TaiKhoan f = new F_NhanVien_TaiKhoan(Current);
            f.FormClosed += Catch_NVTK_Close;
            f.ShowDialog();
        }
    }
}

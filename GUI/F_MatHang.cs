using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Management;
using System.Windows.Forms;
using BUS;
using DTO;
using GUI.MyEventArgs;
using Microsoft.SqlServer.Server;

namespace GUI
{
    public partial class F_MatHang : Form
    {
        BUS_MatHang BUS_MatHang = new BUS_MatHang();
        BUS_LoaiHang BUS_LoaiHang = new BUS_LoaiHang();
        BUS_KhuyenMai BUS_KhuyenMai = new BUS_KhuyenMai();

        tblMatHang Current = new tblMatHang();
        OpenFileDialog FileDialog_PickImage = new OpenFileDialog();
        bool ImageChange = false;

        public F_MatHang()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            dateHanSuDung.Value = MyDefault.MaxDate;
        }

        private void F_MatHang_SizeChanged(object sender, EventArgs e)
        {
            pnLeft.Width = 550;
            if (pnLeft.Width > pnMain.Width)
            {
                pnLeft.Width = 400;
            }
        }

        private void F_MatHang_Load(object sender, EventArgs e)
        {
            dtg.AutoGenerateColumns = false;
            dtg_AddColumns();
            dtg_Modify();
            LoadDanhSachMatHang(BUS_MatHang.DanhSachMatHang());
            LoadDanhSachLoaiHang();
            LoadDanhSachKhuyenMai();
        }

        void LoadDanhSachKhuyenMai()
        {
            cbKhuyenMai.DataSource = BUS_KhuyenMai.DanhSach();
            cbKhuyenMai.ValueMember = "MaKM";
            cbKhuyenMai.DisplayMember = "TenKM";
        }

        void LoadDanhSachLoaiHang()
        {
            cbLoaiHang.DataSource = BUS_LoaiHang.DanhSach();
            cbLoaiHang.ValueMember = "MaLoai";
            cbLoaiHang.DisplayMember = "TenLoai";
        }
        
        void dtg_AddColumns()
        {
            dtg.Columns.Clear();
            dtg.Columns.Add("MaMH", "Mã mặt hàng");
            dtg.Columns.Add("TenMH", "Tên mặt hàng");
            dtg.Columns.Add("MoTa", "Mô tả");
            dtg.Columns.Add("SoLg", "Số lượng tồn");      
            dtg.Columns.Add("DonViTinh", "Đơn vị");
            dtg.Columns.Add("GiaBan", "Giá bán");
            dtg.Columns.Add("GiaNhap", "Giá nhập");
            dtg.Columns.Add("MaLoai", "Mã loại");
        }

        void dtg_Modify()
        {
            dtg.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtg.Columns["MaLoai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtg.Columns["DonViTinh"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtg.Columns["SoLg"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg.Columns["GiaBan"].DefaultCellStyle.Format = "C";
            dtg.Columns["GiaNhap"].DefaultCellStyle.Format = "C";
        }

        void LoadDanhSachMatHang(List<tblMatHang> DSMH)
        {
            dtg.DataSource = DSMH;
            dtg.Columns["MaMH"].DataPropertyName = "MaMH";
            dtg.Columns["TenMH"].DataPropertyName = "TenMH";
            dtg.Columns["MoTa"].DataPropertyName = "MoTa";
            dtg.Columns["SoLg"].DataPropertyName = "SoLuong";
            dtg.Columns["DonViTinh"].DataPropertyName = "DonViTinh";
            dtg.Columns["GiaBan"].DataPropertyName = "GiaBan";
            dtg.Columns["GiaNhap"].DataPropertyName = "GiaNhap";
            dtg.Columns["MaLoai"].DataPropertyName = "MaLoai";
        }

        void LoadThongTinMatHang(tblMatHang MatHang)
        {
            Current = MatHang;
            if (Current is null)
            {
                pic.Image = null;
                txtMaMH.Clear();
                txtMoTa.Clear();
                txtTenMH.Clear();
                txtGiaBan.Clear();
                txtGiaNhap.Clear();
                txtDonVi.Clear();
                txtSolg.Clear();
                cbKhuyenMai.SelectedIndex = 0;
                cbLoaiHang.SelectedIndex = 0;
                return;
            }

            txtMaMH.Text = MatHang.MaMH;
            txtTenMH.Text = MatHang.TenMH;
            txtMoTa.Text = MatHang.Mota;
            txtGiaBan.Text = MatHang.GiaBan.ToString();
            txtGiaNhap.Text = MatHang.GiaNhap.ToString();
            txtSolg.Text = MatHang.SoLuong.ToString();
            txtDonVi.Text = MatHang.DonViTinh;
            if (MatHang.HanSuDung is null)
            {
                dateHanSuDung.Value = MyDefault. MaxDate;
            }
            else
            {
                dateHanSuDung.Value = MatHang.HanSuDung.Value;
            }
            if (MatHang.MaLoai != null)
            {
                cbLoaiHang.SelectedValue = MatHang.MaLoai;
            }
            else
            {
                cbLoaiHang.SelectedIndex = 0;
            }
            if (MatHang.MaKM != null)
            {
                cbKhuyenMai.SelectedValue = MatHang.MaKM;
            }
            else
            {
                cbKhuyenMai.SelectedIndex = 0;
            }
            try
            {
                pic.Image = Image.FromFile(BUS_MatHang.LayDuongDanHinhAnh(MatHang.LinkHinhAnh));
            }
            catch
            {
                pic.Image = null;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaMH.Text != "" && txtMaMH.Text != null)
            {
                DialogResult ques = MessageBox.Show("Bạn có muốn xóa mặt hàng này không?", "", MessageBoxButtons.YesNo);
                if (ques == DialogResult.Yes)
                {
                    XoaMatHang(txtMaMH.Text);
                    btnRefresh_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn mặt hàng muốn xóa!", "");
            }
        }

        void XoaMatHang(string MaMH)
        {
            BUS_MatHang.Xoa(MaMH);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cbLoaiHang.Controls.Clear();
            cbKhuyenMai.Controls.Clear();
            Current = null;

            LoadDanhSachMatHang(BUS_MatHang.DanhSachMatHang());
            LoadDanhSachLoaiHang();
            LoadDanhSachKhuyenMai();

            LoadThongTinMatHang(Current);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            F_MatHang_ThemMatHang F_ThemMatHang = new F_MatHang_ThemMatHang();
            F_ThemMatHang.ReloadSauKhiThemMatHang += btnRefresh_Click;
            F_ThemMatHang.Show();
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            LoadThongTinMatHang(Current);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Equals(txtMaMH.Text.Trim(), ""))
            {
                MessageBox.Show("Bạn chưa chọn mặt hàng nào!");
                return;
            }
            if (!(MessageBox.Show("Bạn có muốn lưu thông tin mặt hàng không?", "", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                return;
            }

            tblMatHang Clone = new tblMatHang();
            Clone = Current;
            Clone.TenMH = txtTenMH.Text;
            Clone.Mota = txtMoTa.Text;
            Clone.MaLoai = cbLoaiHang.SelectedValue.ToString();
            Clone.MaKM = cbKhuyenMai.SelectedValue.ToString();
            Clone.SoLuong = Convert.ToInt16(txtSolg.Text ?? "0");
            Clone.GiaNhap = Convert.ToInt32(txtGiaNhap.Text ?? "0");
            Clone.GiaBan = Convert.ToInt32(txtGiaBan.Text ?? "0");
            Clone.DonViTinh = txtDonVi.Text;
            Clone.HanSuDung = dateHanSuDung.Value;

            if (ImageChange)
            {
                string ImageName = BUS_MatHang.XuLyTenHinh(FileDialog_PickImage.FileName, txtMaMH.Text);
                BUS_MatHang.TaoDuongDanHinhanh(FileDialog_PickImage.FileName, ImageName);
                Clone.LinkHinhAnh = BUS_MatHang.LayTenTuDuongDang(ImageName);
                ImageChange = false;
            }

            if (!BUS_MatHang.Sua(Current, Clone))
            {
                MessageBox.Show("Cập nhật không thành công!");
            }
            else
            {
                MessageBox.Show("Cập nhật thành công!");
            }
            btnRefresh_Click(sender, e);
        }

        private void pic_Click(object sender, EventArgs e)
        {
            FileDialog_PickImage.Filter = "Tệp tin hình ảnh|*.png;*.jpg;*.jpeg;*.gif";
            if (FileDialog_PickImage.ShowDialog() == DialogResult.OK)
            {
                ImageChange = true;
                pic.Image = Image.FromFile(FileDialog_PickImage.FileName);
            }
        }

        private void txtGiaBan_TextChanged(object sender, EventArgs e)
        {
            int GiaBan;
            if (int.TryParse(txtGiaBan.Text, out GiaBan))
            {
                return;
            }
            txtGiaBan.Text = GiaBan.ToString("#.###");
        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ngăn ký tự không phải là chữ được nhập vào
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            BUS_MatHang.dtg_Filter(dtg, txtTimKiem.Text);
        }

        private void dtg_SelectionChanged(object sender, EventArgs e)
        {
            if (dtg.SelectedRows.Count > 0)
            {
                var cell = dtg.SelectedRows[0].Cells[0].Value;
                if (cell != null)
                {
                    LoadThongTinMatHang(BUS_MatHang.LayTheoMa(cell.ToString()));
                }
            }
        }

        private void txtGiaNhap_TextChanged(object sender, EventArgs e)
        {
            int GiaNhap;
            if (int.TryParse(txtGiaBan.Text, out GiaNhap))
            {
                return;
            }
            txtGiaNhap.Text = GiaNhap.ToString("#.###");
        }
    }
}

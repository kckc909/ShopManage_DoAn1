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
            pnLeft.Width = pnLeft.Width == 400 ? 550 : 400;
            LoadDanhSachMatHang(BUS_MatHang.DanhSachMatHang());
        }

        private void F_MatHang_Load(object sender, EventArgs e)
        {
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

        void LoadDanhSachMatHang(List<tblMatHang> DSMH)
        {
            pnDSMH.Controls.Clear();

            int ItemWidth = 180;
            int MaxCol = pnDSMH.Width / ItemWidth;
            int ItemPadding = 15;
            int Col = 0;
            int Row = 0;

            foreach (tblMatHang MatHang in DSMH)
            {
                var C_MH = new C_MatHang(MatHang);
                C_MH.SuKienChonMatHang += Bat_SuKienChonMatHang;
                pnDSMH.Controls.Add(C_MH);
                C_MH.Show();
                C_MH.Location = new Point(Col * (ItemWidth + ItemPadding), Row * (ItemWidth + ItemPadding));

                if (Col < MaxCol - 1)
                {
                    Col++;
                }
                else
                {
                    Col = 0;
                    Row++;
                }
            }
        }

        void LoadThongTinMatHang(tblMatHang MatHang)
        {
            txtMaMH.Text = MatHang.MaMH;
            txtTenMH.Text = MatHang.TenMH;
            txtMoTa.Text = MatHang.Mota;
            txtGiaBan.Text = MatHang.GiaBan.ToString();
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
            if (MatHang.MaKM != null)
            {
                cbKhuyenMai.SelectedValue = MatHang.MaKM;
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

        private void Bat_SuKienChonMatHang(object sender, EventArgsMatHang e)
        {
            Current = e.MatHang;
            LoadThongTinMatHang(e.MatHang);
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
            pnDSMH.Controls.Clear();
            cbLoaiHang.Controls.Clear();
            cbKhuyenMai.Controls.Clear();
            Current = new tblMatHang();

            pic.Image = null;
            txtMaMH.Clear();
            txtMoTa.Clear();
            txtTenMH.Clear();
            txtGiaBan.Clear();
            txtDonVi.Clear();
            txtSolg.Clear();

            LoadDanhSachMatHang(BUS_MatHang.DanhSachMatHang());
            LoadDanhSachLoaiHang();
            LoadDanhSachKhuyenMai();
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
            Clone.SoLuong = Convert.ToInt16(txtSolg.Text);
            Clone.GiaBan = Convert.ToInt32(txtGiaBan.Text);
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
            var dsTK = BUS_MatHang.TimKiem(txtTimKiem.Text);
            LoadDanhSachMatHang(dsTK);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        DateTime MaxDate = Convert.ToDateTime("30-12-9000");
        tblMatHang Current = new tblMatHang();

        public F_MatHang()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            dateHanSuDung.Value = MaxDate;
        }

        private void F_MatHang_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                pnLeft.Width = 550;
            }
            else
            {
                pnLeft.Width = 400;
            }
        }

        private void F_MatHang_Load(object sender, EventArgs e)
        {
            LoadDanhSachMatHang();
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

        void LoadDanhSachMatHang()
        {
            int ItemWidth = 180;
            int MaxCol = pnDSMH.Width / ItemWidth;
            int ItemPadding = 15;
            int Col = 0;
            int Row = 0;

            foreach (tblMatHang MatHang in BUS_MatHang.DanhSachMatHang())
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
                dateHanSuDung.Value = MaxDate;
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
                    XoaMatHangTrenManHinh(txtMaMH.Text);
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

        void XoaMatHangTrenManHinh(string MaMH)
        {
            foreach (C_MatHang C_MH in pnDSMH.Controls)
            {
                if (Equals(C_MH.MaMH, MaMH))
                {
                    pnDSMH.Controls.Remove(C_MH);
                    return;
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            pnDSMH.Controls.Clear();
            cbLoaiHang.Controls.Clear();
            cbKhuyenMai.Controls.Clear();
            Current = new tblMatHang();

            txtMaMH.Clear();
            txtMoTa.Clear();
            txtTenMH.Clear();
            txtGiaBan.Clear();
            txtDonVi.Clear();
            txtSolg.Clear();

            LoadDanhSachMatHang();
            LoadDanhSachLoaiHang();
            LoadDanhSachKhuyenMai();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            F_MatHang_ThemMatHang F_ThemMatHang = new F_MatHang_ThemMatHang();
            F_ThemMatHang.Show();

        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            LoadThongTinMatHang(Current);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn lưu thông tin mặt hàng không?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                tblMatHang Clone = new tblMatHang();
                Clone = Current;

                Clone.TenMH = txtTenMH.Text;
                Clone.Mota = txtMoTa.Text;
                Clone.MaLoai = cbLoaiHang.SelectedValue.ToString();
                Clone.MaKM = cbKhuyenMai.SelectedValue.ToString();
                Clone.SoLuong = Convert.ToInt16(txtSolg.Text);
                Clone.GiaBan = Convert.ToInt16(txtGiaBan.Text);
                Clone.DonViTinh = txtDonVi.Text;
                Clone.HanSuDung = dateHanSuDung.Value;

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
        }
    }
}

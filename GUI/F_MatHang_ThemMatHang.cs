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
    public partial class F_MatHang_ThemMatHang : Form
    {
        public event EventHandler ReloadSauKhiThemMatHang;
        BUS_LoaiHang BUS_LoaiHang = new BUS_LoaiHang();
        BUS_MatHang BUS_MatHang = new BUS_MatHang();
        OpenFileDialog FileDialog_PickImage = new OpenFileDialog();
        tblMatHang _MatHang = new tblMatHang();
        bool ImageChange = false;

        public F_MatHang_ThemMatHang()
        {
            InitializeComponent();
        }

        private void F_MatHang_ThemMatHang_Load(object sender, EventArgs e)
        {
            Load_cbLoaiHang();
        }

        private void btnThemMatHang_Click(object sender, EventArgs e)
        {
            if (ThongTinMatHang())
            {
                Them();
                Close();
            }
        }

        private void btnMaxValue_Click(object sender, EventArgs e)
        {
            dateHanSuDung.Value = MyDefault.MaxDate;
        }

        private void btnHuyThem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThemHinhAnh_Click(object sender, EventArgs e)
        {
            FileDialog_PickImage.Filter = "Tệp tin hình ảnh|*.png;*.jpg;*.jpeg;*.gif";
            if (FileDialog_PickImage.ShowDialog() == DialogResult.OK)
            {
                ImageChange = true;
                pic.Image = Image.FromFile(FileDialog_PickImage.FileName);
            }
        }

        void Load_cbLoaiHang()
        {
            cbLoaiHang.DataSource = BUS_LoaiHang.DanhSach();
            cbLoaiHang.ValueMember = "MaLoai";
            cbLoaiHang.DisplayMember = "TenLoai";
            cbLoaiHang.SelectedIndex = 0;
        }

        bool ThongTinMatHang()
        {
            _MatHang.MaMH = BUS_MatHang.AutomaticID();

            if (Equals(txtTenMH.Text.Trim(), ""))
            {
                MessageBox.Show("Vui lòng nhập tên mặt hàng!");
                txtTenMH.Focus();
                return false;
            }
            _MatHang.TenMH = txtTenMH.Text;

            if (Equals(txtDonVi.Text.Trim(), ""))
            {
                MessageBox.Show("Vui lòng nhập đơn vị tính của mặt hàng!");
                txtDonVi.Focus();
                return false;
            }
            _MatHang.DonViTinh = txtDonVi.Text;
            int _tmp;
            if (int.TryParse(txtSolg.Text, out _tmp))
            {
                _MatHang.GiaBan = _tmp;
            }
            else
            {
                _MatHang.GiaBan = 0;
            }

            if (Equals(txtSolg.Text.Trim(), ""))
            {
                _MatHang.SoLuong = 0;
            }
            else
            {
                _MatHang.SoLuong = Convert.ToInt16(txtSolg.Text);
            }

            if (dateHanSuDung.Value <= DateTime.Now)
            {
                MessageBox.Show("Hạn sử dụng không thể nhỏ hơn ngày hiện tại!");
                return false;
            }
            _MatHang.HanSuDung = dateHanSuDung.Value;

            if (ImageChange)
            {
                string ImageName = BUS_MatHang.XuLyTenHinh(FileDialog_PickImage.FileName, _MatHang.MaMH);
                BUS_MatHang.TaoDuongDanHinhanh(FileDialog_PickImage.FileName, ImageName);
                _MatHang.LinkHinhAnh = BUS_MatHang.LayTenTuDuongDan(ImageName);
                ImageChange = false;
            }

            _MatHang.Mota = txtMoTa.Text;
            _MatHang.MaLoai = cbLoaiHang.SelectedValue.ToString();
            _MatHang.MaKM = MyDefault.MaKM;
            return true;
        }

        void Them()
        {
            BUS_MatHang.Add(_MatHang);
            Raise_ReloadSauKhiThemMatHang();
        }
        void Raise_ReloadSauKhiThemMatHang()
        {
            ReloadSauKhiThemMatHang.Invoke(this, EventArgs.Empty);
        }
    }
}


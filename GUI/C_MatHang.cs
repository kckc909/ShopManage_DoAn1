using BUS;
using DTO;
using System;
using GUI.MyEventArgs;
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
    public partial class C_MatHang : Form
    {
        BUS_KhuyenMai BUS_KhuyenMai = new BUS_KhuyenMai();

        public event EventHandler<EventArgsMatHang> SuKienChonMatHang;

        public string MaMH;
        private tblMatHang _tblMatHang;
        private tblKhuyenMai _tblKhuyenMai;
        bool flag_CoKhuyenMai = false;

        public C_MatHang(tblMatHang MatHang)
        {
            InitializeComponent();
            TopLevel = false;

            _tblMatHang = MatHang;
            MaMH = MatHang.MaMH;
            LoadThongTinMatHang();
        }

        void LoadThongTinMatHang()
        {
            picHinhAnh.Image = Image.FromFile(_tblMatHang.LinkHinhAnh);
            lbTenMatHang.Text = _tblMatHang.TenMH;
            lbGiaMatHang.Text = _tblMatHang.GiaBan.ToString();

            lbKhuyenMai.Hide();
             _tblKhuyenMai = BUS_KhuyenMai.LayKhuyenMai(_tblMatHang.MaKM);
            if (_tblKhuyenMai is default(tblKhuyenMai))
            {
                if (_tblKhuyenMai.PhamTramGiam > 0)
                {
                    lbKhuyenMai.Text = _tblKhuyenMai.PhamTramGiam + "%";
                    lbKhuyenMai.ForeColor = Color.Red;
                    lbKhuyenMai.Location = new Point(picHinhAnh.Width - lbKhuyenMai.Width, picHinhAnh.Height - lbKhuyenMai.Height);
                    flag_CoKhuyenMai = true;
                    lbKhuyenMai.Show();
                }
            }
            if (flag_CoKhuyenMai)
            {
                lbGiaMatHang.Text += " -> " + _tblMatHang.GiaBan * _tblKhuyenMai.PhamTramGiam / 100;
            }

            lbGiaMatHang.Text += " vnd";
        }

        private void AllControl_MouseEnter(object sender, EventArgs e)
        {
            // đổi màu viền
            panel.BorderColor = Color.Silver;
        }

        private void AllControl_MouseLeave(object sender, EventArgs e)
        {
            // Trả lại màu viền
            panel.BorderColor = Color.Black;
        }

        private void lbTenMatHang_Click(object sender, EventArgs e)
        {
            // Phát sự kiện truyền thông tin để hiển thị thông tin chi tiết
            Phat_SuKienChonMatHang(_tblMatHang, _tblKhuyenMai);
        }
        void Phat_SuKienChonMatHang(tblMatHang MatHang, tblKhuyenMai KhuyenMai)
        {
            EventArgsMatHang ea = new EventArgsMatHang();
            ea.MatHang = MatHang;
            ea.KhuyenMai = KhuyenMai;

            SuKienChonMatHang?.Invoke(this, ea);
        }
    }
}

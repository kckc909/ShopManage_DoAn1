using BUS;
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
    public partial class F_BaoCaoThongKe : Form
    {
        BUS_HoaDonBan BUS_HoaDonBan = new BUS_HoaDonBan();
        BUS_HoaDonNhap BUS_HoaDonNhap = new BUS_HoaDonNhap();
        BUS_NhanVien BUS_NhanVien = new BUS_NhanVien();

        private List<string> columnNames = new List<string>();
        private List<double> values_ChiPhi = new List<double>(); // hóa đơn nhập
        private List<double> values_DoanhThu = new List<double>(); // hóa đơn bán
        public F_BaoCaoThongKe()
        {
            InitializeComponent();
        }
        private void Cal_DoanhSoNV()
        {
            // lấy từng nhân viên, duyệt qua các nhân viên -> nhân viên và tổng doanh số của họ

        }

        private void Cal_DoanhThu(string FormatString)
        {
            columnNames.Clear();
            values_ChiPhi.Clear();
            values_DoanhThu.Clear();

            DateTime StartTime = dateStart.Value;
            DateTime EndTime = dateEnd.Value;

            while (StartTime <= EndTime)
            {
                double chi_phi = 0, doanh_thu = 0;
                var LstHDN = BUS_HoaDonNhap.HDN_GetAll().FindAll(x => x.NgayNhap.Value.ToString(FormatString).Equals(StartTime.ToString(FormatString)));
                LstHDN.ForEach(hd =>
                {
                    chi_phi += BUS_HoaDonNhap.CT_GetByID_HDN(hd.MaHDN).Sum(x => x.SoLg * x.GiaNhap).Value;
                });
                var ListHDB = BUS_HoaDonBan.HDB_GetAll().FindAll(x => x.NgayBan.Value.ToString(FormatString).Equals(StartTime.ToString(FormatString)));
                ListHDB.ForEach(hd =>
                {
                    doanh_thu += BUS_HoaDonBan.HDB_TinhTien(hd.MaHDB)[2];
                });
                values_ChiPhi.Add(chi_phi);
                values_DoanhThu.Add(doanh_thu);
                columnNames.Add(StartTime.ToString(FormatString));
                StartTime = StartTime.AddDays(1);
            }

            chart_DoanhThu.Series["Series_ChiPhi"].Points.DataBindXY(columnNames, values_ChiPhi);
            chart_DoanhThu.Series["Series_DoanhThu"].Points.DataBindXY(columnNames, values_DoanhThu);
        }

        private void F_BaoCaoThongKe_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            switch (cboLoai.SelectedIndex)
            {
                case 0:
                    Cal_DoanhThu("dd/MM/yyyy");
                    break;
                case 1:
                    Cal_DoanhThu("MM/yyyy");
                    break;
                case 2:
                    Cal_DoanhThu("yyyy");
                    break;
            }
        }

        private void F_BaoCaoThongKe_SizeChanged(object sender, EventArgs e)
        {
            if (pnFooterContainer.Width > 1200)
            {
                chart_DoanhSoNV.Size = chart_DoanhSoNV.MaximumSize;
            }
            else
            {
                chart_DoanhSoNV.Size = chart_DoanhSoNV.MinimumSize;
            }
        }
    }
}

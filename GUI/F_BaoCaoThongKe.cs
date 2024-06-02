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
        BUS_BaoCaoThongKe BUS_BaoCaoThongKe = new BUS_BaoCaoThongKe();

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
            List<string> columnNames = new List<string>();
            List<double> values_ChiPhi = new List<double>(); // hóa đơn nhập
            List<double> values_DoanhThu = new List<double>(); // hóa đơn bán

            List<(double, double, string)> lst = BUS_BaoCaoThongKe.RevenueByDay(dtpStart.Value, dtpEnd.Value, FormatString);
            columnNames = lst.Select(x => x.Item3).ToList();
            values_ChiPhi = lst.Select(x => x.Item1).ToList();
            values_DoanhThu = lst.Select(x => x.Item2).ToList();
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

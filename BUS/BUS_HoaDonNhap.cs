using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_HoaDonNhap
    {
        DAL_HoaDonNhap DAL_HoaDonNhap = new DAL_HoaDonNhap();
        public void Them(tblHoaDonNhap HDN)
        {
            DAL_HoaDonNhap.Them(HDN);
        }
        public void Sua(tblHoaDonNhap _old, tblHoaDonNhap _new)
        {
            DAL_HoaDonNhap.Sua(_old, _new);
        }
        public void Sua_TinhTrang(string MaHDN, int TinhTrang)
        {
            DAL_HoaDonNhap.Sua_TinhTrang(HDN_LayTheoMa(MaHDN), TinhTrang);
        }
        public void Xoa(string MaHDN)
        {
            DAL_HoaDonNhap.Xoa(DS_HDN().Find(x => x.MaHDN.Trim().Equals(MaHDN.Trim())));
        }
        public tblHoaDonNhap HDN_LayTheoMa(string MaHDN)
        {
            return DAL_HoaDonNhap.GetByID(MaHDN);
        }
        public List<tblHoaDonNhap> DS_HDN()
        {
            return DAL_HoaDonNhap.DanhSachHoaDonNhap();
        }
        public string MaTuDong()
        {
            return DateTime.Now.ToString("ddMMyyyyHHmmssff");
        }
        public void Loc_TimKiem(DataGridView dtg, string s, int TinhTrang)
        {
            foreach (DataGridViewRow r in dtg.Rows)
            {
                r.Visible = false;
                r.Cells["TT"].Value = TinhTrang;
                foreach (DataGridViewCell c in r.Cells)
                {
                    if (c.Value.ToString().Contains(s))
                    {
                        r.Visible = true;
                    }
                }
            }
        }
        public int Tinh_TongTien(tblHoaDonNhap HDN)
        {
            if (HDN.tblChiTietHDNs.Count == 0)
                return 0;
            return HDN.tblChiTietHDNs.Sum(x => x.SoLg * x.GiaNhap ).Value;
        }
    }
}

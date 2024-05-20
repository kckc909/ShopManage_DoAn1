using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            DAL_HoaDonNhap.Sua_TinhTrang(HDN_LayTheoMa(MaHDN) ,TinhTrang);
        }
        public void Xoa(string MaHDN)
        {
            DAL_HoaDonNhap.Xoa(DS_HDN().Find(x => x.MaHDN.Trim().Equals(MaHDN.Trim())));
        }
        public tblHoaDonNhap HDN_LayTheoMa(string MaHDN)
        {
            return DS_HDN().Find(x => x.MaHDN.Trim().Equals(MaHDN.Trim()));
        }
        public List<tblHoaDonNhap> DS_HDN()
        {
            return DAL_HoaDonNhap.DanhSachHoaDonNhap();
        }
    }
}

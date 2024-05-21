using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
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
        public string MaTuDong()
        {
            int i = DS_HDN().Count;
            while (DS_HDN().Any(x => x.MaHDN.Equals($"HDN{i}")))
            {
                i++;
            }
            return $"HDN{i}";
        }
    }
}

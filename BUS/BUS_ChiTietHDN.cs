using DAL;
using DTO;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_ChiTietHDN
    {
        DAL_ChiTietHDN DAL_ChiTietHDN = new DAL_ChiTietHDN();
        public void Them(string MaHDN, string MaMH, int SoLg, int GiaNhap)
        {
            var CTHDN = new tblChiTietHDN();
            CTHDN.MaHDN = MaHDN;
            CTHDN.MaMH = MaMH;
            CTHDN.SoLg = SoLg;
            CTHDN.GiaNhap = GiaNhap;
            DAL_ChiTietHDN.Them(CTHDN);
        }
        public void Sua_SoLuong(string MaHDN, string MaMH, int SoLuongMoi)
        {
            DAL_ChiTietHDN.Sua_SoLuong(MaHDN, MaMH, SoLuongMoi);
        }
        public void Xoa(string MaHDN, string MaMH)
        {
            DAL_ChiTietHDN.Xoa(new tblChiTietHDN()
            {
                MaHDN = MaHDN,
                MaMH = MaMH,
                SoLg = 0
            });
        }
        
    }
}

using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DangNhap
    {
        DAL.DangNhap DAL_DangNhap = new DAL.DangNhap();
        public bool KiemTraTaiKhoanMatKhau(string TenTaiKhoan, string MatKhau)
        {
            foreach (tblTaiKhoanMatKhau TaiKhoan in DAL_DangNhap.LayTatCaTaiKhoan())
            {
                if (Equals(TaiKhoan.TaiKhoan, TenTaiKhoan) && Equals(MatKhau, TaiKhoan.MatKhau))
                {
                    return true;
                }
            }
            return false;
        }
        public bool KiemTraRong(string TenTaiKhoan, string MatKhau)
        {
            if (Equals(TenTaiKhoan.Trim(), "") || Equals(MatKhau.Trim(), ""))
            {
                return false;
            }
            return true;
        }
    }
}

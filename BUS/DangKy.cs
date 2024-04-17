using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    internal class DangKy
    {
        public void ThemTaiKhoan()
        {

        }

        public bool KiemTraTenTaiKhoan(string TenTaiKhoan)
        {
            throw new NotImplementedException();
        }

        public bool KiemTraMaNhanVien(string TenTaiKhoan, string MaNV)
        {

            throw new NotImplementedException();
        }

        public bool KiemTraTrungMatKhau(string MatKhau, string NhapLaiMatKhau)
        {
            return (MatKhau == NhapLaiMatKhau) ? true : false;
        }
    }
}

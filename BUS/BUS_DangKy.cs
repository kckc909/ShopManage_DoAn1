using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_DangKy
    { 
        DAL_TaiKhoanMatKhau DAL_TKMK = new DAL_TaiKhoanMatKhau();
        DAL_NhanVien DAL_NhanVien = new DAL_NhanVien();

        public bool KiemTraEmail(string Email)
        {
            return ! DAL_NhanVien.DanhSachNhanVien().Exists(x => x.Email.Trim() == Email);
        }

        public bool KiemTraTrungMatKhau(string MatKhau, string NhapLaiMatKhau)
        {
            return (MatKhau == NhapLaiMatKhau) ? true : false;
        }

        public void TaoTaiKhoan(string TenTaiKhoan, string MatKhau, string Email)
        {
            var DSNV = DAL_NhanVien.DanhSachNhanVien();
            var NhanVien = DSNV.Find(x => x.Email.Trim() == Email);
            var MaNV = NhanVien.MaNV;

            tblTaiKhoanMatKhau NewTKMK = new tblTaiKhoanMatKhau()
            {
                TaiKhoan = TenTaiKhoan,
                MatKhau = MatKhau,
                MaNV = MaNV
            };

            DAL_TKMK.Them(NewTKMK);
        }
        public bool KiemTraTenTaiKhoan(string TenTaiKhoan)
        {
            var DSTK = DAL_TKMK.DanhSachTaiKhoanMatKhau();
            return ! DSTK.Exists(x => x.TaiKhoan.Trim() == TenTaiKhoan);            
        }
    }
}

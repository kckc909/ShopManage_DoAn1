using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_DangNhap
    {
        DAL_TaiKhoanMatKhau DAL_TKKM = new DAL_TaiKhoanMatKhau();
        DAL_NhanVien DAL_NV = new DAL_NhanVien();

        public bool KiemTraRong(string TenTaiKhoan, string MatKhau)
        {
            if (Equals(TenTaiKhoan.Trim(), "") || Equals(MatKhau.Trim(), ""))
            {
                return false;
            }

            return true;
        }
        public tblNhanVien LayNhanVien(string TenTaiKhoan)
        {
            tblTaiKhoanMatKhau TaiKhoan = DAL_TKKM.DanhSachTaiKhoanMatKhau().Find(y => y.TaiKhoan.Trim() == TenTaiKhoan);
            tblNhanVien NhanVien = DAL_NV.DanhSachNhanVien().Find(x => x.MaNV.Trim().ToUpper() == TaiKhoan.MaNV.Trim().ToUpper());

            return NhanVien;
        }

        public bool KiemTraTaiKhoanMatKhau(string TK, string MK)
        {
            tblTaiKhoanMatKhau TKMK = DAL_TKKM.DanhSachTaiKhoanMatKhau().Find(x => x.TaiKhoan.Trim() == TK.Trim());
            if (TKMK.MatKhau.Trim() == MK.Trim())
            {
                return true;
            }
            return false;   
        }
    }
}

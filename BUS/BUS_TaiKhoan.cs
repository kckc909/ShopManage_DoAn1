using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_TaiKhoan
    {
        DAL_TaiKhoanMatKhau DAL_TaiKhoanMatKhau = new DAL_TaiKhoanMatKhau();
        public bool Check_TenTaiKhoanMoi(string TenTK, string TenTKMoi)
        {
            if (TenTK.Equals(TenTKMoi))
            {
                return true;
            }
            else if (DAL_TaiKhoanMatKhau.GetAll().Any(x => x.TaiKhoan.Trim().Equals(TenTKMoi.Trim())))
            {
                return false;
            }
            else
            { return true; }
        }
        public bool Check_TrungTenTaiKhoan(string TenTaiKhoan)
        {
            return DAL_TaiKhoanMatKhau.GetAll().Any(x => x.TaiKhoan.Equals(TenTaiKhoan));
        }
        public bool Check_NhanVienCoTaiKhoan(string MaNV)
        {
            return DAL_TaiKhoanMatKhau.GetAll().Any(x => x.MaNV.Equals(MaNV));
        }
        public bool Check_NhapLaiMatKhau(string MatKhau, string NhapLaiMatKhau)
        {
            return MatKhau.Equals(NhapLaiMatKhau);
        }
        public void Them(tblTaiKhoanMatKhau tkmk)
        {
            DAL_TaiKhoanMatKhau.Add(tkmk);
        }
        public void Sua(string TenTaiKhoan, string TenTKMoi, string MatKhauMoi)
        {
            DAL_TaiKhoanMatKhau.Update(TenTaiKhoan, TenTKMoi, MatKhauMoi);
        }
        public void Xoa(string TenTK)
        {
            DAL_TaiKhoanMatKhau.Delete(TenTK);
        }
        public tblTaiKhoanMatKhau TheoTenTaiKhoan(string TenTaiKhoan)
        {
            return DAL_TaiKhoanMatKhau.GetAll().Find(x => x.TaiKhoan.Trim().Equals(TenTaiKhoan.Trim()));
        }
        public tblTaiKhoanMatKhau TheoMaNhanVien(string MaNV)
        {
            return DAL_TaiKhoanMatKhau.GetAll().Find(x => x.MaNV.Equals(MaNV));
        }
        public bool Check_DangNhap(string TenTK, string MatKhau)
        {
            return DAL_TaiKhoanMatKhau.GetAll().Any(x => x.TaiKhoan.Trim().Equals(TenTK.Trim()) 
            && x.MatKhau.Trim().Equals(MatKhau.Trim()));
        }
        public List<tblTaiKhoanMatKhau> DSTK ()
        {
            return DAL_TaiKhoanMatKhau.GetAll();
        }
    }
}

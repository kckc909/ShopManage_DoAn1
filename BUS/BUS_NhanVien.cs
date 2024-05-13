using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_NhanVien
    {
        DAL_NhanVien DAL = new DAL_NhanVien();
        public void Them(tblNhanVien nv) => DAL.Them(nv);
        public void Sua(tblNhanVien _old, tblNhanVien _new) => DAL.Sua(_old, _new);
        public void Xoa(tblNhanVien nv) => DAL.Xoa(nv);
        public List<tblNhanVien> DSNV() => DAL.DanhSachNhanVien();
        public List<tblNhanVien> DSNV(string str) => DSNV().Where(x =>
                x.MaNV.Contains(str) ||
                x.TenNV.Contains(str) ||
                (x.SDT != null && x.SDT.Contains(str)) ||
                (x.DiaChi != null && x.DiaChi.Contains(str)) ||
                (x.NgaySinh != null && x.NgaySinh.Value.ToString().Contains(str)) ||
                (x.Email != null && x.Email.Contains(str))
            ).ToList();
        public tblNhanVien NhanVienTheoMa(string MaNV) => DSNV().Find(x => Equals(x.MaNV, MaNV));
        public string MaTuDong()
        {
            int i = DSNV().Count;
            while (DSNV().Exists(x => Equals(x.MaNV.Trim(), $"NV{i}")))
            {
                i++;
            }
            return $"NV{i}";
        }
        public string DuongDanHinhAnh(string TenHinhAnh) => Path.Combine(MyDefault.Path_Avatar, TenHinhAnh);
        public string TaoTenHinhAnh(string Extention)
        {
            List<string> files = Directory.GetFiles(MyDefault.Path_Avatar).ToList();
            int i = files.Count;
            while (files.Exists(x => Equals(Path.GetFileNameWithoutExtension(x), $"Avatar{i}")))
            {
                i++;
            }
            return $"Avatar{i}" + Extention;
        }
        public void CopyHinhAnh(string Source, string FileName)
        {
            try
            {
                string Destination = Path.Combine(MyDefault.Path_Avatar, FileName);
                File.Copy(Source, Destination);
            }
            catch
            {

            }
        }
    }
}

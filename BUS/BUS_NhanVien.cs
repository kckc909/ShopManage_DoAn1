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
        DAL_Quyen DAL_Quyen = new DAL_Quyen();
        public void Them(tblNhanVien nv) => DAL.Add(nv);
        public void Sua(tblNhanVien _old, tblNhanVien _new) => DAL.Update(_old, _new);
        public void Xoa(tblNhanVien nv) => DAL.Delete(nv);
        public List<tblQuyen> GetAll_Quyen() => DAL_Quyen.GetAll();
        public List<tblNhanVien> DSNV() => DAL.GetAll();
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
        public string TaoTenHinhAnh(string FileName)
        {
            string Extension = Path.GetExtension(FileName);
            if (!Directory.Exists(MyDefault.Path_Avatar))
            {
                Directory.CreateDirectory(MyDefault.Path_Avatar);
            }
            List<string> files = Directory.GetFiles(MyDefault.Path_Avatar).ToList();
            int i = files.Count;
            while (files.Exists(x => Equals(Path.GetFileNameWithoutExtension(x), $"Avatar{i}")))
            {
                i++;
            }
            return $"Avatar{i}" + Extension;
        }
        public void CopyHinhAnh(string Source, string FileName)
        {
            string Destination = Path.Combine(MyDefault.Path_Avatar, Path.GetFileName(FileName));
            File.Copy(Source, Destination);
        }
        public tblNhanVien NhanVienTheoEmail(string Email)
        {
            return DSNV().Find(x => x.Email.Equals(Email));
        }
        public bool KiemTraTonTai(string MaNV)
        {
            return DSNV().Any(x => x.MaNV.Trim().Equals(MaNV.Trim()));
        }
    }
}

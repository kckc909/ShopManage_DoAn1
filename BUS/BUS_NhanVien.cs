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
        public void Add(tblNhanVien nv) => DAL.Add(nv);
        public void Update(tblNhanVien _old, tblNhanVien _new) => DAL.Update(_old, _new);
        public void Delete(tblNhanVien nv) => DAL.Delete(nv);
        public List<tblQuyen> GetAll_Quyen() => DAL_Quyen.GetAll();
        public List<tblNhanVien> GetAll() => DAL.GetAll();
        public List<tblNhanVien> GetAll(string str) => GetAll().Where(x =>
                x.MaNV.Contains(str) ||
                x.TenNV.Contains(str) ||
                (x.SDT != null && x.SDT.Contains(str)) ||
                (x.DiaChi != null && x.DiaChi.Contains(str)) ||
                (x.NgaySinh != null && x.NgaySinh.Value.ToString().Contains(str)) ||
                (x.Email != null && x.Email.Contains(str))
            ).ToList();
        public tblNhanVien GetById(string MaNV) => GetAll().Find(x => Equals(x.MaNV, MaNV));
        public string MaTuDong()
        {
            int i = GetAll().Count;
            while (GetAll().Exists(x => Equals(x.MaNV.Trim(), $"NV{i}")))
            {
                i++;
            }
            return $"NV{i}";
        }
        public string DuongDanHinhAnh(string TenHinhAnh) => Path.Combine(MyDefault.Path_Avatar, TenHinhAnh ?? "");
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
            return GetAll().Find(x => x.Email.Equals(Email));
        }
        public bool KiemTraTonTai(string MaNV)
        {
            return GetAll().Any(x => x.MaNV.Trim().Equals(MaNV.Trim()));
        }
    }
}

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
    public class BUS_KhachHang
    {
        DAL_KhachHang DAL_KhachHang = new DAL_KhachHang();
        public void Them(tblKhachHang KhachHang) => DAL_KhachHang.Them(KhachHang);
        public void Sua(tblKhachHang _old, tblKhachHang _new) => DAL_KhachHang.Sua(_old, _new);
        public void Xoa(tblKhachHang khachHang) => DAL_KhachHang.Xoa(khachHang);
        public List<tblKhachHang> DSKH(string str) => 
            DSKH().FindAll(x => x.MaKH.Contains(str) || x.TenKH.Contains(str) || x.SDT.Contains(str));
        public List<tblKhachHang> DSKH() => DAL_KhachHang.DanhSachKhachHang();
        public tblKhachHang LayTheoMa(string MaKH) => DSKH().Find(x => x.MaKH.Equals(MaKH));
        public string MaTuDong()
        {
            int i = DSKH().Count;
            while (DSKH().Exists(x => x.MaKH.Equals($"KH{i}")))
            {
                i++;
            }
            return $"KH{i}";
        }
    }
}

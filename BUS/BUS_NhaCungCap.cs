using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_NhaCungCap
    {
        DAL_NhaCungCap DAL_NhaCungCap = new DAL_NhaCungCap();

        public void Them(tblNCC NCC) => DAL_NhaCungCap.Them(NCC);
        public void Sua(tblNCC _old, tblNCC _new) => DAL_NhaCungCap.Sua(_old, _new);
        public void Xoa(tblNCC ncc) => DAL_NhaCungCap.Xoa(ncc);
        public List<tblNCC> DanhSachNCC() => DAL_NhaCungCap.DanhSachNCC();
        public List<tblNCC> DanhSachNCC(string str) => DAL_NhaCungCap.DanhSachNCC().FindAll(x =>
                x.MaNCC.Contains(str) ||
                x.TenNCC.Contains(str) ||
                (x.SDT != null && x.SDT.Contains(str)) ||
                (x.DiaChi != null && x.DiaChi.Contains(str)) ||
                (x.Email != null && x.Email.Contains(str))
        );
        public string MaTuDong ()
        {
            int i = DanhSachNCC().Count;
            while (DanhSachNCC().Exists(x => Equals(x.MaNCC.Trim(), $"NCC{i}")))
            {
                i++;
            }
            return $"NCC{i}";
        }
        public tblNCC GetById(string MaNCC) => DanhSachNCC().Find(x => Equals(x.MaNCC, MaNCC));

    }
}

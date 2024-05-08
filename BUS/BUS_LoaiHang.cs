using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_LoaiHang
    {
        DAL_LoaiHang DAL_LoaiHang = new DAL_LoaiHang();

        public void Them(tblLoaiHang LH) => DAL_LoaiHang.Them(LH);
        public void Sua(tblLoaiHang _old, tblLoaiHang _new) => DAL_LoaiHang.Sua(_old, _new);
        public void Xoa(string MaLH) => DAL_LoaiHang.Xoa(DanhSach().Find(x => x.MaLoai.Trim() == MaLH.Trim()));
        public List<tblLoaiHang> DanhSach() => DAL_LoaiHang.DanhSach();
    }
}

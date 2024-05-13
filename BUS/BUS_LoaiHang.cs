using DAL;
using DTO;
using System;
using System.CodeDom.Compiler;
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
        public tblLoaiHang LayLoaiHangTheoMaLoai(string MaLoai) => DanhSach().Find(x => Equals(x.MaLoai.Trim(), MaLoai.Trim()));
        public string MaLoaiHangTuDong()
        {
            int i = DanhSach().Count() + 1;
            while (DanhSach().Exists(x => Equals(x.MaLoai.Trim(), $"LH{i}")))
            {
                i++;
            }
            return $"LH{i}";
        }
        public List<tblMatHang> DSMatHangThamChieu(string MaLoai)
        {
            return LayLoaiHangTheoMaLoai(MaLoai).tblMatHangs.Where(x => Equals(x.MaLoai, MaLoai)).ToList();
        }
        public List<tblLoaiHang> TimKiem(string str)
        {
            var Result = new List<tblLoaiHang>();
            foreach (tblLoaiHang LoaiHang in DanhSach())
            {
                if (LoaiHang.MaLoai.Contains(str) ||
                    LoaiHang.TenLoai.Contains(str) ||
                    (LoaiHang.MoTa != null && LoaiHang.MoTa.Contains(str)))
                {
                    Result.Add(LoaiHang);
                }
            }
            return Result;
        }
    }
}

using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_KhuyenMai
    {
        DAL_KhuyenMai dal = new DAL_KhuyenMai();
        public tblKhuyenMai LayKhuyenMai(string MaKM)
        {
            return dal.DanhSachKhuyenMai().Find(x => Equals(x.MaKM, MaKM));
        }
        public void Them(tblKhuyenMai KM) => dal.Them(KM);
        public void Sua(tblKhuyenMai _old, tblKhuyenMai _new) => dal.Sua(_old, _new);
        public void Xoa(tblKhuyenMai km) => dal.Xoa(km);
        public List<tblKhuyenMai> DanhSach() => dal.DanhSachKhuyenMai();
        public List<tblKhuyenMai> DanhSach(string str) => dal.DanhSachKhuyenMai().Where(x=> 
            x.MaKM.Contains(str)||
            x.TenKM.Contains(str)||
            (x.MoTa != null && x.MoTa.Contains(str)) ||
            x.PhamTramGiam.Value.ToString().Contains(str)
            ).ToList();
        public string MaTuDong()
        {
            int i = dal.DanhSachKhuyenMai().Count;
            while (DanhSach().Exists(x => x.MaKM.Equals($"KM{i}")))
            {
                i ++;
            }
            return $"KM{i}";
        }
        
    }
}

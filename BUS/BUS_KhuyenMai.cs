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
        DAL_KhuyenMai DAL_KhuyenMai = new DAL_KhuyenMai();
        public tblKhuyenMai LayKhuyenMai(string MaKM)
        {
            return DAL_KhuyenMai.DanhSachKhuyenMai().Find(x => x.MaKM.Trim() == MaKM.Trim());
        }
        public List<tblKhuyenMai> DanhSach() => DAL_KhuyenMai.DanhSachKhuyenMai();

    }
}

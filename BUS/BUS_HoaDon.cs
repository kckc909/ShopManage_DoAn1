using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_HoaDonBan
    {
        DAL_HoaDonBan DAL_HoaDonBan = new DAL_HoaDonBan();

        public List<tblHoaDonBan> DanhSachHoaDonBan()
        {
            return DAL_HoaDonBan.DanhSachHoaDonBan();
        }
    }
}

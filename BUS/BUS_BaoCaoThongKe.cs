using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public  class BUS_BaoCaoThongKe
    {
        DAL_MatHang dal_MatHang = new DAL_MatHang();
        DAL_ChiTietHDB dal_ChiTietHDB = new DAL_ChiTietHDB();
        DAL_ChiTietHDN dal_ChiTietHDN = new DAL_ChiTietHDN();
        DAL_HoaDonBan dal_HoaDonBan = new DAL_HoaDonBan();
    }
}

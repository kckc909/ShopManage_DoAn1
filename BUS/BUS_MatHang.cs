using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_MatHang
    {
        DAL_MatHang DAL_MatHang = new DAL_MatHang();
        public List<tblMatHang> DanhSachMatHang()
        {
            return DAL_MatHang.DanhSachMatHang();
        }

        public bool Xoa(string MaMH)
        {
            var MatHang = DanhSachMatHang().Find(x => Equals(x.MaMH.Trim(), MaMH.Trim()));
            if (MatHang != null)
            {
                DAL_MatHang.Xoa(MatHang);
                return true;
            }
            return false;
        }

        public bool Them(tblMatHang matHang)
        {
            if (!DanhSachMatHang().Exists(x => Equals(x.MaMH.Trim(), matHang.MaMH)))
            {
                DAL_MatHang.Them(matHang);
                return true;
            }
            return false;
        }

        public bool Sua(tblMatHang _old, tblMatHang _new)
        {
            if (Equals(_old.MaMH, _new.MaMH))
            {
                if (DanhSachMatHang().Exists(x => Equals(x.MaMH, _old.MaMH)))
                {
                    DAL_MatHang.Sua(_old, _new);
                    return true;
                }
            }
            return false;
        }
    }
}

using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Voucher
    {
        DAL_Voucher dal = new DAL_Voucher();
        public void Them(tblVoucher vc) => dal.Them(vc);
        public void Sua(tblVoucher _old, tblVoucher _new) => dal.Sua(_old, _new);
        public void Xoa(string MaV) => dal.Xoa(DSVoucher().Find(x => x.MaV.Equals(MaV)));
        public List<tblVoucher> DSVoucher() => dal.DanhSachVoucher();
        public List<tblVoucher> DSVoucher(string str) => dal.DanhSachVoucher().Where(
            x => x.MaV.Contains(str) || 
            x.TenV.Contains(str) ||
            x.GiaTri.Value.ToString().Contains(str) ||
            x.DonVi.Contains(str)
            ).ToList();
        public string MaTuDong()
        {
            int i = DSVoucher().Count;
            while (DSVoucher().Exists(x => x.MaV.Trim().Equals($"V{i}")))
            {
                i++ ;
            }
            return $"V{i}";
        }
    }
}

using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_ApDungVoucher
    {
        DAL_ApDungVoucher dal = new DAL_ApDungVoucher();
        public void Them(tblApDungVoucher apDungVoucher) => dal.Them(apDungVoucher);
        public void Sua(tblApDungVoucher _old, tblApDungVoucher _new) => dal.Sua(_old, _new);
        public void Xoa(tblApDungVoucher adv) => dal.Xoa(adv);
        public List<tblApDungVoucher> DanhSach() => dal.DanhSachApDungVoucher();
        public List<tblApDungVoucher> DanhSachTheoMaHDB(string MaHDB) => DanhSach().FindAll(x => Equals(x.MaHDB, MaHDB));
    }
}

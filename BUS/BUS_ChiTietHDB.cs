using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_ChiTietHDB
    {
        public DAL_ChiTietHDB DAL_ChiTietHDB = new DAL_ChiTietHDB();
        public void Them(tblChiTietHDB CTHDB)
        {
            DAL_ChiTietHDB.Them(CTHDB);
        }
        public void Sua_SoLuong(string MaHDB, string MaMH, int SoLuongMoi)
        {
            var CTHDB = DAL_ChiTietHDB.DS_CTHDB().Find(x => x.MaHDB.Equals(MaHDB) && x.MaMH.Equals(MaMH));
            DAL_ChiTietHDB.Sua_SoLuong(CTHDB, SoLuongMoi);
        }
        public void Sua(tblChiTietHDB _old, tblChiTietHDB _new)
        {
            DAL_ChiTietHDB.Sua(_old, _new);
        }
        public void Xoa(string MaHDB, string MH)
        {
            DAL_ChiTietHDB.Xoa(DS_CTHDB_MaHDB().Find(x => x.MaHDB.Equals(MaHDB) && x.MaMH.Equals(MH)));
        }
        public List<tblChiTietHDB> DS_CTHDB_MaHDB()
        {
            return DAL_ChiTietHDB.DS_CTHDB();
        }
        public double TongTien(List<tblChiTietHDB> DS_CTHDB)
        {
            return DS_CTHDB.Sum(x => x.SoLg * x.GiaBan).Value;
        }
    }
}

using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_SoHuuVoucher
    {
        DAL_SoHuuVoucher DAL_SoHuuVoucher = new DAL_SoHuuVoucher();
        public void Them(tblSoHuuVoucher SHVc)
        {
            if (DsSoHuuVoucher().Exists(x => x.MaSHVc.Equals(SHVc.MaSHVc)))
            {
                DAL_SoHuuVoucher.Them(SHVc);
            }
        }
        public void Xoa(string MaSHVc)
        {
            var shvc = DsSoHuuVoucher().Find(x => x.MaSHVc.Equals(MaSHVc));
            if (shvc != null)
            {
                DAL_SoHuuVoucher.Xoa(shvc);
            }
        }
        public List<tblSoHuuVoucher> DsSoHuuVoucher() => DAL_SoHuuVoucher.DanhSachSoHuuVoucher();
        public string MaTuDong()
        {
            int i = DsSoHuuVoucher().Count;
            while (DsSoHuuVoucher().Exists(x => x.MaSHVc.Trim().Equals("SH"+i)))
            {
                i++;
            }
            return "SH" + i;
        }
        public List<tblSoHuuVoucher> DsSoHuuVoucher_TheoMaKH(string MaKH) => DsSoHuuVoucher().FindAll(x => x.MaKH.Trim().Equals(MaKH));
        public tblSoHuuVoucher LayTheoMaSHVc(string MaSHVc) => DsSoHuuVoucher().Find(x => x.MaSHVc.Trim().Equals(MaSHVc));
        public void TangVoucher(List<tblSoHuuVoucher> dsshvc, tblKhachHang KH)
        {
            List<tblSoHuuVoucher> DsVcCn = DsSoHuuVoucher_TheoMaKH(KH.MaKH);
            dsshvc.ForEach(vc => 
            {
                if (!(vc.tblVoucher.Loai.Equals(0) && KH.tblSoHuuVouchers.ToList().Any(x => x.MaV.Equals(vc.MaV))))
                {
                    Them(vc);
                }
            });
        }
        public List<tblSoHuuVoucher> CoTheSuDung(List<tblSoHuuVoucher> DSSHVc, int TongTien)
        {
            return DSSHVc.Where(x => x.NgayKetThuc > DateTime.Now && x.TinhTrang == 0 && x.tblVoucher.GTToiThieu < TongTien).ToList();
        }
    }
}

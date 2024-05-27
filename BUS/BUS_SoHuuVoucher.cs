using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_SoHuuVoucher
    {
        DAL_SoHuuVoucher DAL_SoHuuVoucher = new DAL_SoHuuVoucher();
        DAL_Voucher DAL_Voucher = new DAL_Voucher();

        public void Them(tblSoHuuVoucher SHVc)
        {
            if (!DsSoHuuVoucher().Exists(x => x.MaSHVc.Equals(SHVc.MaSHVc)))
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
            while (DsSoHuuVoucher().Exists(x => x.MaSHVc.Trim().Equals("SH" + i)))
            {
                i++;
            }
            return "SH" + i;
        }
        public List<tblSoHuuVoucher> DsSoHuuVoucher_TheoMaKH(string MaKH) => DsSoHuuVoucher().FindAll(x => x.MaKH.Equals(MaKH));
        public void TangVoucher(DataGridView dtg, tblKhachHang KH, int HSD)
        {
            var DsMaVc = dtg.Rows.Cast<DataGridViewRow>().ToList()
                .Where(r => r.Cells["Check"].Value != null && r.Cells["Check"].Value.Equals(true))
                .Select(r => r.Cells["MaV"].Value.ToString()).ToList();
            var DSSHVc = DsSoHuuVoucher_TheoMaKH(KH.MaKH);
            foreach (var MaV in DsMaVc)
            {
                var vc = DAL_Voucher.GetById(MaV);
                if (!(vc.Loai.Equals(0) && DSSHVc.Any(x => x.MaV.Equals(vc.MaV))))
                {
                    tblSoHuuVoucher SHVc = new tblSoHuuVoucher()
                    {
                        MaSHVc = MaTuDong(),
                        MaV = MaV,
                        MaKH = KH.MaKH,
                        NgayBatDau = DateTime.Now,
                        NgayKetThuc = DateTime.Now.AddDays(HSD),
                        TinhTrang = 0
                    };
                    Them(SHVc);
                }
            }
        }
        public List<tblSoHuuVoucher> CoTheSuDung(List<tblSoHuuVoucher> DSSHVc, int TongTien)
        {
            return DSSHVc.Where(x => x.NgayKetThuc > DateTime.Now
                                    && x.TinhTrang == 0
                                    && x.tblVoucher.GTToiThieu < TongTien).ToList();

        }
        public void dtg_Filter_KhaDung(DataGridView dtg)
        {
            dtg.Rows.Cast<DataGridViewRow>().ToList().ForEach(r =>
            {
                var han = r.Cells["NgayKetThuc"].Value;
                var tt = r.Cells[5].Value;
                if (han != null)
                {
                    r.Visible = false;
                    if (Convert.ToDateTime(han) >= DateTime.Now && tt != null && (int)tt == 0)
                    {
                        r.Visible = true;
                    }
                }
            });
        }
        public void dtg_Filter_HetHan(DataGridView dtg)
        {
            dtg.Rows.Cast<DataGridViewRow>().ToList().ForEach(r =>
            {
                var han = r.Cells["NgayKetThuc"].Value;
                var tt = r.Cells["TinhTrang"].Value;
                if (han != null)
                {
                    r.Visible = false;
                    if (Convert.ToDateTime(han) < DateTime.Now && tt != null && (int)tt == 1)
                    {
                        r.Visible = true;
                    }
                }
            });
        }
        public void SHVc_Status(DataGridView dtg)
        {
            dtg.Rows.Cast<DataGridViewRow>().ToList().ForEach(r =>
            {
                var isChecked = r.Cells[0].Value;
                var MaSHVc = r.Cells["MaSHVc"].Value;
                if (MaSHVc != null)
                {
                    var SHVc = DAL_SoHuuVoucher.GetById(MaSHVc.ToString());
                    if (isChecked != null && isChecked is true)
                    {
                        SHVc.TinhTrang = 1;
                        DAL_SoHuuVoucher.Sua_TinhTrang(SHVc);
                    }
                    else
                    {
                        SHVc.TinhTrang = 0;
                        DAL_SoHuuVoucher.Sua_TinhTrang(SHVc);
                    }
                }
            });
        }
    }
}

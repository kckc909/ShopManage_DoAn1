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
                i++;
            }
            return $"V{i}";
        }
        public tblVoucher LayTheoMa(string MaV) => DSVoucher().Find(x => x.MaV.Equals(MaV));
        public void Filter_None(DataGridView dtg)
        {
            dtg.Rows.Cast<DataGridViewRow>().ToList().ForEach(x => x.Visible = true);
        }
        public void Filter_CoTheTang(DataGridView dtg, tblKhachHang KH)
        {
            dtg.Rows.Cast<DataGridViewRow>().ToList().ForEach(r =>
            {
                if (r.Cells[1].Value != null)
                {
                    r.Visible = false;
                    var vc = LayTheoMa(r.Cells[1].Value.ToString());
                    if (vc.Loai == 1 || !vc.tblSoHuuVouchers.ToList().Any(x => x.MaKH.Equals(KH.MaKH)))
                    {
                        r.Visible = true;
                    }
                }
            });
        }
        public void Filter_KhongTheTang(DataGridView dtg, tblKhachHang KH)
        {
            dtg.Rows.Cast<DataGridViewRow>().ToList().ForEach(r =>
            {
                if (r.Cells[1].Value != null)
                {
                    r.Visible = false;
                    var vc = LayTheoMa(r.Cells[1].Value.ToString());
                    if (vc.Loai == 0 && vc.tblSoHuuVouchers.ToList().Any(x => x.MaKH.Equals(KH.MaKH)))
                    {
                        r.Visible = true;
                    }
                }
            });
        }
        public void Filter_TimKiem(DataGridView dtg, string ss)
        {
            dtg.Rows.Cast<DataGridViewRow>().ToList().ForEach(r =>
            {
                if (r.Cells[1].Value != null)
                {
                    r.Visible = false;
                    if (r.Cells.Cast<DataGridViewCell>().ToList().Any(c => c.Value.ToString().Contains(ss)))
                    {
                        r.Visible = true;
                    }
                }
            });
        }
    }
}

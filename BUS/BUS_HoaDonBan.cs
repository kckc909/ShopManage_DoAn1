using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_HoaDonBan
    {
        DAL_HoaDonBan DAL_HoaDonBan = new DAL_HoaDonBan();
        public void Them(tblHoaDonBan hdb)
        {
            DAL_HoaDonBan.Them(hdb);
        }
        public void Sua(tblHoaDonBan _old, tblHoaDonBan _new)
        {
            DAL_HoaDonBan.Sua(_old, _new);
        }
        public void Sua_TinhTrang(string MaHDB, int TinhTrang)
        {
            if (DS_HDB().Any(x => x.MaHDB.Equals(MaHDB)))
            {
                DAL_HoaDonBan.Sua_TinhTrang(MaHDB, TinhTrang);
            }
        }
        public void Xoa(string MaHDB)
        {
            DAL_HoaDonBan.Xoa(DS_HDB().Find(x => x.MaHDB.Trim().Equals(MaHDB.Trim())));
        }
        public tblHoaDonBan HDB_LayTheoMa(string MaHDB)
        {
            return DS_HDB().Find(x => x.MaHDB.Trim().Equals(MaHDB.Trim()));
        }
        public List<tblHoaDonBan> DS_HDB()
        {
            return DAL_HoaDonBan.DanhSachHoaDonBan();
        }
        public void Loc_HDChuaTT(DataGridView dtg)
        {
            var ds = DS_HDB().ToList();
            dtg.Rows.Cast<DataGridViewRow>().ToList().ForEach(r =>
            {
                r.Visible = false;
                if (r.Cells["TT"].Value.Equals(0))
                {
                    r.Visible |= true;
                }
            });
        }
        public void Loc_HĐaTT(DataGridView dtg)
        {
            var ds = DS_HDB().ToList();
            dtg.Rows.Cast<DataGridViewRow>().ToList().ForEach(r =>
            {
                r.Visible = false;
                if (r.Cells["TT"].Value.Equals(1))
                {
                    r.Visible |= true;
                }
            });
        }
        public void Loc_TimKiem(DataGridView dtg, string s, int TinhTrang)
        {
            foreach (DataGridViewRow r in dtg.Rows)
            {
                r.Visible = false;
                r.Cells["TT"].Value = TinhTrang;
                foreach (DataGridViewCell c in r.Cells)
                {
                    if (c.Value.ToString().Contains(s))
                    {
                        r.Visible = true;
                    }
                }
            }
        }
        public string MaTuDong()
        {
            return DateTime.Now.ToString("ddMMyyyyHHmmssff");
        }
        public double Tinh_TongTien(tblHoaDonBan HDB)
        {
            if (HDB.tblChiTietHDBs.Count == 0)
                return 0;
            return HDB.tblChiTietHDBs.Sum(x => x.SoLg * x.GiaBan).Value;
        }
        public double Tinh_TongGiamGia(tblHoaDonBan HDB, double TongTien = 0)
        {
            if (TongTien == 0)
            {
                TongTien = Tinh_TongTien(HDB);
            }
            if (HDB.tblApDungVouchers.Count == 0)
            {
                return 0;
            }
            else
            {
                double TongGiamGia = 0;
                double temp;
                HDB.tblApDungVouchers.ToList().ForEach(x =>
                {
                    if (x.tblVoucher.DonVi.Equals("%"))
                    {
                        temp = (x.tblVoucher.GiaTri * TongGiamGia / 100).Value;
                        if (temp > x.tblVoucher.GTToiDa)
                        {
                            temp = x.tblVoucher.GTToiDa.Value;
                        }
                        TongGiamGia += temp;
                    }
                    else
                    {
                        TongGiamGia += x.tblVoucher.GiaTri.Value;
                    }
                });
                return TongGiamGia;
            }
        }
        public double Tinh_ThanhTien(double TongTien, double TongGiam)
        {
            return TongTien - TongGiam;
        }
    }
}

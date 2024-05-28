using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_HoaDonNhap
    {
        DAL_HoaDonNhap dal_HoaDonNhap = new DAL_HoaDonNhap();
        DAL_ChiTietHDN dal_ChiTietHDN = new DAL_ChiTietHDN();
        DAL_MatHang dal_MatHang = new DAL_MatHang();
        // HDN
        public void HDN_Add(tblHoaDonNhap HDN)
        {
            dal_HoaDonNhap.Add(HDN);
        }
        public void HDN_Change(tblHoaDonNhap HDN)
        {
            dal_HoaDonNhap.Change(HDN);
        }
        public void HDN_Change_Status_Off(tblHoaDonNhap HDN)
        {
            dal_HoaDonNhap.Change_Status_Off(HDN);
        }
        public void HDN_Delete(tblHoaDonNhap HDN)
        {
            dal_HoaDonNhap.Delete(HDN);
        }
        public tblHoaDonNhap HDN_GetById(string MaHDN)
        {
            return dal_HoaDonNhap.GetByID(MaHDN);
        }
        public List<tblHoaDonNhap> HDN_GetAll()
        {
            return dal_HoaDonNhap.GetAll();
        }
        // CTHDN
        public void CT_AddRange(List<tblChiTietHDN> DS_CTHDN, string MaHDN)
        {
            List<tblChiTietHDN> DelLst = dal_ChiTietHDN.GetById_HDN(MaHDN)
                .Where(x => !DS_CTHDN.Any(y => x.MaMH.Equals(y.MaMH))).ToList();
            dal_ChiTietHDN.AddRange(DS_CTHDN);
        }
        public void CT_DeleteRange(List<tblChiTietHDN> DS_CTHDN)
        {
            dal_ChiTietHDN.DeleteRange(DS_CTHDN);
        }
        public List<tblChiTietHDN> CT_GetByID_HDN(string MaHDN)
        {
            return dal_ChiTietHDN.GetById_HDN(MaHDN);
        }
        // Logic HDN
        public string AutomatiicID()
        {
            return DateTime.Now.ToString("ddMMyyyyHHmmssff");
        }
        public void HDN_dtg_Filter(DataGridView dtg, int TinhTrang)
        {
            dtg.Rows.Cast<DataGridViewRow>().ToList().ForEach(r =>
            {
                r.Visible = false;
                if (r.Cells["TT"].Value.Equals(TinhTrang))
                {
                    r.Visible = true;
                }
            });
        }
        public void HDN_dtg_Search(DataGridView dtg, string ss)
        {
            dtg.Rows.Cast<DataGridViewRow>().ToList().ForEach(r =>
            {
                r.Visible = false;
                var cells = r.Cells.Cast<DataGridViewCell>().ToList();
                if (cells.Any(x => x != null && x.Value.ToString().Contains(ss)))
                {
                    r.Visible = true;
                }
            });
            // Logic CTHDN
        }
        public int HDN_TinhTien(string MaHDN)
        {
            dal_ChiTietHDN = new DAL_ChiTietHDN();
            var HDN = dal_HoaDonNhap.GetByID(MaHDN);
            int TongTien = 0;

            foreach (var CTHDN in HDN.tblChiTietHDNs)
            {
                TongTien += (CTHDN.SoLg * CTHDN.GiaNhap).Value;
            }

            return TongTien;
        }
        public void MH_ThayDoiSoLuong(List<tblChiTietHDN> DS_CTHDN)
        {
            List<tblMatHang> DSMH = new List<tblMatHang>();
            DS_CTHDN.ForEach(x =>
            {
                DSMH.Add(new tblMatHang() { MaMH = x.MaMH, SoLuong = x.SoLg});
            });
                dal_MatHang.Sua_DSMH_TangSoLuong(DSMH);
        }
    }
}

﻿using DAL;
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
        DAL_HoaDonBan dal_HoaDonBan = new DAL_HoaDonBan();
        DAL_ChiTietHDB dal_ChiTietHDB = new DAL_ChiTietHDB();
        DAL_Voucher dal_Voucher = new DAL_Voucher();
        DAL_ApDungVoucher dal_ApDungVoucher = new DAL_ApDungVoucher();

        // HDB
        public void HDB_Add(tblHoaDonBan HDB)
        {
            dal_HoaDonBan.Add(HDB);
        }
        public void HDB_Change(tblHoaDonBan HDB)
        {
            dal_HoaDonBan.Change(HDB);
        }
        public void HDB_Change_Status_Off(tblHoaDonBan HDB)
        {
            dal_HoaDonBan.Change_Status_Off(HDB);
        }
        public void HDB_Delete(tblHoaDonBan HDB)
        {
            dal_HoaDonBan.Delete(HDB);
        }
        public tblHoaDonBan HDB_GetById(string MaHDB)
        {
            return dal_HoaDonBan.GetByID(MaHDB);
        }
        public List<tblHoaDonBan> HDB_GetAll()
        {
            return dal_HoaDonBan.GetAll();
        }
        // CTHDB
        public void CT_AddRange(List<tblChiTietHDB> DS_CTHDB)
        {
            dal_ChiTietHDB.AddRange(DS_CTHDB);
        }
        public void CT_DeleteRange(List<tblChiTietHDB> DS_CTHDB)
        {
            dal_ChiTietHDB.DeleteRange(DS_CTHDB);
        }
        public List<tblChiTietHDB> CT_GetByID_HDB(string MaHDB)
        {
            return dal_ChiTietHDB.GetById_HDB(MaHDB);
        }
        // Logic
        public string AutomatiicID()
        {
            return DateTime.Now.ToString("ddMMyyyyHHmmssff");
        }
        public void HDB_dtg_Filter(DataGridView dtg, int TinhTrang)
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
        public void HDB_dtg_Search(DataGridView dtg, string ss)
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
        }
        public int[] HDB_TinhTien(string MaHDB)
        {
            tblHoaDonBan HDB = dal_HoaDonBan.GetByID(MaHDB);
            int TongTien = 0;

            foreach (tblChiTietHDB CTHDB in HDB.tblChiTietHDBs)
            {
                TongTien += (CTHDB.SoLg * CTHDB.GiaBan * (1 - CTHDB.tblKhuyenMai.PhamTramGiam / 100)).Value;
            }

            int TongGiam = 0;
            foreach (tblApDungVoucher vc in HDB.tblApDungVouchers)
            {
                if (vc.tblVoucher.DonVi.Trim().Equals("%"))
                {
                    TongGiam += (TongTien * vc.tblVoucher.GiaTri / 100).Value;
                }
                else
                {
                    TongGiam += vc.tblVoucher.GiaTri.Value;
                }
            }
            return new int[] { TongTien, TongGiam, TongTien - TongGiam };
        }
    }
}

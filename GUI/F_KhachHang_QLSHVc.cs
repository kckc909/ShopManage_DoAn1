using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace GUI
{
    public partial class F_KhachHang_QLSHVc : Form
    {
        public event EventHandler Event_Closed;
        BUS_SoHuuVoucher BUS_SoHuuVoucher = new BUS_SoHuuVoucher();
        BUS_Voucher BUS_Voucher = new BUS_Voucher();
        tblKhachHang KhachHang;
        string MaSHVC_Current;
        public F_KhachHang_QLSHVc(tblKhachHang khachHang)
        {
            InitializeComponent();
            KhachHang = khachHang;
        }

        void dtg_Modify()
        {
            dtg.AutoGenerateColumns = false;
        }

        void dtg_AddColumns()
        {
            dtg.Columns.Add("MaSHVc", "Mã sở hữu");
            dtg.Columns.Add("MaV", "Mã vocuher");
            dtg.Columns.Add("GiaTri", "Giá trị");
            dtg.Columns.Add("DonVi", "Đơn vị");
            dtg.Columns.Add("NgayKetThuc", "Ngày kết thúc");
        }

        void dtg_LoadData()
        {
            dtg.Rows.Clear();
            var DSSHVc = BUS_SoHuuVoucher.DsSoHuuVoucher_TheoMaKH(KhachHang.MaKH);
            foreach (var SHVc in DSSHVc)
            {
                var Vc = BUS_Voucher.LayTheoMa(SHVc.MaV);
                dtg.Rows.Add(SHVc.MaSHVc, Vc.MaV, Vc.GiaTri, Vc.DonVi, SHVc.NgayKetThuc);
            }
        }

        void Catch_Event_ThemThanhCong(object sender, EventArgs e)
        {
            dtg_LoadData();
            ((Form)sender).Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            F_KhachHang_TangVoucher F = new F_KhachHang_TangVoucher(KhachHang);
            F.Event_ThemThanhCong += Catch_Event_ThemThanhCong;
            F.Show();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Close();
            Event_Closed?.Invoke(this, EventArgs.Empty);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtg.SelectedRows.Count > 0)
            {
                var cv = dtg.SelectedRows[0].Cells[0].Value;
                if (cv != null)
                {
                    if (MessageBox.Show("Bạn có muốn xóa voucher này không !", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        BUS_SoHuuVoucher.Xoa(MaSHVC_Current);
                        dtg_LoadData();
                    }
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            BUS_Voucher.Filter_TimKiem(dtg, txtTimKiem.Text);
        }

        private void dtg_SelectionChanged(object sender, EventArgs e)
        {
            if (dtg.SelectedRows.Count > 0)
            {
                if (dtg.SelectedRows[0].Cells[0].Value != null)
                {
                    MaSHVC_Current = dtg.SelectedRows[0].Cells[0].Value.ToString();
                }
            }
        }

        private void F_KhachHang_QLSHVc_Load(object sender, EventArgs e)
        {
            dtg_Modify();
            dtg_AddColumns();
            dtg_LoadData();
        }

        private void cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo.SelectedIndex == 0)
            {
                BUS_SoHuuVoucher.dtg_Filter_KhaDung(dtg);
            }
            else
            {
                BUS_SoHuuVoucher.dtg_Filter_HetHan(dtg);
            }
        }
    }
}

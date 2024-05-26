using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class F_HoaDon_TT_Voucher : Form
    {
        public event EventHandler Event_VoucherChanged;
        BUS_KhachHang BUS_KhachHang = new BUS_KhachHang();
        BUS_SoHuuVoucher BUS_SoHuuVoucher = new BUS_SoHuuVoucher();
        BUS_ApDungVoucher BUS_ApDungVoucher = new BUS_ApDungVoucher();
        
        List<tblSoHuuVoucher> DSSHVc = null;
        string MaKH;
        string MaHDB;
        int TongTien;
        
        public F_HoaDon_TT_Voucher(string MHDB, string MaKH, int TongTien)
        {
            InitializeComponent();
            MaHDB = MHDB;
            DSSHVc = BUS_SoHuuVoucher.DsSoHuuVoucher_TheoMaKH(MaKH);
            this.MaKH = MaKH;
            this.TongTien = TongTien;
        }

        void Load_Infomation()
        {
            var KH = BUS_KhachHang.LayTheoMa(MaKH);
            lbMaKH.Text = KH.MaKH;
            lbTenKH.Text = KH.TenKH;
        }

        void dtg_Modify()
        {
            dtg.AutoGenerateColumns = false;
        }

        void dtg_AddColumns()
        {
            dtg.Columns.Add(new DataGridViewCheckBoxColumn()
            {
                Name = "Check",
                HeaderText = "Áp dụng"
            });
            dtg.Columns.Add("MaV", "Mã Voicher");
            dtg.Columns.Add("TenV", "Tên Voucher");
            dtg.Columns.Add("GiaTri", "Giá trị");
            dtg.Columns.Add("DonVi", "Đơn vị");
            dtg.Columns.Add("GTToiThieu", "Mức tối thiểu");
            dtg.Columns.Add("GTToiDa", "Giảm tối đa");
            dtg.Columns.Add("MaSHVc", "MaSHVc");
        }

        void dtg_LoadData()
        {
            var lstSHVc = BUS_SoHuuVoucher.CoTheSuDung(DSSHVc, TongTien);
            int i = 0;
            foreach (tblSoHuuVoucher SHVc in lstSHVc)
            {
                dtg.Rows.Add(false);
                dtg.Rows[i].Cells[1].Value = SHVc.MaV;
                dtg.Rows[i].Cells[2].Value = SHVc.tblVoucher.TenV;
                dtg.Rows[i].Cells[3].Value = SHVc.tblVoucher.GiaTri;
                dtg.Rows[i].Cells[4].Value = SHVc.tblVoucher.DonVi;
                dtg.Rows[i].Cells[5].Value = SHVc.tblVoucher.GTToiThieu;
                dtg.Rows[i].Cells[6].Value = SHVc.tblVoucher.GTToiDa;
                dtg.Rows[i].Cells[7].Value = SHVc.MaSHVc;
                i++;
            }
        }

        void Raise_Event_VoucherChanged()
        {
            var dsadvc = BUS_ApDungVoucher.dtg_ApDungVoucher(dtg, MaHDB);
            Event_VoucherChanged?.Invoke(this , EventArgs.Empty);
        }

        private void F_HoaDon_TT_Voucher_Load(object sender, EventArgs e)
        {
            Load_Infomation();
            dtg_Modify();
            dtg_AddColumns();
            dtg_LoadData();
            BUS_ApDungVoucher.dtg_Checked(dtg, MaHDB);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnApDung_Click(object sender, EventArgs e)
        {
            Raise_Event_VoucherChanged();
            // thay đổi trạng thái của sở hữu voucher
            BUS_SoHuuVoucher.SHVc_Status(dtg);
        }

        private void dtg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg.SelectedRows.Count > 0)
            {
                if (dtg.SelectedRows[0].Cells[0].Value != null)
                {
                    dtg.SelectedRows[0].Cells[0].Value = !(bool)dtg.SelectedRows[0].Cells[0].Value;
                }
                else
                {
                    dtg.SelectedRows[0].Cells[0].Value = true;
                }
            }
        }
    }
}

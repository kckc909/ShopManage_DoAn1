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
        BUS_SoHuuVoucher BUS_SoHuuVoucher = new BUS_SoHuuVoucher();
        BUS_ApDungVoucher BUS_ApDungVoucher = new BUS_ApDungVoucher();
        
        List<tblSoHuuVoucher> DSSHVc = null;
        string MaHDB;
        int TongTien;

        public F_HoaDon_TT_Voucher(string MHDB, string MaKH, int TongTien)
        {
            InitializeComponent();
            MaHDB = MHDB;
            DSSHVc = BUS_SoHuuVoucher.DsSoHuuVoucher_TheoMaKH(MaKH);
            this.TongTien = TongTien;
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
        }

        void dtg_LoadData()
        {
            dtg.DataSource = BUS_SoHuuVoucher.CoTheSuDung(DSSHVc, TongTien);
            dtg.Columns[1].DataPropertyName = "MaV";
            dtg.Columns[2].DataPropertyName = "TenV";
            dtg.Columns[3].DataPropertyName = "GiaTri";
            dtg.Columns[4].DataPropertyName = "DonVi";
            dtg.Columns[5].DataPropertyName = "GTToiThieu";
            dtg.Columns[6].DataPropertyName = "GTToiDa";
        }

        void dtg_Checked()
        {
            BUS_ApDungVoucher.dtg_Checked(dtg, MaHDB);
        }

        void Raise_Event_VoucherChanged()
        {
            var dsadvc = BUS_ApDungVoucher.dtg_ApDungVoucher(dtg, MaHDB);
            Event_VoucherChanged?.Invoke(this , EventArgs.Empty);
        }

        private void F_HoaDon_TT_Voucher_Load(object sender, EventArgs e)
        {
            dtg_Modify();
            dtg_AddColumns();
            dtg_LoadData();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnApDung_Click(object sender, EventArgs e)
        {
            Raise_Event_VoucherChanged();
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

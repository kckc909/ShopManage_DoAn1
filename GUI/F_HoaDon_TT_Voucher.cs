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
        BUS_SoHuuVoucher BUS_SoHuuVoucher = new BUS_SoHuuVoucher();
        BUS_ApDungVoucher BUS_ApDungVoucher=new BUS_ApDungVoucher();
        string MaHDB;
        List<tblSoHuuVoucher> DSSHVc = null;
        int TongTien;
        public F_HoaDon_TT_Voucher(string MHDB, List<tblSoHuuVoucher> dSSHVc, int TongTien)
        {
            InitializeComponent();
            MaHDB = MHDB;
            DSSHVc = dSSHVc;
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
            BUS_ApDungVoucher.dtg_ApDungVoucher(dtg, MaHDB);
        }
    }
}

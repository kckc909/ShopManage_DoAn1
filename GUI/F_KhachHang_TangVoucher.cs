using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class F_KhachHang_TangVoucher : Form
    {
        public event EventHandler ThemThanhCong;
        BUS_SoHuuVoucher BUS_SoHuuVoucher = new BUS_SoHuuVoucher();
        BUS_Voucher BUS_Voucher = new BUS_Voucher();
        tblKhachHang KH;
        public F_KhachHang_TangVoucher(tblKhachHang kh)
        {
            InitializeComponent();
            KH = kh;
        }

        void dtg_Modify()
        {
            dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        void dtg_AddColumn()
        {
            dtg.Columns.Add(new DataGridViewCheckBoxColumn()
            {
                Name = "Check",
                HeaderText = "   "
            });
            dtg.Columns.Add("MaV", "Mã Voucher");
            dtg.Columns.Add("TenV", "Tên Voucher");
            dtg.Columns.Add("MoTa", "Mô tả");
            dtg.Columns.Add("GiaTri", "Giá trị");
            dtg.Columns.Add("DonVi", "Đơn vị");
            dtg.Columns.Add("GTToiThieu", "Tối thiểu để áp dụng");
            dtg.Columns.Add("GTToiDa", "Hạn mức tối đa");
            dtg.Columns.Add("Loai", "Loại");
        }

        void dtg_LoadData(List<tblVoucher> DSVc)
        {
            int i = 0;
            foreach (tblVoucher vc in DSVc)
            {
                dtg.Rows.Add(false);
                dtg.Rows[i].Cells[1].Value = vc.MaV;
                dtg.Rows[i].Cells[2].Value = vc.TenV;
                dtg.Rows[i].Cells[3].Value = vc.MoTa;
                dtg.Rows[i].Cells[4].Value = vc.GiaTri;
                dtg.Rows[i].Cells[5].Value = vc.DonVi;
                dtg.Rows[i].Cells[6].Value = vc.GTToiThieu;
                dtg.Rows[i].Cells[7].Value = vc.GTToiDa;
                if (vc.Loai == 0)
                {
                    dtg.Rows[i].Cells[8].Value = "1";
                }
                else
                {
                    dtg.Rows[i].Cells[8].Value = "n";
                }
                i++;
            }
        }

        void cbo_LoadData()
        {
            cboFilter.Items.Add("Tất cả");
            cboFilter.Items.Add("Có thể tặng");
            cboFilter.Items.Add("Không thể tặng");
        }

        private void dtg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dtg.Rows[e.RowIndex].Cells[0].Value is true)
                {
                    dtg.Rows[e.RowIndex].Cells[0].Value = false;
                }
                else
                {
                    dtg.Rows[e.RowIndex].Cells[0].Value = true;
                }
            }
        }

        private void cboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFilter.SelectedIndex == 0)
            {
                BUS_Voucher.Filter_None(dtg);
            }
            else if (cboFilter.SelectedIndex == 1)
            {
                BUS_Voucher.Filter_CoTheTang(dtg, KH);
            }
            else
            {
                BUS_Voucher.Filter_KhongTheTang(dtg, KH);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtg.Rows)
            {
                row.Visible = false;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value.ToString().Contains(txtTimKiem.Text))
                    {
                        row.Visible |= true;
                        break;
                    }
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var DsMaVc = dtg.Rows.Cast<DataGridViewRow>().ToList()
                .Where(r => (bool)r.Cells["Check"].Value)
                .Select(r => r.Cells["MaV"].Value.ToString()).ToList();
            BUS_SoHuuVoucher.TangVoucher(BUS_SoHuuVoucher.DsSoHuuVoucher().Where(vc => DsMaVc.Contains(vc.MaV)).ToList(), KH);
            ThemThanhCong?.Invoke(sender, e);
        }

        private void F_KhachHang_TangVoucher_Load(object sender, EventArgs e)
        {
            dtg_Modify();
            dtg_AddColumn();
            dtg_LoadData(BUS_Voucher.DSVoucher());
            cbo_LoadData();
        }
    }
}

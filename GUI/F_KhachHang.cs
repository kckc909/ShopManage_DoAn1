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
    public partial class F_KhachHang : Form
    {
        BUS_KhachHang BUS_KhachHang = new BUS_KhachHang();
        tblKhachHang Current;
        public F_KhachHang()
        {
            InitializeComponent();
        }

        void ModifyDtg()
        {
            dtgDSKH.AutoGenerateColumns = false;
            dtgDSVcSH.AutoGenerateColumns = false;
        }

        void AddColumnDtg()
        {
            dtgDSKH.Columns.AddRange(new DataGridViewColumn[]
            {
                new DataGridViewColumn() {Name = "MaKH", DataPropertyName = "MaKH", HeaderText = "Mã khách hàng"},
                new DataGridViewColumn() {Name = "TenKH", DataPropertyName = "TenKH", HeaderText = "Tên khách hàng"},
                new DataGridViewColumn() {Name = "SDT", DataPropertyName = "SDT", HeaderText = "Số điện thoại"}
            });
            dtgDSVcSH.Columns.AddRange(new DataGridViewColumn[]
            {
                new DataGridViewColumn() {Name = "MaV", DataPropertyName = "MaV", HeaderText = "Mã giảm giá"},
                new DataGridViewColumn() {Name = "GiaTri", DataPropertyName = "GiaTri", HeaderText = "Trị giá"},
                new DataGridViewColumn() {Name = "DonVi", DataPropertyName = "DonVi", HeaderText = "Đơn vị"},
                new DataGridViewColumn() {Name = "GTToiDa", DataPropertyName = "GTToiDa", HeaderText = "Hạn mức"},
                new DataGridViewColumn() {Name = "GTToiThieu", DataPropertyName = "GTToiThieu", HeaderText = "Mức tối thiểu"}
            });
        }
        void LoadDataDtgDSKH(List<tblKhachHang> DSKH)
        {
            dtgDSKH.DataSource = DSKH;
        }

        void LoadDataKhachHang()
        {
            if (Current is null)
            {
                txtMaKH.Clear();
                txtTenKH.Clear();
                txtSDT.Clear();
                dtgDSVcSH.Rows.Clear();
            }
            else
            {
                txtMaKH.Text = Current.MaKH;
                txtTenKH.Text = Current.TenKH;
                txtSDT.Text = Current.SDT;
                dtgDSVcSH.Rows.Clear();
                foreach (tblSoHuuVoucher shvc in Current.tblSoHuuVouchers)
                {
                    if (shvc.TinhTrang == MyDefault.Status_On)
                    {
                        tblVoucher vc = shvc.tblVoucher;
                        dtgDSVcSH.Rows.Add(vc.MaV, vc.GiaTri, vc.DonVi, vc.GTToiDa, vc.GTToiThieu);
                    }
                }
            }
        }

        private void F_KhachHang_SizeChanged(object sender, EventArgs e)
        {
            pnLeft.Width = pnLeft.Width == 400 ? 550 : 400;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            Current = null;
            LoadDataDtgDSKH(BUS_KhachHang.DSKH());
            LoadDataKhachHang();
        }

        private void btnTangVoucher_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (Current != null)
            {
                if (MessageBox.Show("Bạn có muốn xóa khách hàng không?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    BUS_KhachHang.Xoa(Current);
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn khách hàng muốn xóa");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            LoadDataKhachHang() ;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void chkVoucherUsed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dtgDSKH_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgDSKH.SelectedRows.Count > 0)
            {
                if (dtgDSKH.SelectedRows[0].Cells[0].Value != null)
                {
                    Current = BUS_KhachHang.LayTheoMa(dtgDSKH.SelectedRows[0].Cells["MaKH"].Value.ToString());
                    LoadDataKhachHang();
                }
            }
        }

        private void F_KhachHang_Load(object sender, EventArgs e)
        {
            ModifyDtg();
            AddColumnDtg();
            LoadDataDtgDSKH(BUS_KhachHang.DSKH());
        }
    }
}

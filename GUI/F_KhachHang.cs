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
        bool isQLSHVcOpened = false;
        public F_KhachHang()
        {
            InitializeComponent();
        }

        void Catch_ThemKhachHang(object sender, EventArgs e)
        {
            ((Form)sender).Close();
            MessageBox.Show("Thêm khách hàng thành công!");
        }
        void ModifyDtg()
        {
            dtgDSKH.AutoGenerateColumns = false;
        }

        void AddColumnDtg()
        {
            dtgDSKH.Columns.Add("MaKH", "Mã khách hàng");
            dtgDSKH.Columns.Add("TenKH", "Tên khách hàng");
            dtgDSKH.Columns.Add("SDT", "Số điện thoại");
        }
        void LoadDataDtgDSKH(List<tblKhachHang> DSKH)
        {
            if (DSKH.Count == 0)
            {
                DSKH.Add(MyDefault.KH);
                BUS_KhachHang.Them(MyDefault.KH);
            }
            dtgDSKH.DataSource = DSKH;
            dtgDSKH.Columns["MaKH"].DataPropertyName = "MaKH";
            dtgDSKH.Columns["TenKH"].DataPropertyName = "TenKH";
            dtgDSKH.Columns["SDT"].DataPropertyName = "SDT";
        }

        void LoadDataKhachHang()
        {
            if (Current is null)
            {
                txtMaKH.Clear();
                txtTenKH.Clear();
                txtSDT.Clear();
            }
            else
            {
                txtMaKH.Text = Current.MaKH;
                txtTenKH.Text = Current.TenKH;
                txtSDT.Text = Current.SDT;
            }
        }

        void Catch_ThemThanhCong(object sender, EventArgs e)
        {
            ((Form)sender).Close();
            MessageBox.Show("Đã thêm voucher cho khách hàng!");
            LoadDataDtgDSKH(BUS_KhachHang.DSKH());
        }

        void Catch_Event_Closed(object s, EventArgs e)
        {
            isQLSHVcOpened = false;
        }

        private void F_KhachHang_SizeChanged(object sender, EventArgs e)
        {

            if (pnLeft.Width > pnMain.Width && pnLeft.Width == 550)
            {
                pnLeft.Width = 400;
            }
            else
            {
                pnLeft.Width = 550;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            Current = null;
            LoadDataDtgDSKH(BUS_KhachHang.DSKH());
            LoadDataKhachHang();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (Current != null)
            {
                if (MessageBox.Show("Bạn có muốn xóa khách hàng không?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    BUS_KhachHang.Xoa(Current);
                    LoadDataDtgDSKH(BUS_KhachHang.DSKH());
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn khách hàng muốn xóa");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Current != null)
            {
                if (!txtTenKH.Text.Trim().Equals(""))
                {
                    if (!txtSDT.Text.Trim().Equals(""))
                    {
                        tblKhachHang kh = new tblKhachHang()
                        {
                            MaKH = txtMaKH.Text,
                            TenKH = txtTenKH.Text,
                            SDT = txtSDT.Text
                        };
                        BUS_KhachHang.Sua(Current, kh);
                        MessageBox.Show("Đã thay đổi thông tin khách hàng!");
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng không xóa trống số điện thoại khách hàng!");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng không xóa trông tên khách hàng!");
                }
            }
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            LoadDataKhachHang();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            F_KhachHang_ThemKhachHang f = new F_KhachHang_ThemKhachHang();
            f.ThemKhachHang += Catch_ThemKhachHang;
            f.ShowDialog();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtgDSKH.Rows)
            {
                if (row.Cells[0].Value != null)
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

        private void btnQLSHVc_Click(object sender, EventArgs e)
        {
            if (Current != null)
            {
                if (!isQLSHVcOpened)
                {
                    isQLSHVcOpened = true;
                    F_KhachHang_QLSHVc F = new F_KhachHang_QLSHVc(Current);
                    F.Dock = DockStyle.Fill;
                    F.TopLevel = false;
                    pnMain.Controls.Add(F);
                    F.Event_Closed += Catch_Event_Closed;
                    F.Show();
                    F.BringToFront();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng trước!");
            }
        }
    }
}

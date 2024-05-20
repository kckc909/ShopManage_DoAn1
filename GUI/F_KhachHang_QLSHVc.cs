using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class F_KhachHang_QLSHVc : Form
    {
        BUS_SoHuuVoucher BUS_SoHuuVoucher = new BUS_SoHuuVoucher();
        tblKhachHang KH;

        public F_KhachHang_QLSHVc(tblKhachHang kH)
        {
            InitializeComponent();
            KH = kH;
        }

        void Catch_ThemThanhCong(object sender, EventArgs e)
        {
            ((Form)sender).Close();
            MessageBox.Show("Đã thêm voucher cho khách hàng!");
        }

        void dtg_AddColumn()
        {
            dtg.Columns.Add("MaSHVc", "Mã số");
            dtg.Columns.Add("TenV", "Tên Voucher");
            dtg.Columns.Add("MoTa", "Mô tả");
            dtg.Columns.Add("GiaTri", "Giá trị");
            dtg.Columns.Add("DonVi", "DonVi");
            dtg.Columns.Add("TinhTrang", "Tình trạng");
            dtg.Columns.Add("NgayKetThuc", "Ngày hết hạn");
        }

        void dtg_LoadData(List<tblSoHuuVoucher> DsSHVc)
        {
            dtg.Rows.Clear();
            int i = 0;
            foreach (tblSoHuuVoucher shvc in DsSHVc)
            {
                dtg.Rows.Add(shvc.MaSHVc);
                dtg.Rows[i].Cells[1].Value = shvc.tblVoucher.TenV;
                dtg.Rows[i].Cells[2].Value = shvc.tblVoucher.MoTa;
                dtg.Rows[i].Cells[3].Value = shvc.tblVoucher.GiaTri;
                dtg.Rows[i].Cells[4].Value = shvc.tblVoucher.DonVi;
                if (shvc.TinhTrang == MyDefault.Status_On)
                {
                    dtg.Rows[i].Cells[5].Value = "Chưa sử dụng";
                }
                else
                {
                    dtg.Rows[i].Cells[5].Value = "Đã sử dụng";
                }
                dtg.Rows[i].Cells[6].Value = shvc.NgayKetThuc.Value.Date;
                i++;
            }
        }

        void cbo_LoadData()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Name");
            dataTable.Rows.Add(new[] { "1", "Tất cả" });
            dataTable.Rows.Add(new[] { "2", "Đã sử dụng" });
            dataTable.Rows.Add(new[] { "3", "Chưa sử dụng" });
            dataTable.Rows.Add(new[] { "4", "Đã hết hạn" });
            dataTable.Rows.Add(new[] { "5", "Có thể sử dụng" });
            cbo.DataSource = dataTable;
            cbo.ValueMember = "ID";
            cbo.DisplayMember = "Name";
        }

        private void F_KhachHang_QLSHVc_Load(object sender, EventArgs e)
        {
            cbo_LoadData();
            dtg_AddColumn();
            dtg_LoadData(KH.tblSoHuuVouchers.ToList());
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtg.Rows)
            {
                row.Visible = false;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value is null)
                    {
                        continue;
                    }
                    if (cell.Value.ToString().Contains(txtTimKiem.Text))
                    {
                        row.Visible |= true;
                        break;
                    }
                }
            }
        }

        private void cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbo.SelectedValue)
            {
                case "1":
                    dtg_LoadData(KH.tblSoHuuVouchers.ToList());
                    break;
                case "2":
                    dtg_LoadData(KH.tblSoHuuVouchers.ToList().FindAll(x => x.TinhTrang == 1));
                    break;
                case "3":
                    dtg_LoadData(KH.tblSoHuuVouchers.ToList().FindAll(x => x.TinhTrang == 0));
                    break;
                case "4":
                    dtg_LoadData(KH.tblSoHuuVouchers.ToList().FindAll(x => x.NgayKetThuc.Value > DateTime.Now));
                    break;
                case "5":
                    dtg_LoadData(KH.tblSoHuuVouchers.ToList().FindAll(x => x.TinhTrang == 0 && x.NgayKetThuc.Value > DateTime.Now));
                    break;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtg.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có muốn xóa voucher này khỏi danh sách voucher của khách hàng không?") == DialogResult.Yes)
                {
                    BUS_SoHuuVoucher.Xoa(dtg.SelectedRows[0].Cells[0].Value.ToString());
                    dtg.Rows.Remove(dtg.SelectedRows[0]);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            F_KhachHang_TangVoucher f = new F_KhachHang_TangVoucher(KH);
            f.ThemThanhCong += Catch_ThemThanhCong;
            f.ShowDialog();
        }
    }
}

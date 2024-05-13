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
    public partial class F_NhaCungCap : Form
    {
        BUS_NhaCungCap BUS_NhaCungCap = new BUS_NhaCungCap();
        tblNCC Current = null;

        public F_NhaCungCap()
        {
            InitializeComponent();
        }

        void Load_SelectedInformation()
        {
            if (Current == null)
            {
                return;
            }
            txtMaNCC.Text = Current.MaNCC;
            txtTenNCC.Text = Current.TenNCC;
            if (Current.SDT != null) txtSDT.Text = Current.SDT;
            if (Current.Email != null) txtEmail.Text = Current.Email;
            if (Current.DiaChi != null) txtDiaChi.Text = Current.DiaChi;
        }

        void Load_SupplierList(List<tblNCC> DSNCC)
        {
            dtg.DataSource = DSNCC;
            dtg.Columns["MaNCC"].DataPropertyName = "MaNCC";
            dtg.Columns["TenNCC"].DataPropertyName = "TenNCC";
            dtg.Columns["SDT"].DataPropertyName = "SDT";
        }

        void Add_Column()
        {
            dtg.Columns.Clear();
            dtg.Columns.Add("MaNCC", "Mã nhà cung cấp");
            dtg.Columns.Add("TenNCC", "Tên nhà cung cấp");
            dtg.Columns.Add("SDT", "Số điện thoại");
        }

        void Catch_AddSuccess(object o, EventArgs e)
        {
            Load_SupplierList(BUS_NhaCungCap.DanhSachNCC());
            MessageBox.Show("Đã thêm nhà cung cấp!");
        }

        private void F_NhaCungCap_Load(object sender, EventArgs e)
        {
            dtg.AutoGenerateColumns = false;
            Add_Column();
            Load_SupplierList(BUS_NhaCungCap.DanhSachNCC());
        }

        private void guna2DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dtg.SelectedRows.Count > 0)
            {
                var cell = dtg.SelectedRows[0].Cells[0];
                if (cell.Value != null)
                {
                    Current = BUS_NhaCungCap.GetById(cell.Value.ToString());
                    Load_SelectedInformation();
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            F_NhaCungCap_ThemNCC f_NhaCungCap_ThemNCC = new F_NhaCungCap_ThemNCC();
            f_NhaCungCap_ThemNCC.AddSuccess += Catch_AddSuccess;
            f_NhaCungCap_ThemNCC.Show();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Equals(txtMaNCC.Text, ""))
            {
                return;
            }
            if (MessageBox.Show("Bạn có muốn lưu thay đổi không?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                tblNCC _new = new tblNCC();
                _new = Current;
                _new.TenNCC = txtTenNCC.Text;
                _new.SDT = txtSDT.Text;
                _new.Email = txtEmail.Text;
                _new.DiaChi = txtDiaChi.Text;

                BUS_NhaCungCap.Sua(Current, _new);
            }
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            Load_SelectedInformation();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (Current != null)
            {
                if (MessageBox.Show("Bạn có muốn xóa nhà cung cấp không?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    BUS_NhaCungCap.Xoa(Current);
                    btnLamMoi_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp muốn xóa!");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Current = null;
            txtMaNCC.Clear();
            txtTenNCC.Clear();
            txtEmail.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtTimKiem.Clear();
            Load_SupplierList(BUS_NhaCungCap.DanhSachNCC());
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Load_SupplierList(BUS_NhaCungCap.DanhSachNCC(txtTimKiem.Text));
        }
    }
}

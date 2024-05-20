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
using System.Web.Caching;
using System.Windows.Forms;

namespace GUI
{
    public partial class F_TaiKhoan : Form
    {
        BUS_TaiKhoan BUS_TaiKhoan = new BUS_TaiKhoan();
        tblTaiKhoanMatKhau Current = null;

        public F_TaiKhoan()
        {
            InitializeComponent();
        }

        void dtg_Modify()
        {
            dtg.AutoGenerateColumns = false;
        }

        void dtg_AddColumn()
        {
            dtg.Columns.Clear();
            dtg.Columns.Add("TenTaiKhoan", "Tên tài khoản");
            dtg.Columns.Add("MatKhau", "Mật khẩu");
            dtg.Columns.Add("MaNV", "Mã nhân viên");
        }

        void dtg_LoadData()
        {
            dtg.DataSource = BUS_TaiKhoan.DSTK();
            dtg.Columns[0].DataPropertyName = "TaiKhoan";
            dtg.Columns[1].DataPropertyName = "MatKhau";
            dtg.Columns[2].DataPropertyName = "MaNV";
        }

        void LamMoi()
        {
            dtg_AddColumn();
            dtg_LoadData();
        }

        void LoadAccountInformation()
        {
            if (Current != null)
            {
                txtTenTK.Text = Current.TaiKhoan;
                txtMatKhau.Text = Current.MatKhau;
                txtMaNV.Text = Current.MaNV;
            }
        }

        private void F_TaiKhoan_Load(object sender, EventArgs e)
        {
            dtg_Modify();
            dtg_AddColumn();
            dtg_LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (Current!=null)
            {
                if (F_MainParent.NguoiDung.MaNV.Trim().Equals(Current.MaNV.Trim()))
                {
                    MessageBox.Show("Bạn không thể xóa tài khoản của mình!");
                    return;
                } 
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này không!","",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    BUS_TaiKhoan.Xoa(Current.TaiKhoan);
                    MessageBox.Show("Đã xóa tài khoản!");
                    LamMoi();
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            F_TaiKhoan_ThemTaiKhoan f = new F_TaiKhoan_ThemTaiKhoan();
            f.ShowDialog();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dtg.Rows.Cast<DataGridViewRow>().ToList().ForEach(r =>
            {
                r.Visible = false;
                if (r.Cells.Cast<DataGridViewCell>().ToList().Any(c => c.Value.ToString().Contains(txtTimKiem.Text)))
                {
                    r.Visible |= true;
                }
            });
        }

        private void dtg_SelectionChanged(object sender, EventArgs e)
        {
            if (dtg.SelectedRows.Count > 0)
            { 
                DataGridViewCell cell = dtg.SelectedRows[0].Cells[0];
                if (cell.Value != null)
                {
                    Current = BUS_TaiKhoan.TheoTenTaiKhoan(cell.Value.ToString()) ;
                    LoadAccountInformation();
                }
            }
        }
    }
}

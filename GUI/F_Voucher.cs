using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class F_Voucher : Form
    {
        BUS_Voucher BUS_Voucher = new BUS_Voucher();
        BUS_DonVi BUS_DonVi = new BUS_DonVi();
        tblVoucher Current = null;

        public F_Voucher()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            F_Voucher_ThemVoucher f_Voucher_ThemVoucher = new F_Voucher_ThemVoucher();
            f_Voucher_ThemVoucher.VoucherAdded += Catch_voucherAdded;
            f_Voucher_ThemVoucher.ShowDialog();
        }

        void Catch_voucherAdded(object sender, EventArgs e)
        {
            ((Form)sender).Close();
            Load_Data_DSVoucher(BUS_Voucher.DSVoucher());
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Load_Data_DSVoucher(BUS_Voucher.DSVoucher(txtTimKiem.Text));
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            foreach (var txt in this.Controls)
            {
                if (txt.GetType() == typeof(TextBox))
                {
                    ((TextBox)txt).Clear();
                }
            }
            Load_Data_DSVoucher(BUS_Voucher.DSVoucher());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaV.Text.Trim().Equals(""))
            {
                if (MessageBox.Show("Bạn có muốn xóa voucher này không ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    BUS_Voucher.Xoa(txtMaV.Text);
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn voucher muốn xóa!");
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Current != null)
            {
                var vc = new tblVoucher();
                vc = Current;
                if (txtTenV.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Tên voucher không thể trống!");
                    txtTenV.Focus();
                    return;
                }
                vc.TenV = txtTenV.Text;
                vc.MoTa = txtMoTa.Text;
                vc.DonVi = cboDonVi.SelectedValue.ToString();
                vc.GiaTri = Convert.ToInt32(txtGiaTri.Text);
                int temp;
                if (int.TryParse(txtGTToiThieu.Text, out temp))
                {
                    if (temp < 0)
                    {
                        temp = 0;
                    }
                    vc.GTToiThieu = temp;
                }
                else
                {
                    MessageBox.Show("Giá trị tối thiểu phải là số!");
                    return;
                }
                if (int.TryParse(txtGTToiDa.Text, out temp))
                {
                    if (temp > 0)
                    {
                        vc.GTToiDa = temp;
                    }
                    else
                    {
                        MessageBox.Show("Hạn mức phải lớn hơn 0!");
                        txtGTToiDa.Focus();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Hạn mức phải là số!");
                    txtGTToiThieu.Focus();
                    return;
                }
                vc.Loai = cboLoai.SelectedIndex;
                BUS_Voucher.Sua(_old: Current, _new: vc);
            }
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            Load_Info_Voucher();
        }

        private void F_Voucher_Load(object sender, EventArgs e)
        {
            dtg.AutoGenerateColumns = false;
            Add_Col_DSVoucher();
            Load_Data_DSVoucher(BUS_Voucher.DSVoucher());
            Load_Data_DonVi();
        }
        private void dtg_SelectionChanged(object sender, EventArgs e)
        {
            if (dtg.SelectedRows.Count > 0)
            {
                if (dtg.SelectedRows[0].Cells[0].Value != null)
                {
                    Current = BUS_Voucher.LayTheoMa(dtg.SelectedRows[0].Cells[0].Value.ToString());
                    Load_Info_Voucher();
                }
            }
        }

        void Add_Col_DSVoucher()
        {
            dtg.Columns.Clear();
            dtg.Columns.Add("MaV", "Mã voucher");
            dtg.Columns.Add("TenV", "Tên voucher");
            dtg.Columns.Add("GiaTri", "Mức giảm");
        }
        void Load_Data_DSVoucher(List<tblVoucher> DSVoucher)
        {
            dtg.DataSource = DSVoucher;
            dtg.Columns["MaV"].DataPropertyName = "MaV";
            dtg.Columns["TenV"].DataPropertyName = "TenV";
            dtg.Columns["GiaTri"].DataPropertyName = "GiaTri";
        }
        void Load_Data_DonVi()
        {
            cboDonVi.DataSource = BUS_DonVi.DS_DonVi();
            cboDonVi.ValueMember = "DonVi";
            cboDonVi.DisplayMember = "DonVi";
        }
        void Load_Info_Voucher()
        {
            if (Current != null)
            {
                txtMaV.Text = Current.MaV;
                txtTenV.Text = Current.TenV;
                txtMoTa.Text = Current.MoTa;
                if (Current.GiaTri != null)
                {
                    txtGiaTri.Text = Current.GiaTri.ToString();
                }
                else
                {
                    txtGiaTri.Clear();
                }
                cboDonVi.SelectedValue = Current.DonVi;
                if (Current.GTToiThieu != null)
                {
                    txtGTToiThieu.Text = Current.GTToiThieu.ToString();
                }
                else
                {
                    txtGTToiThieu.Clear();
                }
                if (Current.GTToiDa != null)
                {
                    txtGTToiDa.Text = Current.GTToiDa.ToString();
                }
                else
                {
                    txtGTToiDa.Clear();
                }
                if (Current.Loai != null)
                {
                    cboLoai.SelectedIndex = (int)Current.Loai;
                }
            }
        }

        private void F_Voucher_SizeChanged(object sender, EventArgs e)
        {
            if (pnLeft.Width == 400)
            {
                pnLeft.Width = 550;
            }
            else
            {
                pnLeft.Width = 400;
            }
            if (pnLeft.Width > pnMain.Width)
            {
                pnLeft.Width = 400;
            }
        }
    }
}

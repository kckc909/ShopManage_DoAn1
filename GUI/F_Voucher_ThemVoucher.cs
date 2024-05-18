using BUS;
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
    public partial class F_Voucher_ThemVoucher : Form
    {
        public event EventHandler VoucherAdded;
        BUS_Voucher BUS_Voucher = new BUS_Voucher();
        BUS_DonVi BUS_DonVi = new BUS_DonVi();

        public F_Voucher_ThemVoucher()
        {
            InitializeComponent();
        }

        private void F_Voucher_ThemVoucher_Load(object sender, EventArgs e)
        {
            cboDonVi.DataSource = BUS_DonVi.DS_DonVi();
            cboDonVi.ValueMember = "DonVi";
            cboDonVi.DisplayMember = "DonVi";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var vc = new DTO.tblVoucher();
            int _;
            vc.MaV = BUS_Voucher.MaTuDong();
            if (txtTenV.Text.Trim().Equals(""))
            {
                MessageBox.Show("Không thể để trống tên vocuher!");
                txtTenV.Focus();
                return;
            }
            vc.TenV = txtTenV.Text;
            vc.MoTa = txtMoTa.Text;
            vc.DonVi = cboDonVi.SelectedValue.ToString();
            if (int.TryParse(txtGiaTri.Text, out _))
            {
                if (vc.DonVi.Trim().Equals("%") && _ >= 100)
                {
                    MessageBox.Show("Giá trị của voucher không thể vượt quá 100%!");
                    txtGiaTri.Focus();
                    return;
                }
                vc.GiaTri = _;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập giá trị voucher");
                txtGiaTri.Focus();
                return;
            }
            if (int.TryParse(txtGTToiThieu.Text, out _))
            {
                vc.GTToiThieu = _;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mức tối thiểu để áp dụng voucher!");
                txtGTToiThieu.Focus();
                return;
            }
            if (int.TryParse(txtGTToiDa.Text, out _))
            {
                if (vc.DonVi.Trim().Equals("vnđ") && _ < vc.GiaTri)
                {
                    MessageBox.Show("Giá trị không thể lớn hơn hạn mức!");
                    txtGTToiDa.Focus();
                    return;
                }    
                vc.GTToiDa = _;
            }    
            else
            {
                MessageBox.Show("Vui lòng nhập hạn mức tối đa!");
                txtGTToiDa.Focus();
                return;
            }    
            vc.Loai = cboLoai.SelectedIndex;
            BUS_Voucher.Them(vc);
            VoucherAdded.Invoke(this, EventArgs.Empty);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtGTToiDa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}

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
    public partial class F_NhaCungCap_ThemNCC : Form
    {
        public event EventHandler AddSuccess;
        BUS_NhaCungCap BUS_NhaCungCap = new BUS_NhaCungCap();

        public F_NhaCungCap_ThemNCC()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            tblNCC nCC = new tblNCC();
            nCC.MaNCC = BUS_NhaCungCap.MaTuDong();
            if (txtTenNCC.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên nhà cung cấp!");
                txtTenNCC.Focus();
                return;
            }
            nCC.TenNCC = txtTenNCC.Text;
            if (txtSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại nhà cung cấp!");
                txtSDT.Focus();
                return;
            }
            nCC.SDT = txtSDT.Text;
            nCC.DiaChi = txtDiaChi.Text;
            nCC.Email = txtEmail.Text;
            BUS_NhaCungCap.Them(nCC);
            Raise_AddSuccess();
            Close();
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            Close();
        }

        void Raise_AddSuccess()
        {
            AddSuccess.Invoke(this, EventArgs.Empty);
        }
    }
}

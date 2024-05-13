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
using System.Web.Management;
using System.Windows.Forms;

namespace GUI
{
    public partial class F_LoaiHang_ThemLoaiHang : Form
    {
        public event EventHandler AddFinished;
        BUS_LoaiHang BUS_LoaiHang = new BUS_LoaiHang();

        public F_LoaiHang_ThemLoaiHang()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            tblLoaiHang LoaiHang = new tblLoaiHang();
            if (Equals(txtTenLH.Text,""))
            {
                MessageBox.Show("Vui lòng nhập tên loại hàng!");
                txtTenLH.Focus();
                return;
            }
            if (Equals(txtMoTa.Text, ""))
            {
                MessageBox.Show("Vui lòng mô tả loại hàng!");
                txtMoTa.Focus();
                return;
            }
            LoaiHang.MaLoai = BUS_LoaiHang.MaLoaiHangTuDong();
            LoaiHang.TenLoai = txtTenLH.Text;
            LoaiHang.MoTa = txtMoTa.Text;
            BUS_LoaiHang.Them(LoaiHang);
            Raise_AddFinished();
            Close();
        }

        private void F_LoaiHang_ThemLoaiHang_Load(object sender, EventArgs e)
        {
            txtTenLH.Focus();
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        void Raise_AddFinished()
        {
            AddFinished?.Invoke(this, new EventArgs());
        }
    }
}

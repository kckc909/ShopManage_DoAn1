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
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace GUI
{
    public partial class F_LoaiHang : Form
    {
        BUS_LoaiHang BUS_LoaiHang = new BUS_LoaiHang();
        tblLoaiHang SelectedItem = new tblLoaiHang();

        public F_LoaiHang()
        {
            InitializeComponent();
        }

        private void F_LoaiHang_SizeChanged(object sender, EventArgs e)
        {
            pnTT.Width = 550;
            if (pnDS.Width < pnTT.Width)
            {
                pnTT.Width = 400;
            }
        }

        private void F_LoaiHang_Load(object sender, EventArgs e)
        {
            dtgDSLH.AutoGenerateColumns = false;
            dtgDSMH.AutoGenerateColumns = false;
            LoadDanhSach();
            txtTimKiem.Focus();
        }

        void LoadDanhSach()
        {
            AddColumn();
            LoadData(BUS_LoaiHang.DanhSach());
        }

        void AddColumn()
        {
            dtgDSLH.Columns.Add("MaLoai", "Mã Loại");
            dtgDSLH.Columns.Add("TenLoai", "Tên Loại");
            dtgDSLH.Columns.Add("MoTa", "Mô Tả");

            dtgDSMH.Columns.Add("MaMH", "Mã mặt hàng");
            dtgDSMH.Columns.Add("TenMH", "Tên mặt hàng");
            dtgDSMH.Columns.Add("MoTa", "Mô tả");
        }

        void LoadData(List<tblLoaiHang> DSLH)
        {
            dtgDSLH.DataSource = DSLH;
            dtgDSLH.Columns["MaLoai"].DataPropertyName = "MaLoai";
            dtgDSLH.Columns["TenLoai"].DataPropertyName = "TenLoai";
            dtgDSLH.Columns["MoTa"].DataPropertyName = "MoTa";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            F_LoaiHang_ThemLoaiHang ThemLoaiHang = new F_LoaiHang_ThemLoaiHang();
            ThemLoaiHang.AddFinished += Catch_AddFinished;
            ThemLoaiHang.Show();
        }

        void Catch_AddFinished(object sender, EventArgs e)
        {
            btnRefresh(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!(SelectedItem is null || SelectedItem is default(tblLoaiHang)))
            {
                if (MessageBox.Show("Bạn có muốn xóa loại hàng không?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    BUS_LoaiHang.Xoa(SelectedItem.MaLoai);
                    btnRefresh(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại hàng muốn xóa!");
            }
        }

        void SelectedItemInfomation()
        {
            if (SelectedItem is null || SelectedItem is default(tblLoaiHang))
            {
                txtMaLH.Clear();
                txtTenLH.Clear();
                txtMoTa.Clear();
                dtgDSMH.DataSource = new DataTable();
                return;
            }

            txtMaLH.Text = SelectedItem.MaLoai;
            if (Equals(SelectedItem.TenLoai, "")) txtMaLH.Text = "";
            else txtTenLH.Text = SelectedItem.TenLoai;
            if (Equals(SelectedItem.MoTa, "")) txtMoTa.Text = "";
            else txtMoTa.Text = SelectedItem.MoTa;

            dtgDSMH.DataSource = BUS_LoaiHang.DSMatHangThamChieu(txtMaLH.Text);
            //dtgDSMH.DataSource = BUS_MatHang.DanhSachMatHangTheoMaLoai(txtMaLH.Text);
            dtgDSMH.Columns["MaMH"].DataPropertyName = "MaMH";
            dtgDSMH.Columns["TenMH"].DataPropertyName = "TenMH";
            dtgDSMH.Columns["MoTa"].DataPropertyName = "MoTa";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Equals(txtTenLH.Text, ""))
            {
                MessageBox.Show("Tên loại hàng không thể để trống!");
                txtTenLH.Focus();
                return;
            }
            if (Equals(txtMoTa.Text, ""))
            {
                MessageBox.Show("Hãy mô tả loại hàng!");
                txtMoTa.Focus();
                return;
            }
            if (MessageBox.Show("Bạn có muốn lưu thay đổi không!", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var _new = new tblLoaiHang();
                _new = SelectedItem;
                _new.MoTa = txtMoTa.Text;
                _new.TenLoai = txtTenLH.Text;
                BUS_LoaiHang.Sua(SelectedItem, _new);

                btnRefresh(sender, e);
            }
        }

        private void btnRefresh(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            LoadData(BUS_LoaiHang.DanhSach());
            SelectedItem = null;
            SelectedItemInfomation();
            txtTimKiem.Focus();
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            txtTenLH.Text = SelectedItem.TenLoai;
            txtMoTa.Text = SelectedItem.MoTa;
        }

        void TimKiem()
        {
            LoadData(BUS_LoaiHang.TimKiem(txtTimKiem.Text));
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                TimKiem();
                return;
            }
            if ((e.KeyChar != (char)Keys.Back) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dtgDSLH_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgDSLH.SelectedRows.Count > 0)
            {
                var ClickedItem = dtgDSLH.SelectedRows[0].Cells[0];
                if (ClickedItem.Value != null)
                {
                    SelectedItem = BUS_LoaiHang.LayLoaiHangTheoMaLoai(ClickedItem.Value.ToString());
                    SelectedItemInfomation();
                }
            }
        }
    }
}

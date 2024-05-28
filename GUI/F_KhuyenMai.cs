using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Web.Caching;
using System.Windows.Forms;

namespace GUI
{
    public partial class F_KhuyenMai : Form
    {
        BUS_KhuyenMai BUS_KhuyenMai = new BUS_KhuyenMai();
        tblKhuyenMai Current = null;

        public F_KhuyenMai()
        {
            InitializeComponent();
        }

        private void btbLamMoi_Click(object sender, EventArgs e)
        {
            LoadDataDSKM(BUS_KhuyenMai.DanhSach());
            LoadInfoKM();
            txtTimKiem.Clear();
            dtg.ClearSelection();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (Current != null)
            {
                if (MessageBox.Show("Bạn có muốn xóa khuyến mãi này không!") == DialogResult.Yes)
                {
                    BUS_KhuyenMai.Xoa(Current);
                    LoadDataDSKM(BUS_KhuyenMai.DanhSach());
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn khuyến mãi muốn xóa!");
                return;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            tblKhuyenMai km = Current;
            km.TenKM = txtTenKM.Text;
            km.MoTa = txtMoTa.Text;
            int _;
            if (int.TryParse(txtPhanTramgGiam.Text, out _))
            {
                if (_ >= 0 && _ <= 100)
                {
                    km.PhamTramGiam = _;
                }
                else
                {
                    MessageBox.Show("Mức giảm không hợp lệ [0, 100]");
                    txtPhanTramgGiam.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Định dạng mức giảm không hợp lệ, vui lòng nhập lại!");
                txtPhanTramgGiam.Focus();
                return;
            }
            if (dtpNgayBatDau.Value <= dtpNgayKetThuc.Value)
            {
                km.NgayKetThuc = dtpNgayKetThuc.Value;
                km.NgayBatDau = dtpNgayBatDau.Value;
            }
            else
            {
                MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc!");
                return;
            }
            BUS_KhuyenMai.Sua(Current, km);
            LoadDataDSKM(BUS_KhuyenMai.DanhSach());
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            LoadInfoKM();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            F_KhuyenMai_ThemKhuyenMai f = new F_KhuyenMai_ThemKhuyenMai();
            f.KhuyenMaiAdded += Catch_KhuyenMaiAdded;
            f.ShowDialog();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadDataDSKM(BUS_KhuyenMai.DanhSach(txtTimKiem.Text));
        }

        private void F_KhuyenMai_Load(object sender, EventArgs e)
        {
            dtg.AutoGenerateColumns = false;
            LoadDataDSKM(BUS_KhuyenMai.DanhSach());
        }
        private void btnApDungKM_Click(object sender, EventArgs e)
        {
            if (Current != null)
            {
                pnApDungKM.Dock = DockStyle.Fill;
                pnApDungKM.Show();
                pnApDungKM.BringToFront();
                F_KhuyenMai_ApdungKhuyenMai f = new F_KhuyenMai_ApdungKhuyenMai(Current);
                f.ADKM_Huy += Catch_ADKM_Huy;
                f.ADKM_ApDung += Catch_ADKM_ApDung;
                pnApDungKM.Controls.Add(f);
                f.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khuyến mãi muốn áp dụng!");
            }
        }

        void Catch_ADKM_Huy(object sender, EventArgs e)
        {
            ((Form)sender).Close();
            pnApDungKM.Hide();
        }

        void Catch_ADKM_ApDung(object sender, EventArgs e)
        {
            ((Form)sender).Close();
            pnApDungKM.Hide();
            MessageBox.Show("Áp dụng khuyến mãi thành công!");
        }

        void LoadDataDSKM(List<tblKhuyenMai> DSKM)
        {
            dtg.DataSource = DSKM;
            dtg.Columns["MaKM"].DataPropertyName = "MaKM";
            dtg.Columns["TenKM"].DataPropertyName = "TenKM";
            dtg.Columns["PhanTramGiam"].DataPropertyName = "PhanTramGiam";
        }

        void LoadInfoKM()
        {
            if (Current is null)
            {
                txtMaKM.Clear();
                txtTenKM.Clear();
                txtMoTa.Clear();
                txtPhanTramgGiam.Clear();
                dtpNgayBatDau.Value = DateTime.Now;
                dtpNgayKetThuc.Value = DateTime.Now;
                return;
            }
            txtMaKM.Text = Current.MaKM;
            txtTenKM.Text = Current.TenKM;
            if (Current.MoTa != null)
            {
                txtMoTa.Text = Current.MoTa;
            }
            if (Current.PhamTramGiam > 0)
            {
                txtPhanTramgGiam.Text = Current.PhamTramGiam.ToString();
            }
            if (Current.NgayBatDau != null)
            {
                dtpNgayBatDau.Value = Current.NgayBatDau.Value;
            }
            if (Current.NgayKetThuc != null)
            {
                dtpNgayKetThuc.Value = Current.NgayKetThuc.Value;
            }
        }
        void Catch_KhuyenMaiAdded(object sender, EventArgs e)
        {
            ((Form)sender).Close();
            LoadDataDSKM(BUS_KhuyenMai.DanhSach());
        }

        private void dtg_SelectionChanged(object sender, EventArgs e)
        {
            if (dtg.SelectedRows.Count > 0)
            {
                if (dtg.SelectedRows[0].Cells[0].Value != null)
                {
                    string makm = dtg.SelectedRows[0].Cells["MaKM"].Value.ToString();
                    Current = BUS_KhuyenMai.LayKhuyenMai(makm);
                    LoadInfoKM();
                }
            }
        }

        private void F_KhuyenMai_SizeChanged(object sender, EventArgs e)
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
    }
}

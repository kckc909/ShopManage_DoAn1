using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class F_KhuyenMai_ApdungKhuyenMai : Form
    {
        public event EventHandler ADKM_Huy;
        public event EventHandler ADKM_ApDung;
        tblKhuyenMai KhuyenMai;
        BUS_MatHang BUS_MatHang = new BUS_MatHang();
        BUS_LoaiHang BUS_LoaiHang = new BUS_LoaiHang();

        public F_KhuyenMai_ApdungKhuyenMai(tblKhuyenMai KhuyenMai)
        {
            this.KhuyenMai = KhuyenMai;
            InitializeComponent();
            Dock = DockStyle.Fill;
            TopLevel = false;
        }

        private void F_KhuyenMai_ApdungKhuyenMai_Load(object sender, EventArgs e)
        {
            dtg.AutoGenerateColumns = false;
            AddColumn();
            LoadData(BUS_MatHang.DanhSachMatHang());
        }

        void AddColumn()
        {
            dtg.Columns.Clear();
            DataGridViewCheckBoxColumn dtgCheckColumn = new DataGridViewCheckBoxColumn()
            {
                Name = "Check",
                HeaderText = "Áp dụng"
            };
            DataGridViewImageColumn dtgImgColumn = new DataGridViewImageColumn()
            {
                Name = "Img",
                HeaderText = "Ảnh",
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };
            dtg.Columns.Add(dtgCheckColumn);
            dtg.Columns.Add(dtgImgColumn);
            dtg.Columns.Add("MaMH", "Mã mặt hàng");
            dtg.Columns.Add("TenMH", "Tên mặt hàng");
            dtg.Columns.Add("Mota", "Mô tả");
            dtg.Columns.Add("TenLoai", "Tên loại hàng");
        }

        void LoadData(List<tblMatHang> DSMH)
        {
            int ir = 0;
            foreach (tblMatHang mh in DSMH)
            {
                // đã áp dụng khuyến mãi này chưa
                dtg.Rows.Add(mh.MaKM.Equals(KhuyenMai.MaKM));
                // gán ảnh
                try
                {
                    dtg.Rows[ir].Cells["Img"].Value = Image.FromFile(BUS_MatHang.LayDuongDanHinhAnh(mh.LinkHinhAnh));
                }
                catch
                {
                    dtg.Rows[ir].Cells["Img"].Value = null;
                }
                // các nội dung khác
                dtg.Rows[ir].Cells["MaMH"].Value = mh.MaMH;
                dtg.Rows[ir].Cells["TenMH"].Value = mh.TenMH;
                dtg.Rows[ir].Cells["MoTa"].Value = mh.Mota;
                if (mh.tblLoaiHang is null)
                {
                    dtg.Rows[ir].Cells["TenLoai"].Value = BUS_LoaiHang.LayLoaiHangTheoMaLoai(mh.MaLoai).TenLoai;

                }
                else
                {
                    dtg.Rows[ir].Cells["TenLoai"].Value = mh.tblLoaiHang.TenLoai;
                }
                ir++;
            }
            dtg.Refresh();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ADKM_Huy.Invoke(this, e);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string str = txtTimKiem.Text;
            foreach (DataGridViewRow r in dtg.Rows)
            {
                try
                {
                    r.Visible = false;
                }
                catch { }
                foreach (DataGridViewCell cell in r.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().Contains(str))
                    {
                        r.Visible = true;
                        break;
                    }
                }
            }
        }

        private void btnApDung_Click(object sender, EventArgs e)
        {
            tblMatHang mh;
            foreach (DataGridViewRow r in dtg.Rows)
            {
                // Kiểm tra nếu mặt hàng được tích thì đổi thành makm đó, nếu không thì kiểm tra xem mã hiện tại là gì, 
                // nếu là mã km này thì thay đổi thành km mặc định
                if (r.Cells["MaMH"].Value != null)
                {
                    mh = BUS_MatHang.LayTheoMa(r.Cells["MaMH"].Value.ToString());
                    if (r.Cells["Check"].Value is true)
                    {
                        mh.MaKM = KhuyenMai.MaKM;
                        BUS_MatHang.Sua(mh, mh);
                    }
                    else
                    {
                        if (mh.MaKM == KhuyenMai.MaKM)
                        {
                            mh.MaKM = MyDefault.MaKM;
                            BUS_MatHang.Sua(mh, mh);
                        }
                    }
                }
            }
            ADKM_ApDung.Invoke(this, e);
        }

        private void dtg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtg.Rows[e.RowIndex];
                if (row.Cells["Check"].Value is null || row.Cells["Check"].Value is false)
                {
                    row.Cells["Check"].Value = true;
                }
                else
                {
                    row.Cells["Check"].Value = false;
                }
            }
        }
    }
}

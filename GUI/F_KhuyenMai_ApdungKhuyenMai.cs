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
    public partial class F_KhuyenMai_ApdungKhuyenMai : Form
    {
        public event EventHandler ADKM_Huy;
        public event EventHandler ADKM_ApDung;
        tblKhuyenMai KhuyenMai;
        BUS_MatHang BUS_MatHang = new BUS_MatHang();

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
                HeaderText = "Áp dụng",
            };
            DataGridViewImageColumn dtgImgColumn = new DataGridViewImageColumn()
            {
                Name = "Img",
                HeaderText = "Ảnh",
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
                dtg.Rows[ir].Cells["Check"].Value = mh.MaKM.Equals(KhuyenMai.MaKM);
                dtg.Rows[ir].Cells["Img"].Value = Image.FromFile(BUS_MatHang.LayDuongDanHinhAnh(mh.LinkHinhAnh));
                dtg.Rows[ir].Cells["MaMH"].Value = mh.MaMH;
                dtg.Rows[ir].Cells["TenMH"].Value = mh.TenMH;
                dtg.Rows[ir].Cells["MoTa"].Value = mh.Mota;
                dtg.Rows[ir].Cells["TenLoai"].Value = mh.tblLoaiHang.TenLoai;
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
                if (r.Cells["Check"].Value is true)
                {
                    if (r.Cells["MaMH"].Value != null)
                    {
                        mh = BUS_MatHang.LayTheoMa(r.Cells["MaMH"].Value.ToString());
                        mh.MaKM = KhuyenMai.MaKM;
                        BUS_MatHang.Sua(mh, mh);
                        ADKM_ApDung.Invoke(this, e);
                    }
                }
            }    
                
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

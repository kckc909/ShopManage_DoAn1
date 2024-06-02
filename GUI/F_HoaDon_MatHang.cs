using BUS;
using DTO;
using GUI.MyEventArgs;
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
    public partial class F_HoaDon_MatHang : Form
    {
        public event EventHandler<EventArgsMatHang> Event_ChonMatHang;
        BUS_MatHang BUS_MatHang = new BUS_MatHang();
        public F_HoaDon_MatHang()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            TopLevel = false;
        }

        void dtg_Modify()
        {
            dtg.AutoGenerateColumns = false;
            dtg.Columns["MaMH"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtg.Columns["DonViTinh"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtg.Columns["SoLg"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg.Columns["GiaBan"].DefaultCellStyle.Format = "C";
        }

        void dtg_AddColumns()
        {
            dtg.Columns.Clear();
            dtg.Columns.Add("MaMH", "Mã mặt hàng");
            dtg.Columns.Add("TenMH", "Tên mặt hàng");
            dtg.Columns.Add("MoTa", "Mô tả");
            dtg.Columns.Add("SoLg", "Số lượng tồn");
            dtg.Columns.Add("DonViTinh", "Đơn vị");
            dtg.Columns.Add("GiaBan", "Giá bán");
        }

        void dtg_LoadData()
        {
            dtg.DataSource = BUS_MatHang.DanhSachMatHang();
            dtg.Columns["MaMH"].DataPropertyName = "MaMH";
            dtg.Columns["TenMH"].DataPropertyName = "TenMH";
            dtg.Columns["MoTa"].DataPropertyName = "MoTa";
            dtg.Columns["SoLg"].DataPropertyName = "SoLuong";
            dtg.Columns["DonViTinh"].DataPropertyName = "DonViTinh";
            dtg.Columns["GiaBan"].DataPropertyName = "GiaBan";
        }

        void Catch_ReloadSauKhiThemMatHang(object sender, EventArgs e)
        {
            dtg_LoadData();
        }

        void Raise_ChonMatHang(tblMatHang MH)
        {
            if (MH != null)
            {
                Event_ChonMatHang?.Invoke(this, new EventArgsMatHang()
                {
                    MatHang = MH
                });
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            F_MatHang_ThemMatHang F_ThemMatHang = new F_MatHang_ThemMatHang();
            F_ThemMatHang.ReloadSauKhiThemMatHang += Catch_ReloadSauKhiThemMatHang;
            F_ThemMatHang.Show();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            BUS_MatHang.dtg_Search(dtg, txtTimKiem.Text);
        }

        private void F_HoaDon_MatHang_Load(object sender, EventArgs e)
        {
            dtg_AddColumns();
            dtg_Modify();
            dtg_LoadData();
        }

        private void dtg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg.SelectedRows.Count > 0)
            {
                var c = dtg.SelectedRows[0].Cells["MaMH"].Value;
                if (c != null)
                {
                    Raise_ChonMatHang(BUS_MatHang.GetByID(c.ToString()));
                }
            }
        }
    }
}

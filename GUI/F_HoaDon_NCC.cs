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
    public partial class F_HoaDon_NCC : Form
    {
        public event EventHandler<EventArgsNCC> ChonNCC;
        BUS_NhaCungCap BUS_NhaCungCap = new BUS_NhaCungCap();
        public F_HoaDon_NCC()
        {
            InitializeComponent();
            TopLevel = false;   
            Dock = DockStyle.Fill;
        }

        void dtg_Modify()
        {
            dtg.AutoGenerateColumns = false;
        }

        void dtg_AddColumns()
        {
            dtg.Columns.Clear();
            dtg.Columns.Add("MaNCC", "Mã nhà cung cấp");
            dtg.Columns.Add("TenNCC", "Tên nhà cung cấp");
            dtg.Columns.Add("SDT", "Số điện thoại");
        }

        void dtg_LoadData()
        {
            dtg.DataSource = BUS_NhaCungCap.DanhSachNCC();
            dtg.Columns["MaNCC"].DataPropertyName = "MaNCC";
            dtg.Columns["TenNCC"].DataPropertyName = "TenNCC";
            dtg.Columns["SDT"].DataPropertyName = "SDT";
        }

        void Raise_ChonNCC(tblNCC NCC)
        {
            ChonNCC?.Invoke(this, new EventArgsNCC()
            {
                NCC = NCC
            });
        }

        void Catch_AddSuccess(object sender, EventArgs e)
        {
            dtg_LoadData();
            MessageBox.Show("Đã thêm nhà cung cấp");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            F_NhaCungCap_ThemNCC f_NhaCungCap_ThemNCC = new F_NhaCungCap_ThemNCC();
            f_NhaCungCap_ThemNCC.AddSuccess += Catch_AddSuccess;
            f_NhaCungCap_ThemNCC.ShowDialog();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            BUS_NhaCungCap.dtg_Filter(dtg, txtTimKiem.Text);
        }

        private void F_HoaDon_NCC_Load(object sender, EventArgs e)
        {
            dtg_Modify();
            dtg_AddColumns();
            dtg_LoadData();
        }

        private void dtg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg.SelectedRows.Count > 0)
            {
                var ma = dtg.SelectedRows[0].Cells["MaNCC"].Value;
                if (ma != null)
                {
                    Raise_ChonNCC(BUS_NhaCungCap.GetById(ma.ToString()));
                }
            }
        }
    }
}

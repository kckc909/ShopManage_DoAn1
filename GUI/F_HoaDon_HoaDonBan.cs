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
    public partial class F_HoaDon_HoaDonBan : Form
    {
        BUS_HoaDonBan BUS_HoaDonBan = new BUS_HoaDonBan();
        public F_HoaDon_HoaDonBan()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            TopLevel = false;
        }

        private void F_HoaDon_QLHoaDon_Load(object sender, EventArgs e)
        {
            dtg.DataSource = BUS_HoaDonBan.DanhSachHoaDonBan();
        }
    }
}

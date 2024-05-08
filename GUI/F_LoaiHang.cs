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
    public partial class F_LoaiHang : Form
    {
        public F_LoaiHang()
        {
            InitializeComponent();
        }

        private void F_LoaiHang_SizeChanged(object sender, EventArgs e)
        {
            pnTT.Width = pnTT.Width == 400 ? 550 : 400;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
    }
}

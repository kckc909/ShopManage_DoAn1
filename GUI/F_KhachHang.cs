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
    public partial class F_KhachHang : Form
    {
        public F_KhachHang()
        {
            InitializeComponent();
        }

        private void F_KhachHang_SizeChanged(object sender, EventArgs e)
        {
            pnLeft.Width = pnLeft.Width == 400 ? 550 : 400;
        }
    }
}

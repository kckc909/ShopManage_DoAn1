using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.MyEventArgs
{
    public class EventArgsMatHang : EventArgs
    {
        public tblMatHang MatHang;
        public tblKhuyenMai KhuyenMai;
    }
}

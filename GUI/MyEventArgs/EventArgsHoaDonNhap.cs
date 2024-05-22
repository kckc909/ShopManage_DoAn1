using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.MyEventArgs
{
    public class EventArgsHoaDonNhap : EventArgs
    {
        public tblHoaDonNhap HDN { get; set; }
        public tblNCC NCC { get; set; }
    }
}

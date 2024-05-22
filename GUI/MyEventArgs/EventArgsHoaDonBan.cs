using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.MyEventArgs
{
    public class EventArgsHoaDonBan : EventArgs
    {
        public tblHoaDonBan HDB { get; set; }
        public tblKhachHang KH {  get; set; }
    }
}

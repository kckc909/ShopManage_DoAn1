using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.MyEventArgs
{
    public class EventArgsChiTietHDB : EventArgs
    {
        public tblChiTietHDB CTHDB { get; set; }
    }
}

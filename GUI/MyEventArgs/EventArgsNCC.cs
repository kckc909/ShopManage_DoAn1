using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.MyEventArgs
{
    public class EventArgsNCC : EventArgs
    {
        public tblNCC NCC {  get; set; }
    }
}

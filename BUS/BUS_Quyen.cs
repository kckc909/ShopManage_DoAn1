using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Quyen
    {
        DAL_Quyen dal = new DAL_Quyen();
        public List<tblQuyen> DanhSachQuyen() => dal.GetAll();
    }
}

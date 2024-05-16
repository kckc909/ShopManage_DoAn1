using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_DonVi
    {
        DAL_DonVi DAL_DonVi = new DAL_DonVi();
        public List<tblDonVi> DS_DonVi() => DAL_DonVi.DS_DonVi();
    }
}

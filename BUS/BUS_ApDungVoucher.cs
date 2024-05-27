using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_ApDungVoucher
    {
        DAL_ApDungVoucher dal = new DAL_ApDungVoucher();
        public void dtg_Checked(DataGridView dtg, string MaHDB)
        {
            var DSADVc = dal.DanhSachApDungVoucher().FindAll(x => x.MaHDB.Equals(MaHDB));
            dtg.Rows.Cast<DataGridViewRow>().ToList().ForEach(r =>
            {
                if (DSADVc.Any(x => x.MaSHVc.Equals(r.Cells["MaSHVc"].Value)))
                {
                    r.Cells[0].Value = true;
                }
            });
        }
        public List<tblApDungVoucher> dtg_ApDungVoucher(DataGridView dtg, string MaHDB)
        {
            var DSADVc = dal.DanhSachApDungVoucher().FindAll(x => x.MaHDB.Equals(MaHDB));
            List<tblApDungVoucher> AddList = new List<tblApDungVoucher>();
            List<tblApDungVoucher> DelList = new List<tblApDungVoucher>();
            dtg.Rows.Cast<DataGridViewRow>().ToList().ForEach(r =>
            {
                var isChecked = r.Cells[0].Value;
                var MaSHVc = r.Cells[7].Value;
                if (isChecked != null && isChecked.Equals(true))
                {
                    if (! DSADVc.Any(x => x.MaSHVc.Equals(MaSHVc)) && MaSHVc != null)
                    {
                        AddList.Add(new tblApDungVoucher()
                        {
                            MaHDB = MaHDB,
                            MaSHVc = MaSHVc.ToString()
                        });
                    }
                }
                else
                {
                    if (DSADVc.Any(x => x.MaSHVc.Equals(MaSHVc)) && MaSHVc != null)
                    {
                        DelList.Add(new tblApDungVoucher()
                        {
                            MaSHVc = MaSHVc.ToString(),
                            MaHDB = MaHDB
                        });
                    }
                }
            });
            dal.AddRange(AddList);
            dal.DeleteRange(DelList);
            return AddList;
        }
    }
}

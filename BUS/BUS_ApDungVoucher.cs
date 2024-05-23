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
                if (DSADVc.Any(x => x.MaV.Equals(r.Cells[1])))
                {
                    r.Cells[0].Value = true;
                }
            });
        }
        public void dtg_ApDungVoucher(DataGridView dtg, string MaHDB)
        {
            var DSADVc = dal.DanhSachApDungVoucher().FindAll(x => x.MaHDB.Equals(MaHDB));
            List<tblApDungVoucher> AddList = new List<tblApDungVoucher>();
            List<tblApDungVoucher> DelList = new List<tblApDungVoucher>();
            dtg.Rows.Cast<DataGridViewRow>().ToList().ForEach(r =>
            {
                if (r.Cells[0].Value.Equals(true))
                {
                    if (DSADVc.Any(x => x.MaV.Equals(r.Cells[1].Value)))
                    {

                    }
                    else
                    {
                        // them
                        tblApDungVoucher ADVc = new tblApDungVoucher();
                        ADVc.MaV = r.Cells[1].Value.ToString();
                        ADVc.MaHDB = MaHDB;
                        AddList.Add(ADVc);
                    }
                }
                else
                {
                    tblApDungVoucher advc = DSADVc.Find(x => x.MaV.Equals(r.Cells[1].Value));
                    if (advc != null)
                    {
                        // xoa
                        DelList.Add(advc);
                    }
                    else
                    {
                        // them
                        tblApDungVoucher ADVc = new tblApDungVoucher();
                        ADVc.MaV = r.Cells[1].Value.ToString();
                        ADVc.MaHDB = MaHDB;
                        AddList.Add(ADVc);
                    }
                }
            });
            dal.AddRange(AddList);
            dal.DeleteRange(DelList);
        }
    }
}

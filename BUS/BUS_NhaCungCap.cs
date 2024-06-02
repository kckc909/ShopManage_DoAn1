using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_NhaCungCap
    {
        DAL_NhaCungCap DAL_NhaCungCap = new DAL_NhaCungCap();

        public void Them(tblNCC NCC) => DAL_NhaCungCap.Add(NCC);
        public void Sua(tblNCC _old, tblNCC _new) => DAL_NhaCungCap.Update(_old, _new);
        public void Xoa(tblNCC ncc) => DAL_NhaCungCap.Delete(ncc);
        public List<tblNCC> DanhSachNCC() => DAL_NhaCungCap.GetAll();
        public string MaTuDong ()
        {
            int i = DanhSachNCC().Count;
            while (DanhSachNCC().Exists(x => Equals(x.MaNCC.Trim(), $"NCC{i}")))
            {
                i++;
            }
            return $"NCC{i}";
        }
        public tblNCC GetById(string MaNCC) => DanhSachNCC().Find(x => Equals(x.MaNCC, MaNCC));
        public void dtg_Filter(DataGridView dtg, string str)
        {
            dtg.Rows.Cast<DataGridViewRow>().ToList().ForEach(r =>
            {
                r.Visible = false;
                if (r.Cells.Cast<DataGridViewCell>().ToList().Any(c => c.Value != null && c.Value.ToString().Contains(str)))
                {
                    r.Visible = true;
                }
            });
        }
    }
}

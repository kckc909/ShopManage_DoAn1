using DAL;
using DTO;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_MatHang
    {
        DAL_MatHang DAL_MatHang = new DAL_MatHang();
        DAL_LoaiHang DAL_LoaiHang = new DAL_LoaiHang();
        DAL_KhuyenMai DAL_KhuyenMai = new DAL_KhuyenMai();

        public List<tblMatHang> DanhSachMatHang()
        {
            return DAL_MatHang.GetAll();
        }

        public bool Delete(string MaMH)
        {
            var MatHang = DanhSachMatHang().Find(x => Equals(x.MaMH.Trim(), MaMH.Trim()));
            if (MatHang != null)
            {
                DAL_MatHang.Delete(MatHang);
                return true;
            }
            return false;
        }

        public bool Add(tblMatHang matHang)
        {
            if (!DanhSachMatHang().Exists(x => Equals(x.MaMH.Trim(), matHang.MaMH)))
            {
                DAL_MatHang.Add(matHang);
                return true;
            }
            return false;
        }

        public bool Update(tblMatHang _old, tblMatHang _new)
        {
            if (DanhSachMatHang().Exists(x => Equals(x.MaMH, _old.MaMH)))
            {
                DAL_MatHang.Update(_old, _new);
                return true;
            }
            return false;
        }

        public string LayDuongDanHinhAnh(string imageName)
        {
            if (imageName is null)
            {
                return "";
            }
            string path = Path.Combine(MyDefault.Path_AnhMatHang, imageName);
            if (File.Exists(path))
            {
                return path;
            }
            return "";
        }

        public void TaoDuongDanHinhanh(string SourceImage, string ImageName)
        {
            DAL_MatHang.CopyToImgSource(SourceImage, ImageName);
        }

        public string XuLyTenHinh(string SourceImage, string ImageName)
        {
            ImageName = Path.GetFileNameWithoutExtension(ImageName) + Path.GetExtension(SourceImage);
            return Path.Combine(MyDefault.Path_AnhMatHang, ImageName);
        }

        public string LayTenTuDuongDan(string path)
        {
            string[] p = path.Split('\\');
            return p[p.Length - 1];
        }

        public string AutomaticID()
        {
            int i = DanhSachMatHang().Count + 1;
            while (CheckExists($"MH{i}")) i++;
            return $"MH{i}";
        }

        private bool CheckExists(string MaMH)
        {
            // Nếu trùng thì true
            if (DanhSachMatHang().Any(x => Equals(x.MaMH.Trim(), MaMH.Trim())))
            {
                return true;
            }
            return false;
        }

        public void dtg_Search(DataGridView dtg, string str)
        {
            var Lst = from mh in DAL_MatHang.GetAll()
                      join lh in DAL_LoaiHang.DanhSach()
                      on mh.MaLoai equals lh.MaLoai
                      join km in DAL_KhuyenMai.DanhSachKhuyenMai()
                      on mh.MaKM equals km.MaKM
                      where (mh.MaMH.Contains(str)
                      || mh.TenMH.Contains(str)
                      || mh.Mota.Contains(str)
                        )
                      select new { mh.MaMH, mh.TenMH, mh.Mota, mh.SoLuong, mh.DonViTinh, mh.GiaBan, mh.GiaNhap};
            dtg.DataSource = Lst.ToList();
        }

        public tblMatHang GetByID(string MaMH) => DanhSachMatHang().Find(x => x.MaMH.Trim().Equals(MaMH.Trim()));
    }
}

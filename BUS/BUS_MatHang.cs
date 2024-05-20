using DAL;
using DTO;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;

namespace BUS
{
    public class BUS_MatHang
    {
        DAL_MatHang DAL_MatHang = new DAL_MatHang();

        public List<tblMatHang> DanhSachMatHang()
        {
            return DAL_MatHang.DanhSachMatHang();
        }

        public bool Xoa(string MaMH)
        {
            var MatHang = DanhSachMatHang().Find(x => Equals(x.MaMH.Trim(), MaMH.Trim()));
            if (MatHang != null)
            {
                DAL_MatHang.Xoa(MatHang);
                return true;
            }
            return false;
        }

        public bool Them(tblMatHang matHang)
        {
            if (!DanhSachMatHang().Exists(x => Equals(x.MaMH.Trim(), matHang.MaMH)))
            {
                DAL_MatHang.Them(matHang);
                return true;
            }
            return false;
        }

        public bool Sua(tblMatHang _old, tblMatHang _new)
        {
            if (DanhSachMatHang().Exists(x => Equals(x.MaMH, _old.MaMH)))
            {
                DAL_MatHang.Sua(_old, _new);
                return true;
            }
            return false;
        }

        public string LayDuongDanHinhAnh(string imageName)
        {
            string path = Path.Combine(MyDefault.Path_AnhMatHang, imageName);
            if (File.Exists(path))
            {
                return path;
            }
            return "";
        }

        public void TaoDuongDanHinhanh(string SourceImage, string ImageName)
        {
            DAL_MatHang.TaoHinhAnh(SourceImage, ImageName);
        }

        public string XuLyTenHinh(string SourceImage, string ImageName)
        {
            ImageName = Path.GetFileNameWithoutExtension(ImageName) + Path.GetExtension(SourceImage);
            return Path.Combine(MyDefault.Path_AnhMatHang, ImageName);
        }

        public string LayTenTuDuongDang(string path)
        {
            string[] p = path.Split('\\');
            return p[p.Length - 1];
        }

        public string MaMatHangTuDong()
        {
            int i = DanhSachMatHang().Count + 1;
            while (KiemTraMaTrung($"MH{i}")) i++;
            return $"MH{i}";
        }

        private bool KiemTraMaTrung(string MaMH)
        {
            // Nếu trùng thì true
            if (DanhSachMatHang().Exists(x => Equals(x.MaMH.Trim(), MaMH.Trim())))
            {
                return true;
            }
            return false;
        }

        public List<tblMatHang> TimKiem(string str) => DanhSachMatHang().FindAll(x =>
                                                        x.TenMH.Contains(str) ||
                                                        x.Mota.Contains(str) ||
                                                        x.MaMH.Contains(str));

        public tblMatHang LayTheoMa(string MaMH) => DanhSachMatHang().Find(x => x.MaMH.Trim().Equals(MaMH.Trim()));
    }
}

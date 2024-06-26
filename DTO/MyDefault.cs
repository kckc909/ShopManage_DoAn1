﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    // 0986034206 -> Chiến (học sinh đầu to của đức)
    public static class MyDefault
    {
        static string basePath = AppDomain.CurrentDomain.BaseDirectory;
        public static string Path_ErrorImages = "C:\\Users\\admin\\source\\repos\\ShopManage_DoAn1\\GUI\\Resources\\icons8-image-50.png";
        public static string Path_AnhMatHang = Path.Combine(basePath, "..", "..", "Images");
        public static string Path_Avatar = Path.Combine(basePath, "..", "..", "Avatars");
        public static DateTime MaxDate = Convert.ToDateTime("30-12-9000");
        public static string MaKM = "KM00";
        public static tblKhachHang KH = new tblKhachHang()
        {
            MaKH = "KH0       ",
            TenKH = "Khách hàng vãng lai",
            SDT = ""
        };
        public static string MaLoai = "LH00      ";
        public static tblNhanVien NV0 = new tblNhanVien()
        {
            MaNV = "NV0",
            TenNV = "Admin"
        };
        public static tblNCC NCC = new tblNCC()
        {
            MaNCC = "NCC0",
            TenNCC = "Mặc định",
            DiaChi = "Mặc định",
            SDT = "0000000000",
            Email = "Mặc định"
        };
        public static int Status_On = 0;
        public static int Status_Off = 1;
    }
}

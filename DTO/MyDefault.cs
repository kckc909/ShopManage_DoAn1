using System;
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

        public static string Path_AnhMatHang = Path.Combine(basePath, "..", "..", "Images");
        public static string Path_Avatar = Path.Combine(basePath, "..", "..", "Avatars");
        public static DateTime MaxDate = Convert.ToDateTime("30-12-9000");
        public static string MaKM = "KM00      ";
        public static string MaLoai = "LH00      ";
        public static int Status_On = 0;
        public static int Status_Off = 1;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using PointerHangMuc = Worksheet.modData.Memories.Pointer.HangMuc;

namespace Worksheet.modData.Memories.Pointer
{
    /*
     Lưu tình trạng sử dụng tài nguyên đầu vào ( Đơn giá + Báo giá ) 
    và vị trí dữ liệu
     */
    internal class Current
    {
        public static HangMuc HM = new HangMuc();
        public static CongViec CV = new CongViec();
        public static VatLieu VL = new VatLieu();
        public static NhanCong NC = new NhanCong();
        public static CaMay CM = new CaMay();
        static string HangMuc { get; set; } = "";
        static string CongViec { get; set; } = "";


        static string VatLieu { get; set; } = "";
        static string NhanCong { get; set; } = "";
        static string CaMay { get; set; } = "";
        static string DonGia { get; set; } = "";
        static string BaoGia { get; set; } = "";
        static string HeSo { get; set; } = "";

        public static string Hangmuc(string? name = null)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                HangMuc = name;
            }

            return "HangMuc." + (name ?? HangMuc);
        }
        public static string Congviec(string? name = null)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                CongViec = name;
            }

            return "HangMuc." + HangMuc + ".CongViec." + (name ?? CongViec);
        }
        public static string Vatlieu(string? name = null)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                VatLieu = name;
            }

            return "HangMuc." + HangMuc + ".CongViec." + CongViec + ".VatLieu." + (name ?? VatLieu);
        }
        public static string Nhancong(string? name = null)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                NhanCong = name;
            }

            return "HangMuc." + HangMuc + ".CongViec." + CongViec + ".NhanCong." + (name ?? NhanCong);
        }
        public static string Camay(string? name = null)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                CaMay = name;
            }

            return "HangMuc." + HangMuc + ".CongViec." + CongViec + ".CaMay." + (name ?? CaMay);
        }
        public static string Dongia(string? name = null)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                DonGia = name;
            }
            return name ?? DonGia;
        }
        public static string Baogia(string? name = null)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                BaoGia = name;
            }
            return name ?? BaoGia;
        }
    }
}

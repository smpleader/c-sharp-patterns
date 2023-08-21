using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worksheet.modData.Memories.Pointer;

namespace Worksheet.modBL
{
    internal class Container
    {
        private static Dictionary<string, ICell> _instance = new Dictionary<string, ICell>() {
            {"", new DefaultCell() },
            {"test2", new prime.vatlieu.colA() },

            // row tiên lượng
            {"CongViec_KhoiLuongPhu", new prime.tienluong.ColL()},
            {"CongViec_KhoiLuong", new prime.tienluong.ColM()},
            {"CongViec_DonGiaVatLieu", new prime.tienluong.colN()},
            {"CongViec_DonGiaVatLieuPhu", new prime.tienluong.colO()},
            {"CongViec_DonGiaNhanCong", new prime.tienluong.colP()},
            {"CongViec_DonGiaMay", new prime.tienluong.colQ()},
            {"CongViec_ThanhTienVatLieu", new prime.tienluong.colR()},
            {"CongViec_ThanhTienVatLieuPhu", new prime.tienluong.colS()},
            {"CongViec_ThanhTienNhanCong", new prime.tienluong.colT()},
            {"CongViec_ThanhTienMay", new prime.tienluong.colU()},

            //group tiên lượng
            {"NhomCongViec_ThanhTienVatLieu", new prime.tienluong.colGR()},
            {"NhomCongViec_ThanhTienVatLieuPhu", new prime.tienluong.colGS()},
            {"NhomCongViec_ThanhTienNhanCong", new prime.tienluong.colGT()},
            {"NhomCongViec_ThanhTienMay", new prime.tienluong.colGU()},

            // foot tiên lượng
            {"CongViec_TongThanhTienVatLieu", new prime.tienluong.colFR()},
            {"CongViec_TongThanhTienVatLieuPhu", new prime.tienluong.colFS()},
            {"CongViec_TongThanhTienNhanCong", new prime.tienluong.colFT()},
            {"CongViec_TongThanhTienMay", new prime.tienluong.colFU()},
        };

        public static bool exists(string name) { return _instance.ContainsKey(name); }
        public static ICell Get(string name) {  return _instance[name]; }

    }
}

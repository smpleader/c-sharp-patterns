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
            {"CongViec_DonGiaVatLieu", new prime.tienluong.colN()},
            {"CongViec_DonGiaVatLieuPhu", new prime.tienluong.colO()},
            {"CongViec_DonGiaNhanCong", new prime.tienluong.colP()},
            {"CongViec_DonGiaMay", new prime.tienluong.colQ()},
            {"CongViec_ThanhTienVatLieu", new prime.tienluong.colR()},
            {"CongViec_ThanhTienVatLieuPhu", new prime.tienluong.colS()},
            {"CongViec_ThanhTienNhanCong", new prime.tienluong.colT()},
            {"CongViec_ThanhTienMay", new prime.tienluong.colU()},
        };

        public static bool exists(string name) { return _instance.ContainsKey(name); }
        public static ICell Get(string name) {  return _instance[name]; }

    }
}

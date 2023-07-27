using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modData.Memories.Record
{
    internal class BaoGiaNhanCong : ARecord
    {
        public int BGId;
        public BaoGiaNhanCong(int Id)
        {
            BGId = Id;
        }

        public override string Path { get { return "BaoGia." + BGId + ".NhanCong." + Id; } }
        public void setDefault()
        {
            ColText["stt"] = "";
            ColText["ma"] = "";
            ColText["ten"] = "";
            ColText["donvi"] = "";

            ColNum["haophi"] = 0;
            ColNum["giagoc"] = 0;
            ColNum["gia"] = 0;
        }

    }
}
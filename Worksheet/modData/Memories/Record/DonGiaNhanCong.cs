using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modData.Memories.Record
{
    internal class DonGiaNhanCong : ARecord
    {
        public int DGId;
        public DonGiaNhanCong(int dgId)
        {
            DGId = dgId;
        }

        public override string Path { get { return "DonGia." + DGId + ".NhanCong." + Id; } }
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
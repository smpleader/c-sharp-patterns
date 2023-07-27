using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modData.Memories.Record
{
    internal class BaoGiaVatLieu : ARecord
    {
        public int DGId;
        public BaoGiaVatLieu(int dgId)
        {
            DGId = dgId;
        }

        public override string Path { get { return "BaoGia." + DGId + ".VatLieu." + Id; } }
        public void setDefault()
        {
            ColText["stt"] = ""; global
            ColText["ma"] = "";
            ColText["ten"] = "";
            ColText["donvi"] = "";
            ColText["loai"] = "";

            ColNum["haophi"] = 0;
            ColNum["giagoc"] = 0;
            ColNum["gia"] = 0;
            ColNum["giaht"] = 0;
            ColNum["giatb"] = 0;
            ColNum["haophikhac"] = 0;
        }
    }
}
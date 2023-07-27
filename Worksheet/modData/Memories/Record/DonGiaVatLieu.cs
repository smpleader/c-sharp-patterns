using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modData.Memories.Record
{
    internal class DonGiaVatLieu : ARecord
    {
        public int DGId;
        public DonGiaVatLieu(int dgId)
        {
            DGId = dgId;
        }

        public override string Path { get { return "DonGia." + DGId + ".VatLieu." + Id; } }
        public void setDefault()
        {
            ColText["stt"] = "";
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modData.Memories.Row
{
    internal class CaMay : ARow
    {
        public CaMay(int index, string hangMuc, string congViec)
        {
            Path = "HangMuc." + hangMuc + ".CongViec." + congViec + ".CaMay." + index;
            Index = index;

            ColText["stt"] = "";
            ColText["ma"] = "";
            ColText["ten"] = "";
            ColText["donvi"] = "";

            ColNum["haophi"] = 0;
            ColNum["giagoc"] = 0;
            ColNum["giatb"] = 0;
            ColNum["giaht"] = 0;
            ColNum["haophikhac"] = 0;
        }
    }
}
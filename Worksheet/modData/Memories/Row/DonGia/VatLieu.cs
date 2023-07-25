using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modData.Memories.Row.DonGia
{
    internal class VatLieu : ARow
    {
        public VatLieu() : base() { }
        public void init()
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
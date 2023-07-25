using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modData.Memories.Row
{
    internal class NhanCong : ARow
    {
        public NhanCong() : base() { }
        public void init()
        {
            ColText["stt"] = "";
            ColText["ma"] = "";
            ColText["ten"] = "";
            ColText["donvi"] = "";

            ColNum["haophi"] = 0;
            ColNum["giagoc"] = 0;
            ColNum["giatb"] = 0;
            ColNum["giaht"] = 0; 
        }

    }
}
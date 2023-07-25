using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worksheet.modData.Memories.Row;
using Worksheet.modDisplay.Tpl.report1;

namespace Worksheet.modDisplay.Tpl.vatlieu
{
    internal class Row: VatLieu
    {
        public Row(int index, string hangMuc, string congViec) : base(index, hangMuc, congViec)
        {
        }

        string A { get { return ColText["stt"]; } set { ColText["stt"] = value; } }
        string B { get { return ColText["ma"]; } set { ColText["ma"] = value; } }
        string C { get { return ColText["ten"]; } set { ColText["ten"] = value; } }
        string D { get { return ColText["donvi"]; } set { ColText["donvi"] = value; } }
        string I { get { return ColText["loai"]; } set { ColText["loai"] = value; } }
        decimal E { get { return ColNum["haophi"]; } set { ColNum["haophi"] = value; } }
        decimal F { get { return ColNum["giagoc"]; } set { ColNum["giagoc"] = value; } }
        decimal G { get { return ColNum["giatb"]; } set { ColNum["giatb"] = value; } }
        decimal H { get { return ColNum["giaht"]; } set { ColNum["giaht"] = value; } }
        decimal K { get { return ColNum["haophikhac"]; } set { ColNum["haophikhac"] = value; } }
    }
}

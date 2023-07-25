using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modData.Memories.Row
{
    internal class NhanCong : ARow
    {
        public NhanCong(int index, string hangMuc, string congViec)
        {
            Path = "HangMuc." + hangMuc + ".CongViec." + congViec + ".NhanCong." + index;
            Index = index;
        }
        protected string stt { get; set; }

        protected string ma { get; set; }

        protected string ten { get; set; }

        protected string donvi { get; set; }

        protected decimal haophi { get; set; }
        protected decimal giagoc { get; set; }
        protected decimal giatb { get; set; }
        protected decimal giaht { get; set; }

    }
}
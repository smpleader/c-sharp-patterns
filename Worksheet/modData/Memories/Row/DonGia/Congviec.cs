using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modData.Memories.Row.DonGia
{
    internal class Congviec : ARow
    {
        public Congviec(int index, string nguonDonGia)
        {
            Path = "NguonDonGia." + nguonDonGia + ".CongViec." + index;
            Index = index;
        }

        protected string ten { get; set; }
        protected string ma { get; set; }
        protected string donvi { get; set; }
        protected string dinhmuc { get; set; }
        protected string gia { get; set; }
        protected string giagoc { get; set; }
    }
}
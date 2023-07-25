using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modData.Memories.Row.DonGia
{
    internal class CaMay : ARow
    {
        public CaMay(int index, string nguonDonGia, string congViec)
        {
            Path = "NguonDonGia." + nguonDonGia + ".CongViec." + congViec + ".CaMay." + index;
            Index = index;
        }
        protected string stt { get; set; }

        protected string ma { get; set; }

        protected string ten { get; set; }

        protected string donvi { get; set; }

        protected string haophi { get; set; }
        protected string giagoc { get; set; }
        protected string gia { get; set; }
        protected string haophikhac { get; set; }

    }
}
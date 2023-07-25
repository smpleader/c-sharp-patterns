using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modData.Memories.Row
{
    // Danh sách kiểu công trình dùng cho dự toán
    internal class BaoGia : ARow
    {
        public BaoGia(int index, string NguonBaoGia)
        {
            Path = "NguonBaoGia." + NguonBaoGia + ".BaoGia." + index;
            Index = index;
        }

        protected string ten { get; set; }
        protected string ma { get; set; }
        protected string donvi { get; set; }
        protected string giagoc { get; set; }
        protected string gia { get; set; }
    }
}
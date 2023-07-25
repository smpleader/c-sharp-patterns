using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modData.Memories.Row
{
    // Danh sách kiểu công trình dùng cho dự toán
    internal class NguonDonGia : ARow
    {
        public NguonDonGia(int index)
        {
            Path = "NguonDonGia." + index;
            Index = index;
        }

        protected string ten { get; set; }
        protected string ma { get; set; }
        protected string ghichu { get; set; }
    }
}
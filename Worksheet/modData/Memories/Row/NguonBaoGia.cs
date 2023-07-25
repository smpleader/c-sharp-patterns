using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modData.Memories.Row
{
    // Danh sách kiểu công trình dùng cho dự toán
    internal class NguonBaoGia : ARow
    {
        public NguonBaoGia(int index)
        {
            Path = "NguonBaoGia." + index;
            Index = index;
        }

        protected string ten { get; set; }
        protected string ma { get; set; }
        protected string ghichu { get; set; }
    }
}
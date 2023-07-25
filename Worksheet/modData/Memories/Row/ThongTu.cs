using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modData.Memories.Row
{
    // Danh sách thông tư, ND dùng cho dự toán
    internal class ThongTu : ARow
    {
        public ThongTu(int index)
        {
            Path = "ThongTu." + index;
            Index = index;
        }

        protected string ten { get; set; }
        protected string ma { get; set; }
    }
}
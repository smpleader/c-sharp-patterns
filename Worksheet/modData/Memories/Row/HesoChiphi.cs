using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modData.Memories.Row
{
    // Dùng tron bảng THKP Hạng mục
    internal class HesoChiphi : ARow
    {
        public HesoChiphi(int index, string ThongTu, string LoaiCongTrinh)
        {
            Path = "ThongTu." + ThongTu + ".LoaiCongTrinh." + LoaiCongTrinh + ".HesoChiphi." + index;
            Index = index;
        }

        protected string stt { get; set; }
        protected string kyhieu { get; set; }
        protected string giatri { get; set; }
        protected string ghichu { get; set; }
    }
}
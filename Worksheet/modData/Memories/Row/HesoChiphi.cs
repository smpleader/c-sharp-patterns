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
        public HesoChiphi() : base() { } 
        public void init()
        {
            ColText["stt"] = "";
            ColText["kyhieu"] = "";
            ColText["giatri"] = "";
            ColText["ghichu"] = "";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worksheet.modData.Memories.Pointer;

namespace Worksheet.modData.Memories.Record
{
    // Dùng tron bảng THKP Hạng mục
    internal class HesoChiphi : ARecord
    {
        public HesoChiphi(string stt, string kyhieu, string giatri, string ghichu)
        {
            ColText["stt"] = stt;
            ColText["kyhieu"] = kyhieu;
            ColText["giatri"] = giatri;
            ColText["ghichu"] = ghichu;

            Id = Current.HSCP.id(true);
        }
        public override string Path { get { return "HeSoChiPhi." + Id; } }
    }
}
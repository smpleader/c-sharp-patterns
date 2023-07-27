using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worksheet.modData.Memories.Pointer;

namespace Worksheet.modData.Memories.Record
{
    // Danh sách kiểu công trình dùng cho dự toán
    internal class NguonDonGia : ARecord
    {
        public NguonDonGia(string ten, string ma, string ghichu = "")
        {
            Id = Current.NguonBG.id(true);
            ColText["ten"] = ten;
            ColText["ma"] = ma;
            ColText["ghichu"] = ma;
        }
        public override string Path { get { return "NguonDonGia." + Id; } }
    }
}
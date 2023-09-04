using modData.Memories.Pointer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modData.Memories.Record
{
    // Danh sách kiểu công trình dùng cho dự toán
    internal class LoaiCongTrinh : ARecord
    {
        public LoaiCongTrinh(string ten, string ma)
        {
            Id = Current.LoaiCT.id(true);
            ColText["ten"] = ten;
            ColText["ma"] = ma;
        }
        public override string Path { get { return "LoaiCongTrinh." + Id; } }
    }
}
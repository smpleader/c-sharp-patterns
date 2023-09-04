using modData.Memories.Pointer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modData.Memories.Record
{
    // Danh sách thông tư, ND dùng cho dự toán
    internal class ThongTu : ARecord
    {
        public ThongTu(string ten, string ma)
        {
            Id = Current.ThongTu.id(true);
            ColText["ten"] = ten;
            ColText["ma"] = ma;
        }
        public override string Path { get { return "ThongTu." + Id; } }
    }
}
using modData.Memories.Pointer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modData.Memories.Record
{
    // Danh sách kiểu công trình dùng cho dự toán
    internal class NguonBaoGia : ARecord
    {
        public NguonBaoGia(string ten, string ma, string ghichu = "")
        {
            Id = Current.NguonBG.id(true);
            ColText["ten"] = ten;
            ColText["ma"] = ma;
            ColText["ghichu"] = ma;
        }
        public override string Path { get { return "NguonBaoGia." + Id; } }
    }
}
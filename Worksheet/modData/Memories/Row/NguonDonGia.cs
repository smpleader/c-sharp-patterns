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
        public NguonDonGia() : base() { }
        public void init()
        {
            ColText["ten"] = "";
            ColText["ma"] = "";
            ColText["ghichu"] = "";
        }
    }
}
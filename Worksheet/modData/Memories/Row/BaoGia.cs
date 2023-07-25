using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modData.Memories.Row
{
    // Danh sách kiểu công trình dùng cho dự toán
    internal class BaoGia : ARow
    {
        public void init()
        {
            ColText["ten"] = "";
            ColText["ma"] = "";
            ColText["ten"] = "";
            ColText["donvi"] = "";
             
            ColNum["giagoc"] = 0; 
        }
    }
}
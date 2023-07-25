using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modData.Memories.Row
{
    internal class CongViec : ARow
    {
        public CongViec() : base() { }
        public void init()
        { 
            ColText["stt"] = "";
            ColText["ma"] = "";
            ColText["ten"] = "";
            ColText["donvi"] = "";

            ColNum["khoiluong"] = 0;
            ColNum["dongiaVatlieu"] = 0;
            ColNum["dongiaNhancong"] = 0;
            ColNum["dongiaMay"] = 0;
            ColNum["tienVatlieu"] = 0;
            ColNum["tienNhancong"] = 0;
            ColNum["tienMay"] = 0;
            // Hệ số định mức, sheet ở dưới 
            ColNum["hsdmVatlieu"] = 0;
            ColNum["hsdmNhancong"] = 0;
            ColNum["hsdmMay"] = 0;
            // Hệ số điều chỉnh, trong sheet Tiên lượng
            ColNum["hsdcVatlieu"] = 0;
            ColNum["hsdcNhancong"] = 0;
            // TODO: diễn giải khối lượng + KL + KL phụ
            ColNum["hsdcMay"] = 0;
        }
    }
}
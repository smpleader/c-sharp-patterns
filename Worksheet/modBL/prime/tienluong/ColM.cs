using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.tienluong
{
    internal class ColM : ICell
    {
        // Cột M cho row object
        public string Col { get { return "M"; } }
        public string option { get { return ""; } }
        public string Name => "CongViec_KhoiLuongPhu";
        public string formula(string[] args)
        {
            return $"=SUM(L{args[0]}:L{args[1]})";
        }
    }
}

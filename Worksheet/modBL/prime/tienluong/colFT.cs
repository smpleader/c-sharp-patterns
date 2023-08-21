using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.tienluong
{
    internal class colFT : ICell
    {
        // Cột T cho foot object
        public string Col { get { return "T"; } }
        public string option { get { return ""; } }
        public string Name => "CongViec_TongThanhTienNhanCong";
        public string formula(string[] args)
        {
            return $"=SUMIF(B{args[0]}:B{args[1]}, \">0\", T{args[0]}:T{args[1]})";
        }
    }
}

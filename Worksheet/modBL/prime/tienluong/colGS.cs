using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.tienluong
{
    internal class colGS : ICell
    {
        // Cột S cho group object
        public string Col { get { return "S"; } }
        public string option { get { return ""; } }
        public string Name => "NhomCongViec_ThanhTienVatLieuPhu";

        public string formula(string[] args)
        {
            return $"=SUMIF(B{args[0]}:B{args[1]}, \">0\", S{args[0]}:S{args[1]})";
        }
    }
}

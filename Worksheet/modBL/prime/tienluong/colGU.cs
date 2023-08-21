using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.tienluong
{
    internal class colGU : ICell
    {
        // Cột U cho group object
        public string Col { get { return "U"; } }
        public string option { get { return ""; } }
        public string Name => "NhomCongViec_ThanhTienMay";
        public string formula(string[] args)
        {
            return $"=SUMIF(B{args[0]}:B{args[1]}, \">0\", U{args[0]}:U{args[1]})";
        }
    }
}

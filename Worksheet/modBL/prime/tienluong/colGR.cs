using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.tienluong
{
    internal class colGR : ICell
    {
        // Cột R cho group object
        public string Col { get { return "R"; } }
        public string option { get { return ""; } }
        public string Name => "NhomCongViec_ThanhTienVatLieu";
        // return forumalation of cell
        public string formula(string[] args)
        {
            return $"=SUMIF(B{args[0]}:B{args[1]}, \">0\", R{args[0]}:R{args[1]})";
        }
    }
}

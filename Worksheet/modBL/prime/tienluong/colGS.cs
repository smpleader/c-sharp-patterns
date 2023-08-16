using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.tienluong
{
    internal class colGS : ICell
    {
        public string option { get { return ""; } }
        // return forumalation of cell
        public string fml()
        {
            return "= SUMIF(B{0}:B{1},\">0\",S{0}:S{1})";
        }
        // return value of cell
        public decimal val()
        {
            return 0;
        }
    }
}

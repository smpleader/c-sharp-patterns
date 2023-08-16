using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.tienluong
{
    internal class ColM : ICell
    {
        public string option { get { return ""; } }
        // return forumalation of cell
        public string fml()
        {
            return "=SUM(L{0}:L{1})";
        }
        // return value of cell
        public decimal val()
        {
            return 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.tienluong
{
    internal class colN : ICell
    {
        public string option { get { return ""; } }
        // return forumalation of cell
        public string fml()
        {
            return "=V{0}*{1}";
        }
        // return value of cell
        public string fml(string[] args)
        {
            return $"=V{args[0]}*{args[1]}";
        }
        public decimal val()
        {
            return 0;
        }
    }
}

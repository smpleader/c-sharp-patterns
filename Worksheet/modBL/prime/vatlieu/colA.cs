using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.vatlieu
{
    internal class colA : ICell
    {
        public string option { get { return ""; } }
        // return forumalation of cell
        public string fml()
        {
            return "";
        }
        // return value of cell
        public string fml(string[] args)
        {
            throw new NotImplementedException();
        }
        public decimal val()
        {
            return 0;
        }
    }
}

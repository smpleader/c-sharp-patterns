using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.vatlieu
{
    internal class colG : ICell
    {
        public string option { get { return ""; } }
        public string Col => "G";
        public string Name => "VatLieu_GiaGoc";
        public string formula(string[] args)
        {
            return "";
        }
    }
}

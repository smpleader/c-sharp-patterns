using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.vatlieu
{
    internal class colM : ICell
    {
        public string option { get { return ""; } }
        public string Col => "M";
        public string Name => "VatLieu_CuocOto";
        public string formula(string[] args)
        {
            return "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.vatlieu
{
    internal class colC : ICell
    {
        public string option { get { return ""; } }
        public string Col => "C";
        public string Name => "VatLieu_MaVatLieu";
        public string formula(string[] args)
        {
            return "";
        }
    }
}

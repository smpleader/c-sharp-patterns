using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.vatlieu
{
    internal class colU : ICell
    {
        public string option { get { return ""; } }
        public string Col => "U";
        public string Name => "VatLieu_TongCuoc";
        public string formula(string[] args)
        {
            return "";
        }
    }
}

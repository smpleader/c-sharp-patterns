using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.vatlieu
{
    internal class colE : ICell
    {
        public string option { get { return ""; } }
        public string Col => "E";
        public string Name => "VatLieu_TenVatLieu";
        public string formula(string[] args)
        {
            return "";
        }
    }
}

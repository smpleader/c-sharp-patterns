using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.vatlieu
{
    internal class colW : ICell
    {
        public string option { get { return ""; } }
        public string Col => "W";
        public string Name => "VatLieu_GhiChu";
        public string formula(string[] args)
        {
            return "";
        }
    }
}

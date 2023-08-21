using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.vatlieu
{
    internal class colV : ICell
    {
        public string option { get { return ""; } }
        public string Col => "V";
        public string Name => "VatLieu_GiaHienTruong";
        public string formula(string[] args)
        {
            return "";
        }
    }
}

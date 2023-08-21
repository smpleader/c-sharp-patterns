using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.vatlieu
{
    internal class colP : ICell
    {
        public string option { get { return ""; } }
        public string Col => "P";
        public string Name => "VatLieu_CuocThuCong";
        public string formula(string[] args)
        {
            return "";
        }
    }
}

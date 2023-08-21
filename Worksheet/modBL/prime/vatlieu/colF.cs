using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.vatlieu
{
    internal class colF : ICell
    {
        public string option { get { return ""; } }
        public string Col => "F";
        public string Name => "VatLieu_DonVi";
        public string formula(string[] args)
        {
            return "";
        }
    }
}

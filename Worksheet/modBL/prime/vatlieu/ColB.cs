using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.vatlieu
{
    internal class colB : ICell
    {
        public string option { get { return ""; } }
        public string Col => "B";
        public string Name => "VatLieu_STT";
        public string formula(string[] args)
        {
            return "";
        }
    }
}

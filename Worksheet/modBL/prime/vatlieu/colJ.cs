using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.vatlieu
{
    internal class colJ : ICell
    {
        public string option { get { return ""; } }
        public string Col => "J";
        public string Name => "VatLieu_GiaThongBao";
        public string formula(string[] args)
        {
            return "";
        }
    }
}

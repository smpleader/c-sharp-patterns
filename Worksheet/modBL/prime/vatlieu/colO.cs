using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.vatlieu
{
    internal class colO : ICell
    {
        public string option { get { return ""; } }
        public string Col => "O";
        public string Name => "VatLieu_CuocSong";
        public string formula(string[] args)
        {
            return "";
        }
    }
}

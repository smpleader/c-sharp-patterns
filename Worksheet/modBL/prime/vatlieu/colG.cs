using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.vatlieu
{
    internal class colG : ACell
    {
        public colG(Option opt) : base(opt)
        {
        }
        public override string Col => "G";
        public override string Name => "VatLieu_GiaGoc";
    }
}

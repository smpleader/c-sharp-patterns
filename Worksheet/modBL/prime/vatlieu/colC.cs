using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.vatlieu
{
    internal class colC : ACell
    {
        public colC(Option opt) : base(opt)
        {
        }
        public string Col => "C";
        public override string Name => "VatLieu_MaVatLieu";
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.vatlieu
{
    internal class colC : ACell
    {
        public colC(Option opt) : base(opt)
        {
        }
        public override string CName => "C";
        public override string UName => "VatLieu_MaVatLieu";
    }
}

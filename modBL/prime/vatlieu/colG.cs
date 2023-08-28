using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.vatlieu
{
    internal class colG : ACell
    {
        public colG(Option opt) : base(opt)
        {
        }
        public override string CName => "G";
        public override string UName => "VatLieu_GiaGoc";
    }
}

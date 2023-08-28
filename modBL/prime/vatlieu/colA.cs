using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.vatlieu
{
    internal class colA : ACell
    {
        public colA(Option opt) : base(opt)
        {
        }
        public override string CName => "A";
        public override string UName => "VatLieu_KhongCoTen";
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.vatlieu
{
    internal class colA : ACell
    {
        public colA(Option opt) : base(opt)
        {
        }
        public override string Col => "A";
        public override string Name => "VatLieu_KhongCoTen";
    }
}

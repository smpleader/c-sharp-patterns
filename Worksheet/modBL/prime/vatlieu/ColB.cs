using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.vatlieu
{
    internal class colB : ACell
    {
        public colB(Option opt) : base(opt)
        {
        }

        public override string CName => "B";
        public override string UName => "VatLieu_STT";
    }
}

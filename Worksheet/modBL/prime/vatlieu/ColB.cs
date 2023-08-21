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

        public override string Col => "B";
        public override string Name => "VatLieu_STT";
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.vatlieu
{
    internal class colW : ACell
    {
        public colW(Option opt) : base(opt)
        {
        }
        public override string Col => "W";
        public override string Name => "VatLieu_GhiChu";
    }
}

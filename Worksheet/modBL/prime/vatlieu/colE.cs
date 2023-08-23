using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.vatlieu
{
    internal class colE : ACell
    {
        public colE(Option opt) : base(opt)
        {
        }
        public override string CName => "E";
        public override string UName => "VatLieu_TenVatLieu";
    }
}

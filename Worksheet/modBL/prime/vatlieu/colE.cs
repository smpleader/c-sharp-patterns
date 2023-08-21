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
        public override string Col => "E";
        public override string Name => "VatLieu_TenVatLieu";
     
    }
}

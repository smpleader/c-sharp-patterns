using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.vatlieu
{
    internal class colS : ACell
    {
        public colS(Option opt) : base(opt)
        {
        }

        public override string Col => "S";
        public override string Name => "VatLieu_CuocBien";
        public override string formula(string[] args)
        {
            return $"'Cước biển'!Q{args[0]}";
        }
    }
}

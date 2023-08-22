using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.vatlieu
{
    internal class colP : ACell
    {
        public colP(Option opt) : base(opt)
        {
        }

        public override string Col => "P";
        public override string Name => "VatLieu_CuocThuCong";
        public override string formula(string[] args)
        {
            switch(Option.PPTCuocTC)
            {
                case PPTCuocTC.TheoTT12_2021:
                    return $"'Cước TC'!S{args[0]}";
            }
            return base.formula(args);
        }
    }
}

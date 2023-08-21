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
            return "Cước TC.CuocTC_TongCuoc";
        }
    }
}

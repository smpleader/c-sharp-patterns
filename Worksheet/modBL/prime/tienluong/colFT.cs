using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.tienluong
{
    internal class colFT : ACell
    {
        public colFT(Option opt) : base(opt)
        {
        }

        // Cột T cho foot object
        public override string CName => "T";
        public override string UName => "CongViec_TongThanhTienNhanCong";
        public override string formula(string[] args)
        {
            return $"=SUMIF(B{args[0]}:B{args[1]}, \">0\", T{args[0]}:T{args[1]})";
        }
    }
}

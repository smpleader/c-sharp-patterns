using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.tienluong
{
    internal class colGT : ACell
    {
        public colGT(Option opt) : base(opt)
        {
        }

        // Cột T cho group object
        public override string CName => "T";
        public override string UName => "NhomCongViec_ThanhTienNhanCong";
        public override string formula(string[] args)
        {
            return $"=SUMIF(B{args[0]}:B{args[1]}, \">0\", T{args[0]}:T{args[1]})";
        }
    }
}

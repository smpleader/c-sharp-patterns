using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.tienluong
{
    internal class colGU : ACell
    {
        public colGU(Option opt) : base(opt)
        {
        }

        // Cột U cho group object
        public override string CName => "U";
        public override string UName => "NhomCongViec_ThanhTienMay";
        public override string formula(string[] args)
        {
            return $"=SUMIF(B{args[0]}:B{args[1]}, \">0\", U{args[0]}:U{args[1]})";
        }
    }
}

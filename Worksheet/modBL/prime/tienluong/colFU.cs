using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.tienluong
{
    internal class colFU : ACell
    {
        public colFU(Option opt) : base(opt)
        {
        }

        // Cột U cho foot object
        public override string Col { get { return "U"; } }
        public override string Name => "CongViec_TongThanhTienMay";
        public override string formula(string[] args)
        {
            return $"=SUMIF(B{args[0]}:B{args[1]}, \">0\", U{args[0]}:U{args[1]})";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.tienluong
{
    internal class colFR : ACell
    {
        public colFR(Option opt) : base(opt)
        {
        }

        // Cột R cho foot object
        public override string Col { get { return "R"; } }
        public override string Name => "CongViec_TongThanhTienVatLieu";

        // return forumalation of cell
        public override string formula(string[] args)
        {
            return $"=SUMIF(B{args[0]}:B{args[1]}, \">0\", R{args[0]}:R{args[1]})";
        }
    }
}

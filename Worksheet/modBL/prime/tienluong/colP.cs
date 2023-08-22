using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.tienluong
{
    internal class colP : ACell
    {
        public colP(Option opt) : base(opt)
        {
        }

        // Cột P cho row object
        public override string Col { get { return "P"; } }
        public override string Name => "CongViec_DonGiaNhanCong";
        public override string formula(string[] args)
        {
            return $"=W{args[0]}*{args[1]}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.tienluong
{
    internal class colN : ACell
    {
        public colN(Option opt) : base(opt)
        {
        }

        // Cột N cho row object
        public override string Col { get { return "N"; } }
        public override string Name => "CongViec_DonGiaVatLieu";
        public override string formula(string[] args)
        {
            return $"=V{args[0]}*{args[1]}";
        }
    }
}

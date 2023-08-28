using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tienluong
{
    internal class colO : ACell
    {
        public colO(Option opt) : base(opt)
        {
        }

        // Cột O cho row object
        public override string CName => "O";
        public override string UName => "CongViec_DonGiaVatLieuPhu";
        public override string formula(string[] args)
        {
            return $"=V{args[0]}*{args[1]}";
        }
    }
}

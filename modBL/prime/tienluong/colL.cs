using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tienluong
{
    public class ColL : ACell
    {
        public ColL(Option opt) : base(opt)
        {
        }

        // Cột L cho row object
        public override string CName => "L";
        public override string UName => "CongViec_KhoiLuongPhu";
        public override string formula(string[] args)
        {
            return $"=PRODUCT(G{args[0]}:K{args[0]})";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tienluong
{
    internal class ColM : ACell
    {
        public ColM(Option opt) : base(opt)
        {
        }

        // Cột M cho row object
        public override string CName => "M";
        public override string UName => "CongViec_KhoiLuong";
        public override string formula(string[] args)
        {
            return $"=SUM(L{args[0]}:L{args[1]})";
        }
    }
}

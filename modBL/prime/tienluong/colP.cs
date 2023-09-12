using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tienluong
{
    public class colP : ACell
    {
        public colP(Option opt) : base(opt)
        {
        }

        // Cột P cho row object
        public override string CName => "P";
        public override string UName => "CongViec_DonGiaNhanCong";
        public override string formula(string[] args)
        {
            return $"={args[1]}*W{args[0]}";
        }
    }
}

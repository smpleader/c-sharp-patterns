using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tienluong
{
    public class colQ : ACell
    {
        public colQ(Option opt) : base(opt)
        {
        }

        // Cột Q cho row object
        public override string CName => "Q";
        public override string UName => "CongViec_DonGiaMay";
        public override string formula(string[] args)
        {
            return $"={args[1]}*X{args[0]}"; //Cột X: hệ số điều chỉnh máy
        }
        public override string formula(string hmId, string[] args)
        {
            return $"={args[1]}*X{args[0]}"; //Cột X: hệ số điều chỉnh máy
        }
    }
}

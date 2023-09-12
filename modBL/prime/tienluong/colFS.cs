using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tienluong
{
    public class colFS : ACell
    {
        public colFS(Option opt) : base(opt)
        {
        }

        // Cột S cho foot object
        public override string CName => "S";
        public override string UName => "CongViec_TongThanhTienVatLieuPhu";
        public override string formula(string[] args)
        {
            return $"=SUMIF(B{args[0]}:B{args[1]};\">0\";S{args[0]}:S{args[1]})";
        }
    }
}

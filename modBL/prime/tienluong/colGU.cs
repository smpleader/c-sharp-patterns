using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tienluong
{
    public class colGU : ACell
    {
        public colGU(Option opt) : base(opt)
        {
        }

        // Cột U cho group object
        public override string CName => "U";
        public override string UName => "NhomCongViec_ThanhTienMay";
        public override string formula(string[] args)
        {
            return $"=SUMIF(B{args[0]}:B{args[1]},\">0\",U{args[0]}:U{args[1]})"; // Cột B: số thứ tự, cột U: thành tiền máy
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=SUMIF(B{args[0]}:B{args[1]},\">0\",U{args[0]}:U{args[1]})"; // Cột B: số thứ tự, cột U: thành tiền máy
        }
    }
}

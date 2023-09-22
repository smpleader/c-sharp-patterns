using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tienluong
{
    public class colFT : ACell
    {
        public colFT(Option opt) : base(opt)
        {
        }

        // Cột T cho foot object
        public override string CName => "T";
        public override string UName => "CongViec_TongThanhTienNhanCong";
        public override string formula(string[] args)
        {
            return $"=SUMIF(B{args[0]}:B{args[1]},\">0\",T{args[0]}:T{args[1]})"; // Cột B: số thứ tự, cột T: thành tiền nhân công
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=SUMIF(B{args[0]}:B{args[1]},\">0\",T{args[0]}:T{args[1]})"; // Cột B: số thứ tự, cột T: thành tiền nhân công
        }
    }
}

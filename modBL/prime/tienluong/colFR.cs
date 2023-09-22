using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tienluong
{
    public class colFR : ACell
    {
        public colFR(Option opt) : base(opt)
        {
        }

        // Cột R cho foot object
        public override string CName => "R";
        public override string UName => "CongViec_TongThanhTienVatLieu";

        // return forumalation of cell
        public override string formula(string[] args)
        {
            return $"=SUMIF(B{args[0]}:B{args[1]},\">0\",R{args[0]}:R{args[1]})"; // Cột B: số thứ tự, cột R: thành tiền vật liệu
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=SUMIF(B{args[0]}:B{args[1]},\">0\",R{args[0]}:R{args[1]})"; // Cột B: số thứ tự, cột R: thành tiền vật liệu
        }
    }
}

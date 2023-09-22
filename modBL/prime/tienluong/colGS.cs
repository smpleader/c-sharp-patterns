using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tienluong
{
    public class colGS : ACell
    {
        public colGS(Option opt) : base(opt)
        {
        }

        // Cột S cho group object
        public override string CName => "S";
        public override string UName => "NhomCongViec_ThanhTienVatLieuPhu";
        public override string formula(string[] args)
        {
            return $"=SUMIF(B{args[0]}:B{args[1]},\">0\",S{args[0]}:S{args[1]})"; // Cột B: số thứ tự, cột S: thành tiền vật liệu phụ
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=SUMIF(B{args[0]}:B{args[1]},\">0\",S{args[0]}:S{args[1]})"; // Cột B: số thứ tự, cột S: thành tiền vật liệu phụ
        }
    }
}

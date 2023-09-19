using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tienluong
{
    public class colS : ACell
    {
        public colS(Option opt) : base(opt)
        {
        }

        // Cột S cho row object
        public override string CName => "S";
        public override string UName => "CongViec_ThanhTienVatLieuPhu";

        /// <summary>
        /// chỉ có 1 phần từ
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=M{args[0]}*O{args[0]}"; // Cột M: Khối lượng, cột O: Đơn giá vật liệu phụ
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=M{args[0]}*O{args[0]}"; // Cột M: Khối lượng, cột O: Đơn giá vật liệu phụ
        }
    }
}

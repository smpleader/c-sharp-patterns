using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghoptholai.bugia
{
    public class colJ : ACell
    {
        public colJ(Option opt) : base(opt)
        {
        }

        public override string CName => "J";
        public override string UName => "TongHopTL_BuGia_GiaGoc";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số chỉ số dòng nhân công tương ứng trong bảng phụ</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.BU_GIA_CA_MAY}'!P{args[0]}"; // Cột P: Giá gốc nhân công, nhiên liệu trong bảng phụ
        }
        public override string formula(string hmId, string[] args)
        {
            return $"='{SheetName.BU_GIA_CA_MAY}_{hmId}'!P{args[0]}"; // Cột P: Giá gốc nhân công, nhiên liệu trong bảng phụ
        }
    }
}

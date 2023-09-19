using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghoptholai.bugia
{
    public class colL : ACell
    {
        public colL(Option opt) : base(opt)
        {
        }

        public override string CName => "L";
        public override string UName => "TongHopTL_BuGia_GiaHienTruong";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số chỉ số dòng nhân công trong bảng phụ</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.BU_GIA_CA_MAY}'!Q{args[0]}"; // Cột Q: Giá HT nhân công, nhiên liệu trong bảng phụ
        }
        public override string formula(string hmId, string[] args)
        {
            return $"='{SheetName.BU_GIA_CA_MAY}_{hmId}'!Q{args[0]}"; // Cột Q: Giá HT nhân công, nhiên liệu trong bảng phụ
        }
    }
}

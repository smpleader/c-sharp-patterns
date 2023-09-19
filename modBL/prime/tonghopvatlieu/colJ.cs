using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopvatlieu
{
    // Đơn giá gốc vật liệu
    public class colJ : ACell
    {
        public colJ(Option opt) : base(opt)
        {
        }

        public override string CName => "J";
        public override string UName => "THVL_GiaGoc";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số chỉ số dòng vật liệu trong bảng Giá VL</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.VAT_LIEU}'!E{args[0]}"; // Cột E: giá gốc vật liệu
        }
        public override string formula(string hmId, string[] args)
        {
            return $"='{SheetName.VAT_LIEU}_{hmId}'!E{args[0]}"; // Cột E: giá gốc vật liệu
        }
    }
}

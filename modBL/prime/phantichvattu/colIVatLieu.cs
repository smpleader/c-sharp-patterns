using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.phantichvattu
{
    /// <summary>
    /// Đơn giá gốc vật liệu
    /// </summary>
    public class colIVatLieu : ACell
    {
        public colIVatLieu(Option opt) : base(opt)
        {
        }

        public override string CName => "I";
        public override string UName => "PTVT_GiaGocVatLieu";

        // <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng vật liệu trong bảng giá vật liệu</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.VAT_LIEU}'!E{args[0]}"; // Cột E: Đơn giá gốc vật liệu
        }
        public override string formula(string hmId, string[] args)
        {
            return $"='{SheetName.VAT_LIEU}_{hmId}'!E{args[0]}";
        }
    }
}

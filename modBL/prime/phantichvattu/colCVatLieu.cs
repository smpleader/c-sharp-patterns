using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.phantichvattu
{
    /// <summary>
    /// Tên vật liệu
    /// </summary>
    public class colCVatLieu : ACell
    {
        public colCVatLieu(Option opt) : base(opt)
        {
        }

        public override string CName => "C";
        public override string UName => "PTVT_TenVatLieu";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng vật liệu trong bảng giá vật liệu</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.VAT_LIEU}'!C{args[0]}"; // Cột C: Tên vật liệu
        }
        public override string formula(string hmId, string[] args)
        {
            return $"='{SheetName.VAT_LIEU}_{hmId}'!C{args[0]}";
        }
    }
}

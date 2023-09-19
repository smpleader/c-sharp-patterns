using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.phantichvattu
{
    /// <summary>
    /// Đơn giá gốc máy
    /// </summary>
    public class colIMay : ACell
    {
        public colIMay(Option opt) : base(opt)
        {
        }

        public override string CName => "I";
        public override string UName => "PTVT_GiaGocMay";

        // <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng máy trong bảng giá ca máy</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.MAY}'!E{args[0]}"; // Cột E: Đơn giá gốc máy
        }
        public override string formula(string hmId, string[] args)
        {
            return $"='{SheetName.MAY}_{hmId}'!E{args[0]}";
        }
    }
}

using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.phantichvattu
{
    /// <summary>
    /// Đơn giá gốc nhân công
    /// </summary>
    public class colINhanCong : ACell
    {
        public colINhanCong(Option opt) : base(opt)
        {
        }

        public override string CName => "I";
        public override string UName => "PTVT_GiaGocNhanCong";

        // <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng nhân công trong bảng giá nhân công</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.NHAN_CONG}'!E{args[0]}"; // Cột E: Đơn giá gốc nhân công
        }
        public override string formula(string hmId, string[] args)
        {
            return $"='{SheetName.NHAN_CONG}_{hmId}'!E{args[0]}";
        }
    }
}

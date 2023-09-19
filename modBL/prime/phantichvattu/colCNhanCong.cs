using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.phantichvattu
{
    /// <summary>
    /// Tên nhân công
    /// </summary>
    public class colCNhanCong : ACell
    {
        public colCNhanCong(Option opt) : base(opt)
        {
        }

        public override string CName => "C";
        public override string UName => "PTVT_TenNhanCong";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng nhân công trong bảng giá nhân công</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.NHAN_CONG}'!C{args[0]}"; // Cột C: Tên nhân công
        }
        public override string formula(string hmId, string[] args)
        {
            return $"='{SheetName.NHAN_CONG}_{hmId}'!C{args[0]}";
        }
    }
}

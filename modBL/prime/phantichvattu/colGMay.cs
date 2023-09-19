using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.phantichvattu
{
    /// <summary>
    /// Hệ số điều chỉnh máy
    /// </summary>
    public class colGMay : ACell
    {
        public colGMay(Option opt) : base(opt)
        {
        }

        public override string CName => "G";
        public override string UName => "PTVT_HeSoDieuChinhMay";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng công việc trong bảng tiên lượng </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.TIEN_LUONG}'!X{args[0]}"; // Cột X: Hệ số điều chỉnh máy
        }
        public override string formula(string hmId, string[] args)
        {
            return $"='{SheetName.TIEN_LUONG}_{hmId}'!X{args[0]}";
        }
    }
}

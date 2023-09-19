using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.phantichvattu
{
    /// <summary>
    /// Hệ số điều chỉnh nhân công
    /// </summary>
    public class colGNhanCong : ACell
    {
        public colGNhanCong(Option opt) : base(opt)
        {
        }

        public override string CName => "G";
        public override string UName => "PTVT_HeSoDieuChinhNhanCong";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng công việc trong bảng tiên lượng </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.TIEN_LUONG}'!W{args[0]}"; // Cột W: Hệ số điều chỉnh nhân công
        }
        public override string formula(string hmId, string[] args)
        {
            return $"='{SheetName.TIEN_LUONG}_{hmId}'!W{args[0]}";
        }
    }
}

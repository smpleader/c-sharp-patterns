using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.phantichvattu
{
    /// <summary>
    /// Tên công việc
    /// </summary>
    public class colCCongViec : ACell
    {
        public colCCongViec(Option opt) : base(opt)
        {
        }

        public override string CName => "C";
        public override string UName => "PTVT_TenCongViec";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng công việc trong bảng tiên lượng </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.TIEN_LUONG}'!D{args[0]}"; //Cột D: tên công việc
        }
        public override string formula(string hmId, string[] args)
        {
            return $"='{SheetName.TIEN_LUONG}_{hmId}'!D{args[0]}";
        }
    }
}

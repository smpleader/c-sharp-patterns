using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.phantichvattu
{
    public class colB : ACell
    {
        public colB(Option opt) : base(opt)
        {
        }

        public override string CName => "B";
        public override string UName => "PTVT_MaSoCongViec";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng công việc trong bảng tiên lượng </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.TIEN_LUONG}'!C{args[0]}"; // Cột C: mã công việc
        }
        public override string formula(string hmId, string[] args)
        {
            return $"='{SheetName.TIEN_LUONG}_{hmId}'!C{args[0]}";
        }
    }
}

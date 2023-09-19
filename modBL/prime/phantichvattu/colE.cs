using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.phantichvattu
{
    public class colE : ACell
    {
        public colE(Option opt) : base(opt)
        {
        }

        public override string CName => "E";
        public override string UName => "PTVT_KhoiLuongCongViec";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng công việc trong bảng tiên lượng </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.TIEN_LUONG}'!M{args[0]}"; // Cột M: khối lượng công việc
        }
        public override string formula(string hmId, string[] args)
        {
            return $"='{SheetName.TIEN_LUONG}_{hmId}'!M{args[0]}";
        }
    }
}

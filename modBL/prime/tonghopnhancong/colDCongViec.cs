using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopnhancong
{
    // Tên công việc
    public class colDCongViec : ACell
    {
        public colDCongViec(Option opt) : base(opt)
        {
        }

        public override string CName => "D";
        public override string UName => "THNC_TenCongViec";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng công việc chứa nhân công trong bảng tiên lượng </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.TIEN_LUONG}'!D{args[0]}";
        }
    }
}

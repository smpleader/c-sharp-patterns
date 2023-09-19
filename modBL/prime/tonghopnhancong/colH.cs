using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopnhancong
{
    public class colH : ACell
    {
        public colH(Option opt) : base(opt)
        {
        }

        public override string CName => "H";
        public override string UName => "THNC_HeSoCongViec";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng công việc chứa nhân công trong bảng tiên lượng </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.TIEN_LUONG}'!W{args[0]}"; // Cột W: hệ số điều chỉnh nhân công
        }
        public override string formula(string hmId, string[] args)
        {
            return $"='{SheetName.TIEN_LUONG}_{hmId}'!W{args[0]}"; // Cột W: hệ số điều chỉnh nhân công
        }
    }
}

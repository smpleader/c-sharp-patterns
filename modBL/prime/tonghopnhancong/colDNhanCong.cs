using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopnhancong
{
    // Tên nhân công
    public class colDNhanCong : ACell
    {
        public colDNhanCong(Option opt) : base(opt)
        {
        }

        public override string CName => "D";
        public override string UName => "THNC_TenNhanCong";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng nhân công trong bảng giá nhân công </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.NHAN_CONG}'!C{args[0]}";
        }
    }
}

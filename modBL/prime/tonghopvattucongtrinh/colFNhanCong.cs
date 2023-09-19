using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopvattucongtrinh
{
    /// <summary>
    /// Giá gốc nhân công
    /// </summary>
    public class colFNhanCong : ACell
    {
        public colFNhanCong(Option opt) : base(opt)
        {
        }

        public override string CName => "F";
        public override string UName => "TongHopVTCT_GiaGocNhanCong";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng nhân công trong bảng giá NC </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.NHAN_CONG}'!E{args[0]}"; //Cột E: giá gốc nhân công
        }
        public override string formula(string hmId, string[] args)
        {
            return $"='{SheetName.NHAN_CONG}_{hmId}'!E{args[0]}"; //Cột E: giá gốc nhân công
        }
    }
}

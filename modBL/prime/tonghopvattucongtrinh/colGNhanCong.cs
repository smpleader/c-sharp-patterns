using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopvattucongtrinh
{
    /// <summary>
    /// Giá TB nhân công
    /// </summary>
    public class colGNhanCong : ACell
    {
        public colGNhanCong(Option opt) : base(opt)
        {
        }

        public override string CName => "G";
        public override string UName => "TongHopVTCT_GiaTBNhanCong";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng nhân công trong bảng giá NC </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.NHAN_CONG}'!F{args[0]}"; //Cột F: giá TB nhân công
        }
        public override string formula(string hmId, string[] args)
        {
            return $"='{SheetName.NHAN_CONG}_{hmId}'!F{args[0]}"; //Cột F: giá TB nhân công
        }
    }
}

using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopvattu
{
    /// <summary>
    /// Khối lượng nhân công
    /// </summary>
    public class colENhanCong : ACell
    {
        public colENhanCong(Option opt) : base(opt)
        {
        }

        public override string CName => "E";
        public override string UName => "TongHopVT_KhoiLuongNhanCong";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng nhân công trong bảng THNC </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.TONG_HOP_NHAN_CONG}'!I{args[0]}"; //Cột I: hao phí nhân công
        }
        public override string formula(string hmId, string[] args)
        {
            return $"='{SheetName.TONG_HOP_NHAN_CONG}_{hmId}'!I{args[0]}";
        }
    }
}

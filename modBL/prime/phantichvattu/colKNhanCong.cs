using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.phantichvattu
{
    /// <summary>
    /// Đơn giá TB nhân công
    /// </summary>
    public class colKNhanCong : ACell
    {
        public colKNhanCong(Option opt) : base(opt)
        {
        }

        public override string CName => "K";
        public override string UName => "PTVT_GiaThongBaoNhanCong";

        // <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng nhân công trong bảng giá nhân công</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.NHAN_CONG}'!F{args[0]}"; // Cột E: Đơn giá TB nhân công
        }
        public override string formula(string hmId, string[] args)
        {
            return $"='{SheetName.NHAN_CONG}_{hmId}'!F{args[0]}";
        }
    }
}

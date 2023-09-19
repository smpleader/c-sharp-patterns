using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopchiphixaydung
{
    /// <summary>
    /// Chi phí xây dựng trước thuế
    /// </summary>
    public class colC : ACell
    {
        public colC(Option opt) : base(opt)
        {
        }

        public override string CName => "C";
        public override string UName => "THCPXD_ChiPhiXayDungTruocThue";

        /// <summary>
        /// 1 tham số
        /// <para>Chỉ số dòng thành tiền giá trị trước thuế trong bảng THKPHM</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"={SheetName.TONG_HOP_KINH_PHI_HANG_MUC}!E{args[0]}"; // Cột E: Thành tiền giá trị trước thuế
        }
        public override string formula(string hmId, string[] args)
        {
            return $"={SheetName.TONG_HOP_KINH_PHI_HANG_MUC}_{hmId}!E{args[0]}"; // Cột E: Thành tiền giá trị trước thuế
        }
    }
}

using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopkinhphi.thongtu112021
{
    /// <summary>
    /// 4.5/ Thuế chi phí kiểm tra hiệu quả khả thi
    /// </summary>
    public class colGKTHQKT : ACell
    {
        public colGKTHQKT(Option opt) : base(opt)
        {
        }
        public override string CName => "G";
        public override string UName => "THKP_TT11_ThueChiPhiKiemTraHieuQuaKhaThi";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng chi phí kiểm tra hiệu quả khả thi </para>
        /// </summary>
        /// <param name="args"> </param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            // ROUND(F19*C7;0)
            return $"=ROUND(F{args[0]}*C7;0)"; // F: giá trị trước thuế chi phí kiểm tra hiệu quả khả thi, cột C: thuế VAT
        }
        public override string formula(string hmId, string[] args)
        {
            // ROUND(F19*C7;0)
            return $"=ROUND(F{args[0]}*C7;0)"; // F: giá trị trước thuế chi phí kiểm tra hiệu quả khả thi, cột C: thuế VAT
        }
    }
}

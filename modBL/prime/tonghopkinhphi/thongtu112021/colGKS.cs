using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopkinhphi.thongtu112021
{
    /// <summary>
    /// 4.1/ Thuế chi phí khảo sát
    /// </summary>
    public class colGKS : ACell
    {
        public colGKS(Option opt) : base(opt)
        {
        }
        public override string CName => "G";
        public override string UName => "THKP_TT11_ThueChiPhiKhaoSat";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng chi phí khảo sát </para>
        /// </summary>
        /// <param name="args"> </param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            // ROUND(F15*C7;0)
            return $"=ROUND(F{args[0]}*C7;0)"; // F: giá trị trước thuế chi phí khảo sát, cột C: thuế VAT
        }
        public override string formula(string hmId, string[] args)
        {
            // ROUND(F15*C7;0)
            return $"=ROUND(F{args[0]}*C7;0)"; // F: giá trị trước thuế chi phí khảo sát, cột C: thuế VAT
        }
    }
}
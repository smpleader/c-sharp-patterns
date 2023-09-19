using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopkinhphi.thongtu112021
{
    /// <summary>
    /// 4.2/ Thuế chi phí lập nhiệm vụ khảo sát
    /// </summary>
    public class colGNVKS : ACell
    {
        public colGNVKS(Option opt) : base(opt)
        {
        }
        public override string CName => "G";
        public override string UName => "THKP_TT11_ThueChiPhiLapNhiemVuKhaoSat";

        /// <summary>
        /// 1 tham số
        /// <para> chỉ số dòng chi phí lập nhiệm vụ khảo sát </para>
        /// </summary>
        /// <param name="args"> </param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            // ROUND(F16*C7;0)
            return $"=ROUND(F{args[0]}*C7;0)"; // F: giá trị trước thuế chi phí lập nhiệm vụ khảo sát, cột C: thuế VAT
        }
        public override string formula(string hmId, string[] args)
        {
            // ROUND(F16*C7;0)
            return $"=ROUND(F{args[0]}*C7;0)"; // F: giá trị trước thuế chi phí lập nhiệm vụ khảo sát, cột C: thuế VAT
        }
    }
}

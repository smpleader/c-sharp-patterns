using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopkinhphi.thongtu112021
{
    /// <summary>
    /// 4.16/ Thuế chi phí thiết kế bản vẽ thi công
    /// </summary>
    public class colGTKBVTC : ACell
    {
        public colGTKBVTC(Option opt) : base(opt)
        {
        }
        public override string CName => "G";
        public override string UName => "THKP_TT11_ThueChiPhiThietKeBanVeThiCong";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng chi phí thiết kế bản vẽ thi công</para>
        /// </summary>
        /// <param name="args"> </param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            // ROUND(F30*C7;0)
            return $"=ROUND(F{args[0]}*C7;0)"; // F: giá trị trước thuế chi phí thiết kế bản vẽ thi công, cột C: thuế VAT
        }
        public override string formula(string hmId, string[] args)
        {
            // ROUND(F30*C7;0)
            return $"=ROUND(F{args[0]}*C7;0)"; // F: giá trị trước thuế chi phí thiết kế bản vẽ thi công, cột C: thuế VAT
        }
    }
}
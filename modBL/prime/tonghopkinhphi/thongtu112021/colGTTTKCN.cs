using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopkinhphi.thongtu112021
{
    /// <summary>
    /// 4.12/ Thuế chi phí thẩm tra thiết kế công nghệ
    /// </summary>
    public class colGTTTKCN : ACell
    {
        public colGTTTKCN(Option opt) : base(opt)
        {
        }
        public override string CName => "G";
        public override string UName => "THKP_TT11_ThueChiPhiThamTraThietKeCongNghe";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng chi phí thẩm tra thiết kế công nghệ</para>
        /// </summary>
        /// <param name="args"> </param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            // ROUND(F26*C7;0)
            return $"=ROUND(F{args[0]}*C7;0)"; // F: giá trị trước thuế chi phí thẩm tra thiết kế công nghệ, cột C: thuế VAT
        }
        public override string formula(string hmId, string[] args)
        {
            // ROUND(F26*C7;0)
            return $"=ROUND(F{args[0]}*C7;0)"; // F: giá trị trước thuế chi phí thẩm tra thiết kế công nghệ, cột C: thuế VAT
        }
    }
}
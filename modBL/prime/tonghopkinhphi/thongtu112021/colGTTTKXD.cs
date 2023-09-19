using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopkinhphi.thongtu112021
{
    /// <summary>
    /// 4.17/ Thuế chi phí thẩm tra thiết kế xây dựng
    /// </summary>
    public class colGTTTKXD : ACell
    {
        public colGTTTKXD(Option opt) : base(opt)
        {
        }
        public override string CName => "G";
        public override string UName => "THKP_TT11_ThueChiPhiThamTraThietKeXayDung";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng chi phí thẩm tra thiết kế xây dựng</para>
        /// </summary>
        /// <param name="args"> </param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            // ROUND(F31*C7;0)
            return $"=ROUND(F{args[0]}*C7;0)"; // F: giá trị trước thuế chi phí thẩm tra thiết kế xây dựng, cột C: thuế VAT
        }
        public override string formula(string hmId, string[] args)
        {
            // ROUND(F31*C7;0)
            return $"=ROUND(F{args[0]}*C7;0)"; // F: giá trị trước thuế chi phí thẩm tra thiết kế xây dựng, cột C: thuế VAT
        }
    }
}
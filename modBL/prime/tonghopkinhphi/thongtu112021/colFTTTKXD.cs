using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopkinhphi.thongtu112021
{
    /// <summary>
    /// Trước thuế chi phí thẩm tra thiết kế xây dựng
    /// </summary>
    public class colFTTTKXD : ACell
    {
        public colFTTTKXD(Option opt) : base(opt)
        {
        }
        public override string CName => "F";
        public override string UName => "THKP_TT11_TruocThueChiPhiThamTraThietKeXayDung";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng chi phí xây dựng</para>
        /// <para> Tham số 2 chỉ số dòng chi phí thẩm tra thiết kế xây dựng</para>
        /// </summary>
        /// <param name="args"> </param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            // MAX(ROUND(F9*C31;0);IF(C31 > 0; 2000000; 0))
            return $"=MAX(ROUND(F{args[0]}*C{args[1]};0);IF(C{args[1]} > 0; 2000000; 0))"; // cột F: giá trị trước thuế, cột C: định mức chi phí thẩm tra thiết kế xây dựng
        }
        public override string formula(string hmId, string[] args)
        {
            // MAX(ROUND(F9*C31;0);IF(C31 > 0; 2000000; 0))
            return $"=MAX(ROUND(F{args[0]}*C{args[1]};0);IF(C{args[1]} > 0; 2000000; 0))"; // cột F: giá trị trước thuế, cột C: định mức chi phí thẩm tra thiết kế xây dựng
        }
    }
}

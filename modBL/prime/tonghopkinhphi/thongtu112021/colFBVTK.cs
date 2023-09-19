using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopkinhphi.thongtu112021
{
    /// <summary>
    /// Trước thuế chi phí thiết kế bản vẽ thi công
    /// </summary>
    public class colFBVTK : ACell
    {
        public colFBVTK(Option opt) : base(opt)
        {
        }
        public override string CName => "F";
        public override string UName => "THKP_TT11_TruocThueChiPhiThietKeBanVeThiCong";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng chi phí xây dựng</para>
        /// <para> Tham số 2 chỉ số dòng chi phí thiết kế bản vẽ thi công</para>
        /// </summary>
        /// <param name="args"> </param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            // ROUND(PRODUCT(F9;C30;D30);0)
            return $"=ROUND(PRODUCT(F{args[0]};C{args[1]};D{args[1]});0)"; // cột F: giá trị trước thuế, cột C: định mức chi phí thiết kế bản vẽ thi công, cột D; hệ số chi phí thiết kế bản vẽ thi công
        }
        public override string formula(string hmId, string[] args)
        {
            // ROUND(PRODUCT(F9;C30;D30);0)
            return $"=ROUND(PRODUCT(F{args[0]};C{args[1]};D{args[1]});0)"; // cột F: giá trị trước thuế, cột C: định mức chi phí thiết kế bản vẽ thi công, cột D; hệ số chi phí thiết kế bản vẽ thi công
        }
    }
}

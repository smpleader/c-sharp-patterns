using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopkinhphi.thongtu112021
{
    /// <summary>
    /// 4.14/ Thuế chi phí thi tuyển thiết kế kiến trúc
    /// </summary>
    public class colGTTTKKT : ACell
    {
        public colGTTTKKT(Option opt) : base(opt)
        {
        }
        public override string CName => "G";
        public override string UName => "THKP_TT11_ThueChiPhiThiTuyenThietKeKienTruc";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng chi phí thi tuyển thiết kế kiến trúc</para>
        /// </summary>
        /// <param name="args"> </param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            // ROUND(F28*C7;0)
            return $"=ROUND(F{args[0]}*C7;0)"; // F: giá trị trước thuế chi phí thi tuyển thiết kế kiến trúc, cột C: thuế VAT
        }
        public override string formula(string hmId, string[] args)
        {
            // ROUND(F28*C7;0)
            return $"=ROUND(F{args[0]}*C7;0)"; // F: giá trị trước thuế chi phí thi tuyển thiết kế kiến trúc, cột C: thuế VAT
        }
    }
}
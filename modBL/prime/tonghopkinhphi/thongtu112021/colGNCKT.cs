using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopkinhphi.thongtu112021
{
    /// <summary>
    /// 4.8/ Thuế chi phí lập báo cáo nghiên cứu khả thi
    /// </summary>
    public class colGNCKT : ACell
    {
        public colGNCKT(Option opt) : base(opt)
        {
        }
        public override string CName => "G";
        public override string UName => "THKP_TT11_ThueChiPhiLapBaoCaoNghienCuuKhaThi";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng chi phí lập báo cáo nghiên cứu khả thi </para>
        /// </summary>
        /// <param name="args"> </param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            // ROUND(F22*C7;0)
            return $"=ROUND(F{args[0]}*C7;0)"; // F: giá trị trước thuế chi phí lập báo cáo nghiên cứu khả thi, cột C: thuế VAT
        }
        public override string formula(string hmId, string[] args)
        {
            // ROUND(F22*C7;0)
            return $"=ROUND(F{args[0]}*C7;0)"; // F: giá trị trước thuế chi phí lập báo cáo nghiên cứu khả thi, cột C: thuế VAT
        }
    }
}
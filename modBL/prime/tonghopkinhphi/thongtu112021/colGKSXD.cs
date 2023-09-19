using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopkinhphi.thongtu112021
{
    /// <summary>
    /// 4.3/ Thuế chi phí giám sát công tác khảo sát xây dựng
    /// </summary>
    public class colGKSXD : ACell
    {
        public colGKSXD(Option opt) : base(opt)
        {
        }
        public override string CName => "G";
        public override string UName => "THKP_TT11_ThueChiPhiGiamSatCongTacKhaoSatXayDung";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng chi phí giám sát công tác khảo sát xây dựng </para>
        /// </summary>
        /// <param name="args"> </param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            // ROUND(F17*C7;0)
            return $"=ROUND(F{args[0]}*C7;0)"; // F: giá trị trước thuế chi phí giám sát công tác khảo sát xây dựng, cột C: thuế VAT
        }
        public override string formula(string hmId, string[] args)
        {
            // ROUND(F17*C7;0)
            return $"=ROUND(F{args[0]}*C7;0)"; // F: giá trị trước thuế chi phí giám sát công tác khảo sát xây dựng, cột C: thuế VAT
        }
    }
}
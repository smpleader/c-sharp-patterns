using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopkinhphi.thongtu112021
{
    /// <summary>
    /// Trước thuế chi phí giám sát công tác khảo sát xây dựng
    /// </summary>
    public class colFGSKSXD : ACell
    {
        public colFGSKSXD(Option opt) : base(opt)
        {
        }
        public override string CName => "F";
        public override string UName => "THKP_TT11_TruocThueChiPhiGiamSatCongTacKhaoSatXayDung";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng chi phí khảo sát</para>
        /// <para> Tham số 2 chỉ số dòng chi phí giám sát công tác khảo sát xây dựng</para>
        /// </summary>
        /// <param name="args"> </param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            // ROUND(PRODUCT(F15;C17;D17);0)
            return $"=ROUND(PRODUCT(F{args[0]};C{args[1]};D{args[1]});0)"; // cột F: giá trị trước thuế, cột C: định mức, cột D: hệ số
        }
        public override string formula(string hmId, string[] args)
        {
            // ROUND(PRODUCT(F15;C17;D17);0)
            return $"=ROUND(PRODUCT(F{args[0]};C{args[1]};D{args[1]});0)"; // cột F: giá trị trước thuế, cột C: định mức, cột D: hệ số
        }
    }
}
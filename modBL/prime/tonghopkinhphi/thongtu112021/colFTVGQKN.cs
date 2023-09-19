using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopkinhphi.thongtu112021
{
    /// <summary>
    /// Trước thuế chi phí cho hội đồng tư vấn giải quyết kiến nghị của nhà thầu
    /// </summary>
    public class colFTVGQKN : ACell
    {
        public colFTVGQKN(Option opt) : base(opt)
        {
        }
        public override string CName => "F";
        public override string UName => "THKP_TT11_TruocThueChiPhiChoHoiDongTuVanGiaiQuyetKienNghiCuaNhaThau";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng GXD (Dự toán gói thầu)</para>
        /// <para> Tham số 2 chỉ số dòng chi phí cho hội đồng tư vấn giải quyết kiến nghị của nhà thầu</para>
        /// </summary>
        /// <param name="args"> </param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            // ROUND(IF(F34*C44<1000000;1000000;IF(F34*C44>50000000;50000000;F34*C44));0)
            return $"=ROUND(IF(F{args[0]}*C{args[1]}<1000000;1000000;IF(F{args[0]}*C{args[1]}>50000000;50000000;F{args[0]}*C{args[1]}));0)"; // cột F: giá trị trước thuế, cột C: định mức chi phí cho hội đồng tư vấn giải quyết kiến nghị của nhà thầu
        }
        public override string formula(string hmId, string[] args)
        {
            // ROUND(IF(F34*C44<1000000;1000000;IF(F34*C44>50000000;50000000;F34*C44));0)
            return $"=ROUND(IF(F{args[0]}*C{args[1]}<1000000;1000000;IF(F{args[0]}*C{args[1]}>50000000;50000000;F{args[0]}*C{args[1]}));0)"; // cột F: giá trị trước thuế, cột C: định mức chi phí cho hội đồng tư vấn giải quyết kiến nghị của nhà thầu
        }
    }
}
using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopkinhphi.thongtu112021
{
    /// <summary>
    /// Trước thuế chi phí lập hồ sơ mời quan tâm đánh giá hồ sơ quan tâm
    /// </summary>
    public class colFHSMQT : ACell
    {
        public colFHSMQT(Option opt) : base(opt)
        {
        }
        public override string CName => "F";
        public override string UName => "THKP_TT11_TruocThueChiPhiLapHoSoMoiQuanTamDanhGiaHoSoQuanTam";

        /// <summary>
        /// 3 tham số
        /// <para> Tham số 1 chỉ số dòng chi phí lập hồ sơ mời thầu, đánh giá hồ sơ dự thầu thi công xây dựng</para>
        /// <para> Tham số 2 chỉ số dòng chi phí lập hồ sơ mời thầu, đánh giá hồ sơ dự thầu mua sắm vật tư, thiết bị</para>
        /// <para> Tham số 3 chỉ số dòng chi phí lập hồ sơ mời quan tâm đánh giá hồ sơ quan tâm</para>
        /// </summary>
        /// <param name="args"> </param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            // ROUND(PRODUCT(F36+F46;C47;D47);0)
            return $"=ROUND(PRODUCT(F{args[0]}+F{args[1]};C{args[2]};D{args[2]});0)"; // cột F: giá trị trước thuế, cột C: định mức chi phí lập hồ sơ mời quan tâm đánh giá hồ sơ quan tâm, cột D: hệ số chi phí lập hồ sơ mời quan tâm đánh giá hồ sơ quan tâm
        }
        public override string formula(string hmId, string[] args)
        {
            // ROUND(PRODUCT(F36+F46;C47;D47);0)
            return $"=ROUND(PRODUCT(F{args[0]}+F{args[1]};C{args[2]};D{args[2]});0)"; // cột F: giá trị trước thuế, cột C: định mức chi phí lập hồ sơ mời quan tâm đánh giá hồ sơ quan tâm, cột D: hệ số chi phí lập hồ sơ mời quan tâm đánh giá hồ sơ quan tâm
        }
    }
}
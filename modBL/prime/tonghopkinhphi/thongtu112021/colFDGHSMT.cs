using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopkinhphi.thongtu112021
{
    /// <summary>
    /// Trước thuế chi phí lập đánh giá hồ sơ mời thầu hồ sơ dự thầu
    /// </summary>
    public class colFDGHSMT : ACell
    {
        public colFDGHSMT(Option opt) : base(opt)
        {
        }
        public override string CName => "F";
        public override string UName => "THKP_TT11_TruocThueChiPhiLapDanhGiaHoSoMoiThauHoSoDuThau";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng GXD (Dự toán gói thầu)</para>
        /// <para> Tham số 2 chỉ số dòng chi phí lập đánh giá hồ sơ mời thầu hồ sơ dự thầu</para>
        /// </summary>
        /// <param name="args"> </param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            // ROUND(PRODUCT(F34;C36;D36);0)
            return $"=ROUND(PRODUCT(F{args[0]};C{args[1]};D{args[1]});0)"; // cột F: giá trị trước thuế, cột C: định mức chi phí lập đánh giá hồ sơ mời thầu hồ sơ dự thầu, cột D; hệ số chi phí lập đánh giá hồ sơ mời thầu hồ sơ dự thầu
        }
        public override string formula(string hmId, string[] args)
        {
            // ROUND(PRODUCT(F34;C36;D36);0)
            return $"=ROUND(PRODUCT(F{args[0]};C{args[1]};D{args[1]});0)"; // cột F: giá trị trước thuế, cột C: định mức chi phí lập đánh giá hồ sơ mời thầu hồ sơ dự thầu, cột D; hệ số chi phí lập đánh giá hồ sơ mời thầu hồ sơ dự thầu
        }
    }
}
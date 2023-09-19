using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopkinhphi.thongtu112021
{
    /// <summary>
    /// Trước thuế chi phí lập hồ sơ mời thầu đánh giá hồ sơ dự thầu mua sắm vật tư thiết bị
    /// </summary>
    public class colFMSVT : ACell
    {
        public colFMSVT(Option opt) : base(opt)
        {
        }
        public override string CName => "F";
        public override string UName => "THKP_TT11_TruocThueChiPhiLapHoSoMoiThauDanhGiaHoSoDuThauMuaSamVatTuThietBi";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng chi phí thiết bị</para>
        /// <para> Tham số 2 chỉ số dòng chi phí lập hồ sơ mời thầu đánh giá hồ sơ dự thầu mua sắm vật tư thiết bị</para>
        /// </summary>
        /// <param name="args"> </param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            // ROUND(PRODUCT(F12;C46;D46);0)
            return $"=ROUND(PRODUCT(F{args[0]};C{args[1]};D{args[1]});0)"; // cột F: giá trị trước thuế, cột C: định mức chi phí lập hồ sơ mời thầu đánh giá hồ sơ dự thầu mua sắm vật tư thiết bị, cột D: hệ số chi phí lập hồ sơ mời thầu đánh giá hồ sơ dự thầu mua sắm vật tư thiết bị
        }
        public override string formula(string hmId, string[] args)
        {
            // ROUND(PRODUCT(F12;C46;D46);0)
            return $"=ROUND(PRODUCT(F{args[0]};C{args[1]};D{args[1]});0)"; // cột F: giá trị trước thuế, cột C: định mức chi phí lập hồ sơ mời thầu đánh giá hồ sơ dự thầu mua sắm vật tư thiết bị, cột D: hệ số chi phí lập hồ sơ mời thầu đánh giá hồ sơ dự thầu mua sắm vật tư thiết bị
        }
    }
}
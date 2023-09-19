using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopkinhphi.thongtu112021
{
    /// <summary>
    /// Trước thuế chi phí kiểm tra công tác nghiệm thu công trình xây dựng
    /// </summary>
    public class colFNTCTXD : ACell
    {
        public colFNTCTXD(Option opt) : base(opt)
        {
        }
        public override string CName => "F";
        public override string UName => "THKP_TT11_TruocThueChiPhiKiemTraCongTacNghiemThuCongTrinhXayDung";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng chi phí kiểm tra công tác nghiệm thu công trình xây dựng</para>
        /// <para> Tham số 2 chỉ số dòng chi phí giám sát thi công xây dựng</para>
        /// </summary>
        /// <param name="args"> </param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            // C59*F45
            return $"=C{args[0]}*F{args[1]}"; // Cột C: định mức chi phí kiểm tra công tác nghiệm thu công trình xây dựng, cột F: chi phí giám sát thi công xây dựng
        }
        public override string formula(string hmId, string[] args)
        {
            // C59*F45
            return $"=C{args[0]}*F{args[1]}"; // Cột C: định mức chi phí kiểm tra công tác nghiệm thu công trình xây dựng, cột F: chi phí giám sát thi công xây dựng
        }
    }
}

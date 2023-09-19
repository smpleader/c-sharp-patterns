using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopkinhphi.thongtu112021
{
    /// <summary>
    /// Trước thuế chi phí khác
    /// </summary>
    public class colFCPK : ACell
    {
        public colFCPK(Option opt) : base(opt)
        {
        }
        public override string CName => "F";
        public override string UName => "THKP_TT11_TruocThueChiPhiKhac";

        /// <summary>
        /// 3 tham số
        /// <para> Tham số 1 chỉ số dòng chi phí khác</para>
        /// <para> Tham số 2 chỉ số dòng bắt đầu phần con của chi phí khác</para>
        /// <para> Tham số 3 chỉ số dòng kết thúc phần con của chi phí khác</para>
        /// </summary>
        /// <param name="args"> </param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            // IF(J50>0;SUMIF(J51:J58;1;F51:F58);0)
            return $"=IF(J{args[0]}>0;SUMIF(J{args[1]}:J{args[2]};1;F{args[1]}:F{args[2]});0)"; // Cột J: có tính, cột F: giá trị trước thuế
        }
        public override string formula(string hmId, string[] args)
        {
            // IF(J50>0;SUMIF(J51:J58;1;F51:F58);0)
            return $"=IF(J{args[0]}>0;SUMIF(J{args[1]}:J{args[2]};1;F{args[1]}:F{args[2]});0)"; // Cột J: có tính, cột F: giá trị trước thuế
        }
    }
}
using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopkinhphi.thongtu112021
{
    /// <summary>
    /// 3/ Thuế chi phí quản lý dự án
    /// </summary>
    public class colGQLDA : ACell
    {
        public colGQLDA(Option opt) : base(opt)
        {
        }
        public override string CName => "G";
        public override string UName => "THKP_TT11_ThueChiPhiQuanLyDuAn";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số chỉ số dòng chi phí quản lý dự án </para>
        /// </summary>
        /// <param name="args"> </param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            // IF(J13>0;ROUND(F13*C7;0);0)
            return $"=IF(J{args[0]}>0;ROUND(F{args[0]}*C7;0);0)"; // Cột J: có tính, cột F: giá trị trước thuế, cột C: thuế VAT
        }
        public override string formula(string hmId, string[] args)
        {
            // IF(J13>0;ROUND(F13*C7;0);0)
            return $"=IF(J{args[0]}>0;ROUND(F{args[0]}*C7;0);0)"; // Cột J: có tính, cột F: giá trị trước thuế, cột C: thuế VAT
        }
    }
}
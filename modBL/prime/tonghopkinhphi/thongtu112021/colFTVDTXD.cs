using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopkinhphi.thongtu112021
{
    /// <summary>
    /// Trước thuế chi phí tư vấn đầu tư xây dựng
    /// </summary>
    public class colFTVDTXD : ACell
    {
        public colFTVDTXD(Option opt) : base(opt)
        {
        }
        public override string CName => "F";
        public override string UName => "THKP_TT11_TruocThueChiPhiTuVanDauTuXayDung";

        /// <summary>
        /// 3 tham số
        /// <para> Tham số 1 chỉ số dòng chi phí tư vấn đầu tư xây dựng</para>
        /// <para> Tham số 2 chỉ số dòng bắt đầu phần con của chi phí đầu tư xây dựng</para>
        /// <para> Tham số 3 chỉ số dòng kết thúc phần con của chi phí đầu tư xây dựng</para>
        /// </summary>
        /// <param name="args"> </param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            // IF(J14>0;ROUND(SUMIF(J15:J49;1;F15:F49);0);0)
            return $"=IF(J{args[0]}>0;ROUND(SUMIF(J{args[1]}:J{args[2]};1;F{args[1]}:F{args[2]});0);0)"; // Cột J: có tính, cột F: giá trị trước thuế
        }
        public override string formula(string hmId, string[] args)
        {
            // IF(J14>0;ROUND(SUMIF(J15:J49;1;F15:F49);0);0)
            return $"=IF(J{args[0]}>0;ROUND(SUMIF(J{args[1]}:J{args[2]};1;F{args[1]}:F{args[2]});0);0)"; // Cột J: có tính, cột F: giá trị trước thuế
        }
    }
}
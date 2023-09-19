using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopkinhphi.thongtu112021
{
    /// <summary>
    /// Trước thuế chi phí xây dựng
    /// </summary>
    public class colFCPXD : ACell
    {
        public colFCPXD(Option opt) : base(opt)
        {
        }
        public override string CName => "F";
        public override string UName => "THKP_TT11_TruocThueChiPhiXayDung";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng hạng mục đầu tiên </para>
        /// <para> Tham số 2 chỉ số dòng hạng mục cuối cùng </para>
        /// </summary>
        /// <param name="args"> </param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            // SUM(F10:F11)
            return $"=SUM(F{args[0]}:F{args[1]})"; // Cột F: giá trị trước thuế
        }
        public override string formula(string hmId, string[] args)
        {
            // SUM(F10:F11)
            return $"=SUM(F{args[0]}:F{args[1]})"; // Cột F: giá trị trước thuế
        }
    }
}
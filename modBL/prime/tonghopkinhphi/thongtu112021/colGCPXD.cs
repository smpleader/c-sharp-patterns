using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopkinhphi.thongtu112021
{
    /// <summary>
    /// 1/ Thuế chi phí xây dựng
    /// </summary>
    public class colGCPXD : ACell
    {
        public colGCPXD(Option opt) : base(opt)
        {
        }
        public override string CName => "G";
        public override string UName => "THKP_TT11_ThueChiPhiXayDung";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng hạng mục đầu tiên </para>
        /// <para> Tham số 1 chỉ số dòng hạng mục cuối cùng </para>
        /// </summary>
        /// <param name="args"> </param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            // SUM(G10:G11)
            return $"=SUM(G{args[0]}:G{args[1]})"; // Cột G: thuế GTGT hạng mục
        }
        public override string formula(string hmId, string[] args)
        {
            // SUM(G10:G11)
            return $"=SUM(G{args[0]}:G{args[1]})"; // Cột G: thuế GTGT hạng mục
        }
    }
}
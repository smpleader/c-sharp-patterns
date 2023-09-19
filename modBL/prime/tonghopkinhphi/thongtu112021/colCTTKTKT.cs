using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopkinhphi.thongtu112021
{
    /// <summary>
    /// Định mức chi phí thẩm tra Báo cáo kinh tế kỹ thuật
    /// </summary>
    public class colCTTKTKT : ACell
    {
        public colCTTKTKT(Option opt) : base(opt)
        {
        }
        public override string CName => "C";
        public override string UName => "THKP_TT11_DinhMucChiPhiThamTraBaoCaoKinhTeKyThuat";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng chi phí thẩm tra thiết kế xây dựng </para>
        /// <para> Tham số 2 chỉ số dòng chi phí thẩm tra dự toán công trình </para>
        /// </summary>
        /// <param name="args"> </param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            // C31+C33
            return $"=C{args[0]}+C{args[1]}"; // Cột C: Định mức chi phí thẩm tra thiết kế xây dựng, định mức chi phí thẩm tra dự toán công trình
        }
        public override string formula(string hmId, string[] args)
        {
            // C31+C33
            return $"=C{args[0]}+C{args[1]}"; // Cột C: Định mức chi phí thẩm tra thiết kế xây dựng, định mức chi phí thẩm tra dự toán công trình
        }
    }
}
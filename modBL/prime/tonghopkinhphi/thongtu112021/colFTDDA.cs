using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopkinhphi.thongtu112021
{
    /// <summary>
    /// Trước thuế phí thẩm định dự án đầu tư xây dựng
    /// </summary>
    public class colFTDDA : ACell
    {
        public colFTDDA(Option opt) : base(opt)
        {
        }
        public override string CName => "F";
        public override string UName => "THKP_TT11_TruocThuePhiThamDinhDuAnDauTuXayDung";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng làm tròn </para>
        /// <para> Tham số 2 chỉ số dòng phí thẩm định dự án đầu tư xây dựng </para>
        /// </summary>
        /// <param name="args"> </param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            // K64*C54
            return $"=K{args[0]}*C{args[1]}"; // Cột K: chưa có tên cột (giá trị làm tròn sau thuế), cột C: định mức phí thẩm định dự án đầu tư xây dựng
        }
        public override string formula(string hmId, string[] args)
        {
            // K64*C54
            return $"=K{args[0]}*C{args[1]}"; // Cột K: chưa có tên cột (giá trị làm tròn sau thuế), cột C: định mức phí thẩm định dự án đầu tư xây dựng
        }
    }
}
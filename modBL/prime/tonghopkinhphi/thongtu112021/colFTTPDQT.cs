using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopkinhphi.thongtu112021
{
    /// <summary>
    /// Trước thuế chi phí thẩm tra phê duyệt quyết toán
    /// </summary>
    public class colFTTPDQT : ACell
    {
        public colFTTPDQT(Option opt) : base(opt)
        {
        }
        public override string CName => "F";
        public override string UName => "THKP_TT11_TruocThueChiPhiThamTraPheDuyetQuyetToan";

        /// <summary>
        /// 3 tham số
        /// <para> Tham số 1 chỉ số dòng làm tròn </para>
        /// <para> Tham số 2 chỉ số dòng chi phí dự phòng </para>
        /// <para> Tham số 3 chỉ số dòng chi phí thẩm tra phê duyệt quyết toán </para>
        /// </summary>
        /// <param name="args"> </param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            // MAX(ROUND((K64-K60)*C55;0);IF(C55 > 0;500000;0))
            return $"=MAX(ROUND((K{args[0]}-K{args[1]})*C{args[2]};0);IF(C{args[2]} > 0;500000;0))"; // Cột K: chưa có tên cột (giá trị làm tròn, chi phí dự phòng sau thuế), cột C: định mức chi phí thẩm tra phê duyệt quyết toán
        }
        public override string formula(string hmId, string[] args)
        {
            // MAX(ROUND((K64-K60)*C55;0);IF(C55 > 0;500000;0))
            return $"=MAX(ROUND((K{args[0]}-K{args[1]})*C{args[2]};0);IF(C{args[2]} > 0;500000;0))"; // Cột K: chưa có tên cột (giá trị làm tròn, chi phí dự phòng sau thuế), cột C: chi phí thẩm tra phê duyệt quyết toán
        }
    }
}

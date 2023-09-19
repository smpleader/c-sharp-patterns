using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopkinhphi.thongtu112021
{
    /// <summary>
    /// Định mức chi phí thẩm tra phê duyệt quyết toán
    /// </summary>
    public class colCTTPDQT : ACell
    {
        public colCTTPDQT(Option opt) : base(opt)
        {
        }
        public override string CName => "C";
        public override string UName => "THKP_TT11_DinhMucChiPhiThamTraPheDuyetQuyetToan";

        /// <summary>
        /// 0 tham số
        /// <para> </para>
        /// </summary>
        /// <param name="args"> </param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            // 'Tra định mức'!J438
            return $"='{SheetName.TRA_DINH_MUC}'!J438"; // Cột J: giá trị
        }
        public override string formula(string hmId, string[] args)
        {
            // 'Tra định mức'!J438
            return $"='{SheetName.TRA_DINH_MUC}_{hmId}'!J438"; // Cột J: giá trị
        }
    }
}
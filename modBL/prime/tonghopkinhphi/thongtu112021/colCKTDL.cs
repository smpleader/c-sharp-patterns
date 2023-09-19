using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopkinhphi.thongtu112021
{
    /// <summary>
    /// Định mức chi phí kiểm toán độc lập
    /// </summary>
    public class colCKTDL : ACell
    {
        public colCKTDL(Option opt) : base(opt)
        {
        }
        public override string CName => "C";
        public override string UName => "THKP_TT11_DinhMucChiPhiKiemToanDocLap";

        /// <summary>
        /// 0 tham số
        /// <para> </para>
        /// </summary>
        /// <param name="args"> </param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            // 'Tra định mức'!J437
            return $"='{SheetName.TRA_DINH_MUC}'!J437"; // Cột J: giá trị
        }
        public override string formula(string hmId, string[] args)
        {
            // 'Tra định mức'!J437
            return $"='{SheetName.TRA_DINH_MUC}_{hmId}'!J437"; // Cột J: giá trị
        }
    }
}
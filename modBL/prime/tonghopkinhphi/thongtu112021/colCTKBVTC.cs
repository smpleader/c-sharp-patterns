using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopkinhphi.thongtu112021
{
    /// <summary>
    /// Định mức chi phí thiết kế bản vẽ thi công
    /// </summary>
    public class colCTKBVTC : ACell
    {
        public colCTKBVTC(Option opt) : base(opt)
        {
        }
        public override string CName => "C";
        public override string UName => "THKP_TT11_DinhMucChiPhiThietKeBanVeThiCong";

        /// <summary>
        /// tham số
        /// <para> </para>
        /// </summary>
        /// <param name="args"> </param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            // IF(OR(C4='Tra định mức'!W229; C4='Tra định mức'!W230);VLOOKUP(C3&'Tra định mức'!W229&C5;'Tra định mức'!T229:U291;2;FALSE);0)*1/100
            return $"=IF(OR(C4='{SheetName.TRA_DINH_MUC}'!W229; C4='{SheetName.TRA_DINH_MUC}'!W230);VLOOKUP(C3&'{SheetName.TRA_DINH_MUC}'!W229&C5;'{SheetName.TRA_DINH_MUC}'!T229:U291;2;FALSE);0)*1/100"; // Cột W: loại thiết kế, cột C: loại công trình, loại thiết kế, cấp công trình, cột T: loại công trình, loại thiết kế, cấp công trình, cột U: giá trị
        }
        public override string formula(string hmId, string[] args)
        {
            // IF(OR(C4='Tra định mức'!W229; C4='Tra định mức'!W230);VLOOKUP(C3&'Tra định mức'!W229&C5;'Tra định mức'!T229:U291;2;FALSE);0)*1/100
            return $"=IF(OR(C4='{SheetName.TRA_DINH_MUC}_{hmId}'!W229; C4='{SheetName.TRA_DINH_MUC}_{hmId}'!W230);VLOOKUP(C3&'{SheetName.TRA_DINH_MUC}_{hmId}'!W229&C5;'{SheetName.TRA_DINH_MUC}_{hmId}'!T229:U291;2;FALSE);0)*1/100"; // Cột W: loại thiết kế, cột C: loại công trình, loại thiết kế, cấp công trình, cột T: loại công trình, loại thiết kế, cấp công trình, cột U: giá trị
        }
    }
}
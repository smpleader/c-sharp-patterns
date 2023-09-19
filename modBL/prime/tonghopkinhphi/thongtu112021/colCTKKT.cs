using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopkinhphi.thongtu112021
{
    /// <summary>
    /// Định mức chi phí thiết kế kỹ thuật
    /// </summary>
    public class colCTKKT : ACell
    {
        public colCTKKT(Option opt) : base(opt)
        {
        }
        public override string CName => "C";
        public override string UName => "THKP_TT11_DinhMucChiPhiThietKeKyThuat";

        /// <summary>
        /// tham số
        /// <para> </para>
        /// </summary>
        /// <param name="args"> </param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            // IF(C4='Tra định mức'!W230;VLOOKUP(C3&C4&C5;'Tra định mức'!T229:U291;2;FALSE);0)*1/100
            return $"=IF(C4='{SheetName.TRA_DINH_MUC}'!W230;VLOOKUP(C3&C4&C5;'{SheetName.TRA_DINH_MUC}'!T229:U291;2;FALSE);0)*1/100"; // Cột W: loại thiết kế, cột C: loại công trình, loại thiết kế, cấp công trình, cột T: loại công trình, loại thiết kế, cấp công trình, cột U: giá trị
        }
        public override string formula(string hmId, string[] args)
        {
            // IF(C4='Tra định mức'!W230;VLOOKUP(C3&C4&C5;'Tra định mức'!T229:U291;2;FALSE);0)*1/100
            return $"=IF(C4='{SheetName.TRA_DINH_MUC}_{hmId}'!W230;VLOOKUP(C3&C4&C5;'{SheetName.TRA_DINH_MUC}_{hmId}'!T229:U291;2;FALSE);0)*1/100"; // Cột W: loại thiết kế, cột C: loại công trình, loại thiết kế, cấp công trình, cột T: loại công trình, loại thiết kế, cấp công trình, cột U: giá trị
        }
    }
}

using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopkinhphi.thongtu112021
{
    /// <summary>
    /// Định mức chi phí giám sát thi công xây dựng
    /// </summary>
    public class colCGSTK : ACell
    {
        public colCGSTK(Option opt) : base(opt)
        {
        }
        public override string CName => "C";
        public override string UName => "THKP_TT11_DinhMucChiPhiGiamSatThiCongXayDung";

        /// <summary>
        /// tham số
        /// <para> </para>
        /// </summary>
        /// <param name="args"> </param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            // VLOOKUP(C3;'Tra định mức'!B379:N383;13;FALSE)*1/100
            return $"=VLOOKUP(C3;'{SheetName.TRA_DINH_MUC}'!B379:N383;13;FALSE)*1/100"; // Cột C: loại công trình, cột B: loại công trình, cột N: giá trị
        }
        public override string formula(string hmId, string[] args)
        {
            // VLOOKUP(C3;'Tra định mức'!B379:N383;13;FALSE)*1/100
            return $"=VLOOKUP(C3;'{SheetName.TRA_DINH_MUC}_{hmId}'!B379:N383;13;FALSE)*1/100"; // Cột C: loại công trình, cột B: loại công trình, cột N: giá trị
        }
    }
}

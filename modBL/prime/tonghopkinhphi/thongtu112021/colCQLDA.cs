using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopkinhphi.thongtu112021
{
    /// <summary>
    /// Định mức chi phí quản lý dự án
    /// </summary>
    public class colCQLDA : ACell
    {
        public colCQLDA(Option opt) : base(opt)
        {
        }
        public override string CName => "C";
        public override string UName => "THKP_TT11_DinhMucChiPhiQuanLyDuAn";

        /// <summary>
        /// 0 tham số
        /// <para></para>
        /// </summary>
        /// <param name="args"> </param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            // VLOOKUP(C3;'Tra định mức'!B179:O183;14;FALSE)*1/100
            return $"=VLOOKUP(C3;'{SheetName.TRA_DINH_MUC}'!B179:O183;14;FALSE)*1/100"; // Cột C: loại công trình, cột B: loại công trình, cột 0: giá trị
        }
        public override string formula(string hmId, string[] args)
        {
            // VLOOKUP(C3;'Tra định mức'!B179:O183;14;FALSE)*1/100
            return $"=VLOOKUP(C3;'{SheetName.TRA_DINH_MUC}_{hmId}'!B179:O183;14;FALSE)*1/100"; // Cột C: loại công trình, cột B: loại công trình, cột 0: giá trị
        }
    }
}

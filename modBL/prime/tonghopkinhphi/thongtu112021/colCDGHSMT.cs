using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopkinhphi.thongtu112021
{
    /// <summary>
    /// Định mức chi phí lập đánh giá hồ sơ mời thầu hồ sơ dự thầu
    /// </summary>
    public class colCDGHSMT : ACell
    {
        public colCDGHSMT(Option opt) : base(opt)
        {
        }
        public override string CName => "C";
        public override string UName => "THKP_TT11_DinhMucChiPhiLapDanhGiaHoSoMoiThauHoSoDuThau";

        /// <summary>
        /// 0 tham số
        /// <para> </para>
        /// </summary>
        /// <param name="args"> </param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            // VLOOKUP(C3;'Tra định mức'!B355:K359;10;FALSE)*1/100
            return $"=VLOOKUP(C3;'{SheetName.TRA_DINH_MUC}'!B355:K359;10;FALSE)*1/100"; // Cột C: loại công trình, cột B: loại công trình, cột K: giá trị
        }
        public override string formula(string hmId, string[] args)
        {
            // VLOOKUP(C3;'Tra định mức'!B355:K359;10;FALSE)*1/100
            return $"=VLOOKUP(C3;'{SheetName.TRA_DINH_MUC}_{hmId}'!B355:K359;10;FALSE)*1/100"; // Cột C: loại công trình, cột B: loại công trình, cột K: giá trị
        }
    }
}
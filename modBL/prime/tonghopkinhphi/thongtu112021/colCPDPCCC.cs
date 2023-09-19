using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopkinhphi.thongtu112021
{
    /// <summary>
    /// Định mức chi phí thẩm định phê duyệt thiết kế về phòng cháy và chữa cháy
    /// </summary>
    public class colCPDPCCC : ACell
    {
        public colCPDPCCC(Option opt) : base(opt)
        {
        }
        public override string CName => "C";
        public override string UName => "THKP_TT11_DinhMucChiPhiThamDinhPheDuyetThietKeVePhongChayVaChuaChay";

        /// <summary>
        /// 0 tham số
        /// <para> </para>
        /// </summary>
        /// <param name="args"> </param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            // VLOOKUP(C3;'Tra định mức'!B414:I418;8;FALSE)*1/100
            return $"=VLOOKUP(C3;'{SheetName.TRA_DINH_MUC}'!B414:I418;8;FALSE)*1/100"; // Cột C: loại công trình, cột B: loại công trình, cột I: giá trị
        }
        public override string formula(string hmId, string[] args)
        {
            // VLOOKUP(C3;'Tra định mức'!B414:I418;8;FALSE)*1/100
            return $"=VLOOKUP(C3;'{SheetName.TRA_DINH_MUC}_{hmId}'!B414:I418;8;FALSE)*1/100"; // Cột C: loại công trình, cột B: loại công trình, cột I: giá trị
        }
    }
}
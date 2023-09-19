using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopkinhphi.thongtu112021
{
    /// <summary>
    /// Trước thuế chi phí thẩm định phê duyệt thiết kế về phòng cháy và chữa cháy
    /// </summary>
    public class colFTDPCCC : ACell
    {
        public colFTDPCCC(Option opt) : base(opt)
        {
        }
        public override string CName => "F";
        public override string UName => "THKP_TT11_TruocThueChiPhiThamDinhPheDuyetThietKeVePhongChayVaChuaChay";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng làm tròn</para>
        /// <para> Tham số 2 chỉ số dòng chi phí thẩm định phê duyệt thiết kế về phòng cháy và chữa cháy</para>
        /// </summary>
        /// <param name="args"> </param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            // MIN(MAX(ROUND((K64)*C58;0);IF(C58>0;500000;0));150000000)
            return $"=MIN(MAX(ROUND((K{args[0]})*C{args[1]};0);IF(C{args[1]}>0;500000;0));150000000)"; // Cột K chưa có tên cột (giá trị sau thuế làm tròn), cột C: định mức chi phí thẩm định phê duyệt thiết kế về phòng cháy và chữa cháy 
        }
        public override string formula(string hmId, string[] args)
        {
            // MIN(MAX(ROUND((K64)*C58;0);IF(C58>0;500000;0));150000000)
            return $"=MIN(MAX(ROUND((K{args[0]})*C{args[1]};0);IF(C{args[1]}>0;500000;0));150000000)"; // Cột K chưa có tên cột (giá trị sau thuế làm tròn), cột C: định mức chi phí thẩm định phê duyệt thiết kế về phòng cháy và chữa cháy
        }
    }
}
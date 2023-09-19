using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopkinhphi.thongtu112021
{
    /// <summary>
    /// Trước thuế chi phí lập báo cáo nghiên cứu tiền khả thi
    /// </summary>
    public class colFNCTKT : ACell
    {
        public colFNCTKT(Option opt) : base(opt)
        {
        }
        public override string CName => "F";
        public override string UName => "THKP_TT11_TruocThueChiPhiLapBaoCaoNghienCuuTienKhaThi";

        /// <summary>
        /// 3 tham số
        /// <para> Tham số 1 chỉ số dòng chi phí xây dựng</para>
        /// <para> Tham số 2 chỉ số dòng chi phí thiết bị</para>
        /// <para> Tham số 3 chỉ số dòng chi phí lập báo cáo nghiên cứu tiền khả thi</para>
        /// </summary>
        /// </summary>
        /// <param name="args"> </param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            // ROUND(PRODUCT(F9+F12;C21;D21);0)
            return $"=ROUND(PRODUCT(F{args[0]}+F{args[1]};C{args[2]};D{args[2]});0)"; // cột F: giá trị trước thuế, cột C: định mức chi phí lập báo cáo nghiên cứu tiền khả thi, cột D: hệ số chi phí lập báo cáo nghiên cứu tiền khả thi
        }
        public override string formula(string hmId, string[] args)
        {
            // ROUND(PRODUCT(F9+F12;C21;D21);0)
            return $"=ROUND(PRODUCT(F{args[0]}+F{args[1]};C{args[2]};D{args[2]});0)"; // cột F: giá trị trước thuế, cột C: định mức chi phí lập báo cáo nghiên cứu tiền khả thi, cột D: hệ số chi phí lập báo cáo nghiên cứu tiền khả thi
        }
    }
}
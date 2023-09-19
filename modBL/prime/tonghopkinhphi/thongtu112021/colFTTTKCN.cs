using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopkinhphi.thongtu112021
{
    /// <summary>
    /// Trước thuế chi phí thẩm tra thiết kế công nghệ
    /// </summary>
    public class colFTTTKCN : ACell
    {
        public colFTTTKCN(Option opt) : base(opt)
        {
        }
        public override string CName => "F";
        public override string UName => "THKP_TT11_TruocThueChiPhiThamTraThietKeCongNghe";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng nghiên cứu thẩm tra báo cáo khả thi</para>
        /// <para> Tham số 2 chỉ số dòng thẩm tra thiết kế công nghệ</para>
        /// </summary>
        /// <param name="args"> </param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            // ROUND(PRODUCT(F25;C26;D26);0)
            return $"=ROUND(PRODUCT(F{args[0]};C{args[1]};D{args[1]});0)"; // cột F: giá trị trước thuế, cột C: định mức chi phí thẩm  tra thiết kế công nghệ, cột D; hệ số chi phí thẩm tra thiết kế công nghệ
        }
        public override string formula(string hmId, string[] args)
        {
            // ROUND(PRODUCT(F25;C26;D26);0)
            return $"=ROUND(PRODUCT(F{args[0]};C{args[1]};D{args[1]});0)"; // cột F: giá trị trước thuế, cột C: định mức chi phí thẩm  tra thiết kế công nghệ, cột D; hệ số chi phí thẩm tra thiết kế công nghệ
        }
    }
}
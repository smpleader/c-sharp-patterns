using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopkinhphi.thongtu112021
{
    /// <summary>
    /// Định mức chi phí dự phòng cho yếu tố trượt giá
    /// </summary>
    public class colCDPTG : ACell
    {
        public colCDPTG(Option opt) : base(opt)
        {
        }
        public override string CName => "C";
        public override string UName => "THKP_TT11_DinhMucChiPhiDuPhongChoYeuToTruotGia";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng chí phí dự phòng cho yếu tố trượt giá</para>
        /// <para> Tham số 2 chỉ số dòng tổng cộng</para>
        /// </summary>
        /// <param name="args"> </param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            // ROUND(H62/H63;5)
            return $"=ROUND(H{args[0]}/H{args[1]};5)"; //Cột H: giá trị sau
        }
        public override string formula(string hmId, string[] args)
        {
            // ROUND(H62/H63;5)
            return $"=ROUND(H{args[0]}/H{args[1]};5)"; //Cột H: giá trị sau
        }
    }
}
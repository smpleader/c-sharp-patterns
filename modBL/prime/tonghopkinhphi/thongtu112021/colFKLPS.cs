using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopkinhphi.thongtu112021
{
    /// <summary>
    /// Trước thuế chi phí dự phòng cho yếu tố khối lượng phát sinh
    /// </summary>
    public class colFKLPS : ACell
    {
        public colFKLPS(Option opt) : base(opt)
        {
        }
        public override string CName => "F";
        public override string UName => "THKP_TT11_TruocThueChiPhiDuPhongChoYeuToKhoiLuongPhatSinh";

        /// <summary>
        /// 6 tham số
        /// <para> Tham số 1 chỉ số dòng chi phí xây dựng</para>
        /// <para> Tham số 2 chỉ số dòng chi phí thiết bị</para>
        /// <para> Tham số 3 chỉ số dòng chi phí quản lý dự án</para>
        /// <para> Tham số 4 chỉ số dòng chi phí tư vấn đầu tư xây dựng</para>
        /// <para> Tham số 5 chỉ số dòng chi phí khác</para>
        /// <para> Tham số 6 chỉ số dòng chi phí dự phòng cho yếu tố khối lượng phát sinh</para>
        /// </summary>
        /// <param name="args"> </param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            // ROUND(PRODUCT(F9+F12+F13+F14+F50;C61;D61);0)
            return $"=ROUND(PRODUCT(F{args[0]}+F{args[1]}+F{args[2]}+F{args[3]}+F{args[4]};C{args[5]};D{args[5]});0)"; // Cột F: giá trị trước thuế, cột D: định mức tổng cộng
        }
        public override string formula(string hmId, string[] args)
        {
            // ROUND(PRODUCT(F9+F12+F13+F14+F50;C61;D61);0)
            return $"=ROUND(PRODUCT(F{args[0]}+F{args[1]}+F{args[2]}+F{args[3]}+F{args[4]};C{args[5]};D{args[5]});0)"; // Cột F: giá trị trước thuế, cột D: định mức tổng cộng
        }
    }
}

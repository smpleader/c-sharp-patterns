using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopkinhphi.thongtu112021
{
    /// <summary>
    /// Trước thuế chi phí dự phòng
    /// </summary>
    public class colFDP : ACell
    {
        public colFDP(Option opt) : base(opt)
        {
        }
        public override string CName => "F";
        public override string UName => "THKP_TT11_TruocThueChiPhiDuPhong";

        /// <summary>
        /// 3 tham số
        /// <para> Tham số 1 chỉ số dòng chi phí dự phòng</para>
        /// <para> Tham số 2 chỉ số dòng chi phí dự phòng cho yếu tố khối lượng phát sinh</para>
        /// <para> Tham số 3 chỉ số dòng chi phí dự phòng cho yếu tố trượt giá</para>
        /// </summary>
        /// <param name="args"> </param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            // IF(J60>0;F61+F62;0)
            return $"=IF(J{args[0]}>0;F{args[1]}+F{args[2]};0)"; // Cột J: có tính, cột F: giá trị trước thuế
        }
        public override string formula(string hmId, string[] args)
        {
            // IF(J60>0;F61+F62;0)
            return $"=IF(J{args[0]}>0;F{args[1]}+F{args[2]};0)"; // Cột J: có tính, cột F: giá trị trước thuế
        }
    }
}
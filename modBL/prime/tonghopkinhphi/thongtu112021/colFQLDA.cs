using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopkinhphi.thongtu112021
{
    /// <summary>
    /// Trước thuế chi phí quản lý dự án
    /// </summary>
    public class colFQLDA : ACell
    {
        public colFQLDA(Option opt) : base(opt)
        {
        }
        public override string CName => "F";
        public override string UName => "THKP_TT11_TruocThueChiPhiQuanLyDuAn";

        /// <summary>
        /// 3 tham số
        /// <para> Tham số 1 chỉ số dòng chi phí quản lý dự án </para>
        /// <para> Tham số 2 chỉ số dòng chi phí xây dựng </para>
        /// <para> Tham số 3 chỉ số dòng chi phí thiết bị </para>
        /// </summary>
        /// <param name="args"> </param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            // IF(J13>0;ROUND(PRODUCT(F9+F12;C13;D13);0);0)
            return $"=IF(J{args[0]}>0;ROUND(PRODUCT(F{args[1]}+F{args[2]};C{args[0]};D{args[0]});0);0)"; // Cột J: có tính, cột F: giá trị trước thuế, cột C: định mức, cột D: hệ số
        }
        public override string formula(string hmId, string[] args)
        {
            // IF(J13>0;ROUND(PRODUCT(F9+F12;C13;D13);0);0)
            return $"=IF(J{args[0]}>0;ROUND(PRODUCT(F{args[1]}+F{args[2]};C{args[0]};D{args[0]});0);0)"; // Cột J: có tính, cột F: giá trị trước thuế, cột C: định mức, cột D: hệ số
        }
    }
}
﻿using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopkinhphi.thongtu112021
{
    /// <summary>
    /// Trước thuế chi phí đánh giá hồ sơ dự thầu hồ sơ đề xuất
    /// </summary>
    public class colFDGHSDT : ACell
    {
        public colFDGHSDT(Option opt) : base(opt)
        {
        }
        public override string CName => "F";
        public override string UName => "THKP_TT11_TruocThueChiPhiDanhGiaHoSoDuThauHoSoDeXuat";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng GXD (Dự toán gói thầu)</para>
        /// <para> Tham số 2 chỉ số dòng chi phí đánh giá hồ sơ dự thầu hồ sơ đề xuất</para>
        /// </summary>
        /// <param name="args"> </param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            // ROUND(IF(F34*C42<1000000;1000000;IF(F34*C42>50000000;50000000;F34*C42));0)
            return $"=ROUND(IF(F{args[0]}*C{args[1]}<1000000;1000000;IF(F{args[0]}*C{args[1]}>50000000;50000000;F{args[0]}*C{args[1]}));0)"; // cột F: giá trị trước thuế, cột C: định mức chi phí đánh giá hồ sơ dự thầu hồ sơ đề xuất
        }
        public override string formula(string hmId, string[] args)
        {
            // ROUND(IF(F34*C42<1000000;1000000;IF(F34*C42>50000000;50000000;F34*C42));0)
            return $"=ROUND(IF(F{args[0]}*C{args[1]}<1000000;1000000;IF(F{args[0]}*C{args[1]}>50000000;50000000;F{args[0]}*C{args[1]}));0)"; // cột F: giá trị trước thuế, cột C: định mức chi phí đánh giá hồ sơ dự thầu hồ sơ đề xuất
        }
    }
}
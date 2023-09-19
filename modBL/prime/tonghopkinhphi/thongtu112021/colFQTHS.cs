﻿using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopkinhphi.thongtu112021
{
    /// <summary>
    /// Trước thuế chi phí lập hồ sơ mời quan tâm hồ sơ mời sơ tuyển
    /// </summary>
    public class colFQTHS : ACell
    {
        public colFQTHS(Option opt) : base(opt)
        {
        }
        public override string CName => "F";
        public override string UName => "THKP_TT11_TruocThueChiPhiLapHoSoMoiQuanTamHoSoMoiSoTuyen";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng GXD (Dự toán gói thầu)</para>
        /// <para> Tham số 2 chỉ số dòng chi phí lập hồ sơ mời quan tâm hồ sơ mời sơ tuyển</para>
        /// </summary>
        /// <param name="args"> </param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            // ROUND(IF(F34*C37<1000000;1000000;IF(F34*C37>30000000;30000000;F34*C37));0)
            return $"=ROUND(IF(F{args[0]}*C{args[1]}<1000000;1000000;IF(F{args[0]}*C{args[1]}>30000000;30000000;F{args[0]}*C{args[1]}));0)"; // cột F: giá trị trước thuế, cột C: định mức chi phí lập hồ sơ mời quan tâm hồ sơ mời sơ tuyển
        }
        public override string formula(string hmId, string[] args)
        {
            // ROUND(IF(F34*C37<1000000;1000000;IF(F34*C37>30000000;30000000;F34*C37));0)
            return $"=ROUND(IF(F{args[0]}*C{args[1]}<1000000;1000000;IF(F{args[0]}*C{args[1]}>30000000;30000000;F{args[0]}*C{args[1]}));0)"; // cột F: giá trị trước thuế, cột C: định mức chi phí lập hồ sơ mời quan tâm hồ sơ mời sơ tuyển
        }
    }
}
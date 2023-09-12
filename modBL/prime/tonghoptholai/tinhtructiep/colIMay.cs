using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghoptholai.tinhtructiep
{
    // Hao phí nhân công theo máy
    public class colIMay : ACell
    {
        public colIMay(Option opt) : base(opt)
        {
        }

        public override string CName => "I";
        public override string UName => "TongHopTL_TinhTT_HaoPhiNhanCongTheoMay";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng máy có nhân công đó</para>
        /// <para> Tham số 2 chỉ số dòng nhân công</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=F{args[0]}*G{args[0]}*H{args[1]}"; // Cột F: Khối lượng máy, cột G: Định mức máy, cột H: hệ số
        }
    }
}

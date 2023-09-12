using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopnhienlieu.tinhtructiep
{
    // Hao phí nhiên liệu theo máy
    public class colIMay : ACell
    {
        public colIMay(Option opt) : base(opt)
        {
        }

        public override string CName => "I";
        public override string UName => "TongHopNL_TinhTT_HaoPhiNhienLieuTheoMay";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng máy có nhiên liệu đó</para>
        /// <para> Tham số 2 chỉ số dòng nhiên liệu</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=F{args[0]}*G{args[0]}*H{args[1]}"; // Cột F: Khối lượng máy, cột G: Định mức máy, cột H: nhiên liệu phụ
        }
    }
}

using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghoptholai.bugia
{
    // Hao phí nhân công
    public class colINC : ACell
    {
        public colINC(Option opt) : base(opt)
        {
        }

        public override string CName => "I";
        public override string UName => "TongHopTL_BuGia_HaoPhiNhanCong";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng bắt đầu máy có nhân công đó</para>
        /// <para> Tham số 2 chỉ số dòng kết thúc máy có nhân công đó</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=SUM(I{args[0]}:I{args[1]})"; // Cột I: Hao phí nhân công theo máy
        }
    }
}

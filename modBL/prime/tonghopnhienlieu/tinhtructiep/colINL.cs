using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopnhienlieu.tinhtructiep
{
    // Hao phí nhiên liệu
    public class colINL : ACell
    {
        public colINL(Option opt) : base(opt)
        {
        }

        public override string CName => "I";
        public override string UName => "TongHopNL_TinhTT_HaoPhiNhienLieu";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng bắt đầu máy có nhiên liệu đó</para>
        /// <para> Tham số 2 chỉ số dòng kết thúc máy có nhiên liệu đó</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=SUM(I{args[0]}:I{args[1]})"; // Cột I: Hao phí nhiên liệu theo máy
        }
    }
}

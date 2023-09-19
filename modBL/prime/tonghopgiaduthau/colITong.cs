using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopgiaduthau
{
    // Tổng giá dự thầu
    public class colITong : ACell
    {
        public colITong(Option opt) : base(opt)
        {
        }

        public override string CName => "I";
        public override string UName => "THDGDT_TongGiaDuThau";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng hạng mục đầu tiên</para>
        /// <para> Tham số 2 chỉ số dòng hạng mục cuối cùng</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='SUM(I{args[0]}:K{args[1]})"; // Cột I, K: giá dự thầu
        }
        public override string formula(string hmId, string[] args)
        {
            return $"='SUM(I{args[0]}:K{args[1]})"; // Cột I, K: giá dự thầu
        }
    }
}

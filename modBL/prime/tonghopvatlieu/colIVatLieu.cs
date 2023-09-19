using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopvatlieu
{
    /// <summary>
    /// Hao phí vật liệu
    /// </summary>
    public class colIVatLieu : ACell
    {
        public colIVatLieu(Option opt) : base(opt)
        {
        }

        public override string CName => "I";
        public override string UName => "THVL_HaoPhiVatLieu";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng bắt đầu công việc có vật liệu đó</para>
        /// <para> Tham số 2 chỉ số dòng kết thúc công việc có vật liệu đó</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=SUM(I{args[0]}:I{args[1]})"; // Cột I: Hao phí vật liệu
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=SUM(I{args[0]}:I{args[1]})"; // Cột I: Hao phí vật liệu
        }
    }
}

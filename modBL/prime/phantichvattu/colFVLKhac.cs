using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.phantichvattu
{
    /// <summary>
    /// Định mức vật liệu khác
    /// </summary>
    public class colFVLKhac : ACell
    {
        public colFVLKhac(Option opt) : base(opt)
        {
        }

        public override string CName => "F";
        public override string UName => "PTVT_DinhMucVatLieuKhac";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng vật liệu đầu tiên  </para>
        /// <para> Tham số 2 chỉ số dòng vật liệu cuối cùng  </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=AVERAGE(O{args[0]}:O{args[1]})"; // Cột O: Định mức vật liệu khác
        }
    }
}

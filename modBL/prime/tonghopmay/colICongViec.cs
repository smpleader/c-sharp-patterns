using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopmay
{
    // Hao phí theo công việc
    public class colICongViec : ACell
    {
        public colICongViec(Option opt) : base(opt)
        {
        }

        public override string CName => "I";
        public override string UName => "THM_HaoPhiCongViecMay";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng công việc trong bảng THM </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=PRODUCT(F{args[0]};G{args[0]};H{args[0]})"; // Cột F: Khối lượng thi công, cột G: định mức máy, cột H: hệ số điều chỉnh máy
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=PRODUCT(F{args[0]};G{args[0]};H{args[0]})"; // Cột F: Khối lượng thi công, cột G: định mức máy, cột H: hệ số điều chỉnh máy
        }
    }
}

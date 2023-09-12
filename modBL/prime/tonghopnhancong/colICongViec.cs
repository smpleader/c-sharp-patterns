using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopnhancong
{
    // Hao phí theo công việc
    public class colICongViec : ACell
    {
        public colICongViec(Option opt) : base(opt)
        {
        }

        public override string CName => "I";
        public override string UName => "THNC_HaoPhiCongViecNhanCong";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng công việc trong bảng THNC </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=PRODUCT(F{args[0]};G{args[0]};H{args[0]})";
        }
    }
}

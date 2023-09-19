using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopnhancong
{
    public class colQ : ACell
    {
        public colQ(Option opt) : base(opt)
        {
        }

        public override string CName => "Q";
        public override string UName => "THNC_GiaThongBaoxHeSo";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số chỉ số dòng tính đơn giá TBxHS trong bảng THNC</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=L{args[0]}*P{args[0]}"; // Cột L: giá TB, cột P: hệ số
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=L{args[0]}*P{args[0]}"; // Cột L: giá TB, cột P: hệ số
        }
    }
}

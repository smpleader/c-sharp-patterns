using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopnhancong
{
    public class colS : ACell
    {
        public colS(Option opt) : base(opt)
        {
        }

        public override string CName => "S";
        public override string UName => "THNC_ChenhLechGiaThongBaoXHeSo";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số chỉ số dòng tính chênh lệch giá TBxHS trong bảng THNC</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=Q{args[0]}-J{args[0]}";
        }
    }
}

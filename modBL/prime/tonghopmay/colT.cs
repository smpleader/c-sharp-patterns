using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopmay
{
    // Tính thành tiền chênh lệch giá TBxHS cho một máy
    public class colT : ACell
    {
        public colT(Option opt) : base(opt)
        {
        }

        public override string CName => "T";
        public override string UName => "THM_ThanhTienChenhLechGiaThongBaoxHeSo";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số chỉ số dòng tính thành tiền chênh lệch giá TBxHS trong bảng THM</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=I{args[0]}*S{args[0]}";
        }
    }
}

using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopvatlieu
{
    // Tính thành tiền chênh lệch giá TBxHS cho một vật liệu
    public class colT : ACell
    {
        public colT(Option opt) : base(opt)
        {
        }

        public override string CName => "T";
        public override string UName => "THVL_ThanhTienChenhLechGiaThongBaoxHeSo";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số chỉ số dòng tính thành tiền chênh lệch giá TBxHS trong bảng THVL</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=I{args[0]}*S{args[0]}"; // Cột I: hao phí vật liệu, cột S chênh lệch giá TBxHS
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=I{args[0]}*S{args[0]}"; // Cột I: hao phí vật liệu, cột S chênh lệch giá TBxHS
        }
    }
}

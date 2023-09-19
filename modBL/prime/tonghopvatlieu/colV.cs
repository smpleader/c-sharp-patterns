using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopvatlieu
{
    // Tính thành tiền cước vận chuyển cho một vật liệu
    public class colV : ACell
    {
        public colV(Option opt) : base(opt)
        {
        }

        public override string CName => "V";
        public override string UName => "THVL_ThanhTienCuocVanChuyen";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số chỉ số dòng tính thành tiền cước vận chuyển trong bảng THVL</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=I{args[0]}*U{args[0]}"; // Cột I: hao phí vật liệu, cột U: cước vận chuyển
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=I{args[0]}*U{args[0]}"; // Cột I: hao phí vật liệu, cột U: cước vận chuyển
        }
    }
}

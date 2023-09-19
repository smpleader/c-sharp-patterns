using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopvatlieu
{
    // Tính thành tiền giá gốc cho một vật liệu
    public class colK : ACell
    {
        public colK(Option opt) : base(opt)
        {
        }

        public override string CName => "K";
        public override string UName => "THVL_ThanhTienGiaGoc";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số chỉ số dòng tính thành tiền giá gốc trong bảng THVL</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=I{args[0]}*J{args[0]}"; // Cột I: Hao phí vật liệu, cột J: giá gốc vật liệu
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=I{args[0]}*J{args[0]}"; // Cột I: Hao phí vật liệu, cột J: giá gốc vật liệu
        }
    }
}

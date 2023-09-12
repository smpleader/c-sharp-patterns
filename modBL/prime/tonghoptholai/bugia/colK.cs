using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghoptholai.bugia
{
    // Tính thành tiền giá gốc cho một nhân công
    public class colK : ACell
    {
        public colK(Option opt) : base(opt)
        {
        }

        public override string CName => "K";
        public override string UName => "TongHopTL_BuGia_ThanhTienGiaGoc";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số chỉ số dòng nhân công</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=I{args[0]}*J{args[0]}"; // Cột I: Hao phí nhân công, cột J: giá gốc nhân công
        }
    }
}

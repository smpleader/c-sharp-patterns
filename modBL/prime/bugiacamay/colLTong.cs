using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.bugiacamay
{
    // Tổng thành tiền bù giá máy
    public class colLTong : ACell
    {
        public colLTong(Option opt) : base(opt)
        {
        }

        public override string CName => "L";
        public override string UName => "BuGiaCM_TongThanhTienBuGiaMay";

        /// <summary>
        /// 2 tham số
        /// <para> Dòng bắt đầu tính bù giá máy</para>
        /// <para> Dòng kết thúc tính bù giá máy</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=SUM(L{args[0]}:L{args[1]})";
        }
    }
}

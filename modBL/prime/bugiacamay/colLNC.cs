using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.bugiacamay
{
    // Thành tiền bù giá NC
    public class colLNC : ACell
    {
        public colLNC(Option opt) : base(opt)
        {
        }

        public override string CName => "L";
        public override string UName => "BuGiaCM_ThanhTienBuGiaNhanCong";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng nhân công</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=G{args[0]}*K{args[0]}";
        }
    }
}

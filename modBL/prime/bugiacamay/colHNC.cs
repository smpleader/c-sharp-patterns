using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.bugiacamay
{
    // Đơn giá gốc nhân công
    public class colHNC : ACell
    {
        public colHNC(Option opt) : base(opt)
        {
        }

        public override string CName => "H";
        public override string UName => "BuGiaCM_GiaGocNhanCong";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng giá gốc nhân công trong bảng phụ</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=P{args[0]}";
        }
    }
}

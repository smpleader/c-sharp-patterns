using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.bugiacamay
{
    //Đơn giá gốc nhiên liệu
    public class colHNL : ACell
    {
        public colHNL(Option opt) : base(opt)
        {
        }

        public override string CName => "H";
        public override string UName => "BuGiaCM_GiaGocNhienLieu";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng giá gốc nhiên liệu trong bảng phụ</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=P{args[0]}";
        }
    }
}

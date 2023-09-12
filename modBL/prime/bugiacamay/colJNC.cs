using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.bugiacamay
{
    //Đơn giá hiện trường nhân công
    public class colJNC : ACell
    {
        public colJNC(Option opt) : base(opt)
        {
        }

        public override string CName => "J";
        public override string UName => "BuGiaCM_GiaHienTruongNhanCong";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng giá HT nhân công trong bảng phụ</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=Q{args[0]}";
        }
    }
}

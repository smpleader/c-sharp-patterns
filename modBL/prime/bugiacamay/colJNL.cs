using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.bugiacamay
{
    // Đơn giá hiện trường nhiên liệu
    public class colJNL : ACell
    {
        public colJNL(Option opt) : base(opt)
        {
        }

        public override string CName => "J";
        public override string UName => "BuGiaCM_GiaHienTruongNhienLieu";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng giá HT nhiên liệu trong bảng phụ</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=Q{args[0]}";
        }
    }
}

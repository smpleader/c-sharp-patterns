using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.phantichvattu
{
    /// <summary>
    /// Thành tiền đơn giá gốc máy
    /// </summary>
    public class colJMay : ACell
    {
        public colJMay(Option opt) : base(opt)
        {
        }

        public override string CName => "J";
        public override string UName => "PTVT_ThanhTienGiaGocMay";

        // <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng máy trong bảng PTVT</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=PRODUCT(F{args[0]}; G{args[0]}; I{args[0]})"; // Cột F: Định mức máy, cột G: Hệ số máy, cột I: Giá gốc máy
        }
    }
}

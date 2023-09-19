using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.phantichvattu
{
    /// <summary>
    /// Thành tiền đơn giá gốc vật liệu phụ
    /// </summary>
    public class colJVLPhu : ACell
    {
        public colJVLPhu(Option opt) : base(opt)
        {
        }

        public override string CName => "J";
        public override string UName => "PTVT_ThanhTienGiaGocVatLieuPhu";

        // <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng vật liệu phụ trong bảng PTVT</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=PRODUCT(F{args[0]}; G{args[0]}; I{args[0]})"; // Cột F: Định mức vật liệu phụ, cột G: Hệ số vật liệu phụ, cột I: Giá gốc vật liệu phụ
        }
    }
}

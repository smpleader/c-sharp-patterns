using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.phantichvattu
{
    /// <summary>
    /// Thành tiền đơn giá HT vật liệu phụ
    /// </summary>
    public class colNVLPhu : ACell
    {
        public colNVLPhu(Option opt) : base(opt)
        {
        }

        public override string CName => "N";
        public override string UName => "PTVT_ThanhTienGiaHienTruongVatLieuPhu";

        // <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng vật liệu phụ trong bảng PTVT</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=PRODUCT(F{args[0]}; G{args[0]}; M{args[0]})"; // Cột F: Định mức vật liệu phụ, cột G: Hệ số vật liệu phụ, cột K: Giá HT vật liệu phụ
        }
    }
}

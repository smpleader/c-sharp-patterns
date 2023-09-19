using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.phantichvattu
{
    /// <summary>
    /// Thành tiền đơn giá TB vật liệu phụ
    /// </summary>
    public class colLVLPhu : ACell
    {
        public colLVLPhu(Option opt) : base(opt)
        {
        }

        public override string CName => "L";
        public override string UName => "PTVT_ThanhTienGiaThongBaoVatLieuPhu";

        // <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng vật liệu phụ trong bảng PTVT</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=PRODUCT(F{args[0]}; G{args[0]}; K{args[0]})"; // Cột F: Định mức vật liệu phụ, cột G: Hệ số vật liệu phụ, cột K: Giá TB vật liệu phụ
        }
    }
}

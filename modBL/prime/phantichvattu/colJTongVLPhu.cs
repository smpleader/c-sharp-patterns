using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.phantichvattu
{
    /// <summary>
    /// Tổng thành tiền đơn giá gốc vật liệu phụ
    /// </summary>
    public class colJTongVLPhu : ACell
    {
        public colJTongVLPhu(Option opt) : base(opt)
        {
        }

        public override string CName => "J";
        public override string UName => "PTVT_TongThanhTienGiaGocVatLieuPhu";

        // <summary>
        /// 2 tham số
        /// <para> Chỉ số dòng vật liệu phụ đầu tiên trong bảng PTVT theo công việc</para>
        /// <para> Chỉ số dòng vật liệu phụ cuối cùng trong bảng PTVT theo công việc</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=SUM(J{args[0]}:J{args[1]})"; // Cột J: Thành tiền giá gốc vật liệu phụ
        }
    }
}

using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.phantichvattu
{
    /// <summary>
    /// Tổng thành tiền đơn giá gốc nhân công
    /// </summary>
    public class colJTongNhanCong : ACell
    {
        public colJTongNhanCong(Option opt) : base(opt)
        {
        }

        public override string CName => "J";
        public override string UName => "PTVT_TongThanhTienGiaGocNhanCong";

        // <summary>
        /// 2 tham số
        /// <para> Chỉ số dòng nhân công đầu tiên trong bảng PTVT theo công việc</para>
        /// <para> Chỉ số dòng nhân công cuối cùng trong bảng PTVT theo công việc</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=SUM(J{args[0]}:J{args[1]})"; // Cột J: Thành tiền giá gốc nhân công
        }
    }
}

using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.phantichvattu
{
    /// <summary>
    /// Tổng thành tiền đơn giá TB máy
    /// </summary>
    public class colLTongMay : ACell
    {
        public colLTongMay(Option opt) : base(opt)
        {
        }

        public override string CName => "L";
        public override string UName => "PTVT_TongThanhTienGiaThongBaoMay";

        // <summary>
        /// 2 tham số
        /// <para> Chỉ số dòng máy đầu tiên trong bảng PTVT theo công việc</para>
        /// <para> Chỉ số dòng máy cuối cùng trong bảng PTVT theo công việc</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=SUM(L{args[0]}:L{args[1]})"; // Cột L: Thành tiền giá TB máy
        }
    }
}

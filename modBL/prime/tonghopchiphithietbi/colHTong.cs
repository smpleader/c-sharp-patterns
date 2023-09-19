using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopchiphithietbi
{
    /// <summary>
    /// Tổng thành tiền trước thuế
    /// </summary>
    public class colHTong : ACell
    {
        public colHTong(Option opt) : base(opt)
        {
        }

        public override string CName => "H";
        public override string UName => "THCPTB_TongThanhTienTruocThue";

        /// <summary>
        /// 2 tham số
        /// <para>Tham số 1 chỉ số dòng đầu tiên bảng chi phí thiết bị</para>
        /// <para>Tham số 2 chỉ số dòng cuối cùng bảng chi phí thiết bị</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=SUMIF(C{args[0]}:C{args[1]};\" <> \";H{args[0]}:H{args[1]})"; // Cột C: Đơn vị, cột H: thành tiền trước thuế
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=SUMIF(C{args[0]}:C{args[1]};\" <> \";H{args[0]}:H{args[1]})"; // Cột C: Đơn vị, cột H: thành tiền trước thuế
        }
    }
}

using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopchiphixaydung
{
    /// <summary>
    /// Tổng chi phí xây dựng trước thuế
    /// </summary>
    public class colCTong : ACell
    {
        public colCTong(Option opt) : base(opt)
        {
        }

        public override string CName => "C";
        public override string UName => "THCPXD_TongChiPhiXayDungTruocThue";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng hạng mục đầu tiên trong bảng</para>
        /// <para> Tham số 2 chỉ số dòng hạng mục cuối cùng trong bảng</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=SUM(C{args[0]}:C{args[1]})"; // Cột C: chi phí xây dựng trước thuế
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=SUM(C{args[0]}:C{args[1]})"; // Cột C: chi phí xây dựng trước thuế
        }
    }
}

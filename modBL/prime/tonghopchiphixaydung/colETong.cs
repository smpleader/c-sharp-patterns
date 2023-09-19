using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopchiphixaydung
{
    /// <summary>
    /// Tổng chi phí xây dựng sau thuế
    /// </summary>
    public class colETong : ACell
    {
        public colETong(Option opt) : base(opt)
        {
        }

        public override string CName => "E";
        public override string UName => "THCPXD_TongChiPhiXayDungSauThue";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng hạng mục đầu tiên trong bảng</para>
        /// <para> Tham số 2 chỉ số dòng hạng mục cuối cùng trong bảng</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=SUM(E{args[0]}:E{args[1]})"; // Cột E: Chi phí xây dựng sau thuế
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=SUM(E{args[0]}:E{args[1]})"; // Cột E: Chi phí xây dựng sau thuế
        }
    }
}

using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopchiphixaydung
{
    /// <summary>
    /// Tổng chi phí xây dựng lán trại nhà tạm
    /// </summary>
    public class colFTong : ACell
    {
        public colFTong(Option opt) : base(opt)
        {
        }

        public override string CName => "F";
        public override string UName => "THCPXD_TongChiPhiXayDungLanTraiNhaTam";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng hạng mục đầu tiên trong bảng</para>
        /// <para> Tham số 2 chỉ số dòng hạng mục cuối cùng trong bảng</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=SUM(F{args[0]}:F{args[1]})"; // Cột E: Chi phí xây dựng lán trại nhà tạm
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=SUM(F{args[0]}:F{args[1]})"; // Cột E: Chi phí xây dựng lán trại nhà tạm
        }
    }
}

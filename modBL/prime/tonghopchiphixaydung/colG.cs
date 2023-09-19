using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopchiphixaydung
{
    /// <summary>
    /// Chi phí xây dựng hạng mục
    /// </summary>
    public class colG : ACell
    {
        public colG(Option opt) : base(opt)
        {
        }

        public override string CName => "G";
        public override string UName => "THCPXD_ChiPhiXayDung";

        /// <summary>
        /// 1 tham số
        /// <para>Chỉ số dòng tổng chi phí xây dựng</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=E{args[0]}+F{args[0]}"; // Cột E: chi phí xây dựng sau thuế, cột F: Chi phí xây dựng lán trại nhà tạm
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=E{args[0]}+F{args[0]}"; // Cột E: chi phí xây dựng sau thuế, cột F: Chi phí xây dựng lán trại nhà tạm
        }
    }
}

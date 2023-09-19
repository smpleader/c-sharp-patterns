using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopchiphixaydung
{
    /// <summary>
    /// Chi phí xây dựng lán trại, nhà tạm
    /// </summary>
    public class colF : ACell
    {
        public colF(Option opt) : base(opt)
        {
        }

        public override string CName => "F";
        public override string UName => "THCPXD_ChiPhiXayDungLanTraiNhaTam";

        /// <summary>
        /// 1 tham số
        /// <para>Chỉ số dòng thành tiền chi phí xây dựng lán trại nhà tạm</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"={SheetName.TONG_HOP_KINH_PHI_HANG_MUC}!E{args[0]}"; // Cột E: Chi phí xây dựng lán trại nhà tạm
        }
        public override string formula(string hmId, string[] args)
        {
            return $"={SheetName.TONG_HOP_KINH_PHI_HANG_MUC}_{hmId}!E{args[0]}"; // Cột E: Chi phí xây dựng lán trại nhà tạm
        }
    }
}

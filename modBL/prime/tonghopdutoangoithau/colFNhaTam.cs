using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopdutoangoithau
{
    /// <summary>
    /// Giá trị sau thuế chi phí lán trại nhà tạm
    /// </summary>
    public class colFNhaTam : ACell
    {
        public colFNhaTam(Option opt) : base(opt)
        {
        }

        public override string CName => "F";
        public override string UName => "GGTXD_GiaTriSauThueChiPhiNhaTam";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng chí phí lán trại nhà tạm</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=D{args[0]}+E{args[0]}"; //Cột D: Giá trị trước thuế chi phí lán trại nhà tạm, cột E: Thuế GTGT chi phí lán trại
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=D{args[0]}+E{args[0]}"; //Cột D: Giá trị trước thuế chi phí lán trại nhà tạm, cột E: Thuế GTGT chi phí lán trại
        }
    }
}

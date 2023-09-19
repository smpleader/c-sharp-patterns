using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopdutoangoithau
{
    /// <summary>
    /// Giá trị sau thuế chi phí công tác không xác định
    /// </summary>
    public class colFKXD : ACell
    {
        public colFKXD(Option opt) : base(opt)
        {
        }

        public override string CName => "F";
        public override string UName => "GGTXD_GiaTriSauThueChiPhiKhongXacDinh";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng chí phí công tác không xác định</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=D{args[0]}+E{args[0]}"; //Cột D: Giá trị trước thuế chi phí công tác không xác định, cột E: thuế GTGT công tác không xác định
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=D{args[0]}+E{args[0]}"; //Cột D: Giá trị trước thuế chi phí công tác không xác định, cột E: thuế GTGT công tác không xác định
        }
    }
}

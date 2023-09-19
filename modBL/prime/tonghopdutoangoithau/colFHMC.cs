using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopdutoangoithau
{
    /// <summary>
    /// Giá trị sau thuế hạng mục chung
    /// </summary>
    public class colFHMC : ACell
    {
        public colFHMC(Option opt) : base(opt)
        {
        }

        public override string CName => "F";
        public override string UName => "GGTXD_GiaTriSauThueHangMucChung";

        /// <summary>
        /// 2 tham số
        /// <para>Tham số 1 Chỉ số dòng chi phí xây dựng lán trại nhà tạm </para>
        /// <para>Tham số 2 Chỉ số dòng chi phí hạng mục chung còn lại </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=ROUND(SUM(F{args[0]}:F{args[1]});0)"; //Cột F: Giá trị sau thuế chi phí lán trại nhà tạm, công tác không xác định, hạng mục chung còn lại
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=ROUND(SUM(F{args[0]}:F{args[1]});0)"; //Cột F: Giá trị sau thuế chi phí lán trại nhà tạm, công tác không xác định, hạng mục chung còn lại
        }
    }
}

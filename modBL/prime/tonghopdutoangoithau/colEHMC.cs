using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopdutoangoithau
{
    /// <summary>
    /// Thuế GTGT hạng mục chung
    /// </summary>
    public class colEHMC : ACell
    {
        public colEHMC(Option opt) : base(opt)
        {
        }

        public override string CName => "E";
        public override string UName => "GGTXD_ThueGiaTriGiaTangHangMucChung";

        /// <summary>
        /// 2 tham số
        /// <para>Tham số 1 Chỉ số dòng chi phí xây dựng lán trại nhà tạm </para>
        /// <para>Tham số 2 Chỉ số dòng chi phí hạng mục chung còn lại </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=ROUND(SUM(E{args[0]}:E{args[1]});0)"; //Cột E: Thuế GTGT lán trại nhà tạm, công tác không xác định, hạng mục chung còn lại
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=ROUND(SUM(E{args[0]}:E{args[1]});0)"; //Cột E: Thuế GTGT lán trại nhà tạm, công tác không xác định, hạng mục chung còn lại
        }
    }
}

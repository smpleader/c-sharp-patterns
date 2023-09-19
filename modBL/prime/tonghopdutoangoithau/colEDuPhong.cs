using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopdutoangoithau
{
    /// <summary>
    /// Thuế GTGT chi phí dự phòng
    /// </summary>
    public class colEDuPhong : ACell
    {
        public colEDuPhong(Option opt) : base(opt)
        {
        }

        public override string CName => "E";
        public override string UName => "GGTXD_ThueGiaTriGiaTangChiPhiDuPhong";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng chi phí dự phòng yếu tố công việc phát sinh </para>
        /// <para> Tham số 2 chỉ số dòng chi phí dự phòng yếu tố trượt giá </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=ROUND(SUM(E{args[0]}:E{args[1]});0)"; //Cột E: Thuế GTGT công việc phát sinh, chi phí dự phòng trượt giá
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=ROUND(SUM(E{args[0]}:E{args[1]});0)"; //Cột E: Thuế GTGT công việc phát sinh, chi phí dự phòng trượt giá
        }
    }
}

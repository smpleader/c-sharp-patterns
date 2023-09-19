using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopdutoangoithau
{
    /// <summary>
    /// Giá trị sau thuế chi phí dự phòng
    /// </summary>
    public class colFDuPhong : ACell
    {
        public colFDuPhong(Option opt) : base(opt)
        {
        }

        public override string CName => "F";
        public override string UName => "GGTXD_GiaTriSauThueChiPhiDuPhong";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng chi phí dự phòng yếu tố công việc phát sinh </para>
        /// <para> Tham số 2 chỉ số dòng chi phí dự phòng yếu tố trượt giá </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=ROUND(SUM(F{args[0]}:F{args[1]});0)"; //Cột F: Giá trị sau thuế công việc phát sinh, chi phí dự phòng trượt giá
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=ROUND(SUM(F{args[0]}:F{args[1]});0)"; //Cột F: Giá trị sau thuế công việc phát sinh, chi phí dự phòng trượt giá
        }
    }
}

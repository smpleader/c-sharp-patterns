using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopdutoangoithau
{
    /// <summary>
    /// Tổng cộng thuế GTGT
    /// </summary>
    public class colETong : ACell
    {
        public colETong(Option opt) : base(opt)
        {
        }

        public override string CName => "E";
        public override string UName => "GGTXD_TongThanhTienThueGiaTriGiaTang";

        /// <summary>
        /// 3 tham số
        /// <para> Chỉ số dòng chí phí xây dựng của gói thầu</para>
        /// <para> Chỉ số dòng chí phí hạng mục chung</para>
        /// <para> Chỉ số dòng chí phí chi phí dự phòng</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=E{args[0]}+E{args[1]}+E{args[2]}"; //Cột E: Thuế GTGT chi phí xây dựng của gói thầu, chi phí hạng mục chung, chi phí dự phòng
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=E{args[0]}+E{args[1]}+E{args[2]}"; //Cột E: Thuế GTGT chi phí xây dựng của gói thầu, chi phí hạng mục chung, chi phí dự phòng
        }
    }
}

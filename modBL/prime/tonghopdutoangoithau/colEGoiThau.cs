using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopdutoangoithau
{
    /// <summary>
    /// Thuế GTGT chi phí xây dựng gói thầu
    /// </summary>
    public class colEGoiThau : ACell
    {
        public colEGoiThau(Option opt) : base(opt)
        {
        }

        public override string CName => "E";
        public override string UName => "GGTXD_ThueGiaTriGiaTangChiPhiXayDungCuaGoiThau";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng hạng mục đầu tiên </para>
        /// <para> Tham số 2 chỉ số dòng hạng mục cuối cùng </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=SUM(E{args[0]}:E{args[1]})"; //Cột E: Thuế GTGT hạng mục
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=SUM(E{args[0]}:E{args[1]})"; //Cột E: Thuế GTGT hạng mục
        }
    }
}

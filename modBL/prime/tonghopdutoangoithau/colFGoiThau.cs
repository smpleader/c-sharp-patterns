using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopdutoangoithau
{
    /// <summary>
    /// Giá trị sau thuế chi phí xây dựng gói thầu
    /// </summary>
    public class colFGoiThau : ACell
    {
        public colFGoiThau(Option opt) : base(opt)
        {
        }

        public override string CName => "F";
        public override string UName => "GGTXD_GiaTriSauThueChiPhiXayDungCuaGoiThau";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng hạng mục đầu tiên </para>
        /// <para> Tham số 2 chỉ số dòng hạng mục cuối cùng </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=SUM(F{args[0]}:F{args[1]})"; //Cột F: Giá trị sau thuế hạng mục
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=SUM(F{args[0]}:F{args[1]})"; //Cột F: Giá trị sau thuế hạng mục
        }
    }
}

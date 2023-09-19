using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopdutoangoithau
{
    /// <summary>
    /// giá trị trước thuế chi phí xây dựng gói thầu
    /// </summary>
    public class colDGoiThau : ACell
    {
        public colDGoiThau(Option opt) : base(opt)
        {
        }

        public override string CName => "D";
        public override string UName => "GGTXD_ThanhTienGiaTriTruocThueChiPhiXayDungCuaGoiThau";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng hạng mục đầu tiên </para>
        /// <para> Tham số 2 chỉ số dòng hạng mục cuối cùng </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=SUM(D{args[0]}:D{args[1]})"; //Cột D: Giá trị trước thuế hạng mục
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=SUM(D{args[0]}:D{args[1]})"; //Cột D: Giá trị trước thuế hạng mục
        }
    }
}

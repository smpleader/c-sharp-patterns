using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopdutoangoithau
{
    /// <summary>
    /// Giá trị sau thuế hạng mục
    /// </summary>
    public class colFHM : ACell
    {
        public colFHM(Option opt) : base(opt)
        {
        }

        public override string CName => "F";
        public override string UName => "GGTXD_GiaTriSauTheHangMuc";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng hạng mục tương ứng trong bảng </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=D{args[0]}+E{args[0]}"; //Cột D: Giá trị trước thuế, cột E: Thuế GTGT hạng mục
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=D{args[0]}+E{args[0]}"; //Cột D: Giá trị trước thuế, cột E: Thuế GTGT hạng mục
        }
    }
}

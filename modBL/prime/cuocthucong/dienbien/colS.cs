using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocthucong.dienbien
{
    public class colS : ACell
    {
        public colS(Option opt) : base(opt)
        {
        }

        public override string CName => "O";
        public override string UName => "CuocTC_DienBien_TongCuoc";

        /// <summary>
        /// 1 tham số
        /// <para> chỉ số dòng vật liệu</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            //S4*H10*(P10+O10*Q10)+R10
            return $"=S4*H{args[0]}*(P{args[0]}+O{args[0]}*Q{args[0]})+R{args[0]}";
        }
    }
}

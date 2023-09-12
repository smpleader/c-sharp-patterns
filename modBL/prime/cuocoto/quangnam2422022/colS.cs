using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocoto.quangnam2422022
{
    public class colS : ACell
    {
        public colS(Option opt) : base(opt)
        {
        }

        public override string CName => "S";
        public override string UName => "CuocOto_QN2422022_Tong";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 là chỉ số dòng vật liệu </para>
        /// <para> Tham số 2 là chỉ số dòng kết thúc tính cước cho vật liệu </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=SUM(M{args[0]}:M{args[1]})+O{args[0]}+Q{args[0]}+R{args[0]}";
        }
    }
}

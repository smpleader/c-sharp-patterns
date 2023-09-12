using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocoto.quangnam382021
{
    public class colT : ACell
    {
        public colT(Option opt) : base(opt)
        {
        }

        public override string CName => "T";
        public override string UName => "CuocOto_QN382021_GiaVanChuyenTruocThue";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số 1 là chỉ số dòng vật liệu </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=ROUND(E{args[0]}*S{args[0]};0)";
        }
    }
}

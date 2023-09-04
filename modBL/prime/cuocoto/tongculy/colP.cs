using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocoto.tongculy
{
    internal class colP : ACell
    {
        public colP(Option opt) : base(opt)
        {
        }
        public override string CName => "P";
        public override string UName => "CuocOto_ChiPhiVanChuyenTruocThue";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số 1 là chỉ số dòng tính cước của vật liệu </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=O{args[0]}/(1 + X5)";
        }
    }
}

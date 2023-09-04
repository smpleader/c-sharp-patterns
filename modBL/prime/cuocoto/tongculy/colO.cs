using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocoto.tongculy
{
    internal class colO : ACell
    {
        public colO(Option opt) : base(opt)
        {
        }
        public override string CName => "O";
        public override string UName => "CuocOto_ChiPhiVanChuyenSauThue";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số 1 là chỉ số dòng tính cước của vật liệu </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=X6*E{args[0]}*G{args[0]}*J{args[1]}*L{args[1]}*N{args[1]}";
        }
    }
}

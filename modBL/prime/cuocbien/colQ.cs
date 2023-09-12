using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocbien
{
    internal class colQ : ACell
    {
        public colQ(Option opt) : base(opt)
        {
        }
        public override string CName => "Q";
        public override string UName => "CuocBien_ChiPhiVanChuyen";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số 1 là chỉ số dòng tính cước vật liệu </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=SUM(G{args[0]}:P{args[0]})";
        }
    }
}

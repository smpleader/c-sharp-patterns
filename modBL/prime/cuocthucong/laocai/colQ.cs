using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocthucong.laocai
{
    internal class colQ : ACell
    {
        public colQ(Option opt) : base(opt)
        {
        }

        public override string CName => "Q";
        public override string UName => "CuocTC_LaoCai_TongCuoc";

        /// <summary>
        /// n tham số
        /// <para> Tham số 1 là chỉ số dòng tính cước vật liệu </para>
        /// <para> Tham số 2->n là số lượng dòng tính cước cho một vật liệu</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            //F10*(O10+P10+O11+P11+O12+P12)
            var tmp = $"=F{args[0]}*(";
            for (var i = 0; i < args.Length; i++)
            {
                tmp += $"O{args[i]}+P{args[i]}+";
            }
            var formula = tmp.TrimEnd('+');
            formula += ")";
            return formula;
        }
    }
}

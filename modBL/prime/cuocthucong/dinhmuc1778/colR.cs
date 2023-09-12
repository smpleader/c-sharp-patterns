using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocthucong.dinhmuc1778
{
    internal class colR : ACell
    {
        public colR(Option opt) : base(opt)
        {
        }

        public override string CName => "R";
        public override string UName => "CuocTC_DM1778_TongCuoc";

        /// <summary>
        /// n tham số
        /// <para> Tham số 1 là chỉ số dòng vật liệu </para>
        /// <para> Tham số 2->n là số lượng dòng tính cước cho một vật liệu</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            //R4*R5*H12*J12*P12+Q12+R4*R5*H12*J13*P13+Q13+R4*R5*H12*J14*P14+Q14
            var tmp = $"=";
            for (var i = 0; i < args.Length; i++)
            {
                tmp += $"R4*R5*H{args[0]}*J{args[i]}*P{args[i]}+Q{args[i]}+";
            }
            var formula = tmp.TrimEnd('+');
            return formula;
        }
    }
}

using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocbien
{
    public class colL : ACell
    {
        public colL(Option opt) : base(opt)
        {
        }
        public override string CName => "L";
        public override string UName => "CuocBien_ChiPhiRaVaoCangCatDaTaiConDao";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số 1 là chỉ số dòng tính cước vật liệu </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=L6*F{args[0]}";
        }
    }
}

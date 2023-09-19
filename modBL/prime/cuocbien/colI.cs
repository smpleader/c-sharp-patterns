using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocbien
{
    public class colI : ACell
    {
        public colI(Option opt) : base(opt)
        {
        }
        public override string CName => "I";
        public override string UName => "CuocBien_ChiPhiVanChuyenCatDa";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số 1 là chỉ số dòng tính cước vật liệu </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=I6*F{args[0]}";
        }
    }
}

using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocbien
{
    internal class colP : ACell
    {
        public colP(Option opt) : base(opt)
        {
        }
        public override string CName => "P";
        public override string UName => "CuocBien_ChiPhiBocXepCatDaDenChanCongTrinh";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số 1 là chỉ số dòng tính cước vật liệu </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=P6*F{args[0]}";
        }
    }
}

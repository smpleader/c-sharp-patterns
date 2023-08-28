using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.vatlieu
{
    internal class colL : ACell
    {
        public colL(Option opt) : base(opt)
        {
        }

        public override string CName => "L";
        public override string UName => "VatLieu_CuocBien";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng tổng cước trong bảng cước biển </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='Cước biển'!Q{args[0]}";
        }
    }
}

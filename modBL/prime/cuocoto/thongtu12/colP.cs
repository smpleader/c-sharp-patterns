using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocoto.thongtu12
{
    public class colP : ACell
    {
        public colP(Option opt) : base(opt)
        {
        }

        public override string CName => "P";
        public override string UName => "CuocOto_TT12_CuLyLonHon60KM";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số 1 là chỉ số dòng tính cước vật liệu </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=L{args[0]}-M{args[0]}-N{args[0]}-O{args[0]}";
        }
    }
}

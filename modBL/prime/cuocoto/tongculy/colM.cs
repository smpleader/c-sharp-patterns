using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocoto.tongculy
{
    internal class colM : ACell
    {
        public colM(Option opt) : base(opt)
        {
        }
        public override string CName => "M";
        public override string UName => "CuocOto_TongCuLy";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 là chỉ số dòng bắt đầu tính cước của vật liệu </para>
        /// <para> Tham số 2 là chỉ số dòng kết thúc tính cước của vật liệu </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=SUM(L{args[0]}:L{args[1]})";
        }
    }
}

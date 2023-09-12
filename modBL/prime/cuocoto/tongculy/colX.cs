using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocoto.tongculy
{
    public class colX : ACell
    {
        public colX(Option opt) : base(opt)
        {
        }
        public override string CName => "X";
        public override string UName => "CuocOto_TongCuLy_TongCuoc";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 là chỉ số dòng bắt đầu tính cước của vật liệu </para>
        /// <para> Tham số 2 là chỉ số dòng kết thúc tính cước của vật liệu </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=SUM(P{args[0]}:P{args[1]})+SUM(S{args[0]}:S{args[1]})+SUM(W{args[0]}:W{args[1]})";
        }
    }
}

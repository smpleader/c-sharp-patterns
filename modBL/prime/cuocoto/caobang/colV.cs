using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocoto.caobang
{
    public class colV : ACell
    {
        public colV(Option opt) : base(opt)
        {
        }
        public override string CName => "V";
        public override string UName => "CuocOto_CaoBang_TongCuoc";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 là chỉ số dòng bắt đầu tính cước vật liệu</para>
        /// <para> Tham số 2 là chỉ số dòng kết thúc tính cước vật liệu</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=SUM(P{args[0]}:P{args[1]})+SUM(R{args[0]}:R{args[1]})+T{args[0]}+SUM(U{args[0]}:U{args[1]})";
        }
    }
}

using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocoto.caobang
{
    public class colT : ACell
    {
        public colT(Option opt) : base(opt)
        {
        }
        public override string CName => "T";
        public override string UName => "CuocOto_CaoBang_ThanhTienHaoHut";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 là chỉ số dòng bắt đầu tính cước vật liệu</para>
        /// <para> Tham số 2 là chỉ số dòng kết thúc tính cước vật liệu</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=IF(E{args[0]}*N{args[0]}=0;0;(G{args[0]}+SUM(P{args[0]}:P{args[1]}))*S{args[0]})";
        }
    }
}

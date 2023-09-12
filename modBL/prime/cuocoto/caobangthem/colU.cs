using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocoto.caobangthem
{
    public class colU : ACell
    {
        public colU(Option opt) : base(opt)
        {
        }
        public override string CName => "U";
        public override string UName => "CuocOto_CaoBangThem_ThanhTienHaoHut";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 là chỉ số dòng bắt đầu tính cước vật liệu</para>
        /// <para> Tham số 2 là chỉ số dòng kết thúc tính cước vật liệu</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=IF(E{args[0]}*N{args[0]}=0;0;(G{args[0]}+SUM(Q{args[0]}:Q{args[1]}))*T{args[0]})";
        }
    }
}

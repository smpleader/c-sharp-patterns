using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocoto.caobangthem
{
    public class colW : ACell
    {
        public colW(Option opt) : base(opt)
        {
        }
        public override string CName => "W";
        public override string UName => "CuocOto_CaoBangThem_TongCuoc";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 là chỉ số dòng bắt đầu tính cước vật liệu</para>
        /// <para> Tham số 2 là chỉ số dòng kết thúc tính cước vật liệu</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=SUM(Q{args[0]}:Q{args[1]})+SUM(S{args[0]}:S{args[1]})+U{args[0]}+SUM(V{args[0]}:V{args[1]})";
        }
    }
}

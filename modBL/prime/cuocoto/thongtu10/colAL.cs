using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocoto.thongtu10
{
    public class colAL : ACell
    {
        public colAL(Option opt) : base(opt)
        {
        }

        public override string CName => "AL";
        public override string UName => "CuocOto_TT10_GiaVanChuyenTruocThue";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số 1 là chỉ số dòng tính cước vật liệu </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=(AK{args[0]}/F{args[0]})+AE{args[0]}+AG{args[0]}";
        }
    }
}

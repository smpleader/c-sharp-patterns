using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocoto.thongtu12
{
    public class colAO : ACell
    {
        public colAO(Option opt) : base(opt)
        {
        }

        public override string CName => "AO";
        public override string UName => "CuocOto_TT12_GiaVanChuyenTruocThue";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số 1 là chỉ số dòng tính cước vật liệu </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=(AN{args[0]}/F{args[0]})+AH{args[0]}+AJ{args[0]}";
        }
    }
}

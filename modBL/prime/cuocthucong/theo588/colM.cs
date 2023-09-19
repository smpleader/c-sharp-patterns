using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocthucong.theo588
{
    public class colM : ACell
    {
        public colM(Option opt) : base(opt)
        {
        }

        public override string CName => "M";
        public override string UName => "CuocTC_Theo588_TongCuoc";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số 1 là chỉ số dòng tính cước vật liệu </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            //H9*IF(H14>0;((I14+J14+K14+IF(H14>10;(H14-10)*L14/10;0))/F14);0)
            return $"=H9*IF(H{args[0]}>0;((I{args[0]}+J{args[0]}+K{args[0]}+IF(H{args[0]}>10;(H{args[0]}-10)*L{args[0]}/10;0))/F{args[0]});0)";
        }
    }
}
